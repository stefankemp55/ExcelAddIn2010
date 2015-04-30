Public Class frmAddModel

    Private Sub ModelsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ModelsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Excel_Model_AuditorDataSet)

    End Sub

    Private Sub frmAddModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Excel_Model_AuditorDataSet.Models' table. You can move, or remove it, as needed.
        Me.ModelsTableAdapter.Fill(Me.Excel_Model_AuditorDataSet.Models)
        Me.cboModelName.DataSource = Me.Excel_Model_AuditorDataSet.Models
        Me.cboModelName.ValueMember = "ModelID"
        Me.cboModelName.DisplayMember = "ModelName"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim ModelRow As Excel_Model_AuditorDataSet.ModelsRow
        Try
            ModelRow = Excel_Model_AuditorDataSet.Models.NewModelsRow()
            ModelRow.ModelName = Me.cboModelName.Text
            Excel_Model_AuditorDataSet.Models.Rows.Add(ModelRow)
            Me.ModelsTableAdapter.Update(Excel_Model_AuditorDataSet.Models)
            'Me.ModelsTableAdapter.Insert("hhh", 1, 1, 1, "hh")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()
    End Sub
End Class