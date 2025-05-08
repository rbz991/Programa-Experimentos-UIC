Imports System.Math
Imports System.IO.Ports
Public Class Form2
    Function ArduinoVB() As Integer
        Arduino = New SerialPort(Comunication_Port_X, 9600)
        Arduino.Open()
        Me.Text = Form1.txtRat.Text & "_" & Form1.txtSesion.Text
        Do
            Try
                If Arduino.BytesToRead > 0 Then
                    Arduino_String = Arduino.ReadLine()
                    DATOS_BRUTOS = Split(Arduino_String, ",")
                    Actual_Response(0) = Convert.ToInt32(DATOS_BRUTOS(0))
                    Actual_Response(1) = Convert.ToInt32(DATOS_BRUTOS(1))
                    Actual_Response(2) = Convert.ToInt32(DATOS_BRUTOS(2))
                    Actual_Response(3) = Convert.ToInt32(DATOS_BRUTOS(3))
                End If
                If (Actual_Response(0) <> Previous_Response(0) And Actual_Response(0) <> 1) Then
                    Response(1)
                End If
                If (Actual_Response(1) <> Previous_Response(1) And Actual_Response(1) <> 1) Then
                    Response(2)
                End If
                If (Actual_Response(2) <> Previous_Response(2) And Actual_Response(2) <> 1) Then
                    Response(3)
                End If
                If (Actual_Response(3) <> Previous_Response(3) And Actual_Response(3) <> 1) Then
                    Response(4)
                End If
                Previous_Response(0) = Actual_Response(0)
                Previous_Response(1) = Actual_Response(1)
                Previous_Response(2) = Actual_Response(2)
                Previous_Response(3) = Actual_Response(3)
                lblReforzadores.Text = vReforzadores
                lblRes1.Text = vResponse(1)
                lblRes2.Text = vResponse(2)
                lblRes3.Text = vResponse(3)
                lblRes4.Text = vResponse(4)
                lblResTotales.Text = vRespuestasTotales
                lblTimeNow.Text = vTimeNow / 1000
                lblEnsayo.Text = vEnsayos
                If tmrStart.Enabled = False Then
                    vTimeNow = Environment.TickCount - vTimeStart
                End If


                If vTimeNow >= SessionDuration Or vEnsayos >= 50 Then
                    Finish()
                End If

                If criterioReforzadores <> 0 Then
                    If vReforzadores >= criterioReforzadores Then Finish()
                End If


            Catch ex As Exception
            End Try
            My.Application.DoEvents()
        Loop
        Return 0
    End Function

    Private Sub Response(Lever As Integer)
        If tmrStart.Enabled = False Then
            If Form1.rdoPreentrenamiento.Checked = True Then
                RegisterResponse(Lever)
                Reinforce()
            ElseIf Form1.rdoFase1IVDer.Checked = True Then
                RegisterResponse(Lever)
                If vRefReady = True And Lever = 1 Then Reinforce()
            ElseIf Form1.rdoFase1IVIzq.Checked = True Then
                RegisterResponse(Lever)
                If vRefReady = True And Lever = 2 Then Reinforce()
            ElseIf Form1.rdoFase2IVDer.Checked = True Then
                RegisterResponse(Lever)
                If vRefReady = True And Lever = 3 Then Reinforce()
            ElseIf Form1.rdoFase2IVIzq.Checked = True Then
                RegisterResponse(Lever)
                If vRefReady = True And Lever = 4 Then Reinforce()


            ElseIf Form1.rdoFase1RFIzq.Checked = True Then
                RegisterResponse(Lever)
                RF_contador(Lever) += 1
                If RF_contador(Lever) >= RF_criterio And Lever = 1 Then
                    RF_contador(Lever) = 0
                    Reinforce()
                End If
            ElseIf Form1.rdoFase1RFDer.Checked = True Then
                RegisterResponse(Lever)
                RF_contador(Lever) += 1
                If RF_contador(Lever) >= RF_criterio And Lever = 2 Then
                    RF_contador(Lever) = 0
                    Reinforce()
                End If
            ElseIf Form1.rdoFase2RFIzq.Checked = True Then
                RegisterResponse(Lever)
                RF_contador(Lever) += 1
                If RF_contador(Lever) >= RF_criterio And Lever = 3 Then
                    RF_contador(Lever) = 0
                    Reinforce()
                End If
            ElseIf Form1.rdoFase2RFDer.Checked = True Then
                RegisterResponse(Lever)
                RF_contador(Lever) += 1
                If RF_contador(Lever) >= RF_criterio And Lever = 4 Then
                    RF_contador(Lever) = 0
                    Reinforce()
                End If


            ElseIf Form1.rdoFase2Lag.Checked = True Then
                RegisterResponse(Lever)
                If Lever = 3 Then
                    Arduino.WriteLine("C")
                    tmrEst.Enabled = True
                End If
                If Lever = 4 Then
                    Arduino.WriteLine("D")
                    tmrEst.Enabled = True
                End If
            ElseIf Form1.rdoFase2Yoked.Checked = True Then
                RegisterResponse(Lever)
                If Lever = 3 Then
                    Arduino.WriteLine("C")
                    tmrEst.Enabled = True
                End If
                If Lever = 4 Then
                    Arduino.WriteLine("D")
                    tmrEst.Enabled = True
                End If
            ElseIf Form1.rdoFase3Ext.Checked = True Then
                RegisterResponse(Lever)
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Finish()
    End Sub
    Private Sub tmrVI_Tick(sender As Object, e As EventArgs) Handles tmrVI.Tick
        tmrVI.Enabled = False
        vRefReady = True
    End Sub
    Private Sub tmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick

        tmrStart.Enabled = False
        vTimeStart = Environment.TickCount
        If Form1.rdoFase2Lag.Checked = True Then

            Do While Not EOF(4)
                'PrevSeqs.
                lbxPrevSeqs.Items.Add(LineInput(4))
            Loop
        ElseIf Form1.rdoFase2Yoked.Checked = True Then

        Else

            If Form1.rdoFase1IVDer.Checked = True Then
                Arduino.WriteLine("A")
                VIGen(Form1.txbVIValue.Text)
            End If
            If Form1.rdoFase1IVIzq.Checked = True Then
                Arduino.WriteLine("B")
                VIGen(Form1.txbVIValue.Text)
            End If
            If Form1.rdoFase2IVDer.Checked = True Then
                Arduino.WriteLine("C")
                VIGen(Form1.txbVIValue.Text)
            End If
            If Form1.rdoFase2IVIzq.Checked = True Then
                Arduino.WriteLine("D")
                VIGen(Form1.txbVIValue.Text)
            End If


            If Form1.rdoFase1RFDer.Checked = True Or Form1.rdoFase1RFIzq.Checked = True Or Form1.rdoFase2RFDer.Checked = True Or Form1.rdoFase2RFIzq.Checked = True Then

                RF_criterio = Form1.txbVIValue.Text

            End If




        End If
    End Sub
    Private Sub Reinforce()
        If Form1.rdoFase2Lag.Checked = True Then
            Dim b As Boolean = False
            For i = 1 To CInt(Form1.txtLag.Text)
                If lbxPrevSeqs.Items.Item(lbxPrevSeqs.Items.Count - 1) = lbxPrevSeqs.Items.Item(lbxPrevSeqs.Items.Count - 1 - i) Then
                    b = True
                End If
            Next
            If b = False Then
                WriteLine(1, vTimeNow, 10)
                WriteLine(2, 10)
                If Form1.rdoLechita.Checked = True Then
                    Arduino.WriteLine("W")
                ElseIf Form1.rdoLiquor.Checked = True Then
                    Arduino.WriteLine("P")
                ElseIf Form1.rdoPelleta.Checked = True Then
                    Arduino.WriteLine("R")
                End If

                vReforzadores += 1
            Else
                WriteLine(1, vTimeNow, 11)
                WriteLine(2, 11)
                Arduino.WriteLine("T")
                tmrEst.Enabled = True
            End If
            vEnsayos += 1
        ElseIf Form1.rdoFase2Yoked.Checked = True Then
            If Not EOF(5) Then
                Dim s As String = LineInput(5)
                If s = 10 Then
                    If Form1.rdoLechita.Checked = True Then
                        Arduino.WriteLine("W")
                    ElseIf Form1.rdoLiquor.Checked = True Then
                        Arduino.WriteLine("P")
                    ElseIf Form1.rdoPelleta.Checked = True Then
                        Arduino.WriteLine("R")
                    End If
                    vReforzadores += 1
                ElseIf s = 11 Then
                    Arduino.WriteLine("T")
                    tmrEst.Enabled = True
                End If
                vEnsayos += 1
                If EOF(5) Then vEnsayos = 50
            Else
                vEnsayos = 50
            End If
        Else
                vRefReady = False
            tmrEst.Enabled = True
            Arduino.WriteLine("abcd")
            WriteLine(1, vTimeNow, 10)
            If Form1.rdoLechita.Checked = True Then
                Arduino.WriteLine("W")
            ElseIf Form1.rdoLiquor.Checked = True Then
                Arduino.WriteLine("P")
            ElseIf Form1.rdoPelleta.Checked = True Then
                Arduino.WriteLine("R")
            End If
            vReforzadores += 1
            VIGen(Form1.txbVIValue.Text)
        End If
    End Sub
    Private Sub RegisterResponse(Lever)
        vResponse(Lever) += 1
        vRespuestasTotales += 1
        If Form1.rdoFase2Lag.Checked = True And (Lever = 3 Or Lever = 4) Then
            If tmrFIRI.Enabled = True Then
                tmrFIRI.Enabled = True
                WriteLine(1, vTimeNow, Lever + 30)
            Else
                If tmrFIRT.Enabled = True Then
                    tmrFIRT.Enabled = True
                    WriteLine(1, vTimeNow, Lever + 20)
                Else
                    WriteLine(1, vTimeNow, Lever)
                    vIndexCS += 1
                    vCurrentSeq = vCurrentSeq & Lever
                    If vIndexCS = Form1.txtValorSecuencia.Text Then
                        vIndexCS = 0
                        lbxPrevSeqs.Items.Add(vCurrentSeq)
                        lbxSecs.Items.Add(vCurrentSeq)
                        WriteLine(3, vCurrentSeq)
                        vCurrentSeq = ""
                        Reinforce()
                        tmrFIRI.Enabled = True
                    End If
                    tmrFIRT.Enabled = True
                End If
            End If
        ElseIf Form1.rdoFase2Yoked.Checked = True And (Lever = 3 Or Lever = 4) Then
            If tmrFIRI.Enabled = True Then
                tmrFIRI.Enabled = True
                WriteLine(1, vTimeNow, Lever + 30)
            Else
                If tmrFIRT.Enabled = True Then
                    tmrFIRT.Enabled = True
                    WriteLine(1, vTimeNow, Lever + 20)
                Else
                    WriteLine(1, vTimeNow, Lever)
                    vIndexCS += 1
                    vCurrentSeq = vCurrentSeq & Lever
                    If vIndexCS = Form1.txtValorSecuencia.Text Then
                        vIndexCS = 0
                        lbxPrevSeqs.Items.Add(vCurrentSeq)
                        lbxSecs.Items.Add(vCurrentSeq)
                        WriteLine(3, vCurrentSeq)
                        vCurrentSeq = ""
                        Reinforce()
                        tmrFIRI.Enabled = True
                    End If
                End If
            End If
        Else
            WriteLine(1, vTimeNow, Lever)
        End If
    End Sub
    Private Sub VIGen(v)
        Dim n = 10
        Dim rd(n)
        Dim vi(n)
        Dim order
        Randomize()
        If VIList.Count = 0 Then
            For m As Integer = 1 To n
                If m = n Then vi(m) = v * (1 + Log(n)) : GoTo 1
                vi(m) = v * (1 + (Log(n)) + (n - m) * (Log(n - m)) - (n - m + 1) * Log(n - m + 1))
