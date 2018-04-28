<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Wow1 = New DataLocker.Wow()
        Me.BonfireAlertBox1 = New DataLocker.BonfireAlertBox()
        Me.BonfireLabel2 = New DataLocker.BonfireLabel()
        Me.BonfireButton1 = New DataLocker.BonfireButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BonfireLabel1 = New DataLocker.BonfireLabel()
        Me.BonfireGroupBox1 = New DataLocker.BonfireGroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Wow1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BonfireGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wow1
        '
        Me.Wow1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Wow1.Controls.Add(Me.BonfireAlertBox1)
        Me.Wow1.Controls.Add(Me.BonfireLabel2)
        Me.Wow1.Controls.Add(Me.BonfireButton1)
        Me.Wow1.Controls.Add(Me.Panel1)
        Me.Wow1.Controls.Add(Me.BonfireGroupBox1)
        Me.Wow1.Location = New System.Drawing.Point(2, 2)
        Me.Wow1.Name = "Wow1"
        Me.Wow1.Padding = New System.Windows.Forms.Padding(1, 55, 1, 1)
        Me.Wow1.Size = New System.Drawing.Size(591, 183)
        Me.Wow1.TabIndex = 0
        Me.Wow1.Tyype = DataLocker.Wow.Type.Student
        '
        'BonfireAlertBox1
        '
        Me.BonfireAlertBox1.AlertStyle = DataLocker.BonfireAlertBox.Style._Error
        Me.BonfireAlertBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireAlertBox1.Location = New System.Drawing.Point(138, 188)
        Me.BonfireAlertBox1.Name = "BonfireAlertBox1"
        Me.BonfireAlertBox1.Size = New System.Drawing.Size(296, 32)
        Me.BonfireAlertBox1.TabIndex = 4
        Me.BonfireAlertBox1.Text = "You have not entered the correct Pin!"
        '
        'BonfireLabel2
        '
        Me.BonfireLabel2.AutoSize = True
        Me.BonfireLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BonfireLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel2.Location = New System.Drawing.Point(154, 66)
        Me.BonfireLabel2.Name = "BonfireLabel2"
        Me.BonfireLabel2.Size = New System.Drawing.Size(261, 13)
        Me.BonfireLabel2.TabIndex = 3
        Me.BonfireLabel2.Text = "Please Enter the pin recieved in the text file."
        '
        'BonfireButton1
        '
        Me.BonfireButton1.ButtonStyle = DataLocker.BonfireButton.Style.Blue
        Me.BonfireButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BonfireButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireButton1.Image = Nothing
        Me.BonfireButton1.Location = New System.Drawing.Point(250, 141)
        Me.BonfireButton1.Name = "BonfireButton1"
        Me.BonfireButton1.RoundedCorners = False
        Me.BonfireButton1.Size = New System.Drawing.Size(65, 26)
        Me.BonfireButton1.TabIndex = 2
        Me.BonfireButton1.Text = "Unlock"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BonfireLabel1)
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 37)
        Me.Panel1.TabIndex = 1
        '
        'BonfireLabel1
        '
        Me.BonfireLabel1.AutoSize = True
        Me.BonfireLabel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel1.Location = New System.Drawing.Point(3, 9)
        Me.BonfireLabel1.Name = "BonfireLabel1"
        Me.BonfireLabel1.Size = New System.Drawing.Size(98, 18)
        Me.BonfireLabel1.TabIndex = 0
        Me.BonfireLabel1.Text = "Enter Code"
        '
        'BonfireGroupBox1
        '
        Me.BonfireGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BonfireGroupBox1.Controls.Add(Me.TextBox1)
        Me.BonfireGroupBox1.Location = New System.Drawing.Point(126, 97)
        Me.BonfireGroupBox1.Name = "BonfireGroupBox1"
        Me.BonfireGroupBox1.Size = New System.Drawing.Size(324, 30)
        Me.BonfireGroupBox1.TabIndex = 0
        Me.BonfireGroupBox1.Text = "BonfireGroupBox1"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(3, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(318, 13)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(595, 187)
        Me.Controls.Add(Me.Wow1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Code"
        Me.Wow1.ResumeLayout(False)
        Me.Wow1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BonfireGroupBox1.ResumeLayout(False)
        Me.BonfireGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wow1 As DataLocker.Wow
    Friend WithEvents BonfireGroupBox1 As DataLocker.BonfireGroupBox
    Friend WithEvents BonfireLabel2 As DataLocker.BonfireLabel
    Friend WithEvents BonfireButton1 As DataLocker.BonfireButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BonfireLabel1 As DataLocker.BonfireLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BonfireAlertBox1 As DataLocker.BonfireAlertBox
End Class
