Public Class Form1

    Private Sub ModelsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ModelsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ModelsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Excel_Model_AuditorDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Excel_Model_AuditorDataSet.Models' table. You can move, or remove it, as needed.
        Me.ModelsTableAdapter.Fill(Me.Excel_Model_AuditorDataSet.Models)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.ModelsBindingSource.EndEdit()
            Me.ModelsTableAdapter.Update(Me.Excel_Model_AuditorDataSet.Models)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()
    End Sub
End Class