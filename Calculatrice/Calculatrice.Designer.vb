<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculatrice
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ButtonE = New System.Windows.Forms.Button()
        Me.ButtonP = New System.Windows.Forms.Button()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.ButtonM = New System.Windows.Forms.Button()
        Me.ButtonV = New System.Windows.Forms.Button()
        Me.ButtonMU = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.ButtonN = New System.Windows.Forms.Button()
        Me.ButtonD = New System.Windows.Forms.Button()
        Me.Ecran = New System.Windows.Forms.TextBox()
        Me.ButtonRESET = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button1.Location = New System.Drawing.Point(171, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 92)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button2.Location = New System.Drawing.Point(292, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 92)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button3.Location = New System.Drawing.Point(413, 432)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 92)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button4.Location = New System.Drawing.Point(171, 334)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 92)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button5.Location = New System.Drawing.Point(292, 334)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 92)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button6.Location = New System.Drawing.Point(413, 334)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 92)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button7.Location = New System.Drawing.Point(171, 236)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(115, 92)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button8.Location = New System.Drawing.Point(292, 236)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(115, 92)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button9.Location = New System.Drawing.Point(413, 236)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(115, 92)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ButtonE
        '
        Me.ButtonE.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.ButtonE.Location = New System.Drawing.Point(662, 530)
        Me.ButtonE.Name = "ButtonE"
        Me.ButtonE.Size = New System.Drawing.Size(115, 92)
        Me.ButtonE.TabIndex = 9
        Me.ButtonE.Text = "="
        Me.ButtonE.UseVisualStyleBackColor = True
        '
        'ButtonP
        '
        Me.ButtonP.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.ButtonP.Location = New System.Drawing.Point(662, 432)
        Me.ButtonP.Name = "ButtonP"
        Me.ButtonP.Size = New System.Drawing.Size(115, 92)
        Me.ButtonP.TabIndex = 10
        Me.ButtonP.Text = "+"
        Me.ButtonP.UseVisualStyleBackColor = True
        '
        'ButtonDel
        '
        Me.ButtonDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ButtonDel.Location = New System.Drawing.Point(783, 530)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(115, 92)
        Me.ButtonDel.TabIndex = 11
        Me.ButtonDel.Text = "DEL"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'ButtonM
        '
        Me.ButtonM.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.ButtonM.Location = New System.Drawing.Point(783, 432)
        Me.ButtonM.Name = "ButtonM"
        Me.ButtonM.Size = New System.Drawing.Size(115, 92)
        Me.ButtonM.TabIndex = 12
        Me.ButtonM.Text = "-"
        Me.ButtonM.UseVisualStyleBackColor = True
        '
        'ButtonV
        '
        Me.ButtonV.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.ButtonV.Location = New System.Drawing.Point(292, 530)
        Me.ButtonV.Name = "ButtonV"
        Me.ButtonV.Size = New System.Drawing.Size(115, 92)
        Me.ButtonV.TabIndex = 13
        Me.ButtonV.Text = "."
        Me.ButtonV.UseVisualStyleBackColor = True
        '
        'ButtonMU
        '
        Me.ButtonMU.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.ButtonMU.Location = New System.Drawing.Point(662, 334)
        Me.ButtonMU.Name = "ButtonMU"
        Me.ButtonMU.Size = New System.Drawing.Size(115, 92)
        Me.ButtonMU.TabIndex = 14
        Me.ButtonMU.Text = "❌"
        Me.ButtonMU.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button0.Location = New System.Drawing.Point(171, 530)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(115, 92)
        Me.Button0.TabIndex = 15
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'ButtonN
        '
        Me.ButtonN.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.ButtonN.Location = New System.Drawing.Point(413, 530)
        Me.ButtonN.Name = "ButtonN"
        Me.ButtonN.Size = New System.Drawing.Size(115, 92)
        Me.ButtonN.TabIndex = 16
        Me.ButtonN.Text = "(-)"
        Me.ButtonN.UseVisualStyleBackColor = True
        '
        'ButtonD
        '
        Me.ButtonD.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.ButtonD.Location = New System.Drawing.Point(783, 334)
        Me.ButtonD.Name = "ButtonD"
        Me.ButtonD.Size = New System.Drawing.Size(115, 92)
        Me.ButtonD.TabIndex = 17
        Me.ButtonD.Text = "÷"
        Me.ButtonD.UseVisualStyleBackColor = True
        '
        'Ecran
        '
        Me.Ecran.BackColor = System.Drawing.Color.White
        Me.Ecran.Enabled = False
        Me.Ecran.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Ecran.Location = New System.Drawing.Point(122, 28)
        Me.Ecran.Multiline = True
        Me.Ecran.Name = "Ecran"
        Me.Ecran.Size = New System.Drawing.Size(447, 156)
        Me.Ecran.TabIndex = 18
        '
        'ButtonRESET
        '
        Me.ButtonRESET.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.ButtonRESET.Location = New System.Drawing.Point(662, 236)
        Me.ButtonRESET.Name = "ButtonRESET"
        Me.ButtonRESET.Size = New System.Drawing.Size(236, 92)
        Me.ButtonRESET.TabIndex = 19
        Me.ButtonRESET.Text = "RESET"
        Me.ButtonRESET.UseVisualStyleBackColor = True
        '
        'Calculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 648)
        Me.Controls.Add(Me.ButtonRESET)
        Me.Controls.Add(Me.Ecran)
        Me.Controls.Add(Me.ButtonD)
        Me.Controls.Add(Me.ButtonN)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.ButtonMU)
        Me.Controls.Add(Me.ButtonV)
        Me.Controls.Add(Me.ButtonM)
        Me.Controls.Add(Me.ButtonDel)
        Me.Controls.Add(Me.ButtonP)
        Me.Controls.Add(Me.ButtonE)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Calculatrice"
        Me.Text = "Calculatrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ButtonE As Button
    Friend WithEvents ButtonP As Button
    Friend WithEvents ButtonDel As Button
    Friend WithEvents ButtonM As Button
    Friend WithEvents ButtonV As Button
    Friend WithEvents ButtonMU As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents ButtonN As Button
    Friend WithEvents ButtonD As Button
    Friend WithEvents Ecran As TextBox
    Friend WithEvents ButtonRESET As Button
End Class
