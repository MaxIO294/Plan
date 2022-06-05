Imports Microsoft.Office.Tools.Ribbon

Public Class ri_Plan

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False


    End Sub
End Class
