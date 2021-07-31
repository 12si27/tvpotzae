<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits MetroFramework.Forms.MetroForm

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CopyBoxBackPanel = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.WarnLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt_min = New System.Windows.Forms.Panel()
        Me.bt_close = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.CopyBoxBackPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CopyBoxBackPanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 169)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(600, 77)
        Me.Panel1.TabIndex = 2
        '
        'CopyBoxBackPanel
        '
        Me.CopyBoxBackPanel.BackColor = System.Drawing.Color.DimGray
        Me.CopyBoxBackPanel.Controls.Add(Me.RichTextBox1)
        Me.CopyBoxBackPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CopyBoxBackPanel.Location = New System.Drawing.Point(5, 5)
        Me.CopyBoxBackPanel.Name = "CopyBoxBackPanel"
        Me.CopyBoxBackPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.CopyBoxBackPanel.Size = New System.Drawing.Size(590, 67)
        Me.CopyBoxBackPanel.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(5, 5)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(580, 57)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'WarnLabel
        '
        Me.WarnLabel.AutoSize = True
        Me.WarnLabel.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.WarnLabel.ForeColor = System.Drawing.Color.Red
        Me.WarnLabel.Location = New System.Drawing.Point(73, 3)
        Me.WarnLabel.Name = "WarnLabel"
        Me.WarnLabel.Size = New System.Drawing.Size(466, 15)
        Me.WarnLabel.TabIndex = 18
        Me.WarnLabel.Text = "Moo0 유튜브 다운로더를 연 뒤 반드시 '클립보드로 부터 자동 시작'을 체크해 주세요!"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.WarnLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 246)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 23)
        Me.Panel2.TabIndex = 19
        '
        'bt_min
        '
        Me.bt_min.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.bt_min.BackgroundImage = Global.tvpotzae.My.Resources.Resources.bt_min
        Me.bt_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_min.Location = New System.Drawing.Point(546, 5)
        Me.bt_min.Name = "bt_min"
        Me.bt_min.Size = New System.Drawing.Size(19, 19)
        Me.bt_min.TabIndex = 17
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.bt_close.BackgroundImage = Global.tvpotzae.My.Resources.Resources.bt_close
        Me.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_close.Location = New System.Drawing.Point(571, 5)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(19, 19)
        Me.bt_close.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.tvpotzae.My.Resources.Resources.animation
        Me.PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 269)
        Me.ControlBox = False
        Me.Controls.Add(Me.bt_min)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DisplayHeader = False
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = "아래 항목들을 복사해주세요!"
        Me.Panel1.ResumeLayout(False)
        Me.CopyBoxBackPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_min As System.Windows.Forms.Panel
    Friend WithEvents bt_close As System.Windows.Forms.Panel
    Friend WithEvents CopyBoxBackPanel As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents WarnLabel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
