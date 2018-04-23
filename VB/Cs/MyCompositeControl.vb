Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports System.ComponentModel
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.Design.Behaviours

Namespace CustomControls

	<ToolboxItem(True), XRDesigner("CustomControls.MyPanelDesigner"), Designer("CustomControls.MyPanelDesigner")> _
	Public Class MyCompositeControl
		Inherits XRPanel
		Public Sub New()
			MyBase.New()
				Me.SizeF = New System.Drawing.SizeF(50, 50)

		End Sub
	End Class
	<DesignerBehaviour(GetType(MyPanelDesignerBehaviour))> _
	Public Class MyPanelDesigner
		Inherits XRPanelDesigner
		Public Sub New()
			MyBase.New()

		End Sub
		Public Sub InitControls()
			Dim panel As MyCompositeControl = TryCast(Me.XRControl, MyCompositeControl)

			Dim label1 As New XRLabel()
			label1.DataBindings.Add("Text", Nothing, "CategoryID")
			label1.SizeF = New System.Drawing.SizeF(50, 25)
			panel.Controls.Add(label1)
			Dim label2 As New XRLabel()
			panel.Controls.Add(label2)
			label2.SizeF = New System.Drawing.SizeF(50, 25)
			label2.LocationF = New System.Drawing.PointF(0, 25)
			label2.DataBindings.Add("Text", Nothing, "CategoryName")
		End Sub
		Public Sub AddChildControlsToContainer()
			Dim panel As MyCompositeControl = TryCast(Me.XRControl, MyCompositeControl)
			For Each childControl As XRControl In panel.Controls
				Dim loc As System.Drawing.PointF = childControl.LocationF
				DesignToolHelper.AddToContainer(fDesignerHost, childControl)
				childControl.LocationF = loc
			Next childControl
		End Sub
		'          override 
	End Class

	Public Class MyPanelDesignerBehaviour
		Inherits DesignerBehaviour
		Public Sub New(ByVal servProvider As IServiceProvider)
			MyBase.New(servProvider)
		End Sub
		Public Overrides Sub SetDefaultComponentBounds()
			MyBase.SetDefaultComponentBounds()
			TryCast(Designer, MyPanelDesigner).InitControls()
			TryCast(Designer, MyPanelDesigner).AddChildControlsToContainer()
		End Sub
	End Class
End Namespace
