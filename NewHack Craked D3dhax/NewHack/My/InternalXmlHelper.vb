Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Xml.Linq

Namespace NewHack.My
	' Token: 0x02000008 RID: 8
	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DebuggerNonUserCode()>
	Friend NotInheritable Class InternalXmlHelper
		' Token: 0x06000024 RID: 36 RVA: 0x00002640 File Offset: 0x00000840
		<EditorBrowsable(EditorBrowsableState.Never)>
		Private Sub New()
		End Sub

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000025 RID: 37 RVA: 0x00002648 File Offset: 0x00000848
		' (set) Token: 0x06000026 RID: 38 RVA: 0x0000269C File Offset: 0x0000089C
		Public Shared Property Value(source As IEnumerable(Of XElement)) As String
			Get
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						Return xelement.Value
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						xelement.Value = value
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000027 RID: 39 RVA: 0x000026EC File Offset: 0x000008EC
		' (set) Token: 0x06000028 RID: 40 RVA: 0x00002744 File Offset: 0x00000944
		Public Shared Property AttributeValue(source As IEnumerable(Of XElement), name As XName) As String
			Get
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						Return CStr(xelement.Attribute(name))
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						xelement.SetAttributeValue(name, value)
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000029 RID: 41 RVA: 0x00002794 File Offset: 0x00000994
		' (set) Token: 0x0600002A RID: 42 RVA: 0x000027B0 File Offset: 0x000009B0
		Public Shared Property AttributeValue(source As XElement, name As XName) As String
			Get
				Return CStr(source.Attribute(name))
			End Get
			Set(value As String)
				source.SetAttributeValue(name, value)
			End Set
		End Property

		' Token: 0x0600002B RID: 43 RVA: 0x000027BC File Offset: 0x000009BC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function CreateAttribute(name As XName, value As Object) As XAttribute
			Dim result As XAttribute
			If value Is Nothing Then
				result = Nothing
			Else
				result = New XAttribute(name, RuntimeHelpers.GetObjectValue(value))
			End If
			Return result
		End Function

		' Token: 0x0600002C RID: 44 RVA: 0x000027E4 File Offset: 0x000009E4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function CreateNamespaceAttribute(name As XName, ns As XNamespace) As XAttribute
			Dim xattribute As XAttribute = New XAttribute(name, ns.NamespaceName)
			xattribute.AddAnnotation(ns)
			Return xattribute
		End Function

		' Token: 0x0600002D RID: 45 RVA: 0x00002808 File Offset: 0x00000A08
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute), obj As Object) As Object
			If obj IsNot Nothing Then
				Dim xelement As XElement = TryCast(obj, XElement)
				If xelement IsNot Nothing Then
					Return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, xelement)
				End If
				Dim enumerable As IEnumerable = TryCast(obj, IEnumerable)
				If enumerable IsNot Nothing Then
					Return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable)
				End If
			End If
			Return obj
		End Function

		' Token: 0x0600002E RID: 46 RVA: 0x0000285C File Offset: 0x00000A5C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute), obj As IEnumerable) As IEnumerable
			Dim result As IEnumerable
			If obj IsNot Nothing Then
				Dim enumerable As IEnumerable(Of XElement) = TryCast(obj, IEnumerable(Of XElement))
				If enumerable IsNot Nothing Then
					result = enumerable.[Select](AddressOf New InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement)
				Else
					result = obj.Cast().[Select](AddressOf New InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject)
				End If
			Else
				result = obj
			End If
			Return result
		End Function

		' Token: 0x0600002F RID: 47 RVA: 0x000028C4 File Offset: 0x00000AC4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute), e As XElement) As XElement
			' The following expression was wrapped in a checked-statement
			If e IsNot Nothing Then
				Dim nextAttribute As XAttribute
				Dim xattribute As XAttribute = e.FirstAttribute
				While xattribute IsNot Nothing
					nextAttribute = xattribute.NextAttribute
					If xattribute.IsNamespaceDeclaration Then
						Dim xnamespace As XNamespace = xattribute.Annotation(Of XNamespace)()
						Dim localName As String = xattribute.Name.LocalName
						If xnamespace IsNot Nothing Then
							If inScopePrefixes IsNot Nothing AndAlso inScopeNs IsNot Nothing Then
								Dim num As Integer = inScopePrefixes.Length - 1
								Dim num2 As Integer = 0
								Dim num3 As Integer = num
								Dim num4 As Integer = num2
								Dim right As XNamespace
								While True
									Dim num5 As Integer = num4
									Dim num6 As Integer = num3
									If num5 > num6 Then
										GoTo Block_7
									End If
									Dim value As String = inScopePrefixes(num4)
									right = inScopeNs(num4)
									If localName.Equals(value) Then
										Exit For
									End If
									num4 += 1
								End While
								If xnamespace Is right Then
									xattribute.Remove()
								End If
								xattribute = Nothing
								Block_7:
							End If
							If xattribute IsNot Nothing Then
								If attributes IsNot Nothing Then
									Dim num7 As Integer = attributes.Count - 1
									Dim num8 As Integer = 0
									Dim num9 As Integer = num7
									Dim num10 As Integer = num8
									Dim xnamespace2 As XNamespace
									While True
										Dim num11 As Integer = num10
										Dim num6 As Integer = num9
										If num11 > num6 Then
											GoTo Block_12
										End If
										Dim xattribute2 As XAttribute = attributes(num10)
										Dim localName2 As String = xattribute2.Name.LocalName
										xnamespace2 = xattribute2.Annotation(Of XNamespace)()
										If xnamespace2 IsNot Nothing AndAlso localName.Equals(localName2) Then
											Exit For
										End If
										num10 += 1
									End While
									If xnamespace Is xnamespace2 Then
										xattribute.Remove()
									End If
									xattribute = Nothing
									Block_12:
								End If
								If xattribute IsNot Nothing Then
									xattribute.Remove()
									attributes.Add(xattribute)
								End If
							End If
						End If
					End If
					xattribute = nextAttribute
				End While
			End If
			Return e
		End Function

		' Token: 0x02000009 RID: 9
		<EditorBrowsable(EditorBrowsableState.Never)>
		<CompilerGenerated()>
		<DebuggerNonUserCode()>
		Private NotInheritable Class RemoveNamespaceAttributesClosure
			' Token: 0x06000030 RID: 48 RVA: 0x00002A18 File Offset: 0x00000C18
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Sub New(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute))
				Me.m_inScopePrefixes = inScopePrefixes
				Me.m_inScopeNs = inScopeNs
				Me.m_attributes = attributes
			End Sub

			' Token: 0x06000031 RID: 49 RVA: 0x00002A38 File Offset: 0x00000C38
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ProcessXElement(elem As XElement) As XElement
				Return InternalXmlHelper.RemoveNamespaceAttributes(Me.m_inScopePrefixes, Me.m_inScopeNs, Me.m_attributes, elem)
			End Function

			' Token: 0x06000032 RID: 50 RVA: 0x00002A60 File Offset: 0x00000C60
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ProcessObject(obj As Object) As Object
				Dim xelement As XElement = TryCast(obj, XElement)
				Dim result As Object
				If xelement IsNot Nothing Then
					result = InternalXmlHelper.RemoveNamespaceAttributes(Me.m_inScopePrefixes, Me.m_inScopeNs, Me.m_attributes, xelement)
				Else
					result = obj
				End If
				Return result
			End Function

			' Token: 0x0400000C RID: 12
			Private m_inScopePrefixes As String()

			' Token: 0x0400000D RID: 13
			Private m_inScopeNs As XNamespace()

			' Token: 0x0400000E RID: 14
			Private m_attributes As List(Of XAttribute)
		End Class
	End Class
End Namespace
