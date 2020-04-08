Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NewHack.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002204 File Offset: 0x00000404
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x0600000A RID: 10 RVA: 0x00002220 File Offset: 0x00000420
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x0600000B RID: 11 RVA: 0x0000223C File Offset: 0x0000043C
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x0600000C RID: 12 RVA: 0x00002258 File Offset: 0x00000458
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000D RID: 13 RVA: 0x00002274 File Offset: 0x00000474
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000002 RID: 2
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000003 RID: 3
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000004 RID: 4
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000005 RID: 5
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000006 RID: 6
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000005 RID: 5
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyForms
			' Token: 0x17000006 RID: 6
			' (get) Token: 0x0600000E RID: 14 RVA: 0x00002290 File Offset: 0x00000490
			' (set) Token: 0x06000011 RID: 17 RVA: 0x00002308 File Offset: 0x00000508
			Public Property actualizacion As actualizacion
				<DebuggerNonUserCode()>
				Get
					Me.m_actualizacion = MyProject.MyForms.Create__Instance__(Of actualizacion)(Me.m_actualizacion)
					Return Me.m_actualizacion
				End Get
				<DebuggerNonUserCode()>
				Set(value As actualizacion)
					If value IsNot Me.m_actualizacion Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of actualizacion)(Me.m_actualizacion)
					End If
				End Set
			End Property

			' Token: 0x17000007 RID: 7
			' (get) Token: 0x0600000F RID: 15 RVA: 0x000022B8 File Offset: 0x000004B8
			' (set) Token: 0x06000012 RID: 18 RVA: 0x00002340 File Offset: 0x00000540
			Public Property Cargando As Cargando
				<DebuggerNonUserCode()>
				Get
					Me.m_Cargando = MyProject.MyForms.Create__Instance__(Of Cargando)(Me.m_Cargando)
					Return Me.m_Cargando
				End Get
				<DebuggerNonUserCode()>
				Set(value As Cargando)
					If value IsNot Me.m_Cargando Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Cargando)(Me.m_Cargando)
					End If
				End Set
			End Property

			' Token: 0x17000008 RID: 8
			' (get) Token: 0x06000010 RID: 16 RVA: 0x000022E0 File Offset: 0x000004E0
			' (set) Token: 0x06000013 RID: 19 RVA: 0x00002378 File Offset: 0x00000578
			Public Property Form2 As Form2
				<DebuggerNonUserCode()>
				Get
					Me.m_Form2 = MyProject.MyForms.Create__Instance__(Of Form2)(Me.m_Form2)
					Return Me.m_Form2
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form2)
					If value IsNot Me.m_Form2 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form2)(Me.m_Form2)
					End If
				End Set
			End Property

			' Token: 0x06000014 RID: 20 RVA: 0x000023B0 File Offset: 0x000005B0
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim result As T
				If Instance IsNot Nothing AndAlso Not Instance.IsDisposed Then
					result = Instance
				Else
					If MyProject.MyForms.m_FormBeingCreated IsNot Nothing Then
						If MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						result = Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return result
			End Function

			' Token: 0x06000015 RID: 21 RVA: 0x000024C0 File Offset: 0x000006C0
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x06000016 RID: 22 RVA: 0x000024E8 File Offset: 0x000006E8
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x06000017 RID: 23 RVA: 0x000024F0 File Offset: 0x000006F0
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000018 RID: 24 RVA: 0x0000250C File Offset: 0x0000070C
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000019 RID: 25 RVA: 0x00002524 File Offset: 0x00000724
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x0600001A RID: 26 RVA: 0x00002540 File Offset: 0x00000740
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x04000007 RID: 7
			Public m_actualizacion As actualizacion

			' Token: 0x04000008 RID: 8
			Public m_Cargando As Cargando

			' Token: 0x04000009 RID: 9
			Public m_Form2 As Form2

			' Token: 0x0400000A RID: 10
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable
		End Class

		' Token: 0x02000006 RID: 6
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyWebServices
			' Token: 0x0600001B RID: 27 RVA: 0x00002558 File Offset: 0x00000758
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x0600001C RID: 28 RVA: 0x00002574 File Offset: 0x00000774
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600001D RID: 29 RVA: 0x0000258C File Offset: 0x0000078C
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x0600001E RID: 30 RVA: 0x000025A8 File Offset: 0x000007A8
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600001F RID: 31 RVA: 0x000025C0 File Offset: 0x000007C0
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim result As T
				If instance Is Nothing Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x06000020 RID: 32 RVA: 0x000025E4 File Offset: 0x000007E4
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x06000021 RID: 33 RVA: 0x00002600 File Offset: 0x00000800
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000007 RID: 7
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000009 RID: 9
			' (get) Token: 0x06000022 RID: 34 RVA: 0x00002608 File Offset: 0x00000808
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					If MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x06000023 RID: 35 RVA: 0x00002638 File Offset: 0x00000838
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x0400000B RID: 11
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
