Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security

' Ogólne informacje o zestawie są kontrolowane poprzez następujący 
' zestaw atrybutów. Zmień wartości tych atrybutów, aby zmodyfikować informacje
' skojarzone z zestawem.

' Sprawdź wartości atrybutów zestawu

<Assembly: AssemblyTitle("Plan")> 
<Assembly: AssemblyDescription("")> 
<Assembly: AssemblyCompany("")> 
<Assembly: AssemblyProduct("Plan")> 
<Assembly: AssemblyCopyright("Copyright ©  2022")> 
<Assembly: AssemblyTrademark("")> 

'Ustawienie wartości false dla elementu ComVisible sprawia, że typy w tym zestawie nie będą widoczne
' dla składników COM. Jeśli potrzebny jest dostęp do typu w tym zestawie z 
' COM, ustaw wartość true dla atrybutu ComVisible tego typu.
<Assembly: ComVisible(False)>

'Następujący identyfikator GUID jest identyfikatorem biblioteki typów w przypadku udostępnienia tego projektu w modelu COM
<Assembly: Guid("b0dfd476-c339-4b2c-b549-49aad41992b1")> 

' Informacje o wersji zestawu zawierają następujące cztery wartości:
'
'      Wersja główna
'      Wersja pomocnicza 
'      Numer kompilacji
'      Rewizja
'
' Możesz określić wszystkie wartości lub użyć domyślnych numerów kompilacji i poprawki 
' przy użyciu symbolu „*”, tak jak pokazano poniżej:
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("1.0.0.0")> 
<Assembly: AssemblyFileVersion("1.0.0.0")> 

Friend Module DesignTimeConstants
    Public Const RibbonTypeSerializer As String = "Microsoft.VisualStudio.Tools.Office.Ribbon.Serialization.RibbonTypeCodeDomSerializer, Microsoft.VisualStudio.Tools.Office.Designer, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Public Const RibbonBaseTypeSerializer As String = "System.ComponentModel.Design.Serialization.TypeCodeDomSerializer, System.Design"
    Public Const RibbonDesigner As String = "Microsoft.VisualStudio.Tools.Office.Ribbon.Design.RibbonDesigner, Microsoft.VisualStudio.Tools.Office.Designer, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
End Module
