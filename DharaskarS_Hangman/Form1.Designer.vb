<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangman
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
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblChooseADifficulty = New System.Windows.Forms.Label()
        Me.cboDifficulty = New System.Windows.Forms.ComboBox()
        Me.btnAlph1 = New System.Windows.Forms.Button()
        Me.btnAlph2 = New System.Windows.Forms.Button()
        Me.btnAlph3 = New System.Windows.Forms.Button()
        Me.btnAlph4 = New System.Windows.Forms.Button()
        Me.btnAlph5 = New System.Windows.Forms.Button()
        Me.btnAlph6 = New System.Windows.Forms.Button()
        Me.btnAlph7 = New System.Windows.Forms.Button()
        Me.btnAlph8 = New System.Windows.Forms.Button()
        Me.btnAlph9 = New System.Windows.Forms.Button()
        Me.btnAlph10 = New System.Windows.Forms.Button()
        Me.btnAlph11 = New System.Windows.Forms.Button()
        Me.btnAlph12 = New System.Windows.Forms.Button()
        Me.btnAlph13 = New System.Windows.Forms.Button()
        Me.btnAlph14 = New System.Windows.Forms.Button()
        Me.btnAlph15 = New System.Windows.Forms.Button()
        Me.btnAlph16 = New System.Windows.Forms.Button()
        Me.btnAlph17 = New System.Windows.Forms.Button()
        Me.btnAlph18 = New System.Windows.Forms.Button()
        Me.btnAlph19 = New System.Windows.Forms.Button()
        Me.btnAlph20 = New System.Windows.Forms.Button()
        Me.btnAlph21 = New System.Windows.Forms.Button()
        Me.btnAlph22 = New System.Windows.Forms.Button()
        Me.btnAlph23 = New System.Windows.Forms.Button()
        Me.btnAlph24 = New System.Windows.Forms.Button()
        Me.btnAlph25 = New System.Windows.Forms.Button()
        Me.btnAlph26 = New System.Windows.Forms.Button()
        Me.grpLettersPicked = New System.Windows.Forms.GroupBox()
        Me.grpGuessesLeft = New System.Windows.Forms.GroupBox()
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.btnChangeLevel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGuessWord = New System.Windows.Forms.Button()
        Me.lblLettersPicked = New System.Windows.Forms.Label()
        Me.lblGuessesLeft = New System.Windows.Forms.Label()
        Me.grpLettersPicked.SuspendLayout()
        Me.grpGuessesLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWord.Font = New System.Drawing.Font("Microsoft YaHei UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(21, 20)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(767, 68)
        Me.lblWord.TabIndex = 0
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChooseADifficulty
        '
        Me.lblChooseADifficulty.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseADifficulty.Location = New System.Drawing.Point(138, 109)
        Me.lblChooseADifficulty.Name = "lblChooseADifficulty"
        Me.lblChooseADifficulty.Size = New System.Drawing.Size(337, 34)
        Me.lblChooseADifficulty.TabIndex = 1
        Me.lblChooseADifficulty.Text = " Choose a Difficulty Level:"
        Me.lblChooseADifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboDifficulty
        '
        Me.cboDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDifficulty.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDifficulty.FormattingEnabled = True
        Me.cboDifficulty.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.cboDifficulty.Location = New System.Drawing.Point(481, 109)
        Me.cboDifficulty.Name = "cboDifficulty"
        Me.cboDifficulty.Size = New System.Drawing.Size(174, 34)
        Me.cboDifficulty.TabIndex = 2
        '
        'btnAlph1
        '
        Me.btnAlph1.BackColor = System.Drawing.Color.Lime
        Me.btnAlph1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph1.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph1.Location = New System.Drawing.Point(71, 159)
        Me.btnAlph1.Name = "btnAlph1"
        Me.btnAlph1.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph1.TabIndex = 3
        Me.btnAlph1.Text = "A"
        Me.btnAlph1.UseVisualStyleBackColor = False
        '
        'btnAlph2
        '
        Me.btnAlph2.BackColor = System.Drawing.Color.Lime
        Me.btnAlph2.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph2.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph2.Location = New System.Drawing.Point(137, 159)
        Me.btnAlph2.Name = "btnAlph2"
        Me.btnAlph2.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph2.TabIndex = 4
        Me.btnAlph2.Text = "B"
        Me.btnAlph2.UseVisualStyleBackColor = False
        '
        'btnAlph3
        '
        Me.btnAlph3.BackColor = System.Drawing.Color.Lime
        Me.btnAlph3.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph3.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph3.Location = New System.Drawing.Point(203, 159)
        Me.btnAlph3.Name = "btnAlph3"
        Me.btnAlph3.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph3.TabIndex = 5
        Me.btnAlph3.Text = "C"
        Me.btnAlph3.UseVisualStyleBackColor = False
        '
        'btnAlph4
        '
        Me.btnAlph4.BackColor = System.Drawing.Color.Lime
        Me.btnAlph4.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph4.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph4.Location = New System.Drawing.Point(269, 159)
        Me.btnAlph4.Name = "btnAlph4"
        Me.btnAlph4.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph4.TabIndex = 6
        Me.btnAlph4.Text = "D"
        Me.btnAlph4.UseVisualStyleBackColor = False
        '
        'btnAlph5
        '
        Me.btnAlph5.BackColor = System.Drawing.Color.Lime
        Me.btnAlph5.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph5.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph5.Location = New System.Drawing.Point(335, 159)
        Me.btnAlph5.Name = "btnAlph5"
        Me.btnAlph5.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph5.TabIndex = 7
        Me.btnAlph5.Text = "E"
        Me.btnAlph5.UseVisualStyleBackColor = False
        '
        'btnAlph6
        '
        Me.btnAlph6.BackColor = System.Drawing.Color.Lime
        Me.btnAlph6.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph6.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph6.Location = New System.Drawing.Point(401, 159)
        Me.btnAlph6.Name = "btnAlph6"
        Me.btnAlph6.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph6.TabIndex = 8
        Me.btnAlph6.Text = "F"
        Me.btnAlph6.UseVisualStyleBackColor = False
        '
        'btnAlph7
        '
        Me.btnAlph7.BackColor = System.Drawing.Color.Lime
        Me.btnAlph7.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph7.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph7.Location = New System.Drawing.Point(467, 159)
        Me.btnAlph7.Name = "btnAlph7"
        Me.btnAlph7.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph7.TabIndex = 9
        Me.btnAlph7.Text = "G"
        Me.btnAlph7.UseVisualStyleBackColor = False
        '
        'btnAlph8
        '
        Me.btnAlph8.BackColor = System.Drawing.Color.Lime
        Me.btnAlph8.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph8.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph8.Location = New System.Drawing.Point(533, 159)
        Me.btnAlph8.Name = "btnAlph8"
        Me.btnAlph8.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph8.TabIndex = 10
        Me.btnAlph8.Text = "H"
        Me.btnAlph8.UseVisualStyleBackColor = False
        '
        'btnAlph9
        '
        Me.btnAlph9.BackColor = System.Drawing.Color.Lime
        Me.btnAlph9.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph9.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph9.Location = New System.Drawing.Point(599, 159)
        Me.btnAlph9.Name = "btnAlph9"
        Me.btnAlph9.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph9.TabIndex = 11
        Me.btnAlph9.Text = "I"
        Me.btnAlph9.UseVisualStyleBackColor = False
        '
        'btnAlph10
        '
        Me.btnAlph10.BackColor = System.Drawing.Color.Lime
        Me.btnAlph10.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph10.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph10.Location = New System.Drawing.Point(665, 159)
        Me.btnAlph10.Name = "btnAlph10"
        Me.btnAlph10.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph10.TabIndex = 12
        Me.btnAlph10.Text = "J"
        Me.btnAlph10.UseVisualStyleBackColor = False
        '
        'btnAlph11
        '
        Me.btnAlph11.BackColor = System.Drawing.Color.Lime
        Me.btnAlph11.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph11.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph11.Location = New System.Drawing.Point(112, 219)
        Me.btnAlph11.Name = "btnAlph11"
        Me.btnAlph11.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph11.TabIndex = 13
        Me.btnAlph11.Text = "K"
        Me.btnAlph11.UseVisualStyleBackColor = False
        '
        'btnAlph12
        '
        Me.btnAlph12.BackColor = System.Drawing.Color.Lime
        Me.btnAlph12.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph12.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph12.Location = New System.Drawing.Point(178, 219)
        Me.btnAlph12.Name = "btnAlph12"
        Me.btnAlph12.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph12.TabIndex = 14
        Me.btnAlph12.Text = "L"
        Me.btnAlph12.UseVisualStyleBackColor = False
        '
        'btnAlph13
        '
        Me.btnAlph13.BackColor = System.Drawing.Color.Lime
        Me.btnAlph13.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph13.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph13.Location = New System.Drawing.Point(244, 219)
        Me.btnAlph13.Name = "btnAlph13"
        Me.btnAlph13.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph13.TabIndex = 15
        Me.btnAlph13.Text = "M"
        Me.btnAlph13.UseVisualStyleBackColor = False
        '
        'btnAlph14
        '
        Me.btnAlph14.BackColor = System.Drawing.Color.Lime
        Me.btnAlph14.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph14.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph14.Location = New System.Drawing.Point(310, 219)
        Me.btnAlph14.Name = "btnAlph14"
        Me.btnAlph14.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph14.TabIndex = 16
        Me.btnAlph14.Text = "N"
        Me.btnAlph14.UseVisualStyleBackColor = False
        '
        'btnAlph15
        '
        Me.btnAlph15.BackColor = System.Drawing.Color.Lime
        Me.btnAlph15.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph15.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph15.Location = New System.Drawing.Point(376, 219)
        Me.btnAlph15.Name = "btnAlph15"
        Me.btnAlph15.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph15.TabIndex = 17
        Me.btnAlph15.Text = "O"
        Me.btnAlph15.UseVisualStyleBackColor = False
        '
        'btnAlph16
        '
        Me.btnAlph16.BackColor = System.Drawing.Color.Lime
        Me.btnAlph16.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph16.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph16.Location = New System.Drawing.Point(442, 219)
        Me.btnAlph16.Name = "btnAlph16"
        Me.btnAlph16.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph16.TabIndex = 18
        Me.btnAlph16.Text = "P"
        Me.btnAlph16.UseVisualStyleBackColor = False
        '
        'btnAlph17
        '
        Me.btnAlph17.BackColor = System.Drawing.Color.Lime
        Me.btnAlph17.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph17.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph17.Location = New System.Drawing.Point(508, 219)
        Me.btnAlph17.Name = "btnAlph17"
        Me.btnAlph17.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph17.TabIndex = 19
        Me.btnAlph17.Text = "Q"
        Me.btnAlph17.UseVisualStyleBackColor = False
        '
        'btnAlph18
        '
        Me.btnAlph18.BackColor = System.Drawing.Color.Lime
        Me.btnAlph18.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph18.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph18.Location = New System.Drawing.Point(574, 219)
        Me.btnAlph18.Name = "btnAlph18"
        Me.btnAlph18.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph18.TabIndex = 20
        Me.btnAlph18.Text = "R"
        Me.btnAlph18.UseVisualStyleBackColor = False
        '
        'btnAlph19
        '
        Me.btnAlph19.BackColor = System.Drawing.Color.Lime
        Me.btnAlph19.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph19.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph19.Location = New System.Drawing.Point(640, 219)
        Me.btnAlph19.Name = "btnAlph19"
        Me.btnAlph19.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph19.TabIndex = 21
        Me.btnAlph19.Text = "S"
        Me.btnAlph19.UseVisualStyleBackColor = False
        '
        'btnAlph20
        '
        Me.btnAlph20.BackColor = System.Drawing.Color.Lime
        Me.btnAlph20.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph20.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph20.Location = New System.Drawing.Point(178, 279)
        Me.btnAlph20.Name = "btnAlph20"
        Me.btnAlph20.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph20.TabIndex = 22
        Me.btnAlph20.Text = "T"
        Me.btnAlph20.UseVisualStyleBackColor = False
        '
        'btnAlph21
        '
        Me.btnAlph21.BackColor = System.Drawing.Color.Lime
        Me.btnAlph21.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph21.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph21.Location = New System.Drawing.Point(244, 279)
        Me.btnAlph21.Name = "btnAlph21"
        Me.btnAlph21.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph21.TabIndex = 23
        Me.btnAlph21.Text = "U"
        Me.btnAlph21.UseVisualStyleBackColor = False
        '
        'btnAlph22
        '
        Me.btnAlph22.BackColor = System.Drawing.Color.Lime
        Me.btnAlph22.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph22.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph22.Location = New System.Drawing.Point(310, 279)
        Me.btnAlph22.Name = "btnAlph22"
        Me.btnAlph22.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph22.TabIndex = 24
        Me.btnAlph22.Text = "V"
        Me.btnAlph22.UseVisualStyleBackColor = False
        '
        'btnAlph23
        '
        Me.btnAlph23.BackColor = System.Drawing.Color.Lime
        Me.btnAlph23.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph23.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph23.Location = New System.Drawing.Point(376, 279)
        Me.btnAlph23.Name = "btnAlph23"
        Me.btnAlph23.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph23.TabIndex = 25
        Me.btnAlph23.Text = "W"
        Me.btnAlph23.UseVisualStyleBackColor = False
        '
        'btnAlph24
        '
        Me.btnAlph24.BackColor = System.Drawing.Color.Lime
        Me.btnAlph24.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph24.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph24.Location = New System.Drawing.Point(442, 279)
        Me.btnAlph24.Name = "btnAlph24"
        Me.btnAlph24.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph24.TabIndex = 26
        Me.btnAlph24.Text = "X"
        Me.btnAlph24.UseVisualStyleBackColor = False
        '
        'btnAlph25
        '
        Me.btnAlph25.BackColor = System.Drawing.Color.Lime
        Me.btnAlph25.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph25.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph25.Location = New System.Drawing.Point(508, 279)
        Me.btnAlph25.Name = "btnAlph25"
        Me.btnAlph25.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph25.TabIndex = 27
        Me.btnAlph25.Text = "Y"
        Me.btnAlph25.UseVisualStyleBackColor = False
        '
        'btnAlph26
        '
        Me.btnAlph26.BackColor = System.Drawing.Color.Lime
        Me.btnAlph26.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlph26.ForeColor = System.Drawing.Color.Lime
        Me.btnAlph26.Location = New System.Drawing.Point(574, 279)
        Me.btnAlph26.Name = "btnAlph26"
        Me.btnAlph26.Size = New System.Drawing.Size(56, 53)
        Me.btnAlph26.TabIndex = 28
        Me.btnAlph26.Text = "Z"
        Me.btnAlph26.UseVisualStyleBackColor = False
        '
        'grpLettersPicked
        '
        Me.grpLettersPicked.Controls.Add(Me.lblLettersPicked)
        Me.grpLettersPicked.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLettersPicked.Location = New System.Drawing.Point(39, 347)
        Me.grpLettersPicked.Name = "grpLettersPicked"
        Me.grpLettersPicked.Size = New System.Drawing.Size(279, 100)
        Me.grpLettersPicked.TabIndex = 29
        Me.grpLettersPicked.TabStop = False
        Me.grpLettersPicked.Text = "Letters Picked"
        '
        'grpGuessesLeft
        '
        Me.grpGuessesLeft.Controls.Add(Me.lblGuessesLeft)
        Me.grpGuessesLeft.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGuessesLeft.Location = New System.Drawing.Point(335, 347)
        Me.grpGuessesLeft.Name = "grpGuessesLeft"
        Me.grpGuessesLeft.Size = New System.Drawing.Size(188, 100)
        Me.grpGuessesLeft.TabIndex = 30
        Me.grpGuessesLeft.TabStop = False
        Me.grpGuessesLeft.Text = "Guesses Left"
        '
        'btnPlayGame
        '
        Me.btnPlayGame.BackColor = System.Drawing.Color.Black
        Me.btnPlayGame.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayGame.ForeColor = System.Drawing.Color.Black
        Me.btnPlayGame.Location = New System.Drawing.Point(21, 465)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(257, 117)
        Me.btnPlayGame.TabIndex = 31
        Me.btnPlayGame.Text = "PLAY GAME"
        Me.btnPlayGame.UseVisualStyleBackColor = False
        '
        'btnChangeLevel
        '
        Me.btnChangeLevel.BackColor = System.Drawing.Color.Black
        Me.btnChangeLevel.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeLevel.Location = New System.Drawing.Point(310, 465)
        Me.btnChangeLevel.Name = "btnChangeLevel"
        Me.btnChangeLevel.Size = New System.Drawing.Size(224, 117)
        Me.btnChangeLevel.TabIndex = 32
        Me.btnChangeLevel.Text = "CHANGE LEVEL"
        Me.btnChangeLevel.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(558, 465)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(230, 117)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnGuessWord
        '
        Me.btnGuessWord.BackColor = System.Drawing.Color.Black
        Me.btnGuessWord.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessWord.Location = New System.Drawing.Point(547, 347)
        Me.btnGuessWord.Name = "btnGuessWord"
        Me.btnGuessWord.Size = New System.Drawing.Size(241, 100)
        Me.btnGuessWord.TabIndex = 34
        Me.btnGuessWord.Text = "GUESS WORD"
        Me.btnGuessWord.UseVisualStyleBackColor = False
        '
        'lblLettersPicked
        '
        Me.lblLettersPicked.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLettersPicked.Location = New System.Drawing.Point(6, 34)
        Me.lblLettersPicked.Name = "lblLettersPicked"
        Me.lblLettersPicked.Size = New System.Drawing.Size(267, 63)
        Me.lblLettersPicked.TabIndex = 0
        '
        'lblGuessesLeft
        '
        Me.lblGuessesLeft.Location = New System.Drawing.Point(6, 34)
        Me.lblGuessesLeft.Name = "lblGuessesLeft"
        Me.lblGuessesLeft.Size = New System.Drawing.Size(176, 63)
        Me.lblGuessesLeft.TabIndex = 0
        Me.lblGuessesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 594)
        Me.Controls.Add(Me.btnGuessWord)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnChangeLevel)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Controls.Add(Me.grpGuessesLeft)
        Me.Controls.Add(Me.grpLettersPicked)
        Me.Controls.Add(Me.btnAlph26)
        Me.Controls.Add(Me.btnAlph25)
        Me.Controls.Add(Me.btnAlph24)
        Me.Controls.Add(Me.btnAlph23)
        Me.Controls.Add(Me.btnAlph22)
        Me.Controls.Add(Me.btnAlph21)
        Me.Controls.Add(Me.btnAlph20)
        Me.Controls.Add(Me.btnAlph19)
        Me.Controls.Add(Me.btnAlph18)
        Me.Controls.Add(Me.btnAlph17)
        Me.Controls.Add(Me.btnAlph16)
        Me.Controls.Add(Me.btnAlph15)
        Me.Controls.Add(Me.btnAlph14)
        Me.Controls.Add(Me.btnAlph13)
        Me.Controls.Add(Me.btnAlph12)
        Me.Controls.Add(Me.btnAlph11)
        Me.Controls.Add(Me.btnAlph10)
        Me.Controls.Add(Me.btnAlph9)
        Me.Controls.Add(Me.btnAlph8)
        Me.Controls.Add(Me.btnAlph7)
        Me.Controls.Add(Me.btnAlph6)
        Me.Controls.Add(Me.btnAlph5)
        Me.Controls.Add(Me.btnAlph4)
        Me.Controls.Add(Me.btnAlph3)
        Me.Controls.Add(Me.btnAlph2)
        Me.Controls.Add(Me.btnAlph1)
        Me.Controls.Add(Me.cboDifficulty)
        Me.Controls.Add(Me.lblChooseADifficulty)
        Me.Controls.Add(Me.lblWord)
        Me.Name = "frmHangman"
        Me.Text = "Hangman"
        Me.grpLettersPicked.ResumeLayout(False)
        Me.grpGuessesLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWord As Label
    Friend WithEvents lblChooseADifficulty As Label
    Friend WithEvents cboDifficulty As ComboBox
    Friend WithEvents btnAlph1 As Button
    Friend WithEvents btnAlph2 As Button
    Friend WithEvents btnAlph3 As Button
    Friend WithEvents btnAlph4 As Button
    Friend WithEvents btnAlph5 As Button
    Friend WithEvents btnAlph6 As Button
    Friend WithEvents btnAlph7 As Button
    Friend WithEvents btnAlph8 As Button
    Friend WithEvents btnAlph9 As Button
    Friend WithEvents btnAlph10 As Button
    Friend WithEvents btnAlph11 As Button
    Friend WithEvents btnAlph12 As Button
    Friend WithEvents btnAlph13 As Button
    Friend WithEvents btnAlph14 As Button
    Friend WithEvents btnAlph15 As Button
    Friend WithEvents btnAlph16 As Button
    Friend WithEvents btnAlph17 As Button
    Friend WithEvents btnAlph18 As Button
    Friend WithEvents btnAlph19 As Button
    Friend WithEvents btnAlph20 As Button
    Friend WithEvents btnAlph21 As Button
    Friend WithEvents btnAlph22 As Button
    Friend WithEvents btnAlph23 As Button
    Friend WithEvents btnAlph24 As Button
    Friend WithEvents btnAlph25 As Button
    Friend WithEvents btnAlph26 As Button
    Friend WithEvents grpLettersPicked As GroupBox
    Friend WithEvents grpGuessesLeft As GroupBox
    Friend WithEvents btnPlayGame As Button
    Friend WithEvents btnChangeLevel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnGuessWord As Button
    Friend WithEvents lblLettersPicked As Label
    Friend WithEvents lblGuessesLeft As Label
End Class
