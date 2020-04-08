Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NewHack.My
	' Token: 0x02000010 RID: 16
	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x06000103 RID: 259 RVA: 0x00008824 File Offset: 0x00006A24
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<DebuggerNonUserCode()>
		Private Shared Sub AutoSaveSettings(sender As Object, e As EventArgs)
			If MyProject.Application.SaveMySettingsOnExit Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x06000104 RID: 260 RVA: 0x00008848 File Offset: 0x00006A48
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				If Not MySettings.addedHandler Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						If Not MySettings.addedHandler Then
							AddHandler MyProject.Application.Shutdown, AddressOf MySettings.AutoSaveSettings
							MySettings.addedHandler = True
						End If
					End SyncLock
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x0400006D RID: 109
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		' Token: 0x0400006E RID: 110
		Private Shared addedHandler As Boolean

		' Token: 0x0400006F RID: 111
		Private Shared addedHandlerLockObject As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace
