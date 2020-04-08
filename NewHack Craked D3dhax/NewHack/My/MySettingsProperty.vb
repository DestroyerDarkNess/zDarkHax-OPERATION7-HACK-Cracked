Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NewHack.My
	' Token: 0x02000011 RID: 17
	<DebuggerNonUserCode()>
	<HideModuleName()>
	<CompilerGenerated()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x17000055 RID: 85
		' (get) Token: 0x06000105 RID: 261 RVA: 0x000088C0 File Offset: 0x00006AC0
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
