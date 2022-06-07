<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DaneKlienta
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DaneKlienta))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_Nazwisko = New System.Windows.Forms.TextBox()
        Me.tb_Imie = New System.Windows.Forms.TextBox()
        Me.tb_Ankieta = New System.Windows.Forms.TextBox()
        Me.tsb_Zapisz = New System.Windows.Forms.ToolStripButton()
        Me.tsb_NowyKlient = New System.Windows.Forms.ToolStripButton()
        Me.tsb_ZapiszDoPliku = New System.Windows.Forms.ToolStripButton()
        Me.mtb_Wiek = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_Telefon = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_AdresMeil = New System.Windows.Forms.MaskedTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_NowyKlient, Me.tsb_Zapisz, Me.tsb_ZapiszDoPliku})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(602, 55)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.mtb_AdresMeil, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.mtb_Telefon, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_Ankieta, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_Imie, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_Nazwisko, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.mtb_Wiek, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 55)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(602, 594)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nazwisko"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(4, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Imię"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(4, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Wiek"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(4, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefon"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(4, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Meil"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(4, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 26)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ankieta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_Nazwisko
        '
        Me.tb_Nazwisko.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_Nazwisko.Location = New System.Drawing.Point(112, 4)
        Me.tb_Nazwisko.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Nazwisko.Name = "tb_Nazwisko"
        Me.tb_Nazwisko.Size = New System.Drawing.Size(486, 26)
        Me.tb_Nazwisko.TabIndex = 6
        '
        'tb_Imie
        '
        Me.tb_Imie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_Imie.Location = New System.Drawing.Point(112, 38)
        Me.tb_Imie.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Imie.Name = "tb_Imie"
        Me.tb_Imie.Size = New System.Drawing.Size(486, 26)
        Me.tb_Imie.TabIndex = 7
        '
        'tb_Ankieta
        '
        Me.tb_Ankieta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_Ankieta.Location = New System.Drawing.Point(112, 174)
        Me.tb_Ankieta.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Ankieta.Multiline = True
        Me.tb_Ankieta.Name = "tb_Ankieta"
        Me.TableLayoutPanel1.SetRowSpan(Me.tb_Ankieta, 2)
        Me.tb_Ankieta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_Ankieta.Size = New System.Drawing.Size(486, 416)
        Me.tb_Ankieta.TabIndex = 11
        '
        'tsb_Zapisz
        '
        Me.tsb_Zapisz.AutoSize = False
        Me.tsb_Zapisz.Image = CType(resources.GetObject("tsb_Zapisz.Image"), System.Drawing.Image)
        Me.tsb_Zapisz.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsb_Zapisz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Zapisz.Margin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.tsb_Zapisz.Name = "tsb_Zapisz"
        Me.tsb_Zapisz.Size = New System.Drawing.Size(100, 51)
        Me.tsb_Zapisz.Text = "Zapisz"
        Me.tsb_Zapisz.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsb_Zapisz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsb_NowyKlient
        '
        Me.tsb_NowyKlient.AutoSize = False
        Me.tsb_NowyKlient.Image = CType(resources.GetObject("tsb_NowyKlient.Image"), System.Drawing.Image)
        Me.tsb_NowyKlient.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsb_NowyKlient.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_NowyKlient.Margin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.tsb_NowyKlient.Name = "tsb_NowyKlient"
        Me.tsb_NowyKlient.Size = New System.Drawing.Size(100, 51)
        Me.tsb_NowyKlient.Text = "Nowy klient"
        Me.tsb_NowyKlient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsb_NowyKlient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsb_ZapiszDoPliku
        '
        Me.tsb_ZapiszDoPliku.AutoSize = False
        Me.tsb_ZapiszDoPliku.Image = CType(resources.GetObject("tsb_ZapiszDoPliku.Image"), System.Drawing.Image)
        Me.tsb_ZapiszDoPliku.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsb_ZapiszDoPliku.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_ZapiszDoPliku.Margin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.tsb_ZapiszDoPliku.Name = "tsb_ZapiszDoPliku"
        Me.tsb_ZapiszDoPliku.Size = New System.Drawing.Size(100, 51)
        Me.tsb_ZapiszDoPliku.Text = "Zapisz do pliku"
        Me.tsb_ZapiszDoPliku.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsb_ZapiszDoPliku.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mtb_Wiek
        '
        Me.mtb_Wiek.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mtb_Wiek.Location = New System.Drawing.Point(112, 72)
        Me.mtb_Wiek.Margin = New System.Windows.Forms.Padding(4)
        Me.mtb_Wiek.Mask = "00"
        Me.mtb_Wiek.Name = "mtb_Wiek"
        Me.mtb_Wiek.Size = New System.Drawing.Size(486, 26)
        Me.mtb_Wiek.TabIndex = 12
        Me.mtb_Wiek.ValidatingType = GetType(Integer)
        '
        'mtb_Telefon
        '
        Me.mtb_Telefon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mtb_Telefon.Location = New System.Drawing.Point(112, 106)
        Me.mtb_Telefon.Margin = New System.Windows.Forms.Padding(4)
        Me.mtb_Telefon.Mask = "000-000-000"
        Me.mtb_Telefon.Name = "mtb_Telefon"
        Me.mtb_Telefon.Size = New System.Drawing.Size(486, 26)
        Me.mtb_Telefon.TabIndex = 13
        '
        'mtb_AdresMeil
        '
        Me.mtb_AdresMeil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mtb_AdresMeil.Location = New System.Drawing.Point(112, 140)
        Me.mtb_AdresMeil.Margin = New System.Windows.Forms.Padding(4)
        Me.mtb_AdresMeil.Mask = "A@A.A"
        Me.mtb_AdresMeil.Name = "mtb_AdresMeil"
        Me.mtb_AdresMeil.Size = New System.Drawing.Size(486, 26)
        Me.mtb_AdresMeil.TabIndex = 14
        Me.mtb_AdresMeil.ValidatingType = GetType(Integer)
        '
        'frm_DaneKlienta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 649)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_DaneKlienta"
        Me.Text = "Dane Klienta"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_Nazwisko As TextBox
    Friend WithEvents tsb_NowyKlient As ToolStripButton
    Friend WithEvents tsb_Zapisz As ToolStripButton
    Friend WithEvents tsb_ZapiszDoPliku As ToolStripButton
    Friend WithEvents mtb_AdresMeil As MaskedTextBox
    Friend WithEvents mtb_Telefon As MaskedTextBox
    Friend WithEvents tb_Ankieta As TextBox
    Friend WithEvents tb_Imie As TextBox
    Friend WithEvents mtb_Wiek As MaskedTextBox
End Class
