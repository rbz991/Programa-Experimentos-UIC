Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIV.Text = Form1.txbVIValue.Text
        lblRefs.Text = vReforzadores
        lblDuracion.Text = (vEndTime / 60 & " m")
        lblRateL1.Text = (vResponse(1) / (vEndTime / 60))
        lblRateL2.Text = (vResponse(2) / (vEndTime / 60))
        lblRateL3.Text = (vResponse(3) / (vEndTime / 60))
        lblRateL4.Text = (vResponse(4) / (vEndTime / 60))
        lblSecDif.Text = vUniqSec
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()
        Form2.Close()
        End
    End Sub
End Class