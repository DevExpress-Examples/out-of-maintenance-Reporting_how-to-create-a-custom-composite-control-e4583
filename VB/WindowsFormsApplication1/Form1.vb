Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.Drawing.Design
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btShowDesigner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btShowDesigner.Click
			If Not Me.btShowDesigner.IsHandleCreated Then Return

			Dim report As New XtraReport1()
			Dim tool As New ReportDesignTool(report)
			AddHandler tool.DesignForm.DesignMdiController.DesignPanelLoaded, AddressOf DesignMdiController_DesignPanelLoaded
			tool.ShowDesignerDialog()
		End Sub

		Private Sub DesignMdiController_DesignPanelLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs)
			Dim ts As IToolboxService = DirectCast(e.DesignerHost.GetService(GetType(IToolboxService)), IToolboxService)
			ts.AddToolboxItem(New ToolboxItem(GetType(CustomControls.MyCompositeControl)), "New Category")

		End Sub


	End Class
End Namespace
