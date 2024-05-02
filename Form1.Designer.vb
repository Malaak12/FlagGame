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
        GroupBox1 = New GroupBox()
        flagPictureBox = New PictureBox()
        Label1 = New Label()
        OptionsComboBox = New ComboBox()
        SubmitButton = New Button()
        NextButton = New Button()
        Label2 = New Label()
        Label3 = New Label()
        FeedbackLabel = New Label()
        GroupBox1.SuspendLayout()
        CType(flagPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(flagPictureBox)
        GroupBox1.Location = New Point(29, 32)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(268, 200)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Flag"
        ' 
        ' flagPictureBox
        ' 
        flagPictureBox.Location = New Point(36, 49)
        flagPictureBox.Name = "flagPictureBox"
        flagPictureBox.Size = New Size(200, 122)
        flagPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        flagPictureBox.TabIndex = 1
        flagPictureBox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(357, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 32)
        Label1.TabIndex = 1
        Label1.Text = "Select Country:"
        ' 
        ' OptionsComboBox
        ' 
        OptionsComboBox.FormattingEnabled = True
        OptionsComboBox.Items.AddRange(New Object() {"australia", "brazil", "china", "italy", "russia", "southafria", "spain", "unitedstates"})
        OptionsComboBox.Location = New Point(357, 81)
        OptionsComboBox.Name = "OptionsComboBox"
        OptionsComboBox.Size = New Size(242, 40)
        OptionsComboBox.TabIndex = 2
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(689, 47)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(150, 60)
        SubmitButton.TabIndex = 3
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' NextButton
        ' 
        NextButton.Location = New Point(689, 146)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(150, 63)
        NextButton.TabIndex = 4
        NextButton.Text = "Next Flag"
        NextButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(357, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 32)
        Label2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(357, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 100)
        Label3.TabIndex = 6
        ' 
        ' FeedbackLabel
        ' 
        FeedbackLabel.AutoSize = True
        FeedbackLabel.Location = New Point(363, 146)
        FeedbackLabel.Name = "FeedbackLabel"
        FeedbackLabel.Size = New Size(14, 32)
        FeedbackLabel.TabIndex = 7
        FeedbackLabel.Text = vbCrLf
        FeedbackLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(876, 286)
        Controls.Add(FeedbackLabel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(NextButton)
        Controls.Add(SubmitButton)
        Controls.Add(OptionsComboBox)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Flag Game"
        GroupBox1.ResumeLayout(False)
        CType(flagPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OptionsComboBox As ComboBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FeedbackLabel As Label
    Friend WithEvents flagPictureBox As PictureBox

End Class
