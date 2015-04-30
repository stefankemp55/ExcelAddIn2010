Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles btnComparedesign.Click
        Dim ds As New Excel_Model_AuditorDataSet
        Try
            MsgBox("Table Count: " & ds.Inputs.Rows(1).Item(1).ToString())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAddModel_Click(sender As Object, e As RibbonControlEventArgs) Handles btnAddModel.Click
        Dim ui As Form1

        ui = New Form1
        ui.Show()
        ui = Nothing
    End Sub

End Class
