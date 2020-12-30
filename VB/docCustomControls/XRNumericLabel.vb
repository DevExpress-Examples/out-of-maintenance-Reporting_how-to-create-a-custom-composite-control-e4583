Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Localization
'...

Namespace CustomControls
	<DefaultBindableProperty("Number"), ToolboxBitmap(GetType(XRNumericLabel))>
	Public Class XRNumericLabel
		Inherits XRLabel

'INSTANT VB NOTE: The field number was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private number_Conflict As Integer

		<SRCategory(ReportStringId.CatData), DefaultValue(0), Bindable(True)>
		Public Overridable Property Number() As Integer
			Get
				Return number_Conflict
			End Get
			Set(ByVal value As Integer)
				number_Conflict = value
			End Set
		End Property

		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never), Bindable(False)>
		Public Overrides Property Text() As String
			Get
				Return number_Conflict.ToString()
			End Get
			Set(ByVal value As String)
				Dim i As Integer = Nothing

				If Integer.TryParse(value, i) Then
					   number_Conflict = i
				Else
					MessageBox.Show("This text can't be converted to a number!")
				End If
			End Set
		End Property
	End Class
End Namespace
