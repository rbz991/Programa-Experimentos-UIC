Imports System.IO.Ports
Imports System.Linq
Module Module1
    Public vPhase As String
    Public Comunication_Port_X As String
    Public Arduino As SerialPort
    Public Arduino_String As String = ""
    Public DATOS_BRUTOS(4) As String
    Public Actual_Response(4) As Integer
    Public Previous_Response(4) As Integer
    Public SessionDuration As Integer = 0
    Public vTimeStart As Integer = 0
    Public vTimeNow As Integer = 0
    Public vSecuencia As Integer = 0
    Public vResponse1 As Integer = 0
    Public vResponse2 As Integer = 0
    Public vResponse3 As Integer = 0
    Public vResponse4 As Integer = 0
    Public vResponse5 As Integer = 0
    Public vResponse(4) As Integer
    Public vRespuestasTotales As Integer = 0
    Public vReforzadores As Integer = 0
    Public vRefReady As Boolean = False
    Public VIList As New List(Of Integer)
    Public PrevSeqs As New List(Of String)
    Public vEndTime As New Integer
    Public vEnsayos As Integer = 0
    Public vCurrentSeq As String = ""
    Public vIndexCS As Byte = 0
    Public vUniqSec As Integer = 0
    Public RF_criterio As Integer = 0
    Public RF_contador As Integer = 0
End Module
