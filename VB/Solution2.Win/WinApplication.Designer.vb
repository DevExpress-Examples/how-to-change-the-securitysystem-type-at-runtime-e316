Imports Microsoft.VisualBasic
Imports System
Namespace Solution2.Win
	Partial Public Class Solution2WindowsFormsApplication
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
			Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
			Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
			Me.module7 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
			Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
			Me.module3 = New Solution2.Module.Solution2Module()
			Me.module4 = New Solution2.Module.Win.Solution2WindowsFormsModule()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' module5
			' 
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
			' 
			' Solution2WindowsFormsApplication
			' 
			Me.ApplicationName = "Solution2"
			Me.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password=;User ID=Admin;Data Source=Solution2.md" & "b;Mode=Share Deny None;"
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module6)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module4)
			Me.Modules.Add(Me.module5)
			Me.Modules.Add(Me.module7)
			Me.Modules.Add(Me.securityModule1)
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.Solution2WindowsFormsApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
		Private module3 As Solution2.Module.Solution2Module
		Private module4 As Solution2.Module.Win.Solution2WindowsFormsModule
		Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
		Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
		Private module7 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
		Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
	End Class
End Namespace
