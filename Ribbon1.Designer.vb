Partial Class ri_Plan
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Wymagane do obsługi Projektanta kompozycji klas Windows.Forms
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'To wywołanie jest wymagane przez Projektanta składników.
        InitializeComponent()

    End Sub

    'Składnik przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta składników
    Private components As System.ComponentModel.IContainer

    'UWAGA: Następująca procedura jest wymagana przez Projektanta składników
    'Można to modyfikować za pomocą Projektanta składników.
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.bt_Klient = Me.Factory.CreateRibbonButton
        Me.bt_Spotkanie = Me.Factory.CreateRibbonButton
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.bt_PomiarMasy = Me.Factory.CreateRibbonButton
        Me.bt_MasaWykres = Me.Factory.CreateRibbonButton
        Me.Group3 = Me.Factory.CreateRibbonGroup
        Me.bt_PomiarObwodów = Me.Factory.CreateRibbonButton
        Me.bt_WykresObwodów = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.Group3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Groups.Add(Me.Group2)
        Me.Tab1.Groups.Add(Me.Group3)
        Me.Tab1.Label = "PLAN TRENINGOWY"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.bt_Klient)
        Me.Group1.Items.Add(Me.bt_Spotkanie)
        Me.Group1.Label = "Klient"
        Me.Group1.Name = "Group1"
        '
        'bt_Klient
        '
        Me.bt_Klient.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.bt_Klient.Image = Global.Plan.My.Resources.Resources.FontAwesome_f007_0__32
        Me.bt_Klient.Label = "Dane klienta"
        Me.bt_Klient.Name = "bt_Klient"
        Me.bt_Klient.ShowImage = True
        '
        'bt_Spotkanie
        '
        Me.bt_Spotkanie.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.bt_Spotkanie.Image = Global.Plan.My.Resources.Resources.FontAwesome_f0c0_0__32
        Me.bt_Spotkanie.Label = "Spotkanie"
        Me.bt_Spotkanie.Name = "bt_Spotkanie"
        Me.bt_Spotkanie.ShowImage = True
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.bt_PomiarMasy)
        Me.Group2.Items.Add(Me.bt_MasaWykres)
        Me.Group2.Label = "Masa ciała"
        Me.Group2.Name = "Group2"
        '
        'bt_PomiarMasy
        '
        Me.bt_PomiarMasy.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.bt_PomiarMasy.Image = Global.Plan.My.Resources.Resources.Waga_80
        Me.bt_PomiarMasy.Label = "Pomiar masy"
        Me.bt_PomiarMasy.Name = "bt_PomiarMasy"
        Me.bt_PomiarMasy.ShowImage = True
        '
        'bt_MasaWykres
        '
        Me.bt_MasaWykres.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.bt_MasaWykres.Image = Global.Plan.My.Resources.Resources.Material_Icons_e01d_0__32
        Me.bt_MasaWykres.Label = "Wykres"
        Me.bt_MasaWykres.Name = "bt_MasaWykres"
        Me.bt_MasaWykres.ShowImage = True
        '
        'Group3
        '
        Me.Group3.Items.Add(Me.bt_PomiarObwodów)
        Me.Group3.Items.Add(Me.bt_WykresObwodów)
        Me.Group3.Label = "Obwody"
        Me.Group3.Name = "Group3"
        '
        'bt_PomiarObwodów
        '
        Me.bt_PomiarObwodów.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.bt_PomiarObwodów.Image = Global.Plan.My.Resources.Resources.Pomiar_32
        Me.bt_PomiarObwodów.Label = "Pomiar obwodów"
        Me.bt_PomiarObwodów.Name = "bt_PomiarObwodów"
        Me.bt_PomiarObwodów.ShowImage = True
        '
        'bt_WykresObwodów
        '
        Me.bt_WykresObwodów.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.bt_WykresObwodów.Image = Global.Plan.My.Resources.Resources.Pomiar_wykres
        Me.bt_WykresObwodów.Label = "Wykres"
        Me.bt_WykresObwodów.Name = "bt_WykresObwodów"
        Me.bt_WykresObwodów.ShowImage = True
        '
        'ri_Plan
        '
        Me.Name = "ri_Plan"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.Group3.ResumeLayout(False)
        Me.Group3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents bt_Klient As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents bt_PomiarMasy As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group3 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents bt_PomiarObwodów As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents bt_Spotkanie As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents bt_MasaWykres As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents bt_WykresObwodów As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As ri_Plan
        Get
            Return Me.GetRibbon(Of ri_Plan)()
        End Get
    End Property
End Class
