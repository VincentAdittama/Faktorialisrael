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
        Me.Judul = New System.Windows.Forms.Label()
        Me.NoticeFak = New System.Windows.Forms.Label()
        Me.TXT_Fak = New System.Windows.Forms.TextBox()
        Me.TXT_Hasil = New System.Windows.Forms.TextBox()
        Me.NoticeHasil = New System.Windows.Forms.Label()
        Me.BTN_Batal = New System.Windows.Forms.Button()
        Me.BTN_Kosongkan = New System.Windows.Forms.Button()
        Me.BTN_Hitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Judul
        '
        Me.Judul.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Judul.AutoSize = True
        Me.Judul.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Judul.Location = New System.Drawing.Point(76, 36)
        Me.Judul.Name = "Judul"
        Me.Judul.Size = New System.Drawing.Size(275, 27)
        Me.Judul.TabIndex = 1
        Me.Judul.Text = "Aplikasi Bilangan Faktorial"
        Me.Judul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NoticeFak
        '
        Me.NoticeFak.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoticeFak.AutoSize = True
        Me.NoticeFak.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NoticeFak.Location = New System.Drawing.Point(76, 92)
        Me.NoticeFak.Name = "NoticeFak"
        Me.NoticeFak.Size = New System.Drawing.Size(147, 15)
        Me.NoticeFak.TabIndex = 3
        Me.NoticeFak.Text = "Masukkan Nilai Faktorial"
        Me.NoticeFak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXT_Fak
        '
        Me.TXT_Fak.AcceptsReturn = True
        Me.TXT_Fak.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TXT_Fak.Location = New System.Drawing.Point(76, 110)
        Me.TXT_Fak.MaxLength = 2
        Me.TXT_Fak.Name = "TXT_Fak"
        Me.TXT_Fak.Size = New System.Drawing.Size(275, 27)
        Me.TXT_Fak.TabIndex = 4
        '
        'TXT_Hasil
        '
        Me.TXT_Hasil.AcceptsReturn = True
        Me.TXT_Hasil.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TXT_Hasil.Location = New System.Drawing.Point(27, 205)
        Me.TXT_Hasil.Name = "TXT_Hasil"
        Me.TXT_Hasil.Size = New System.Drawing.Size(372, 36)
        Me.TXT_Hasil.TabIndex = 4
        Me.TXT_Hasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NoticeHasil
        '
        Me.NoticeHasil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoticeHasil.AutoSize = True
        Me.NoticeHasil.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NoticeHasil.Location = New System.Drawing.Point(169, 187)
        Me.NoticeHasil.Name = "NoticeHasil"
        Me.NoticeHasil.Size = New System.Drawing.Size(88, 15)
        Me.NoticeHasil.TabIndex = 3
        Me.NoticeHasil.Text = "Hasil Faktorial"
        Me.NoticeHasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_Batal
        '
        Me.BTN_Batal.BackColor = System.Drawing.Color.LawnGreen
        Me.BTN_Batal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_Batal.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTN_Batal.Location = New System.Drawing.Point(27, 286)
        Me.BTN_Batal.Name = "BTN_Batal"
        Me.BTN_Batal.Size = New System.Drawing.Size(120, 37)
        Me.BTN_Batal.TabIndex = 5
        Me.BTN_Batal.Text = "BATAL"
        Me.BTN_Batal.UseVisualStyleBackColor = False
        '
        'BTN_Kosongkan
        '
        Me.BTN_Kosongkan.BackColor = System.Drawing.Color.LawnGreen
        Me.BTN_Kosongkan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_Kosongkan.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTN_Kosongkan.Location = New System.Drawing.Point(153, 286)
        Me.BTN_Kosongkan.Name = "BTN_Kosongkan"
        Me.BTN_Kosongkan.Size = New System.Drawing.Size(120, 37)
        Me.BTN_Kosongkan.TabIndex = 5
        Me.BTN_Kosongkan.Text = "KOSONGKAN"
        Me.BTN_Kosongkan.UseVisualStyleBackColor = False
        '
        'BTN_Hitung
        '
        Me.BTN_Hitung.BackColor = System.Drawing.Color.LawnGreen
        Me.BTN_Hitung.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_Hitung.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTN_Hitung.Location = New System.Drawing.Point(279, 286)
        Me.BTN_Hitung.Name = "BTN_Hitung"
        Me.BTN_Hitung.Size = New System.Drawing.Size(120, 37)
        Me.BTN_Hitung.TabIndex = 5
        Me.BTN_Hitung.Text = "HITUNG"
        Me.BTN_Hitung.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 398)
        Me.Controls.Add(Me.TXT_Fak)
        Me.Controls.Add(Me.BTN_Kosongkan)
        Me.Controls.Add(Me.BTN_Hitung)
        Me.Controls.Add(Me.BTN_Batal)
        Me.Controls.Add(Me.NoticeHasil)
        Me.Controls.Add(Me.NoticeFak)
        Me.Controls.Add(Me.Judul)
        Me.Controls.Add(Me.TXT_Hasil)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maksimal 2 digit sih"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents Judul As Label
    Friend WithEvents NoticeFak As Label
    Friend WithEvents TXT_Fak As TextBox
    Friend WithEvents TXT_Hasil As TextBox
    Friend WithEvents NoticeHasil As Label
    Friend WithEvents BTN_Batal As Button
    Friend WithEvents BTN_Kosongkan As Button
    Friend WithEvents BTN_Hitung As Button

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
