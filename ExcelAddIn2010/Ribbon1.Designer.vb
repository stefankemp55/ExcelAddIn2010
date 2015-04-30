Partial Class Ribbon1
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
   Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
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

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.tabModelAuditor = Me.Factory.CreateRibbonTab
        Me.grpDesign = Me.Factory.CreateRibbonGroup
        Me.chkDesignDifferences = Me.Factory.CreateRibbonCheckBox
        Me.chkMovedCells = Me.Factory.CreateRibbonCheckBox
        Me.Separator1 = Me.Factory.CreateRibbonSeparator
        Me.grpOutputs = Me.Factory.CreateRibbonGroup
        Me.chkCreateWorkbooks = Me.Factory.CreateRibbonCheckBox
        Me.chkEvents = Me.Factory.CreateRibbonCheckBox
        Me.Separator2 = Me.Factory.CreateRibbonSeparator
        Me.grpModels = Me.Factory.CreateRibbonGroup
        Me.grpScenarios = Me.Factory.CreateRibbonGroup
        Me.btnComparedesign = Me.Factory.CreateRibbonButton
        Me.btnCompareOutputs = Me.Factory.CreateRibbonButton
        Me.btnInternal = Me.Factory.CreateRibbonButton
        Me.btnAddModel = Me.Factory.CreateRibbonButton
        Me.btnMapModel = Me.Factory.CreateRibbonButton
        Me.btnDuplicateMap = Me.Factory.CreateRibbonButton
        Me.btnEditMap = Me.Factory.CreateRibbonButton
        Me.btnHighlightFields = Me.Factory.CreateRibbonButton
        Me.btnConnectMap = Me.Factory.CreateRibbonButton
        Me.btnImportScenarios = Me.Factory.CreateRibbonButton
        Me.btnGetAttributes = Me.Factory.CreateRibbonButton
        Me.btnListScenarios = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.tabModelAuditor.SuspendLayout()
        Me.grpDesign.SuspendLayout()
        Me.grpOutputs.SuspendLayout()
        Me.grpModels.SuspendLayout()
        Me.grpScenarios.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Label = "TabAddIns"
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Visible = False
        '
        'Group1
        '
        Me.Group1.Label = "Group1"
        Me.Group1.Name = "Group1"
        '
        'tabModelAuditor
        '
        Me.tabModelAuditor.Groups.Add(Me.grpDesign)
        Me.tabModelAuditor.Groups.Add(Me.grpOutputs)
        Me.tabModelAuditor.Groups.Add(Me.grpModels)
        Me.tabModelAuditor.Groups.Add(Me.grpScenarios)
        Me.tabModelAuditor.KeyTip = "MA"
        Me.tabModelAuditor.Label = "Model Auditor"
        Me.tabModelAuditor.Name = "tabModelAuditor"
        '
        'grpDesign
        '
        Me.grpDesign.Items.Add(Me.chkDesignDifferences)
        Me.grpDesign.Items.Add(Me.chkMovedCells)
        Me.grpDesign.Items.Add(Me.Separator1)
        Me.grpDesign.Items.Add(Me.btnComparedesign)
        Me.grpDesign.Label = "Compare Model Design"
        Me.grpDesign.Name = "grpDesign"
        '
        'chkDesignDifferences
        '
        Me.chkDesignDifferences.Label = "Highlight Differences"
        Me.chkDesignDifferences.Name = "chkDesignDifferences"
        '
        'chkMovedCells
        '
        Me.chkMovedCells.Label = "Check for Moved Cells"
        Me.chkMovedCells.Name = "chkMovedCells"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        '
        'grpOutputs
        '
        Me.grpOutputs.Items.Add(Me.chkCreateWorkbooks)
        Me.grpOutputs.Items.Add(Me.chkEvents)
        Me.grpOutputs.Items.Add(Me.Separator2)
        Me.grpOutputs.Items.Add(Me.btnCompareOutputs)
        Me.grpOutputs.Items.Add(Me.btnInternal)
        Me.grpOutputs.Label = "Compare Model Outputs"
        Me.grpOutputs.Name = "grpOutputs"
        '
        'chkCreateWorkbooks
        '
        Me.chkCreateWorkbooks.Checked = True
        Me.chkCreateWorkbooks.Label = "Create Workbooks"
        Me.chkCreateWorkbooks.Name = "chkCreateWorkbooks"
        '
        'chkEvents
        '
        Me.chkEvents.Label = "Disable Events"
        Me.chkEvents.Name = "chkEvents"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        '
        'grpModels
        '
        Me.grpModels.Items.Add(Me.btnAddModel)
        Me.grpModels.Items.Add(Me.btnMapModel)
        Me.grpModels.Items.Add(Me.btnDuplicateMap)
        Me.grpModels.Items.Add(Me.btnEditMap)
        Me.grpModels.Items.Add(Me.btnHighlightFields)
        Me.grpModels.Items.Add(Me.btnConnectMap)
        Me.grpModels.Label = "Models"
        Me.grpModels.Name = "grpModels"
        '
        'grpScenarios
        '
        Me.grpScenarios.Items.Add(Me.btnImportScenarios)
        Me.grpScenarios.Items.Add(Me.btnGetAttributes)
        Me.grpScenarios.Items.Add(Me.btnListScenarios)
        Me.grpScenarios.Label = "Scenarios"
        Me.grpScenarios.Name = "grpScenarios"
        '
        'btnComparedesign
        '
        Me.btnComparedesign.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnComparedesign.Label = "Compare Design"
        Me.btnComparedesign.Name = "btnComparedesign"
        Me.btnComparedesign.ShowImage = True
        '
        'btnCompareOutputs
        '
        Me.btnCompareOutputs.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnCompareOutputs.Label = "Compare Outputs"
        Me.btnCompareOutputs.Name = "btnCompareOutputs"
        Me.btnCompareOutputs.ShowImage = True
        '
        'btnInternal
        '
        Me.btnInternal.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnInternal.Label = "Check Internal Consistency"
        Me.btnInternal.Name = "btnInternal"
        Me.btnInternal.ShowImage = True
        '
        'btnAddModel
        '
        Me.btnAddModel.Label = "Add Model"
        Me.btnAddModel.Name = "btnAddModel"
        '
        'btnMapModel
        '
        Me.btnMapModel.Label = "Map Model"
        Me.btnMapModel.Name = "btnMapModel"
        '
        'btnDuplicateMap
        '
        Me.btnDuplicateMap.Label = "Duplicate Map"
        Me.btnDuplicateMap.Name = "btnDuplicateMap"
        '
        'btnEditMap
        '
        Me.btnEditMap.Label = "Edit Map"
        Me.btnEditMap.Name = "btnEditMap"
        '
        'btnHighlightFields
        '
        Me.btnHighlightFields.Label = "Highlight Fields"
        Me.btnHighlightFields.Name = "btnHighlightFields"
        '
        'btnConnectMap
        '
        Me.btnConnectMap.Label = "Connect Map"
        Me.btnConnectMap.Name = "btnConnectMap"
        '
        'btnImportScenarios
        '
        Me.btnImportScenarios.Label = "Import Scenarios"
        Me.btnImportScenarios.Name = "btnImportScenarios"
        '
        'btnGetAttributes
        '
        Me.btnGetAttributes.Label = "Get Attributes"
        Me.btnGetAttributes.Name = "btnGetAttributes"
        '
        'btnListScenarios
        '
        Me.btnListScenarios.Label = "List Scenarios"
        Me.btnListScenarios.Name = "btnListScenarios"
        '
        'Ribbon1
        '
        Me.Name = "Ribbon1"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tabs.Add(Me.tabModelAuditor)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.tabModelAuditor.ResumeLayout(False)
        Me.tabModelAuditor.PerformLayout()
        Me.grpDesign.ResumeLayout(False)
        Me.grpDesign.PerformLayout()
        Me.grpOutputs.ResumeLayout(False)
        Me.grpOutputs.PerformLayout()
        Me.grpModels.ResumeLayout(False)
        Me.grpModels.PerformLayout()
        Me.grpScenarios.ResumeLayout(False)
        Me.grpScenarios.PerformLayout()

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents tabModelAuditor As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents grpDesign As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnComparedesign As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents chkDesignDifferences As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents chkMovedCells As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents Separator1 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents grpOutputs As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents chkCreateWorkbooks As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents chkEvents As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents Separator2 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents btnCompareOutputs As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnInternal As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpModels As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnAddModel As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnMapModel As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnDuplicateMap As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnEditMap As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnHighlightFields As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnConnectMap As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpScenarios As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnImportScenarios As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnGetAttributes As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnListScenarios As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As Ribbon1
        Get
            Return Me.GetRibbon(Of Ribbon1)()
        End Get
    End Property
End Class
