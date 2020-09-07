'************************************************************************************
'   Name: Soumil Dharaskar
'
'   
'
'   Program Function: This program is a hangman game that allows the user play hangman
'                       at easy, medium, and hard difficulties. The user also has the option
'                       of guessing the correct word, after which they will be evaluated for their guess'
'                       credibility.
'************************************************************************************
Imports System.IO
Public Class frmHangman

    Private guessesEasy As Integer = 8
    Private guessesMedium As Integer = 10
    Private guessesHard As Integer = 12
    Private chosenWord As String
    Dim strHyphen As String
    Dim guessedWord As String

    Private Sub cboDifficulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDifficulty.SelectedIndexChanged

        If cboDifficulty.SelectedItem = "Easy" Then
            btnPlayGame.ForeColor = Color.White
            btnPlayGame.Enabled = True
            lblGuessesLeft.Text = guessesEasy
        ElseIf cboDifficulty.SelectedItem = "Medium" Then
            btnPlayGame.ForeColor = Color.White
            btnPlayGame.Enabled = True
            lblGuessesLeft.Text = guessesMedium
        ElseIf cboDifficulty.SelectedItem = "Hard" Then
            btnPlayGame.ForeColor = Color.White
            btnPlayGame.Enabled = True
            lblGuessesLeft.Text = guessesHard
        End If

    End Sub

    Private Sub btnPlayGame_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click

        Dim btnArray() As Button = {btnAlph1, btnAlph2, btnAlph3, btnAlph4, btnAlph5, btnAlph6, btnAlph7, btnAlph8, btnAlph9, btnAlph10, btnAlph11, btnAlph12, btnAlph13, btnAlph14, btnAlph15, btnAlph16, btnAlph17, btnAlph18, btnAlph19, btnAlph20, btnAlph21, btnAlph22, btnAlph23, btnAlph24, btnAlph25, btnAlph26}
        Dim wordsFile As StreamReader
        Dim num As String
        Dim rand As New Random
        Dim words() As String

        cboDifficulty.Enabled = False
        btnPlayGame.Enabled = False
        btnChangeLevel.Enabled = True
        btnChangeLevel.ForeColor = Color.White
        btnGuessWord.Enabled = True
        btnGuessWord.ForeColor = Color.White

        For i = 0 To btnArray.Length - 1
            btnArray(i).Enabled = True
            btnArray(i).ForeColor = Color.Lime
        Next

        If cboDifficulty.Text = "Easy" Then
            wordsFile = File.OpenText("Easy.txt")
            num = rand.Next(1, 19)

            Do Until wordsFile.Peek = -1
                words = Split(wordsFile.ReadLine, " ")

                If num = words(0) Then
                    chosenWord = words(1)
                End If

            Loop

            For i = 0 To chosenWord.Length - 1
                strHyphen &= "_ "
            Next

            lblWord.Text = strHyphen

        ElseIf cboDifficulty.Text = "Medium" Then

            wordsFile = File.OpenText("Medium.txt")
            num = rand.Next(1, 19)

            Do Until wordsFile.Peek = -1
                words = Split(wordsFile.ReadLine, " ")

                If num = words(0) Then
                    chosenWord = words(1)
                End If

            Loop

            For i = 0 To chosenWord.Length - 1
                strHyphen &= "_ "
            Next

            lblWord.Text = strHyphen

        ElseIf cboDifficulty.Text = "Hard" Then
            wordsFile = File.OpenText("Hard.txt")

            num = rand.Next(1, 19)

            Do Until wordsFile.Peek = -1
                    words = Split(wordsFile.ReadLine, " ")

                    If num = words(0) Then
                        chosenWord = words(1)
                    End If

                Loop

                For i = 0 To chosenWord.Length - 1
                    strHyphen &= "_ "
                Next

                lblWord.Text = strHyphen
            End If
    End Sub

    Private Sub frmHangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim btnArray() As Button = {btnAlph1, btnAlph2, btnAlph3, btnAlph4, btnAlph5, btnAlph6, btnAlph7, btnAlph8, btnAlph9, btnAlph10, btnAlph11, btnAlph12, btnAlph13, btnAlph14, btnAlph15, btnAlph16, btnAlph17, btnAlph18, btnAlph19, btnAlph20, btnAlph21, btnAlph22, btnAlph23, btnAlph24, btnAlph25, btnAlph26}

        For i = 0 To btnArray.Length - 1
            btnArray(i).Enabled = False
            btnArray(i).ForeColor = Color.Black
            btnArray(i).BackColor = Color.Black
        Next

        btnPlayGame.Enabled = False
        btnGuessWord.Enabled = False
        btnChangeLevel.Enabled = False

    End Sub

    Private Sub btnAlph1_Click(sender As Object, e As EventArgs) Handles btnAlph1.Click, btnAlph2.Click, btnAlph3.Click, btnAlph4.Click, btnAlph5.Click, btnAlph6.Click, btnAlph7.Click, btnAlph8.Click, btnAlph9.Click, btnAlph10.Click, btnAlph11.Click, btnAlph12.Click, btnAlph13.Click, btnAlph14.Click, btnAlph15.Click, btnAlph16.Click, btnAlph17.Click, btnAlph18.Click, btnAlph19.Click, btnAlph20.Click, btnAlph21.Click, btnAlph22.Click, btnAlph23.Click, btnAlph24.Click, btnAlph25.Click, btnAlph26.Click

        Dim btnArray() As Button = {btnAlph1, btnAlph2, btnAlph3, btnAlph4, btnAlph5, btnAlph6, btnAlph7, btnAlph8, btnAlph9, btnAlph10, btnAlph11, btnAlph12, btnAlph13, btnAlph14, btnAlph15, btnAlph16, btnAlph17, btnAlph18, btnAlph19, btnAlph20, btnAlph21, btnAlph22, btnAlph23, btnAlph24, btnAlph25, btnAlph26}
        Dim btnSender As Button = sender
        Dim strReplaceLetter() As String
        Dim strReplaceHyphen As String
        Static strLettersPicked As String = ""

        btnSender.Enabled = False
        'strReplaceHyphen = strHyphen

        For i = 0 To chosenWord.Length - 1

            If btnSender.Text = chosenWord.Chars(i) Then
                'grpLettersPicked.Text = btnSender.Text
                strReplaceLetter = Split(strHyphen)
                strReplaceLetter(i) = chosenWord.Chars(i)

                For j = 0 To strReplaceLetter.Length - 1
                    strReplaceHyphen &= strReplaceLetter(j) & " "
                Next

                strHyphen = strReplaceHyphen
                lblWord.Text = strReplaceHyphen

                If strReplaceHyphen.Replace(" ", "") = chosenWord Then
                    MessageBox.Show("YOU WIN! " & chosenWord & " IS CORRECT.", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Close()
                    Application.Restart()

                End If
                strReplaceHyphen = ""
            End If
        Next

        If cboDifficulty.Text = "Easy" Then
            guessesEasy -= 1
            lblGuessesLeft.Text = guessesEasy
            If guessesEasy = 0 Then
                guessedWord = InputBox("Please guess the word!", "GUESS WORD", "I DON'T KNOW")
                If guessedWord.ToUpper = chosenWord Then
                    MessageBox.Show("YOU WIN! " & chosenWord & " IS CORRECT.", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("YOU LOSE! " & chosenWord & " IS THE RIGHT ANSWER.", "YOU LOSE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Application.Restart()
            End If

        ElseIf cboDifficulty.Text = "Medium" Then

            guessesMedium -= 1
            lblGuessesLeft.Text = guessesMedium

            If guessesMedium = 0 Then
                guessedWord = InputBox("Please guess the word!", "GUESS WORD", "I DON'T KNOW")
                If guessedWord.ToUpper = chosenWord Then
                    MessageBox.Show("YOU WIN! " & chosenWord & " IS CORRECT.", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("YOU LOSE! " & chosenWord & " IS THE RIGHT ANSWER.", "YOU LOSE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Application.Restart()
            End If

        ElseIf cboDifficulty.Text = "Hard" Then

            guessesHard -= 1
            lblGuessesLeft.Text = guessesHard

            If guessesHard = 0 Then
                guessedWord = InputBox("Please guess the word!", "GUESS WORD", "I DON'T KNOW")

                If guessedWord.ToUpper = chosenWord Then
                    MessageBox.Show("YOU WIN! " & chosenWord & " IS CORRECT.", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("YOU LOSE! " & chosenWord & " IS THE RIGHT ANSWER.", "YOU LOSE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Application.Restart()

            End If
        End If

        strLettersPicked &= btnSender.Text
        lblLettersPicked.Text = strLettersPicked

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGuessWord_Click(sender As Object, e As EventArgs) Handles btnGuessWord.Click

        guessedWord = InputBox("Please guess the word!", "GUESS WORD", "I DON'T KNOW")

        If guessedWord.ToUpper = chosenWord Then
            MessageBox.Show("YOU WIN! " & chosenWord & " IS CORRECT.", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("YOU LOSE! " & chosenWord & " IS THE RIGHT ANSWER.", "YOU LOSE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Application.Restart()

    End Sub

    Private Sub btnChangeLevel_Click(sender As Object, e As EventArgs) Handles btnChangeLevel.Click

        Application.Restart()

    End Sub
End Class
