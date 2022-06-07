Imports Microsoft.Office.Tools.Ribbon

Public Class ri_Plan
    Private Sub bt_Klient_Click(sender As Object, e As RibbonControlEventArgs) Handles bt_Klient.Click
        Dim frm As New frm_DaneKlienta
        frm.ShowDialog()
    End Sub

    Private Sub bt_Spotkanie_Click(sender As Object, e As RibbonControlEventArgs) Handles bt_Spotkanie.Click

    End Sub

    Private Sub bt_PomiarMasy_Click(sender As Object, e As RibbonControlEventArgs) Handles bt_PomiarMasy.Click

    End Sub

    Private Sub bt_MasaWykres_Click(sender As Object, e As RibbonControlEventArgs) Handles bt_MasaWykres.Click

    End Sub

    Private Sub bt_PomiarObwodów_Click(sender As Object, e As RibbonControlEventArgs) Handles bt_PomiarObwodów.Click

    End Sub

    Private Sub bt_WykresObwodów_Click(sender As Object, e As RibbonControlEventArgs) Handles bt_WykresObwodów.Click

    End Sub
End Class
