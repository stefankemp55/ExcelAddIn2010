<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Excel_Model_AuditorDataSet = New ExcelAddIn2010.Excel_Model_AuditorDataSet()
        Me.ModelsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelsTableAdapter = New ExcelAddIn2010.Excel_Model_AuditorDataSetTableAdapters.ModelsTableAdapter()
        Me.TableAdapterManager = New ExcelAddIn2010.Excel_Model_AuditorDataSetTableAdapters.TableAdapterManager()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboModelName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.Excel_Model_AuditorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Excel_Model_AuditorDataSet
        '
        Me.Excel_Model_AuditorDataSet.DataSetName = "Excel_Model_AuditorDataSet"
        Me.Excel_Model_AuditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModelsBindingSource
        '
        Me.ModelsBindingSource.DataMember = "Models"
        Me.ModelsBindingSource.DataSource = Me.Excel_Model_AuditorDataSet
        '
        'ModelsTableAdapter
        '
        Me.ModelsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BridgingValuesTableAdapter = Nothing
        Me.TableAdapterManager.InputsTableAdapter = Nothing
        Me.TableAdapterManager.InputValuesTableAdapter = Nothing
        Me.TableAdapterManager.MapOfInputsTableAdapter = Nothing
        Me.TableAdapterManager.MapOfInternalsTableAdapter = Nothing
        Me.TableAdapterManager.MapOfOutputsTableAdapter = Nothing
        Me.TableAdapterManager.ModelsTableAdapter = Me.ModelsTableAdapter
        Me.TableAdapterManager.ModelToBatchMappingTableAdapter = Nothing
        Me.TableAdapterManager.ModelToMapTableAdapter = Nothing
        Me.TableAdapterManager.OutputsTableAdapter = Nothing
        Me.TableAdapterManager.ScenarioBatchesTableAdapter = Nothing
        Me.TableAdapterManager.ScenariosTableAdapter = Nothing
        Me.TableAdapterManager.StandardValuesTableAdapter = Nothing
        Me.TableAdapterManager.tblAttributesTableAdapter = Nothing
        Me.TableAdapterManager.tblAttributeToOutputMappingTableAdapter = Nothing
        Me.TableAdapterManager.tblAttributeValuesTableAdapter = Nothing
        Me.TableAdapterManager.tblScenarioAttributesTableAdapter = Nothing
        Me.TableAdapterManager.tempBatchIDsTableAdapter = Nothing
        Me.TableAdapterManager.tempListValuesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ExcelAddIn2010.Excel_Model_AuditorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(334, 187)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboModelName
        '
        Me.cboModelName.FormattingEnabled = True
        Me.cboModelName.Location = New System.Drawing.Point(85, 9)
        Me.cboModelName.Name = "cboModelName"
        Me.cboModelName.Size = New System.Drawing.Size(324, 21)
        Me.cboModelName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Model Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Version"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(85, 46)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Build"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(207, 46)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox3.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(293, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Draft"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(329, 46)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox4.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Description"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(85, 85)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(324, 96)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(253, 187)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmAddModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 226)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboModelName)
        Me.Controls.Add(Me.btnClose)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddModel"
        Me.Text = "frmAddModel"
        CType(Me.Excel_Model_AuditorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Excel_Model_AuditorDataSet As ExcelAddIn2010.Excel_Model_AuditorDataSet
    Friend WithEvents ModelsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelsTableAdapter As ExcelAddIn2010.Excel_Model_AuditorDataSetTableAdapters.ModelsTableAdapter
    Friend WithEvents TableAdapterManager As ExcelAddIn2010.Excel_Model_AuditorDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cboModelName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
