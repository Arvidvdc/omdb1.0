Imports SARgELib
Imports System.IO
Imports System.Net
Imports System.Xml
Public Class frmOMDbSearch
    Dim SARgE As New SARgEFunctions
    Public Sub FillOMDb(ByVal ZoekType As Integer, ByVal ZoekTerm As String, Optional ByVal ZoekJaar As String = Nothing, Optional ByVal ZoekGroep As String = Nothing)
        Dim sourceFile As String = Nothing

        '-----Ophalen OMDb gegevens-----
        txtSerieNaam.Text = SARgE.OMDb(ZoekType, ZoekTerm, 0, ZoekJaar, ZoekGroep)
        txtActeurs.Text = SARgE.OMDb(ZoekType, ZoekTerm, 8, ZoekJaar, ZoekGroep)
        txtIMDBCijfer.Text = SARgE.OMDb(ZoekType, ZoekTerm, 15, ZoekJaar, ZoekGroep)
        txtUitgezonden.Text = SARgE.OMDb(ZoekType, ZoekTerm, 1, ZoekJaar, ZoekGroep)
        txtSpeelDuur.Text = SARgE.OMDb(ZoekType, ZoekTerm, 4, ZoekJaar, ZoekGroep)
        txtPlot.Text = SARgE.OMDb(ZoekType, ZoekTerm, 9, ZoekJaar, ZoekGroep)
        txtWebsite.Text = "http://www.imdb.com/title/" & SARgE.OMDb(ZoekType, ZoekTerm, 17, ZoekJaar, ZoekGroep)
        txtGenres.Text = SARgE.OMDb(ZoekType, ZoekTerm, 5, ZoekJaar, ZoekGroep)
        txtCountry.Text = SARgE.OMDb(ZoekType, ZoekTerm, 11, ZoekJaar, ZoekGroep)
        txtRegiseur.Text = SARgE.OMDb(ZoekType, ZoekTerm, 6, ZoekJaar, ZoekGroep)
        txtType.Text = SARgE.OMDb(ZoekType, ZoekTerm, 18, ZoekJaar, ZoekGroep)
        If SARgE.OMDb(ZoekType, ZoekTerm, 2, ZoekJaar, ZoekGroep).IndexOf("N/A") > -1 Then
            txtRating.Text = "NOT RATED"
        Else
            txtRating.Text = SARgE.OMDb(ZoekType, ZoekTerm, 2, ZoekJaar, ZoekGroep)
        End If
        If SARgE.OMDb(ZoekType, ZoekTerm, 10, ZoekJaar, ZoekGroep).IndexOf("English") > -1 Then
            txtTaal.Text = "Engels"
        ElseIf SARgE.OMDb(ZoekType, ZoekTerm, 10, ZoekJaar, ZoekGroep).IndexOf("Dutch") > -1 Then
            txtTaal.Text = "Nederlands"
        ElseIf SARgE.OMDb(ZoekType, ZoekTerm, 10, ZoekJaar, ZoekGroep).IndexOf("Danish") > -1 Then
            txtTaal.Text = "Deens"
        Else
            txtTaal.Text = SARgE.OMDb(ZoekType, ZoekTerm, 10, ZoekJaar, ZoekGroep)
        End If

        If SARgE.OMDb(ZoekType, ZoekTerm, 13, ZoekJaar, ZoekGroep) = "N/A" Then
            sourceFile = Nothing
        Else
            sourceFile = SARgE.OMDb(ZoekType, ZoekTerm, 13, ZoekJaar, ZoekGroep)
        End If

        If Not sourceFile = Nothing Then
            pbSerieImage.Visible = True
            pbSerieImage.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(sourceFile)))
            lblSourceFile.Text = sourceFile
            Me.Width = pbSerieImage.Right + 33
        Else
            pbSerieImage.Visible = False
            Me.Width = butSelect.Right + 33
        End If

    End Sub
    Private Sub frmOMDbSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pbSerieImage.Visible = False Then
            Me.Width = butSelect.Right + 33
            Me.Height = butSelect.Bottom + 55
        End If

        cmbZoekType.Items.Clear()
        cmbZoekType.Items.Add("Alle")
        cmbZoekType.Items.Add("Games")
        cmbZoekType.Items.Add("Movies")
        cmbZoekType.Items.Add("Series")

    End Sub

    Private Sub butZoek_Click(sender As Object, e As EventArgs) Handles butZoek.Click
        Dim i As Integer = Nothing          ' Random used counter
        Dim i2 As Integer = Nothing         ' Split used counter
        Dim sURL As String = Nothing        ' URL voor xml opvragen
        Dim sTitel As String = Nothing      ' Naam van de te zoeken serie
        Dim sType As String = Nothing       ' Type categorie opgeven

        '----- Opmaken URL strings -----
        sTitel = txtIMDbText.Text.Replace(" ", "+").Replace("&", "%26")

        Select Case UCase(cmbZoekType.Text)
            Case "ALLE"
                sType = Nothing
            Case "GAMES"
                sType = "&type=game"
            Case "MOVIES"
                sType = "&type=movie"
            Case "SERIES"
                sType = "&type=series"
            Case Else
                sType = Nothing
        End Select

        sURL = "http://www.omdbapi.com/?apikey=7ed4327f&s=" & sTitel & "&r=xml" & sType

        '----- Totaal hits opvragen -----
        Dim intTotaal As Integer = Nothing ' Voor vullen label resultaat.
        Dim strFeedBack As String = SARgE.GetResultCount(sURL)
        If strFeedBack.IndexOf("No Response") > -1 Then
            MsgBox("Geen resultaten gevonden met deze gegevens.")
            panInfo.Visible = False
            Me.Height = butSelect.Bottom + 55
            Exit Sub
        Else
            intTotaal = strFeedBack
            lblSearchNo.Text = intTotaal
        End If

        '----- Bepalen hoeveel pagina's -----
        Dim intLooping As Integer = Nothing  'Max couter voor pagina's doorlopen.
        Dim intInput As String = intTotaal / 10
        Dim strSplit = intInput.Split(",")
        If intInput.IndexOf(",") Then
            If strSplit(1) > 0 Then
                intLooping = strSplit(0) + 1
            Else
                intLooping = intTotaal / 10
            End If
        Else
            intLooping = intTotaal / 10
        End If

        '----- Ophalen alle records -----
        i = 1
        Do Until i = intLooping + 1
            sURL = "http://www.omdbapi.com/?apikey=7ed4327f&s=" & sTitel & "&r=xml&page=" & i & sType
            strFeedBack = SARgE.GetIMDbID(sURL)
            If strFeedBack.IndexOf("No Response") > -1 Then
                MsgBox("Geen resultaten gevonden met deze gegevens.")
                panInfo.Visible = False
                Me.Height = butSelect.Bottom + 55
                Exit Sub
            Else
                strSplit = strFeedBack.Split(";")
                i2 = 0
                Do Until i2 = strSplit.Count - 1
                    lbTempStore.Items.Add(strSplit(i2).ToString())
                    i2 += 1
                Loop
            End If
            i += 1
        Loop

        '----- Afhandeling -----
        lblResultaat.Text = "Record 01 van " & lblSearchNo.Text
        panInfo.Visible = True
        Me.Height = panInfo.Bottom + 55
        lbTempStore.SelectedIndex = 0
        Call FillOMDb(1, lbTempStore.Text)
        butPrevious.Enabled = False
        'butSelect.Visible = True
        butOpnieuw.Visible = True

    End Sub

    Private Sub lbTempStore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTempStore.SelectedIndexChanged
        Call FillOMDb(1, lbTempStore.Text)
        If lbTempStore.SelectedIndex >= lbTempStore.Items.Count - 1 Then
            butNext.Enabled = False
        Else
            butNext.Enabled = True
        End If
        If lbTempStore.SelectedIndex <= 0 Then
            butPrevious.Enabled = False
        Else
            butPrevious.Enabled = True
        End If
        lblResultaat.Text = "Resultaat " & lbTempStore.SelectedIndex + 1 & " van " & lblSearchNo.Text
    End Sub

    Private Sub butNext_Click(sender As Object, e As EventArgs) Handles butNext.Click
        lbTempStore.SelectedIndex = lbTempStore.SelectedIndex + 1
    End Sub

    Private Sub butPrevious_Click(sender As Object, e As EventArgs) Handles butPrevious.Click
        lbTempStore.SelectedIndex = lbTempStore.SelectedIndex - 1
    End Sub

    Private Sub butSwitch_Click(sender As Object, e As EventArgs) Handles butSwitch.Click
        Select Case butSwitch.Text
            Case "Seizoen"
                '----- Standaard instellingen -----
                panInfo.Visible = False
                panSeasons.Visible = True
                panSeasons.Location = panInfo.Location
                panSeasons.Height = 396
                butSwitch.Text = "Serie"

                '----- Variabelen vullen -----
                lblAfleveringNaam.Text = "Aflevering"
                lblAfleveringNummer.Text = "Nr."
                lblAfleveringDatum.Text = "Uitgezonden"
                lblAfleveringRating.Text = "Cijfer"
                lblSerieTitel.Text = txtSerieNaam.Text
                Dim intSeasonNo As Integer = SARgE.GetSeasonInfo(1, lbTempStore.Text, 1)
                Dim i As Integer = 1
                cmbSeason.Text = Nothing
                cmbSeason.Items.Clear()
                Do Until i = intSeasonNo + 1
                    If i <= 9 Then
                        cmbSeason.Items.Add("Seizoen 0" & i)
                    Else
                        cmbSeason.Items.Add("Seizoen " & i)
                    End If
                    i += 1
                Loop
            Case "Serie"
                panInfo.Visible = True
                panSeasons.Visible = False
                butSwitch.Text = "Seizoen"
        End Select

    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        If UCase(txtType.Text) = "SERIES" Then
            butSwitch.Visible = True
            butSwitch.Text = "Seizoen"
        Else
            butSwitch.Visible = False
        End If
    End Sub

    Private Sub ButChrome_Click(sender As Object, e As EventArgs) Handles ButChrome.Click
        Process.Start("Chrome", txtWebsite.Text)
    End Sub

    Private Sub cmbSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSeason.SelectedIndexChanged
        If cmbSeason.Text = "" Then Exit Sub
        Dim strSplit = cmbSeason.Text.Split(" ")
        Dim intSeasonNo As Integer = strSplit(1)

        Dim strTitel = SARgE.GetSeasonList(1, lbTempStore.Text, intSeasonNo, 0)
        Dim strEpisodeNo = SARgE.GetSeasonList(1, lbTempStore.Text, intSeasonNo, 2)
        Dim strDatum = SARgE.GetSeasonList(1, lbTempStore.Text, intSeasonNo, 1)
        Dim strRating = SARgE.GetSeasonList(1, lbTempStore.Text, intSeasonNo, 3)

        lblAfleveringNaam.Text = "Aflevering" & vbCrLf
        Dim i As Integer = 0
        strSplit = strTitel.Split(";")
        i = 0
        Do Until i = strSplit.Count
            lblAfleveringNaam.Text += strSplit(i).ToString() & vbCrLf
            i = i + 1
        Loop

        lblAfleveringNummer.Text = "Nr." & vbCrLf
        strSplit = strEpisodeNo.Split(";")
        i = 0
        Do Until i = strSplit.Count
            lblAfleveringNummer.Text += strSplit(i).ToString() & vbCrLf
            i = i + 1
        Loop

        lblAfleveringDatum.Text = "Uitgezonden" & vbCrLf
        strSplit = strDatum.Split(";")
        i = 0
        Do Until i = strSplit.Count
            lblAfleveringDatum.Text += strSplit(i).ToString() & vbCrLf
            i = i + 1
        Loop

        lblAfleveringRating.Text = "Cijfer" & vbCrLf
        strSplit = strRating.Split(";")
        i = 0
        Do Until i = strSplit.Count
            lblAfleveringRating.Text += strSplit(i).ToString() & vbCrLf
            i = i + 1
        Loop

        lblAfleveringNaam.Location = New Point(lblAfleveringNummer.Right + 5, lblAfleveringNummer.Top)
        lblAfleveringDatum.Location = New Point(lblAfleveringNaam.Right + 5, lblAfleveringNaam.Top)
        lblAfleveringRating.Location = New Point(lblAfleveringDatum.Right + 5, lblAfleveringDatum.Top)
    End Sub

    Private Sub butOpnieuw_Click(sender As Object, e As EventArgs) Handles butOpnieuw.Click
        butOpnieuw.Visible = False
        butSwitch.Visible = False
        txtIMDbText.Clear()
        cmbZoekType.Text = Nothing
        lbTempStore.Items.Clear()
        lbTempStore.Text = Nothing
        panInfo.Visible = True
        pbSerieImage.Image = Nothing
        pbSerieImage.Visible = False
        Me.Width = butSelect.Right + 33
        Me.Height = butSelect.Bottom + 55
    End Sub
End Class