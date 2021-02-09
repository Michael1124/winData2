Public Class frmData2

    Public rid As Integer
    Public eName As String



   
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click


        Dim ta As New DataSet1TableAdapters.設備保養日期TableAdapter

        ta.Insert(rid, Me.dtMainDate.Value.ToShortDateString, txtReason.Text)

        Form1.SetDgMainTain(rid)


    End Sub

    Private Sub frmData2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtEName.Text = eName


    End Sub
End Class