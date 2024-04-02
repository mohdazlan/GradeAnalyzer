Public Class frmGradeAnalyzer
    Private Students As New List(Of String())
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim name As String = txtStudentName.Text
        Dim studentID As String = txtStudentID.Text
        Dim mathGrade As String = 

    End Sub

    Sub updateGridview()

    End Sub

    Private Sub frmGradeAnalyzer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvGrade.Columns.Add("StudentName", "Student Name")
        dgvGrade.Columns.Add("StudentID", "Student ID")
        dgvGrade.Columns.Add("MathGrade", "Math Grade")
        dgvGrade.Columns.Add("ScienceGrade", "Science Grade")
    End Sub
End Class