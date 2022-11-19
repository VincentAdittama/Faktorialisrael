<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Judul = New System.Windows.Forms.Label()
        Me.TXT_Pass = New System.Windows.Forms.TextBox()
        Me.Notice = New System.Windows.Forms.Label()
        Me.BTN_Masuk = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Judul
        '
        Me.Judul.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Judul.AutoSize = True
        Me.Judul.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Judul.Location = New System.Drawing.Point(22, 42)
        Me.Judul.Name = "Judul"
        Me.Judul.Size = New System.Drawing.Size(275, 27)
        Me.Judul.TabIndex = 0
        Me.Judul.Text = "Aplikasi Bilangan Faktorial"
        Me.Judul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_Pass
        '
        Me.TXT_Pass.AcceptsReturn = True
        Me.TXT_Pass.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TXT_Pass.Location = New System.Drawing.Point(22, 93)
        Me.TXT_Pass.Name = "TXT_Pass"
        Me.TXT_Pass.Size = New System.Drawing.Size(275, 27)
        Me.TXT_Pass.TabIndex = 1
        '
        'Notice
        '
        Me.Notice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Notice.AutoSize = True
        Me.Notice.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Notice.Location = New System.Drawing.Point(41, 123)
        Me.Notice.Name = "Notice"
        Me.Notice.Size = New System.Drawing.Size(236, 15)
        Me.Notice.TabIndex = 0
        Me.Notice.Text = "Masukkan Password Untuk Melanjutkan"
        Me.Notice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_Masuk
        '
        Me.BTN_Masuk.BackColor = System.Drawing.Color.LawnGreen
        Me.BTN_Masuk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_Masuk.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTN_Masuk.Location = New System.Drawing.Point(102, 162)
        Me.BTN_Masuk.Name = "BTN_Masuk"
        Me.BTN_Masuk.Size = New System.Drawing.Size(114, 37)
        Me.BTN_Masuk.TabIndex = 2
        Me.BTN_Masuk.Text = "MASUK"
        Me.BTN_Masuk.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Salmon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(102, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "KELUAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 308)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_Masuk)
        Me.Controls.Add(Me.TXT_Pass)
        Me.Controls.Add(Me.Notice)
        Me.Controls.Add(Me.Judul)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Are you human?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Judul As Label
    Friend WithEvents TXT_Pass As TextBox
    Friend WithEvents Notice As Label
    Friend WithEvents BTN_Masuk As Button
    Friend WithEvents Button1 As Button
End Class
