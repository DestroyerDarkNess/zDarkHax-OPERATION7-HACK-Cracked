Namespace NewHack
	' Token: 0x0200000A RID: 10
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class actualizacion
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000036 RID: 54 RVA: 0x00002BC0 File Offset: 0x00000DC0
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000037 RID: 55 RVA: 0x00002C00 File Offset: 0x00000E00
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NewHack.actualizacion))
			Me.Recv = New Global.System.Windows.Forms.Label()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.SuspendLayout()
			Me.Recv.AutoSize = True
			Me.Recv.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Recv.ForeColor = Global.System.Drawing.Color.Lime
			Dim recv As Global.System.Windows.Forms.Control = Me.Recv
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(62, 25)
			recv.Location = location
			Me.Recv.Name = "Recv"
			Dim recv2 As Global.System.Windows.Forms.Control = Me.Recv
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(0, 18)
			recv2.Size = size
			Me.Recv.TabIndex = 0
			Me.Button1.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(57, 60)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(102, 26)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Cheked"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Button2.BackColor = Global.System.Drawing.Color.Red
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button2.ForeColor = Global.System.Drawing.Color.Black
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(189, 0)
			button3.Location = location
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(32, 27)
			button4.Size = size
			Me.Button2.TabIndex = 12
			Me.Button2.Text = "X"
			Me.Button2.UseVisualStyleBackColor = False
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Blue
			size = New Global.System.Drawing.Size(219, 93)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Recv)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "actualizacion"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000010 RID: 16
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
