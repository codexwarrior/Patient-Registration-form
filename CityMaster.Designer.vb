<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CityMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCity = New System.Windows.Forms.TextBox()
        Me.TextBoxCityID = New System.Windows.Forms.TextBox()
        Me.ComboBoxState = New System.Windows.Forms.ComboBox()
        Me.TextBoxStateID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CityID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(378, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "StateID"
        '
        'TextBoxCity
        '
        Me.TextBoxCity.Location = New System.Drawing.Point(95, 102)
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCity.TabIndex = 4
        '
        'TextBoxCityID
        '
        Me.TextBoxCityID.Location = New System.Drawing.Point(508, 99)
        Me.TextBoxCityID.Name = "TextBoxCityID"
        Me.TextBoxCityID.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCityID.TabIndex = 5
        '
        'ComboBoxState
        '
        Me.ComboBoxState.FormattingEnabled = True
        Me.ComboBoxState.Location = New System.Drawing.Point(95, 190)
        Me.ComboBoxState.Name = "ComboBoxState"
        Me.ComboBoxState.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxState.TabIndex = 6
        '
        'TextBoxStateID
        '
        Me.TextBoxStateID.Location = New System.Drawing.Point(508, 198)
        Me.TextBoxStateID.Name = "TextBoxStateID"
        Me.TextBoxStateID.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxStateID.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(268, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 59)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxStateID)
        Me.Controls.Add(Me.ComboBoxState)
        Me.Controls.Add(Me.TextBoxCityID)
        Me.Controls.Add(Me.TextBoxCity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "City"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents TextBoxCityID As TextBox
    Friend WithEvents ComboBoxState As ComboBox
    Friend WithEvents TextBoxStateID As TextBox
    Friend WithEvents Button1 As Button
End Class
