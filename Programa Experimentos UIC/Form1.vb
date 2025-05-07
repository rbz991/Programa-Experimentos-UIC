
Imports System.IO.Ports

Public Class Form1
    Dim vFile
    Dim vFile2
    Dim vFile3
    Dim vFile4
    Dim vFile5
    Dim vLeftL As Boolean = True
    Dim vRightL As Boolean = True
    'Dim vFileSecuencias
    'Dim vFileJustSecuencias
    'Dim vFileEnsayos
    Dim Filereader As System.IO.StreamReader
    Dim stringReader As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Arduino.Close()


        SessionDuration = txbDurSesion.Text * 60000
        Comunication_Port_X = txtCOM.Text
        vFile = "C:\Data\" & txtRat.Text & "_" & txtSesion.Text & "_raw.txt"
        FileOpen(1, vFile, OpenMode.Append)
        WriteLine(1, Format(Date.Now, "dd-MM-yyyy_hh-mm-ss"))
        WriteLine(1, "Rat: " & txtRat.Text)
        WriteLine(1, "Session: " & txtSesion.Text)
        WriteLine(1, "Fase: " & vPhase)

        If rdoFase2Lag.Checked = True Then
            vFile2 = "C:\Data\" & txtRat.Text & "_" & txtSesion.Text & "_refs.txt"
            vFile3 = "C:\Data\" & txtRat.Text & "_" & txtSesion.Text & "_seqs.txt"
            FileOpen(2, vFile2, OpenMode.Append)
            FileOpen(3, vFile3, OpenMode.Append)

            vFile4 = "C:\Data\" & txtRat.Text & "_" & txtSesion.Text - 1 & "_seqs.txt"
            FileOpen(4, vFile4, OpenMode.Input)
        End If

        If rdoFase2Yoked.Checked = True Then
            vFile2 = "C:\Data\" & txtRat.Text & "_" & txtSesion.Text & "_refs.txt"
            vFile3 = "C:\Data\" & txtRat.Text & "_" & txtSesion.Text & "_seqs.txt"
            FileOpen(2, vFile2, OpenMode.Append)
            FileOpen(3, vFile3, OpenMode.Append)

            vFile5 = "C:\Data\" & txtRatY.Text & "_" & txtSesion.Text & "_refs.txt"
            FileOpen(5, vFile5, OpenMode.Input)
        End If



        Dim x As New Form2
        x.Show()
        x.ArduinoVB()
        Me.Visible = False
    End Sub

    Private Sub rdoFase2Yoked_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFase2Yoked.CheckedChanged
        If rdoFase2Yoked.Checked = True Then
            txtRatY.Enabled = True
        Else
            txtRatY.Text = ""
            txtRatY.Enabled = False
        End If
    End Sub

    Private Sub rdoFase2Lag_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFase2Lag.CheckedChanged
        If rdoFase2Lag.Checked = True Then
            txtLag.Enabled = True
        Else
            txtLag.Text = ""
            txtLag.Enabled = False
        End If
    End Sub

    Private Sub rdo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPreentrenamiento.CheckedChanged, rdoFase1RFIzq.CheckedChanged, rdoFase1RFDer.CheckedChanged, rdoFase2RFDer.CheckedChanged, rdoFase2RFIzq.CheckedChanged, rdoFase1IVIzq.CheckedChanged, rdoFase1IVDer.CheckedChanged, rdoFase2IVDer.CheckedChanged, rdoFase2IVIzq.CheckedChanged, rdoFase3Ext.CheckedChanged
        vPhase = sender.Text
    End Sub

    Private Sub btnLeftLever_Click(sender As Object, e As EventArgs) Handles btnLeftLever.Click
        If vLeftL = False Then
            vLeftL = True
            Arduino.WriteLine("L")
        Else
            vLeftL = False
            Arduino.WriteLine("l")
        End If
    End Sub

    Private Sub btnRightLever_Click(sender As Object, e As EventArgs) Handles btnRightLever.Click
        If vRightL = False Then
            vRightL = True
            Arduino.WriteLine("M")
        Else
            vRightL = False
            Arduino.WriteLine("m")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnConect.Click


        Try
            Comunication_Port_X = txtCOM.Text
            Arduino = New SerialPort(Comunication_Port_X, 9600)
            Arduino.Open()
            btnConect.Enabled = False
            Button1.Enabled = True
            btnLeftLever.Enabled = True
            btnRightLever.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check COM Port is available.")
        End Try

    End Sub


End Class