1:              order = Int((n * Rnd() + 1))
                If rd(order) = 0 Then
                    rd(order) = vi(m)
                Else
                    GoTo 1
                End If
            Next
            For a As Integer = 1 To n
                VIList.Add(rd(a))
            Next
        End If
        Dim Rand As New Random
        Dim p As Integer = Rand.Next(VIList.Count)
        tmrVI.Interval = (VIList.Item(p) + 1) * 1000
        tmrVI.Enabled = True
        VIList.RemoveAt(p)
    End Sub

    Private Sub RFGen(v)

    End Sub

    Public Sub Finish()
        Dim uniqueSec As Integer = lbxSecs.Items.Cast(Of String)().Distinct().Count()
        vUniqSec = uniqueSec
        Arduino.WriteLine("abcdt")
        vEndTime = vTimeNow / 1000

        WriteLine(1, "IV: " & Form1.txbVIValue.Text)
        WriteLine(1, "Tasa de respuesta 1: " & vResponse(1) / (vEndTime / 60))
        WriteLine(1, "Tasa de respuesta 2: " & vResponse(2) / (vEndTime / 60))
        WriteLine(1, "Tasa de respuesta 3: " & vResponse(3) / (vEndTime / 60))
        WriteLine(1, "Tasa de respuesta 4: " & vResponse(4) / (vEndTime / 60))
        WriteLine(1, "Secuencias diferentes: " & vUniqSec)
        WriteLine(1, "Reforzadores totales: " & vReforzadores)
        WriteLine(1, "Total time: " & vEndTime / 60 & "m")
        FileClose(1)
        FileClose(2)
        FileClose(3)
        FileClose(4)
        tmrEst.Enabled = False

        Arduino.WriteLine("")
        Arduino.Close()
        My.Computer.Audio.Stop()
        Dim x As New Form3
        x.Show()
    End Sub
    Private Sub tmrEst_Tick(sender As Object, e As EventArgs) Handles tmrEst.Tick
        tmrEst.Enabled = False
        If Form1.rdoFase2Lag.Checked = True Or Form1.rdoFase2Yoked.Checked = True Then
            Arduino.WriteLine("tcd")
        Else
            If Form1.rdoFase1IVDer.Checked = True Then Arduino.WriteLine("A")
            If Form1.rdoFase1IVIzq.Checked = True Then Arduino.WriteLine("B")
            If Form1.rdoFase2IVDer.Checked = True Then Arduino.WriteLine("C")
            If Form1.rdoFase2IVIzq.Checked = True Then Arduino.WriteLine("D")
        End If
    End Sub
    Private Sub tmrFIRT_Tick(sender As Object, e As EventArgs) Handles tmrFIRT.Tick
        tmrFIRT.Enabled = False
    End Sub
    Private Sub tmrFIRI_Tick(sender As Object, e As EventArgs) Handles tmrFIRI.Tick
        tmrFIRI.Enabled = False
    End Sub
End Class