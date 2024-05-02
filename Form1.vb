Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim m_strOptions As String() = {"Australia", "Brazil", "China", "Italy", "Russia", "South Africa", "Spain", "United States"}
    Dim m_blnUsed As Boolean() = New Boolean(m_strOptions.GetUpperBound(0)) {}

    Dim m_intCount As Integer = 1  ' number of flags shown
    Dim m_strCountry As String     ' current flag's country

    ' handles Flag Quiz Form's Load event
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Array.Sort(m_strOptions)  ' alphabetize country names
        ' display country names in ComboBox
        OptionsComboBox.DataSource = m_strOptions
        DisplayFlag()  ' display first flag in PictureBox
    End Sub ' Form1_Load

    ' return full path name of images file as a String
    Function BuildPathName(country As String) As String
        ' begin with country name
        Dim strOutput As String = country
        ' remove spaces from country name
        strOutput = strOutput.Replace(" ", "")
        strOutput &= ".png" ' add file extension
        ' add path name
        strOutput = System.IO.Path.Combine(Application.StartupPath, "images\", strOutput)
        Return strOutput  ' return full path name
    End Function ' BuildPathName

    ' return an unused random number
    Function GetUniqueRandomNumber() As Integer
        Dim objRandom As Random = New Random
        Dim intRandom As Integer
        ' generate random numbers until unused flag is found
        Do
            intRandom = objRandom.Next(0, m_blnUsed.Length)
        Loop Until m_blnUsed(intRandom) = False
        ' indicate that flag has been used
        m_blnUsed(intRandom) = True
        Return intRandom  ' return index for new flag
    End Function ' GetUniqueRandomNumber

    ' display random flag in PictureBox
    Sub DisplayFlag()
        ' unique index ensures that a flag is used no more than once
        Dim intRandom As Integer = GetUniqueRandomNumber()
        ' retrieve country name from array m_strOptions
        m_strCountry = m_strOptions(intRandom)
        ' get images's full path name
        Dim strPath As String = BuildPathName(m_strCountry)
        Try
            If IO.File.Exists(strPath) Then
                flagPictureBox.Image = Image.FromFile(strPath)  ' display images
            Else
                MessageBox.Show("Image file not found: " & strPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' DisplayFlag

    ' handles Submit Button's Click event
    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        ' retrieve answer from ComboBox
        Dim strResponse As String = Convert.ToString(OptionsComboBox.SelectedValue)
        ' verify answer
        If strResponse = m_strCountry Then
            FeedbackLabel.Text = "Correct!"
        Else
            FeedbackLabel.Text = "Sorry, incorrect."
        End If
        ' inform user if quiz is over
        If m_intCount >= 5 Then  ' quiz is over
            FeedbackLabel.Text &= "   Done!"
            NextButton.Enabled = False
            SubmitButton.Enabled = False
            OptionsComboBox.Enabled = False
        Else  ' quiz is not over
            SubmitButton.Enabled = False
            NextButton.Enabled = True
        End If
    End Sub ' btnSubmit_Click

    ' handles Next Flag Button's Click event
    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        DisplayFlag()  ' display next flag
        FeedbackLabel.Text = ""  ' clear output
        ' change selected country to first in ComboBox
        OptionsComboBox.SelectedIndex = 0
        m_intCount += 1  ' update number of flags shown
        SubmitButton.Enabled = True
        NextButton.Enabled = False
    End Sub ' btnNext_Click

    Private Sub OptionsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OptionsComboBox.SelectedIndexChanged

    End Sub
End Class ' Form1
