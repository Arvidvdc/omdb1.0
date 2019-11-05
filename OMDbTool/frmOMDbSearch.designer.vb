<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOMDbSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOMDbSearch))
        Me.pbSerieImage = New System.Windows.Forms.PictureBox()
        Me.txtIMDbText = New System.Windows.Forms.TextBox()
        Me.lblOMDbText = New System.Windows.Forms.Label()
        Me.lblZoekType = New System.Windows.Forms.Label()
        Me.cmbZoekType = New System.Windows.Forms.ComboBox()
        Me.butZoek = New System.Windows.Forms.Button()
        Me.butSelect = New System.Windows.Forms.Button()
        Me.panInfo = New System.Windows.Forms.Panel()
        Me.txtPlot = New System.Windows.Forms.TextBox()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.txtRegiseur = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtTaal = New System.Windows.Forms.TextBox()
        Me.txtGenres = New System.Windows.Forms.TextBox()
        Me.lblTaal = New System.Windows.Forms.Label()
        Me.lblGenres = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblRegiseur = New System.Windows.Forms.Label()
        Me.txtSpeelDuur = New System.Windows.Forms.TextBox()
        Me.lblSpeelDuur = New System.Windows.Forms.Label()
        Me.txtUitgezonden = New System.Windows.Forms.TextBox()
        Me.lblUitgezonden = New System.Windows.Forms.Label()
        Me.txtIMDBCijfer = New System.Windows.Forms.TextBox()
        Me.lblIMDBCijfer = New System.Windows.Forms.Label()
        Me.txtActeurs = New System.Windows.Forms.TextBox()
        Me.lblActeurs = New System.Windows.Forms.Label()
        Me.ButChrome = New System.Windows.Forms.Button()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.lblSerieNaam = New System.Windows.Forms.Label()
        Me.txtSerieNaam = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblResultaat = New System.Windows.Forms.Label()
        Me.butPrevious = New System.Windows.Forms.Button()
        Me.butNext = New System.Windows.Forms.Button()
        Me.lbTempStore = New System.Windows.Forms.ListBox()
        Me.lblSearchNo = New System.Windows.Forms.Label()
        Me.lblSourceFile = New System.Windows.Forms.Label()
        Me.panSeasons = New System.Windows.Forms.Panel()
        Me.lblAfleveringRating = New System.Windows.Forms.Label()
        Me.lblAfleveringDatum = New System.Windows.Forms.Label()
        Me.lblAfleveringNummer = New System.Windows.Forms.Label()
        Me.lblAfleveringNaam = New System.Windows.Forms.Label()
        Me.lblSerieTitel = New System.Windows.Forms.Label()
        Me.cmbSeason = New System.Windows.Forms.ComboBox()
        Me.lblChooseSeason = New System.Windows.Forms.Label()
        Me.butSwitch = New System.Windows.Forms.Button()
        Me.butOpnieuw = New System.Windows.Forms.Button()
        CType(Me.pbSerieImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panInfo.SuspendLayout()
        Me.panSeasons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbSerieImage
        '
        Me.pbSerieImage.Location = New System.Drawing.Point(532, 67)
        Me.pbSerieImage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbSerieImage.Name = "pbSerieImage"
        Me.pbSerieImage.Size = New System.Drawing.Size(279, 396)
        Me.pbSerieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSerieImage.TabIndex = 195
        Me.pbSerieImage.TabStop = False
        Me.pbSerieImage.Visible = False
        '
        'txtIMDbText
        '
        Me.txtIMDbText.Location = New System.Drawing.Point(177, 3)
        Me.txtIMDbText.Name = "txtIMDbText"
        Me.txtIMDbText.Size = New System.Drawing.Size(161, 22)
        Me.txtIMDbText.TabIndex = 196
        '
        'lblOMDbText
        '
        Me.lblOMDbText.AutoSize = True
        Me.lblOMDbText.Location = New System.Drawing.Point(28, 6)
        Me.lblOMDbText.Name = "lblOMDbText"
        Me.lblOMDbText.Size = New System.Drawing.Size(79, 17)
        Me.lblOMDbText.TabIndex = 197
        Me.lblOMDbText.Text = "Zoeknaam:"
        '
        'lblZoekType
        '
        Me.lblZoekType.AutoSize = True
        Me.lblZoekType.Location = New System.Drawing.Point(28, 34)
        Me.lblZoekType.Name = "lblZoekType"
        Me.lblZoekType.Size = New System.Drawing.Size(71, 17)
        Me.lblZoekType.TabIndex = 198
        Me.lblZoekType.Text = "Zoektype:"
        '
        'cmbZoekType
        '
        Me.cmbZoekType.FormattingEnabled = True
        Me.cmbZoekType.Location = New System.Drawing.Point(177, 31)
        Me.cmbZoekType.Name = "cmbZoekType"
        Me.cmbZoekType.Size = New System.Drawing.Size(161, 24)
        Me.cmbZoekType.TabIndex = 199
        '
        'butZoek
        '
        Me.butZoek.Location = New System.Drawing.Point(444, 2)
        Me.butZoek.Name = "butZoek"
        Me.butZoek.Size = New System.Drawing.Size(82, 25)
        Me.butZoek.TabIndex = 224
        Me.butZoek.Text = "Zoeken"
        Me.butZoek.UseVisualStyleBackColor = True
        '
        'butSelect
        '
        Me.butSelect.Location = New System.Drawing.Point(444, 33)
        Me.butSelect.Name = "butSelect"
        Me.butSelect.Size = New System.Drawing.Size(82, 25)
        Me.butSelect.TabIndex = 228
        Me.butSelect.Text = "selecteren"
        Me.butSelect.UseVisualStyleBackColor = True
        Me.butSelect.Visible = False
        '
        'panInfo
        '
        Me.panInfo.Controls.Add(Me.txtPlot)
        Me.panInfo.Controls.Add(Me.lblRating)
        Me.panInfo.Controls.Add(Me.txtRating)
        Me.panInfo.Controls.Add(Me.txtRegiseur)
        Me.panInfo.Controls.Add(Me.txtCountry)
        Me.panInfo.Controls.Add(Me.txtTaal)
        Me.panInfo.Controls.Add(Me.txtGenres)
        Me.panInfo.Controls.Add(Me.lblTaal)
        Me.panInfo.Controls.Add(Me.lblGenres)
        Me.panInfo.Controls.Add(Me.lblCountry)
        Me.panInfo.Controls.Add(Me.lblRegiseur)
        Me.panInfo.Controls.Add(Me.txtSpeelDuur)
        Me.panInfo.Controls.Add(Me.lblSpeelDuur)
        Me.panInfo.Controls.Add(Me.txtUitgezonden)
        Me.panInfo.Controls.Add(Me.lblUitgezonden)
        Me.panInfo.Controls.Add(Me.txtIMDBCijfer)
        Me.panInfo.Controls.Add(Me.lblIMDBCijfer)
        Me.panInfo.Controls.Add(Me.txtActeurs)
        Me.panInfo.Controls.Add(Me.lblActeurs)
        Me.panInfo.Controls.Add(Me.ButChrome)
        Me.panInfo.Controls.Add(Me.txtWebsite)
        Me.panInfo.Controls.Add(Me.lblWebsite)
        Me.panInfo.Controls.Add(Me.lblSerieNaam)
        Me.panInfo.Controls.Add(Me.txtSerieNaam)
        Me.panInfo.Controls.Add(Me.txtType)
        Me.panInfo.Controls.Add(Me.lblType)
        Me.panInfo.Controls.Add(Me.lblResultaat)
        Me.panInfo.Controls.Add(Me.butPrevious)
        Me.panInfo.Controls.Add(Me.butNext)
        Me.panInfo.Location = New System.Drawing.Point(12, 67)
        Me.panInfo.Name = "panInfo"
        Me.panInfo.Size = New System.Drawing.Size(514, 396)
        Me.panInfo.TabIndex = 229
        Me.panInfo.Visible = False
        '
        'txtPlot
        '
        Me.txtPlot.AcceptsReturn = True
        Me.txtPlot.Location = New System.Drawing.Point(19, 240)
        Me.txtPlot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPlot.Multiline = True
        Me.txtPlot.Name = "txtPlot"
        Me.txtPlot.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPlot.Size = New System.Drawing.Size(491, 104)
        Me.txtPlot.TabIndex = 279
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(313, 128)
        Me.lblRating.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(86, 17)
        Me.lblRating.TabIndex = 278
        Me.lblRating.Text = "Classificatie:"
        '
        'txtRating
        '
        Me.txtRating.Location = New System.Drawing.Point(407, 123)
        Me.txtRating.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(103, 22)
        Me.txtRating.TabIndex = 277
        '
        'txtRegiseur
        '
        Me.txtRegiseur.Location = New System.Drawing.Point(165, 125)
        Me.txtRegiseur.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegiseur.Name = "txtRegiseur"
        Me.txtRegiseur.Size = New System.Drawing.Size(131, 22)
        Me.txtRegiseur.TabIndex = 276
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(407, 93)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(103, 22)
        Me.txtCountry.TabIndex = 275
        '
        'txtTaal
        '
        Me.txtTaal.Location = New System.Drawing.Point(165, 93)
        Me.txtTaal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTaal.Name = "txtTaal"
        Me.txtTaal.Size = New System.Drawing.Size(131, 22)
        Me.txtTaal.TabIndex = 274
        '
        'txtGenres
        '
        Me.txtGenres.Location = New System.Drawing.Point(165, 63)
        Me.txtGenres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGenres.Name = "txtGenres"
        Me.txtGenres.Size = New System.Drawing.Size(345, 22)
        Me.txtGenres.TabIndex = 273
        '
        'lblTaal
        '
        Me.lblTaal.AutoSize = True
        Me.lblTaal.Location = New System.Drawing.Point(16, 96)
        Me.lblTaal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaal.Name = "lblTaal"
        Me.lblTaal.Size = New System.Drawing.Size(109, 17)
        Me.lblTaal.TabIndex = 272
        Me.lblTaal.Text = "Gesproken taal:"
        '
        'lblGenres
        '
        Me.lblGenres.AutoSize = True
        Me.lblGenres.Location = New System.Drawing.Point(16, 66)
        Me.lblGenres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenres.Name = "lblGenres"
        Me.lblGenres.Size = New System.Drawing.Size(59, 17)
        Me.lblGenres.TabIndex = 271
        Me.lblGenres.Text = "Genres:"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(313, 96)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(84, 17)
        Me.lblCountry.TabIndex = 270
        Me.lblCountry.Text = "Gemaakt in:"
        '
        'lblRegiseur
        '
        Me.lblRegiseur.AutoSize = True
        Me.lblRegiseur.Location = New System.Drawing.Point(16, 126)
        Me.lblRegiseur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegiseur.Name = "lblRegiseur"
        Me.lblRegiseur.Size = New System.Drawing.Size(93, 17)
        Me.lblRegiseur.TabIndex = 269
        Me.lblRegiseur.Text = "Regisseur(s):"
        '
        'txtSpeelDuur
        '
        Me.txtSpeelDuur.Location = New System.Drawing.Point(451, 33)
        Me.txtSpeelDuur.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSpeelDuur.Name = "txtSpeelDuur"
        Me.txtSpeelDuur.Size = New System.Drawing.Size(59, 22)
        Me.txtSpeelDuur.TabIndex = 268
        '
        'lblSpeelDuur
        '
        Me.lblSpeelDuur.AutoSize = True
        Me.lblSpeelDuur.Location = New System.Drawing.Point(370, 36)
        Me.lblSpeelDuur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpeelDuur.Name = "lblSpeelDuur"
        Me.lblSpeelDuur.Size = New System.Drawing.Size(73, 17)
        Me.lblSpeelDuur.TabIndex = 267
        Me.lblSpeelDuur.Text = "Speelduur"
        '
        'txtUitgezonden
        '
        Me.txtUitgezonden.Location = New System.Drawing.Point(165, 33)
        Me.txtUitgezonden.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUitgezonden.Name = "txtUitgezonden"
        Me.txtUitgezonden.Size = New System.Drawing.Size(106, 22)
        Me.txtUitgezonden.TabIndex = 266
        '
        'lblUitgezonden
        '
        Me.lblUitgezonden.AutoSize = True
        Me.lblUitgezonden.Location = New System.Drawing.Point(16, 36)
        Me.lblUitgezonden.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUitgezonden.Name = "lblUitgezonden"
        Me.lblUitgezonden.Size = New System.Drawing.Size(88, 17)
        Me.lblUitgezonden.TabIndex = 265
        Me.lblUitgezonden.Text = "Uitgezonden"
        '
        'txtIMDBCijfer
        '
        Me.txtIMDBCijfer.Location = New System.Drawing.Point(327, 33)
        Me.txtIMDBCijfer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIMDBCijfer.Name = "txtIMDBCijfer"
        Me.txtIMDBCijfer.Size = New System.Drawing.Size(35, 22)
        Me.txtIMDBCijfer.TabIndex = 264
        '
        'lblIMDBCijfer
        '
        Me.lblIMDBCijfer.AutoSize = True
        Me.lblIMDBCijfer.Location = New System.Drawing.Point(279, 36)
        Me.lblIMDBCijfer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIMDBCijfer.Name = "lblIMDBCijfer"
        Me.lblIMDBCijfer.Size = New System.Drawing.Size(40, 17)
        Me.lblIMDBCijfer.TabIndex = 263
        Me.lblIMDBCijfer.Text = "Cijfer"
        '
        'txtActeurs
        '
        Me.txtActeurs.Location = New System.Drawing.Point(165, 185)
        Me.txtActeurs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtActeurs.Name = "txtActeurs"
        Me.txtActeurs.Size = New System.Drawing.Size(345, 22)
        Me.txtActeurs.TabIndex = 262
        '
        'lblActeurs
        '
        Me.lblActeurs.AutoSize = True
        Me.lblActeurs.Location = New System.Drawing.Point(16, 188)
        Me.lblActeurs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActeurs.Name = "lblActeurs"
        Me.lblActeurs.Size = New System.Drawing.Size(56, 17)
        Me.lblActeurs.TabIndex = 261
        Me.lblActeurs.Text = "Acteurs"
        '
        'ButChrome
        '
        Me.ButChrome.BackgroundImage = Global.OMDbTool.My.Resources.Resources.Google_Chrome
        Me.ButChrome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButChrome.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButChrome.Location = New System.Drawing.Point(483, 211)
        Me.ButChrome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButChrome.Name = "ButChrome"
        Me.ButChrome.Size = New System.Drawing.Size(27, 25)
        Me.ButChrome.TabIndex = 259
        Me.ButChrome.UseVisualStyleBackColor = True
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(165, 213)
        Me.txtWebsite.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(312, 22)
        Me.txtWebsite.TabIndex = 258
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(16, 215)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(106, 17)
        Me.lblWebsite.TabIndex = 257
        Me.lblWebsite.Text = "Website (IMDB)"
        '
        'lblSerieNaam
        '
        Me.lblSerieNaam.AutoSize = True
        Me.lblSerieNaam.Location = New System.Drawing.Point(16, 8)
        Me.lblSerieNaam.Name = "lblSerieNaam"
        Me.lblSerieNaam.Size = New System.Drawing.Size(127, 17)
        Me.lblSerieNaam.TabIndex = 260
        Me.lblSerieNaam.Text = "Naam van de serie"
        '
        'txtSerieNaam
        '
        Me.txtSerieNaam.Location = New System.Drawing.Point(165, 5)
        Me.txtSerieNaam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSerieNaam.Name = "txtSerieNaam"
        Me.txtSerieNaam.Size = New System.Drawing.Size(345, 22)
        Me.txtSerieNaam.TabIndex = 256
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(165, 155)
        Me.txtType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(131, 22)
        Me.txtType.TabIndex = 255
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(16, 158)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(40, 17)
        Me.lblType.TabIndex = 254
        Me.lblType.Text = "Type"
        '
        'lblResultaat
        '
        Me.lblResultaat.AutoSize = True
        Me.lblResultaat.Location = New System.Drawing.Point(167, 355)
        Me.lblResultaat.Name = "lblResultaat"
        Me.lblResultaat.Size = New System.Drawing.Size(143, 17)
        Me.lblResultaat.TabIndex = 253
        Me.lblResultaat.Text = "Resultaat 01 van 100"
        '
        'butPrevious
        '
        Me.butPrevious.Location = New System.Drawing.Point(66, 349)
        Me.butPrevious.Name = "butPrevious"
        Me.butPrevious.Size = New System.Drawing.Size(95, 29)
        Me.butPrevious.TabIndex = 252
        Me.butPrevious.Text = "Vorige"
        Me.butPrevious.UseVisualStyleBackColor = True
        '
        'butNext
        '
        Me.butNext.Location = New System.Drawing.Point(316, 349)
        Me.butNext.Name = "butNext"
        Me.butNext.Size = New System.Drawing.Size(95, 29)
        Me.butNext.TabIndex = 251
        Me.butNext.Text = "Volgende"
        Me.butNext.UseVisualStyleBackColor = True
        '
        'lbTempStore
        '
        Me.lbTempStore.FormattingEnabled = True
        Me.lbTempStore.ItemHeight = 16
        Me.lbTempStore.Location = New System.Drawing.Point(12, 469)
        Me.lbTempStore.Name = "lbTempStore"
        Me.lbTempStore.Size = New System.Drawing.Size(149, 180)
        Me.lbTempStore.TabIndex = 230
        Me.lbTempStore.Visible = False
        '
        'lblSearchNo
        '
        Me.lblSearchNo.AutoSize = True
        Me.lblSearchNo.Location = New System.Drawing.Point(167, 469)
        Me.lblSearchNo.Name = "lblSearchNo"
        Me.lblSearchNo.Size = New System.Drawing.Size(71, 17)
        Me.lblSearchNo.TabIndex = 231
        Me.lblSearchNo.Text = "SearchNo"
        Me.lblSearchNo.Visible = False
        '
        'lblSourceFile
        '
        Me.lblSourceFile.AutoSize = True
        Me.lblSourceFile.Location = New System.Drawing.Point(167, 486)
        Me.lblSourceFile.Name = "lblSourceFile"
        Me.lblSourceFile.Size = New System.Drawing.Size(75, 17)
        Me.lblSourceFile.TabIndex = 232
        Me.lblSourceFile.Text = "SourceFile"
        Me.lblSourceFile.Visible = False
        '
        'panSeasons
        '
        Me.panSeasons.AutoScroll = True
        Me.panSeasons.Controls.Add(Me.lblAfleveringRating)
        Me.panSeasons.Controls.Add(Me.lblAfleveringDatum)
        Me.panSeasons.Controls.Add(Me.lblAfleveringNummer)
        Me.panSeasons.Controls.Add(Me.lblAfleveringNaam)
        Me.panSeasons.Controls.Add(Me.lblSerieTitel)
        Me.panSeasons.Controls.Add(Me.cmbSeason)
        Me.panSeasons.Controls.Add(Me.lblChooseSeason)
        Me.panSeasons.Location = New System.Drawing.Point(297, 469)
        Me.panSeasons.Name = "panSeasons"
        Me.panSeasons.Size = New System.Drawing.Size(514, 214)
        Me.panSeasons.TabIndex = 233
        '
        'lblAfleveringRating
        '
        Me.lblAfleveringRating.AutoSize = True
        Me.lblAfleveringRating.Location = New System.Drawing.Point(378, 66)
        Me.lblAfleveringRating.Name = "lblAfleveringRating"
        Me.lblAfleveringRating.Size = New System.Drawing.Size(112, 17)
        Me.lblAfleveringRating.TabIndex = 7
        Me.lblAfleveringRating.Text = "AfleveringRating"
        '
        'lblAfleveringDatum
        '
        Me.lblAfleveringDatum.AutoSize = True
        Me.lblAfleveringDatum.Location = New System.Drawing.Point(260, 66)
        Me.lblAfleveringDatum.Name = "lblAfleveringDatum"
        Me.lblAfleveringDatum.Size = New System.Drawing.Size(112, 17)
        Me.lblAfleveringDatum.TabIndex = 6
        Me.lblAfleveringDatum.Text = "AfleveringDatum"
        '
        'lblAfleveringNummer
        '
        Me.lblAfleveringNummer.AutoSize = True
        Me.lblAfleveringNummer.Location = New System.Drawing.Point(16, 66)
        Me.lblAfleveringNummer.Name = "lblAfleveringNummer"
        Me.lblAfleveringNummer.Size = New System.Drawing.Size(124, 17)
        Me.lblAfleveringNummer.TabIndex = 5
        Me.lblAfleveringNummer.Text = "AfleveringNummer"
        '
        'lblAfleveringNaam
        '
        Me.lblAfleveringNaam.AutoSize = True
        Me.lblAfleveringNaam.Location = New System.Drawing.Point(146, 66)
        Me.lblAfleveringNaam.Name = "lblAfleveringNaam"
        Me.lblAfleveringNaam.Size = New System.Drawing.Size(108, 17)
        Me.lblAfleveringNaam.TabIndex = 4
        Me.lblAfleveringNaam.Text = "AfleveringNaam"
        '
        'lblSerieTitel
        '
        Me.lblSerieTitel.AutoSize = True
        Me.lblSerieTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerieTitel.Location = New System.Drawing.Point(16, 8)
        Me.lblSerieTitel.Name = "lblSerieTitel"
        Me.lblSerieTitel.Size = New System.Drawing.Size(73, 17)
        Me.lblSerieTitel.TabIndex = 2
        Me.lblSerieTitel.Text = "Serietitel"
        '
        'cmbSeason
        '
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.Location = New System.Drawing.Point(165, 33)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(121, 24)
        Me.cmbSeason.TabIndex = 1
        '
        'lblChooseSeason
        '
        Me.lblChooseSeason.AutoSize = True
        Me.lblChooseSeason.Location = New System.Drawing.Point(16, 36)
        Me.lblChooseSeason.Name = "lblChooseSeason"
        Me.lblChooseSeason.Size = New System.Drawing.Size(116, 17)
        Me.lblChooseSeason.TabIndex = 0
        Me.lblChooseSeason.Text = "Kies een seizoen"
        '
        'butSwitch
        '
        Me.butSwitch.Location = New System.Drawing.Point(356, 33)
        Me.butSwitch.Name = "butSwitch"
        Me.butSwitch.Size = New System.Drawing.Size(82, 25)
        Me.butSwitch.TabIndex = 234
        Me.butSwitch.Text = "Seizoen"
        Me.butSwitch.UseVisualStyleBackColor = True
        Me.butSwitch.Visible = False
        '
        'butOpnieuw
        '
        Me.butOpnieuw.Location = New System.Drawing.Point(356, 2)
        Me.butOpnieuw.Name = "butOpnieuw"
        Me.butOpnieuw.Size = New System.Drawing.Size(82, 25)
        Me.butOpnieuw.TabIndex = 235
        Me.butOpnieuw.Text = "Opnieuw"
        Me.butOpnieuw.UseVisualStyleBackColor = True
        Me.butOpnieuw.Visible = False
        '
        'frmOMDbSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 695)
        Me.Controls.Add(Me.butOpnieuw)
        Me.Controls.Add(Me.butSwitch)
        Me.Controls.Add(Me.panSeasons)
        Me.Controls.Add(Me.lblSourceFile)
        Me.Controls.Add(Me.lblSearchNo)
        Me.Controls.Add(Me.lbTempStore)
        Me.Controls.Add(Me.panInfo)
        Me.Controls.Add(Me.butSelect)
        Me.Controls.Add(Me.butZoek)
        Me.Controls.Add(Me.cmbZoekType)
        Me.Controls.Add(Me.lblZoekType)
        Me.Controls.Add(Me.lblOMDbText)
        Me.Controls.Add(Me.txtIMDbText)
        Me.Controls.Add(Me.pbSerieImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOMDbSearch"
        Me.Text = "frmOMDbSearch"
        CType(Me.pbSerieImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panInfo.ResumeLayout(False)
        Me.panInfo.PerformLayout()
        Me.panSeasons.ResumeLayout(False)
        Me.panSeasons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbSerieImage As System.Windows.Forms.PictureBox
    Friend WithEvents txtIMDbText As System.Windows.Forms.TextBox
    Friend WithEvents lblOMDbText As System.Windows.Forms.Label
    Friend WithEvents lblZoekType As System.Windows.Forms.Label
    Friend WithEvents cmbZoekType As System.Windows.Forms.ComboBox
    Friend WithEvents butZoek As System.Windows.Forms.Button
    Friend WithEvents butSelect As System.Windows.Forms.Button
    Friend WithEvents panInfo As System.Windows.Forms.Panel
    Friend WithEvents lblResultaat As System.Windows.Forms.Label
    Friend WithEvents butPrevious As System.Windows.Forms.Button
    Friend WithEvents butNext As System.Windows.Forms.Button
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lbTempStore As System.Windows.Forms.ListBox
    Friend WithEvents lblSearchNo As System.Windows.Forms.Label
    Friend WithEvents txtSpeelDuur As System.Windows.Forms.TextBox
    Friend WithEvents lblSpeelDuur As System.Windows.Forms.Label
    Friend WithEvents txtUitgezonden As System.Windows.Forms.TextBox
    Friend WithEvents lblUitgezonden As System.Windows.Forms.Label
    Friend WithEvents txtIMDBCijfer As System.Windows.Forms.TextBox
    Friend WithEvents lblIMDBCijfer As System.Windows.Forms.Label
    Friend WithEvents txtActeurs As System.Windows.Forms.TextBox
    Friend WithEvents lblActeurs As System.Windows.Forms.Label
    Friend WithEvents ButChrome As System.Windows.Forms.Button
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents lblWebsite As System.Windows.Forms.Label
    Friend WithEvents lblSerieNaam As System.Windows.Forms.Label
    Friend WithEvents txtSerieNaam As System.Windows.Forms.TextBox
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents txtRating As System.Windows.Forms.TextBox
    Friend WithEvents txtRegiseur As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtTaal As System.Windows.Forms.TextBox
    Friend WithEvents txtGenres As System.Windows.Forms.TextBox
    Friend WithEvents lblTaal As System.Windows.Forms.Label
    Friend WithEvents lblGenres As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblRegiseur As System.Windows.Forms.Label
    Friend WithEvents txtPlot As System.Windows.Forms.TextBox
    Friend WithEvents lblSourceFile As System.Windows.Forms.Label
    Friend WithEvents panSeasons As System.Windows.Forms.Panel
    Friend WithEvents butSwitch As System.Windows.Forms.Button
    Friend WithEvents lblAfleveringRating As System.Windows.Forms.Label
    Friend WithEvents lblAfleveringDatum As System.Windows.Forms.Label
    Friend WithEvents lblAfleveringNummer As System.Windows.Forms.Label
    Friend WithEvents lblAfleveringNaam As System.Windows.Forms.Label
    Friend WithEvents lblSerieTitel As System.Windows.Forms.Label
    Friend WithEvents cmbSeason As System.Windows.Forms.ComboBox
    Friend WithEvents lblChooseSeason As System.Windows.Forms.Label
    Friend WithEvents butOpnieuw As System.Windows.Forms.Button
End Class
