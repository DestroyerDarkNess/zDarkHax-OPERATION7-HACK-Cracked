Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NewHack.My.Resources
	' Token: 0x0200000F RID: 15
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	<HideModuleName()>
	Friend NotInheritable Module Resources
		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000FE RID: 254 RVA: 0x00008794 File Offset: 0x00006994
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
					Dim resourceManager As ResourceManager = New ResourceManager("NewHack.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x060000FF RID: 255 RVA: 0x000087D8 File Offset: 0x000069D8
		' (set) Token: 0x06000100 RID: 256 RVA: 0x000087EC File Offset: 0x000069EC
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x0400006B RID: 107
		Private resourceMan As ResourceManager

		' Token: 0x0400006C RID: 108
		Private resourceCulture As CultureInfo
	End Module
End Namespace
