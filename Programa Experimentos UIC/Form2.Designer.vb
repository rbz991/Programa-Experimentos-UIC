<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRes1 = New System.Windows.Forms.Label()
        Me.lblRes2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblReforzadores = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRes4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblRes3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblResTotales = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.tmrVI = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEst = New System.Windows.Forms.Timer(Me.components)
        Me.lblEnsayo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbxPrevSeqs = New System.Windows.Forms.ListBox()
        Me.tmrFIRT = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFIRI = New System.Windows.Forms.Timer(Me.components)
        Me.lbxSecs = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1478, 459)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 94)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Abortar misión"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(468, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Respuestas 1"
        '
        'lblRes1
        '
        Me.lblRes1.AutoSize = True
        Me.lblRes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes1.Location = New System.Drawing.Point(542, 109)
        Me.lblRes1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRes1.Name = "lblRes1"
        Me.lblRes1.Size = New System.Drawing.Size(36, 37)
        Me.lblRes1.TabIndex = 2
        Me.lblRes1.Text = "0"
        '
        'lblRes2
        '
        Me.lblRes2.AutoSize = True
        Me.lblRes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes2.Location = New System.Drawing.Point(832, 109)
        Me.lblRes2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRes2.Name = "lblRes2"
        Me.lblRes2.Size = New System.Drawing.Size(36, 37)
        Me.lblRes2.TabIndex = 4
        Me.lblRes2.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(752, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Respuestas 2"
        '
        'lblReforzadores
        '
        Me.lblReforzadores.AutoSize = True
        Me.lblReforzadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReforzadores.Location = New System.Drawing.Point(542, 296)
        Me.lblReforzadores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReforzadores.Name = "lblReforzadores"
        Me.lblReforzadores.Size = New System.Drawing.Size(36, 37)
        Me.lblReforzadores.TabIndex = 6
        Me.lblReforzadores.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(468, 230)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 37)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Reforzadores"
        '
        'lblRes4
        '
        Me.lblRes4.AutoSize = True
        Me.lblRes4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes4.Location = New System.Drawing.Point(1360, 109)
        Me.lblRes4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRes4.Name = "lblRes4"
        Me.lblRes4.Size = New System.Drawing.Size(36, 37)
        Me.lblRes4.TabIndex = 10
        Me.lblRes4.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1280, 49)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(223, 37)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Respuestas 4"
        '
        'lblRes3
        '
        Me.lblRes3.AutoSize = True
        Me.lblRes3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes3.Location = New System.Drawing.Point(1112, 109)
        Me.lblRes3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRes3.Name = "lblRes3"
        Me.lblRes3.Size = New System.Drawing.Size(36, 37)
        Me.lblRes3.TabIndex = 8
        Me.lblRes3.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1020, 49)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(223, 37)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Respuestas 3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(768, 230)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(179, 37)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Rs Totales"
        '
        'lblResTotales
        '
        Me.lblResTotales.AutoSize = True
        Me.lblResTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResTotales.Location = New System.Drawing.Point(832, 296)
        Me.lblResTotales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResTotales.Name = "lblResTotales"
        Me.lblResTotales.Size = New System.Drawing.Size(36, 37)
        Me.lblResTotales.TabIndex = 12
        Me.lblResTotales.Text = "0"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(1072, 230)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(130, 37)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "Tiempo"
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeNow.Location = New System.Drawing.Point(1112, 296)
        Me.lblTimeNow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(36, 37)
        Me.lblTimeNow.TabIndex = 14
        Me.lblTimeNow.Text = "0"
        '
        'tmrVI
        '
        '
        'tmrStart
        '
        Me.tmrStart.Enabled = True
        Me.tmrStart.Interval = 600
        '
        'tmrEst
        '
        '
        'lblEnsayo
        '
        Me.lblEnsayo.AutoSize = True
        Me.lblEnsayo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnsayo.Location = New System.Drawing.Point(1334, 296)
        Me.lblEnsayo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnsayo.Name = "lblEnsayo"
        Me.lblEnsayo.Size = New System.Drawing.Size(36, 37)
        Me.lblEnsayo.TabIndex = 16
        Me.lblEnsayo.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1294, 230)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 37)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Ensayo"
        '
        'lbxPrevSeqs
        '
        Me.lbxPrevSeqs.FormattingEnabled = True
        Me.lbxPrevSeqs.ItemHeight = 25
        Me.lbxPrevSeqs.Location = New System.Drawing.Point(1600, 49)
        Me.lbxPrevSeqs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lbxPrevSeqs.Name = "lbxPrevSeqs"
        Me.lbxPrevSeqs.Size = New System.Drawing.Size(236, 179)
        Me.lbxPrevSeqs.TabIndex = 17
        '
        'tmrFIRT
        '
        Me.tmrFIRT.Interval = 500
        '
        'tmrFIRI
        '
        Me.tmrFIRI.Interval = 5000
        '
        'lbxSecs
        '
        Me.lbxSecs.FormattingEnabled = True
        Me.lbxSecs.ItemHeight = 25
        Me.lbxSecs.Location = New System.Drawing.Point(1600, 244)
        Me.lbxSecs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lbxSecs.Name = "lbxSecs"
        Me.lbxSecs.Size = New System.Drawing.Size(236, 179)
        Me.lbxSecs.TabIndex = 18
        Me.lbxSecs.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Programa_Experimentos_UIC.My.Resources.Resources._5OIW
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(449, 282)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1867, 585)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbxSecs)
        Me.Controls.Add(Me.lbxPrevSeqs)
        Me.Controls.Add(Me.lblEnsayo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimeNow)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblResTotales)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblRes4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblRes3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblReforzadores)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblRes2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRes1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRes1 As Label
    Friend WithEvents lblRes2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblReforzadores As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRes4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblRes3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblResTotales As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblTimeNow As Label
    Friend WithEvents tmrVI As Timer
    Friend WithEvents tmrStart As Timer
    Friend WithEvents tmrEst As Timer
    Friend WithEvents lblEnsayo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbxPrevSeqs As ListBox
    Friend WithEvents tmrFIRT As Timer
    Friend WithEvents tmrFIRI As Timer
    Friend WithEvents lbxSecs As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
