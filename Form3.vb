Public Class Form3
    Dim tab1 As New DataTable("tab1")
    Dim index As Integer

    Private Sub btnCom1_Click(sender As Object, e As EventArgs) Handles btnCom1.Click
        Dim classpart As Double
        Dim quiz As Double
        Dim mjrexam As Double
        Dim trmgrade As Double

        classpart = TextCP1.Text
        quiz = TextQuiz1.Text
        mjrexam = TextME1.Text

        'classpart 20
        'quiz 30
        'exam 50

        trmgrade = (classpart * 0.2) + (quiz * 0.3) + (mjrexam * 0.5)
        TextTG1.Text = trmgrade
    End Sub

    Private Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        Dim msg As String
        msg = MessageBox.Show("Do you want to save this grade?", "Encounter GRADING SYSTEM", MessageBoxButtons.YesNo)
        If msg = DialogResult.Yes Then
            If ComboTerm1.Text = "Midterm" Then
                TextMid1.Text = TextTG1.Text
            ElseIf ComboTerm1.Text = "Finals" Then
                TextF1.Text = TextTG1.Text
            Else
                MsgBox("Please select term!", MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnC1_Click(sender As Object, e As EventArgs) Handles btnC1.Click
        TextCP1.Clear()
        TextQuiz1.Clear()
        TextME1.Clear()
        TextTG1.Clear()
    End Sub

    Private Sub btnAve1_Click(sender As Object, e As EventArgs) Handles btnAve1.Click
        Dim mtgrade As New Double
        Dim finalgrade As New Double
        Dim finalave As New Double
        mtgrade = TextMid1.Text
        finalgrade = TextF1.Text

        finalave = (mtgrade * 0.5) + (finalgrade * 0.5)
        TextFA1.Text = finalave
        If TextFA1.Text >= 96 And TextFA1.Text <= 100 Then
            TextLG1.Text = "A+"
        ElseIf TextFA1.Text >= 91 And TextFA1.Text <= 95 Then
            TextLG1.Text = "A"
        ElseIf TextFA1.Text >= 86 And TextFA1.Text <= 90 Then
            TextLG1.Text = "A-"
        ElseIf TextFA1.Text >= 81 And TextFA1.Text <= 85 Then
            TextLG1.Text = "B+"
        ElseIf TextFA1.Text >= 76 And TextFA1.Text <= 80 Then
            TextLG1.Text = "B"
        ElseIf TextFA1.Text >= 71 And TextFA1.Text <= 75 Then
            TextLG1.Text = "B-"
        ElseIf TextFA1.Text >= 66 And TextFA1.Text <= 70 Then
            TextLG1.Text = "C"
        ElseIf TextFA1.Text <= 70 Then
            TextLG1.Text = "Failed"
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tab1.Columns.Add("Student Numbers", Type.GetType("System.Int32"))
        tab1.Columns.Add("Last Name", Type.GetType("System.String"))
        tab1.Columns.Add("First Name", Type.GetType("System.String"))
        tab1.Columns.Add("Middle Name", Type.GetType("System.String"))
        tab1.Columns.Add("Subject", Type.GetType("System.String"))
        tab1.Columns.Add("Grade", Type.GetType("System.Double"))
        tab1.Columns.Add("Equivalent", Type.GetType("System.String"))
        DGVStu1.DataSource = tab1
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        tab1.Rows.Add(TextSN1.Text, TextLN1.Text, TextFN1.Text, TextMN1.Text, TextSub1.Text, TextFA1.Text, TextLG1.Text)
        DGVStu1.DataSource = tab1
    End Sub


    Private Sub DGVStu1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVStu1.CellClick
        index = e.RowIndex
        Dim selected As DataGridViewRow
        selected = DGVStu1.Rows(index)

        TextSN1.Text = selected.Cells(0).Value.ToString
        TextLN1.Text = selected.Cells(1).Value.ToString
        TextFN1.Text = selected.Cells(2).Value.ToString
        TextMN1.Text = selected.Cells(3).Value.ToString
        TextSub1.Text = selected.Cells(4).Value.ToString
        TextFA1.Text = selected.Cells(5).Value.ToString
        TextLG1.Text = selected.Cells(6).Value.ToString


    End Sub

    Private Sub btnClr2_Click(sender As Object, e As EventArgs) Handles btnClr2.Click
        TextSN1.Clear()
        TextLN1.Clear()
        TextFN1.Clear()
        TextMN1.Clear()
        TextSub1.Clear()
        TextCP1.Clear()
        TextQuiz1.Clear()
        TextME1.Clear()
        TextTG1.Clear()
        TextMid1.Clear()
        TextF1.Clear()
        TextLG1.Clear()
        TextFA1.Clear()
    End Sub

    Private Sub btnUp1_Click(sender As Object, e As EventArgs) Handles btnUp1.Click
        Dim newdata As DataGridViewRow
        newdata = DGVStu1.Rows(index)

        newdata.Cells(0).Value = TextSN1.Text
        newdata.Cells(1).Value = TextLN1.Text
        newdata.Cells(2).Value = TextFN1.Text
        newdata.Cells(3).Value = TextMN1.Text
        newdata.Cells(4).Value = TextSub1.Text
        newdata.Cells(5).Value = TextFA1.Text
        newdata.Cells(6).Value = TextLG1.Text
    End Sub

    Private Sub btnDel1_Click(sender As Object, e As EventArgs) Handles btnDel1.Click
        DGVStu1.Rows.RemoveAt(index)
    End Sub
End Class