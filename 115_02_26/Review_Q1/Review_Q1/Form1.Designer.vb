<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        computerLabel = New Label()
        playerLabel = New Label()
        computerPictureBox = New PictureBox()
        playerPictureBox = New PictureBox()
        resultLabel = New Label()
        stoneButton = New Button()
        paperButton = New Button()
        scissorButton = New Button()
        exitButton = New Button()
        CType(computerPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(playerPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' computerLabel
        ' 
        computerLabel.AutoSize = True
        computerLabel.Font = New Font("微軟正黑體", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        computerLabel.Location = New Point(275, 35)
        computerLabel.Margin = New Padding(6, 0, 6, 0)
        computerLabel.Name = "computerLabel"
        computerLabel.Size = New Size(99, 35)
        computerLabel.TabIndex = 0
        computerLabel.Text = "電腦出"
        ' 
        ' playerLabel
        ' 
        playerLabel.AutoSize = True
        playerLabel.Font = New Font("微軟正黑體", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        playerLabel.Location = New Point(733, 35)
        playerLabel.Margin = New Padding(6, 0, 6, 0)
        playerLabel.Name = "playerLabel"
        playerLabel.Size = New Size(99, 35)
        playerLabel.TabIndex = 0
        playerLabel.Text = "玩家出"
        ' 
        ' computerPictureBox
        ' 
        computerPictureBox.BorderStyle = BorderStyle.FixedSingle
        computerPictureBox.Image = CType(resources.GetObject("computerPictureBox.Image"), Image)
        computerPictureBox.Location = New Point(159, 88)
        computerPictureBox.Margin = New Padding(6, 5, 6, 5)
        computerPictureBox.Name = "computerPictureBox"
        computerPictureBox.Size = New Size(365, 211)
        computerPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        computerPictureBox.TabIndex = 1
        computerPictureBox.TabStop = False
        ' 
        ' playerPictureBox
        ' 
        playerPictureBox.BorderStyle = BorderStyle.FixedSingle
        playerPictureBox.Location = New Point(660, 88)
        playerPictureBox.Margin = New Padding(6, 5, 6, 5)
        playerPictureBox.Name = "playerPictureBox"
        playerPictureBox.Size = New Size(365, 211)
        playerPictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        playerPictureBox.TabIndex = 1
        playerPictureBox.TabStop = False
        ' 
        ' resultLabel
        ' 
        resultLabel.BorderStyle = BorderStyle.FixedSingle
        resultLabel.Font = New Font("微軟正黑體", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        resultLabel.Location = New Point(220, 336)
        resultLabel.Margin = New Padding(6, 0, 6, 0)
        resultLabel.Name = "resultLabel"
        resultLabel.Size = New Size(732, 69)
        resultLabel.TabIndex = 2
        resultLabel.Text = "玩家贏"
        resultLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' stoneButton
        ' 
        stoneButton.Font = New Font("微軟正黑體", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        stoneButton.Location = New Point(110, 442)
        stoneButton.Margin = New Padding(6, 5, 6, 5)
        stoneButton.Name = "stoneButton"
        stoneButton.Size = New Size(183, 71)
        stoneButton.TabIndex = 3
        stoneButton.Text = "石頭"
        stoneButton.UseVisualStyleBackColor = True
        ' 
        ' paperButton
        ' 
        paperButton.Font = New Font("微軟正黑體", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        paperButton.Location = New Point(458, 442)
        paperButton.Margin = New Padding(6, 5, 6, 5)
        paperButton.Name = "paperButton"
        paperButton.Size = New Size(183, 71)
        paperButton.TabIndex = 3
        paperButton.Text = "布"
        paperButton.UseVisualStyleBackColor = True
        ' 
        ' scissorButton
        ' 
        scissorButton.Font = New Font("微軟正黑體", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        scissorButton.Location = New Point(807, 442)
        scissorButton.Margin = New Padding(6, 5, 6, 5)
        scissorButton.Name = "scissorButton"
        scissorButton.Size = New Size(183, 71)
        scissorButton.TabIndex = 3
        scissorButton.Text = "剪刀"
        scissorButton.UseVisualStyleBackColor = True
        ' 
        ' exitButton
        ' 
        exitButton.Font = New Font("微軟正黑體", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        exitButton.Location = New Point(403, 566)
        exitButton.Margin = New Padding(6, 5, 6, 5)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(293, 71)
        exitButton.TabIndex = 3
        exitButton.Text = "結束遊戲"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1100, 708)
        Controls.Add(computerLabel)
        Controls.Add(playerLabel)
        Controls.Add(computerPictureBox)
        Controls.Add(playerPictureBox)
        Controls.Add(resultLabel)
        Controls.Add(stoneButton)
        Controls.Add(paperButton)
        Controls.Add(scissorButton)
        Controls.Add(exitButton)
        Margin = New Padding(6, 5, 6, 5)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "剪刀、布、石頭遊戲"
        CType(computerPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(playerPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents computerLabel As Label
    Friend WithEvents playerLabel As Label
    Friend WithEvents computerPictureBox As PictureBox
    Friend WithEvents playerPictureBox As PictureBox
    Friend WithEvents resultLabel As Label
    Friend WithEvents stoneButton As Button
    Friend WithEvents paperButton As Button
    Friend WithEvents scissorButton As Button
    Friend WithEvents exitButton As Button

End Class
