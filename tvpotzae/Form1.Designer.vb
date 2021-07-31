<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTB2 = New System.Windows.Forms.Panel()
        Me.BT2 = New System.Windows.Forms.Label()
        Me.BTB1 = New System.Windows.Forms.Panel()
        Me.BT1 = New System.Windows.Forms.Label()
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.List_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.List_num = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PanelOne = New System.Windows.Forms.Panel()
        Me.PotNamePanel = New System.Windows.Forms.Panel()
        Me.PotNameLabel = New System.Windows.Forms.Label()
        Me.SearchTypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTwo = New System.Windows.Forms.Panel()
        Me.PotThumb = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EpiState = New System.Windows.Forms.Label()
        Me.CopyState = New System.Windows.Forms.Label()
        Me.MetroProgressSpinner2 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Finder = New System.ComponentModel.BackgroundWorker()
        Me.AddDelay = New System.ComponentModel.BackgroundWorker()
        Me.PotThumbLoad = New System.ComponentModel.BackgroundWorker()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bt_min = New System.Windows.Forms.Panel()
        Me.bt_close = New System.Windows.Forms.Panel()
        Me.BTB2.SuspendLayout()
        Me.BTB1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelOne.SuspendLayout()
        Me.PotNamePanel.SuspendLayout()
        Me.PanelTwo.SuspendLayout()
        CType(Me.PotThumb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(93, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 27)
        Me.TextBox1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "대상 ID"
        '
        'BTB2
        '
        Me.BTB2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BTB2.Controls.Add(Me.BT2)
        Me.BTB2.Location = New System.Drawing.Point(411, 360)
        Me.BTB2.Name = "BTB2"
        Me.BTB2.Size = New System.Drawing.Size(126, 46)
        Me.BTB2.TabIndex = 8
        '
        'BT2
        '
        Me.BT2.AutoSize = True
        Me.BT2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BT2.ForeColor = System.Drawing.Color.White
        Me.BT2.Location = New System.Drawing.Point(8, 9)
        Me.BT2.Name = "BT2"
        Me.BT2.Size = New System.Drawing.Size(109, 20)
        Me.BT2.TabIndex = 1
        Me.BT2.Text = "주소 복사 시작"
        '
        'BTB1
        '
        Me.BTB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BTB1.Controls.Add(Me.BT1)
        Me.BTB1.Location = New System.Drawing.Point(238, 24)
        Me.BTB1.Name = "BTB1"
        Me.BTB1.Size = New System.Drawing.Size(84, 27)
        Me.BTB1.TabIndex = 9
        '
        'BT1
        '
        Me.BT1.AutoSize = True
        Me.BT1.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BT1.ForeColor = System.Drawing.Color.White
        Me.BT1.Location = New System.Drawing.Point(12, 6)
        Me.BT1.Name = "BT1"
        Me.BT1.Size = New System.Drawing.Size(60, 17)
        Me.BT1.TabIndex = 1
        Me.BT1.Text = "탐색하기"
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(1, 2)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(41, 41)
        Me.MetroProgressSpinner1.Speed = 2.0!
        Me.MetroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroProgressSpinner1.TabIndex = 10
        Me.MetroProgressSpinner1.UseSelectable = True
        Me.MetroProgressSpinner1.Value = 33
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.MetroProgressSpinner1)
        Me.Panel1.Location = New System.Drawing.Point(328, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 45)
        Me.Panel1.TabIndex = 11
        Me.Panel1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "목록 탐색 작업중..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.List_name, Me.List_num})
        Me.ListView1.Location = New System.Drawing.Point(0, 57)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(514, 194)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'List_name
        '
        Me.List_name.Text = "영상 제목"
        Me.List_name.Width = 400
        '
        'List_num
        '
        Me.List_num.Text = "번호"
        Me.List_num.Width = 86
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(0, 257)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 19)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "모두 선택"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(463, 418)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(74, 17)
        Me.LinkLabel2.TabIndex = 18
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "세부 설정..."
        '
        'PanelOne
        '
        Me.PanelOne.Controls.Add(Me.PotNamePanel)
        Me.PanelOne.Controls.Add(Me.SearchTypeComboBox1)
        Me.PanelOne.Controls.Add(Me.Button2)
        Me.PanelOne.Controls.Add(Me.Button1)
        Me.PanelOne.Controls.Add(Me.Label1)
        Me.PanelOne.Controls.Add(Me.ListView1)
        Me.PanelOne.Controls.Add(Me.CheckBox1)
        Me.PanelOne.Controls.Add(Me.TextBox1)
        Me.PanelOne.Controls.Add(Me.Label2)
        Me.PanelOne.Controls.Add(Me.BTB1)
        Me.PanelOne.Controls.Add(Me.Panel1)
        Me.PanelOne.Location = New System.Drawing.Point(23, 80)
        Me.PanelOne.Name = "PanelOne"
        Me.PanelOne.Size = New System.Drawing.Size(514, 277)
        Me.PanelOne.TabIndex = 19
        '
        'PotNamePanel
        '
        Me.PotNamePanel.Controls.Add(Me.PotNameLabel)
        Me.PotNamePanel.Location = New System.Drawing.Point(53, 4)
        Me.PotNamePanel.Name = "PotNamePanel"
        Me.PotNamePanel.Size = New System.Drawing.Size(269, 18)
        Me.PotNamePanel.TabIndex = 24
        '
        'PotNameLabel
        '
        Me.PotNameLabel.AutoSize = True
        Me.PotNameLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PotNameLabel.Location = New System.Drawing.Point(179, 2)
        Me.PotNameLabel.Name = "PotNameLabel"
        Me.PotNameLabel.Size = New System.Drawing.Size(87, 15)
        Me.PotNameLabel.TabIndex = 23
        Me.PotNameLabel.Text = "게시자 : 123님"
        Me.PotNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.PotNameLabel.Visible = False
        '
        'SearchTypeComboBox1
        '
        Me.SearchTypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchTypeComboBox1.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SearchTypeComboBox1.FormattingEnabled = True
        Me.SearchTypeComboBox1.Items.AddRange(New Object() {"팟 페이지", "재생목록"})
        Me.SearchTypeComboBox1.Location = New System.Drawing.Point(0, 25)
        Me.SearchTypeComboBox1.Name = "SearchTypeComboBox1"
        Me.SearchTypeComboBox1.Size = New System.Drawing.Size(87, 25)
        Me.SearchTypeComboBox1.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(439, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 22)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "체크 해제"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "체크"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(273, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "선택한 항목을"
        '
        'PanelTwo
        '
        Me.PanelTwo.Controls.Add(Me.PotThumb)
        Me.PanelTwo.Controls.Add(Me.Label7)
        Me.PanelTwo.Controls.Add(Me.EpiState)
        Me.PanelTwo.Controls.Add(Me.CopyState)
        Me.PanelTwo.Controls.Add(Me.MetroProgressSpinner2)
        Me.PanelTwo.Location = New System.Drawing.Point(23, 80)
        Me.PanelTwo.Name = "PanelTwo"
        Me.PanelTwo.Size = New System.Drawing.Size(514, 277)
        Me.PanelTwo.TabIndex = 19
        Me.PanelTwo.Visible = False
        '
        'PotThumb
        '
        Me.PotThumb.BackColor = System.Drawing.Color.Transparent
        Me.PotThumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PotThumb.Location = New System.Drawing.Point(232, 95)
        Me.PotThumb.Name = "PotThumb"
        Me.PotThumb.Size = New System.Drawing.Size(50, 50)
        Me.PotThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PotThumb.TabIndex = 15
        Me.PotThumb.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(46, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(421, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "경고 : 복사 작업 중에는 절대 복사/붙여넣기를 하지 마세요. 값이 소실됩니다."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EpiState
        '
        Me.EpiState.AutoSize = True
        Me.EpiState.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.EpiState.Location = New System.Drawing.Point(231, 224)
        Me.EpiState.Name = "EpiState"
        Me.EpiState.Size = New System.Drawing.Size(50, 15)
        Me.EpiState.TabIndex = 13
        Me.EpiState.Text = "EpiState"
        '
        'CopyState
        '
        Me.CopyState.AutoSize = True
        Me.CopyState.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CopyState.Location = New System.Drawing.Point(217, 197)
        Me.CopyState.Name = "CopyState"
        Me.CopyState.Size = New System.Drawing.Size(78, 20)
        Me.CopyState.TabIndex = 12
        Me.CopyState.Text = "CopyState"
        '
        'MetroProgressSpinner2
        '
        Me.MetroProgressSpinner2.Location = New System.Drawing.Point(192, 55)
        Me.MetroProgressSpinner2.Maximum = 100
        Me.MetroProgressSpinner2.Name = "MetroProgressSpinner2"
        Me.MetroProgressSpinner2.Size = New System.Drawing.Size(130, 130)
        Me.MetroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroProgressSpinner2.TabIndex = 11
        Me.MetroProgressSpinner2.UseSelectable = True
        Me.MetroProgressSpinner2.Value = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(236, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 26)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Shift(Alt) 키를 누른 채로 클릭하여" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "복수(개별) 선택이 가능합니다"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Finder
        '
        Me.Finder.WorkerSupportsCancellation = True
        '
        'AddDelay
        '
        '
        'PotThumbLoad
        '
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel3.Location = New System.Drawing.Point(20, 418)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(355, 17)
        Me.LinkLabel3.TabIndex = 21
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "다운로더 강제로 죽이기 (프로그램 응답 없음, 실행 불가시)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(485, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "0.3 베타"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PictureBox2.Image = Global.tvpotzae.My.Resources.Resources.down_bt
        Me.PictureBox2.Location = New System.Drawing.Point(23, 360)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(126, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.tvpotzae.My.Resources.Resources.title
        Me.PictureBox1.Location = New System.Drawing.Point(23, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(514, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'bt_min
        '
        Me.bt_min.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.bt_min.BackgroundImage = Global.tvpotzae.My.Resources.Resources.bt_min
        Me.bt_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_min.Location = New System.Drawing.Point(493, 3)
        Me.bt_min.Name = "bt_min"
        Me.bt_min.Size = New System.Drawing.Size(19, 19)
        Me.bt_min.TabIndex = 15
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.bt_close.BackgroundImage = Global.tvpotzae.My.Resources.Resources.bt_close
        Me.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_close.Location = New System.Drawing.Point(518, 3)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(19, 19)
        Me.bt_close.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(560, 443)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTB2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bt_min)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.PanelOne)
        Me.Controls.Add(Me.PanelTwo)
        Me.DisplayHeader = False
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = "tv팟제 Beta"
        Me.BTB2.ResumeLayout(False)
        Me.BTB2.PerformLayout()
        Me.BTB1.ResumeLayout(False)
        Me.BTB1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelOne.ResumeLayout(False)
        Me.PanelOne.PerformLayout()
        Me.PotNamePanel.ResumeLayout(False)
        Me.PotNamePanel.PerformLayout()
        Me.PanelTwo.ResumeLayout(False)
        Me.PanelTwo.PerformLayout()
        CType(Me.PotThumb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTB2 As System.Windows.Forms.Panel
    Friend WithEvents BT2 As System.Windows.Forms.Label
    Friend WithEvents BTB1 As System.Windows.Forms.Panel
    Friend WithEvents BT1 As System.Windows.Forms.Label
    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bt_min As System.Windows.Forms.Panel
    Friend WithEvents bt_close As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents List_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents List_num As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents PanelOne As System.Windows.Forms.Panel
    Friend WithEvents PanelTwo As System.Windows.Forms.Panel
    Friend WithEvents CopyState As System.Windows.Forms.Label
    Friend WithEvents MetroProgressSpinner2 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents EpiState As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Finder As System.ComponentModel.BackgroundWorker
    Friend WithEvents AddDelay As System.ComponentModel.BackgroundWorker
    Friend WithEvents SearchTypeComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PotNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PotThumbLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents PotThumb As System.Windows.Forms.PictureBox
    Friend WithEvents PotNamePanel As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
