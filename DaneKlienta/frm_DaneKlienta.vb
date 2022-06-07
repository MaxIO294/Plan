Public Class frm_DaneKlienta

    Private Sub frm_DaneKlienta_Load(sender As Object, e As EventArgs) Handles Me.Load
        PobierzDaneZArkusza()
    End Sub

    Private Sub PobierzDaneZArkusza()
        tb_Nazwisko.Text = Globals.Arkusz3.Range("B2").Value
        tb_Imie.Text = Globals.Arkusz3.Range("B3").Value
        mtb_Wiek.Text = Globals.Arkusz3.Range("B4").Value
        mtb_Telefon.Text = Globals.Arkusz3.Range("B5").Value
        mtb_AdresMeil.Text = Globals.Arkusz3.Range("B6").Value
        tb_Ankieta.Text = Globals.Arkusz3.Range("B7").Value
    End Sub
End Class