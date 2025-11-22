Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class register
    Dim connstring As String = "server = 127.0.0.1; userid = root; password =; database = database_panel; port = 3306"

    Public Function md5fromstring(ByVal source As String) As String
        Dim sb As New StringBuilder()
        Dim bytes() As Byte
        If String.IsNullOrEmpty(source) Then

            Throw New ArgumentNullException()
        End If

        bytes = Encoding.Default.GetBytes(source)
        bytes = MD5.Create().ComputeHash(bytes)
        For Each b As Byte In bytes
            sb.Append(b.ToString("x2"))
        Next
        Return sb.ToString()
    End Function

    Private Sub register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Maximize window on load
        Me.WindowState = FormWindowState.Maximized

        ' Hide password characters
        pass.UseSystemPasswordChar = True

        ' Try to connect and get the latest ID from the account table
        Try
            Dim conn As New MySqlConnection(connstring)
            conn.Open()

            ' Get the highest existing ID from the account table
            Dim cmd As New MySqlCommand("SELECT IFNULL(MAX(id), 0) FROM account", conn)
            Dim uid As Integer = cmd.ExecuteScalar()

            ' Set the next ID in TextBox1 (auto-generated)
            id.Text = (uid + 1).ToString()
        Catch ex As Exception
            ' If there's an error fallback to ID = 1
            MessageBox.Show("Error generating ID: " & ex.Message)
            id.Text = "1"
        End Try

        stat.Text = "OFF"

        coursepanel.Visible = False
        subjectpanel.Visible = False

    End Sub



    Private Sub get_u_id()
        Dim ad As New MySqlDataAdapter("select max (id)from account", conn)
        Dim ds As New System.Data.DataSet
        id.Text = ds.Tables(0).Rows(0).Item("id") + 1
    End Sub

    Private Sub register_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Panel2.Left = (Me.ClientSize.Width - Panel2.Width) \ 2
        Panel2.Top = (Me.ClientSize.Height - Panel2.Height) \ 2
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hashcode As register
        hashcode = New register()
        ' Validation
        If id.Text = "" Or ln.Text = "" Or fn.Text = "" Or mi.Text = "" Or un.Text = "" Or pass.Text = "" Or add.Text = "" Or secques.SelectedIndex = -1 Or sa.Text = "" Or role.SelectedIndex = -1 Or stat.Text = "" Or ct.Text = "" Or age.Text = "" Or bd.Text = "" Or gen.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all fields!")
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                ' Check kung may existing username
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM account WHERE username=@username", conn)
                checkCmd.Parameters.AddWithValue("@username", un.Text)
                Dim count As Integer = checkCmd.ExecuteScalar()

                If count > 0 Then
                    MessageBox.Show("Username already exists!")
                Else
                    ' Insert new account
                    Dim insertCmd As New MySqlCommand("INSERT INTO account(id, lastname, firstname, middlename, username, passwordusername, address, role, secques, secans, acc_status, course, subject, age, contact, gender, birthday, section)  VALUES(@id, @lastname, @firstname, @middlename, @username, @passwordusername, @address, @role, @secques, @secans, 'OFF', @course, @subject, @age, @contact, @gender, @birthday, @section)", conn)

                    insertCmd.Parameters.AddWithValue("@id", id.Text)
                    insertCmd.Parameters.AddWithValue("@lastname", ln.Text.Trim)
                    insertCmd.Parameters.AddWithValue("@firstname", fn.Text.Trim)
                    insertCmd.Parameters.AddWithValue("@middlename", mi.Text.Trim)
                    insertCmd.Parameters.AddWithValue("@username", un.Text.Trim)
                    insertCmd.Parameters.AddWithValue("@passwordusername", hashcode.md5fromstring(pass.Text).Trim)
                    insertCmd.Parameters.AddWithValue("@address", add.Text.Trim)
                    insertCmd.Parameters.AddWithValue("@role", role.SelectedItem.ToString())
                    insertCmd.Parameters.AddWithValue("@secques", secques.SelectedItem.ToString())
                    insertCmd.Parameters.AddWithValue("@secans", sa.Text.Trim)
                    insertCmd.Parameters.AddWithValue("@acc_status", stat.Text)
                    insertCmd.Parameters.AddWithValue("@course", course.Text)
                    insertCmd.Parameters.AddWithValue("@subject", subject.Text)
                    insertCmd.Parameters.AddWithValue("@age", age.Text)
                    insertCmd.Parameters.AddWithValue("@contact", ct.Text.Trim)
                    insertCmd.Parameters.AddWithValue("@gender", gen.SelectedItem.ToString())
                    insertCmd.Parameters.AddWithValue("@birthday", bd.Text)
                    insertCmd.Parameters.AddWithValue("@section", section.Text.Trim)




                    insertCmd.ExecuteNonQuery()

                    MessageBox.Show("Registration submitted! Your account is currently OFF and awaiting admin approval.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    ' Example: balik sa login form (palitan depende sa form name mo)
                    Me.Close()
                    Form.Show()


                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles role.SelectedIndexChanged
        Dim selectrole As String = role.SelectedItem.ToString
        coursepanel.Visible = False
        subjectpanel.Visible = False
        If selectrole = "STUDENT" Then
            coursepanel.Visible = True
        ElseIf selectrole = "PROFESSOR" Then
            subjectpanel.Visible = True


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            pass.UseSystemPasswordChar = False
        Else
            pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles course.SelectedIndexChanged
        If course.SelectedIndex <> -1 Then

        End If
        ' Optional: show confirmation
        subject.Text = ""
        coursepanel.Visible = False
        sectionpanel.Visible = True
        ' Load sections with limit check
        section.Items.Clear()

        Dim sections As String() = {"1-1", "1-2", "1-3"}

        For Each sect In sections
            Dim studentCount As Integer = sectioning(course.Text, sect)

            If studentCount >= 30 Then
                section.Items.Add(sect & " (FULL)")
            Else
                section.Items.Add(sect)
            End If
        Next

    End Sub

    Private Sub subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subject.SelectedIndexChanged
        If subject.SelectedIndex <> -1 Then

        End If
        ' Optional: show confirmation
        MessageBox.Show("You selected: " & subject.SelectedItem.ToString(), "Subject Selected(", MessageBoxButtons.OK, MessageBoxIcon.Information)
        course.Text = ""
        section.Text = ""
        subjectpanel.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        subjectpanel.Visible = False
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        coursepanel.Visible = False
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        bd.Text = MonthCalendar1.SelectionStart.ToShortDateString()
        MonthCalendar1.Visible = False
    End Sub

    Private Sub bd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bd.Click
        MonthCalendar1.Visible = True
    End Sub

    Private Sub sec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles section.SelectedIndexChanged
        If section.SelectedItem Is Nothing Then

        ElseIf section.SelectedItem.ToString().Contains("(FULL)") Then
            MessageBox.Show("This section " & section.Text & " already reached the limit of 30 students.", "Section Full", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            section.SelectedIndex = -1
            Return
        End If

        If section.SelectedIndex <> -1 Then
            MessageBox.Show("You selected: " & course.SelectedItem.ToString() & section.Text, "Course and Section Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        subject.Text = ""
        sectionpanel.Visible = False
    End Sub
    Private Function sectioning(ByVal course As String, ByVal section As String) As Integer
        Dim sec As Integer = 0

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                Dim sectioncmd As New MySqlCommand("SELECT COUNT(*) FROM account WHERE course=@course AND section=@section", conn)

                sectioncmd.Parameters.AddWithValue("@course", course)
                sectioncmd.Parameters.AddWithValue("@section", section)

                Dim result = sectioncmd.ExecuteScalar()
                If result Is Nothing OrElse IsDBNull(result) Then
                    sec = 0
                Else
                    sec = Convert.ToInt32(result)
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking section limit: " & ex.Message)
        End Try

        Return sec
    End Function

    Private Sub age_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles age.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ct_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ct.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub CapitalFirstLetter(ByVal cap As TextBox)
        If cap.TextLength > 0 Then
            Dim curPos As Integer = cap.SelectionStart
            cap.Text = Char.ToUpper(cap.Text(0)) & cap.Text.Substring(1)
            cap.SelectionStart = curPos
        End If
    End Sub

    Private Sub ln_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ln.TextChanged
        CapitalFirstLetter(ln)
    End Sub

    Private Sub fn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fn.TextChanged
        CapitalFirstLetter(fn)
    End Sub

    Private Sub mi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi.TextChanged
        CapitalFirstLetter(mi)
    End Sub

    Private Sub add_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.TextChanged
        CapitalFirstLetter(add)
    End Sub

    Private Sub sa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sa.TextChanged
        CapitalFirstLetter(sa)
    End Sub

    Private Sub un_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles un.TextChanged
        CapitalFirstLetter(un)
    End Sub

    Private Sub pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class