Namespace WindowsFormsApplication1
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.btShowDesigner = New System.Windows.Forms.Button()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Controls.Add(Me.btShowDesigner, 0, 0)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 1
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(233, 86)
			Me.tableLayoutPanel1.TabIndex = 0
			' 
			' btShowDesigner
			' 
			Me.btShowDesigner.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btShowDesigner.Location = New System.Drawing.Point(40, 31)
			Me.btShowDesigner.Name = "btShowDesigner"
			Me.btShowDesigner.Size = New System.Drawing.Size(152, 23)
			Me.btShowDesigner.TabIndex = 1
			Me.btShowDesigner.Text = "Show Designer"
			Me.btShowDesigner.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btShowDesigner.Click += new System.EventHandler(this.btShowDesigner_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(233, 86)
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private WithEvents btShowDesigner As System.Windows.Forms.Button
	End Class
End Namespace

