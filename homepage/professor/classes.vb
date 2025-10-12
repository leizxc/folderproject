


Public Class classes
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub BackToMainPanel(ByVal sender As Object, ByVal e As EventArgs)
        Panel1.Controls.Clear()

        ' Ibalik yung original controls (ListBox1, ListBox2, Enter Button, etc.)
        Panel1.Controls.Add(ListBox1)
        Panel1.Controls.Add(ListBox2)
        Panel1.Controls.Add(btnEnter)
        ' idagdag lahat ng controls na nasa Panel1 dati
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        ' Check selections
        If ListBox1.SelectedIndex = -1 Or ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please select both Course and Year Level!")
            Exit Sub
        End If

        Dim course As String = ListBox1.SelectedItem.ToString()
        Dim yearLevel As String = ListBox2.SelectedItem.ToString()

        ' Clear previous controls sa Panel
        Panel1.Controls.Clear()
        Panel1.Visible = True

        ' Example condition: BSIT + 1ST YEAR
        If course = "BSIT" And yearLevel = "1ST YEAR" Then
            Dim uc As New UC_BSIS1ST()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)

            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


            ' Halimbawa, BSIT + 2ND YEAR
        ElseIf course = "BSIT" And yearLevel = "2ND YEAR" Then
            Dim uc As New UC_BSIT2ND()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)

            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIT" And yearLevel = "3RD YEAR" Then
            Dim uc As New UC_BSIS3RD()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)

            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIT" And yearLevel = "4TH YEAR" Then
            Dim uc As New UC_BSIS4TH
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSCS" And yearLevel = "1ST YEAR" Then
            Dim uc As New SC_BSCS1ST()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSCS" And yearLevel = "2ND YEAR" Then
            Dim uc As New UC_BSCS2ND()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSCS" And yearLevel = "3RD YEAR" Then
            Dim uc As New UC_BSCS3RD()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSCS" And yearLevel = "4TH YEAR" Then
            Dim uc As New UC_BSCS4TH()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIS" And yearLevel = "1ST YEAR" Then
            Dim uc As New UC_BSIS1ST()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIS" And yearLevel = "2ND YEAR" Then
            Dim uc As New UC_BSIS2ND()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSIS" And yearLevel = "3RD YEAR" Then
            Dim uc As New UC_BSIS3RD()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIS" And yearLevel = "4TH YEAR" Then
            Dim uc As New UC_BSIS4TH()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSCE" And yearLevel = "1ST YEAR" Then
            Dim uc As New UC_BSCE1ST()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSCE" And yearLevel = "2ND YEAR" Then
            Dim uc As New UC_BSCE2ND()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSCE" And yearLevel = "3RD YEAR" Then
            Dim uc As New UC_BSCE3RD()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSCE" And yearLevel = "4TH YEAR" Then
            Dim uc As New UC_BSCE4TH()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSMA" And yearLevel = "1ST YEAR" Then
            Dim uc As New UC_BSMA1ST()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSMA" And yearLevel = "2ND YEAR" Then
            Dim uc As New UC_BSMA2ND()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSMA" And yearLevel = "3RD YEAR" Then
            Dim uc As New UC_BSMA3RD()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSMA" And yearLevel = "4TH YEAR" Then
            Dim uc As New UC_BSMA4TH()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        Else
            ' Default message kung wala pang UserControl
            Dim lbl As New Label()
            lbl.Text = "No UserControl available for " & course & " - " & yearLevel
            lbl.Dock = DockStyle.Fill
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.Font = New Font("Arial", 14, FontStyle.Bold)
            Panel1.Controls.Add(lbl)
        End If
    End Sub

    ' Optional handlers kung gusto mong may dagdag na action kapag pinili ang isang item
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Pwedeng dagdagan kung gusto mong mag-react agad pag nagselect ng Course
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        ' Pwedeng dagdagan kung gusto mong mag-react agad pag nagselect ng Year Level
    End Sub
End Class
