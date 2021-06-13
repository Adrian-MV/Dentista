Public Class ConsultarEliminar

    ''''' INGRESAR PUAS MAYUSCULAS''''''
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Me.TextBox6.Text = UCase(Me.TextBox6.Text)
        Me.TextBox6.SelectionStart = Me.TextBox6.TextLength + 1
    End Sub

    ''''' INGRESAR PUAS MAYUSCULAS''''''
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.TextBox1.Text = UCase(Me.TextBox1.Text)
        Me.TextBox1.SelectionStart = Me.TextBox1.TextLength + 1
    End Sub

    ''''' INGRESAR PUAS MAYUSCULAS''''''
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Me.TextBox7.Text = UCase(Me.TextBox7.Text)
        Me.TextBox7.SelectionStart = Me.TextBox7.TextLength + 1
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        Select Case e.KeyData
            Case Keys.Enter

                If TextBox6.Text = "" Then
                    MessageBox.Show("Ingresa El Nombre del Paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox6.Focus()

                End If

                If TextBox6.Text <> "" Then

                    mysqlstring = ("SELECT * FROM Datos WHERE NOMBRE = '" & Trim(TextBox6.Text.ToLower) & "'")
                    ABREBD()
                    Cmd = New OleDb.OleDbCommand(mysqlstring, cnx)
                    Cmd.Parameters.AddWithValue("@nombre", TextBox6.Text)
                    Dim reader As OleDb.OleDbDataReader
                    reader = Cmd.ExecuteReader
                    If reader.Read Then
                        TextBox1.Text = Convert.ToString(reader(1))
                        TextBox2.Text = Convert.ToString(reader(2))
                        TextBox7.Text = Convert.ToString(reader(3))
                        TextBox3.Text = Convert.ToString(reader(4))
                        TextBox4.Text = Convert.ToString(reader(5))
                        TextBox5.Text = Convert.ToString(reader(6))
                        DateTimePicker1.Value = Convert.ToString(reader(7))

                        TextBox6.Focus()


                    Else

                        MessageBox.Show("El Paciente No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox6.Text = ""
                        TextBox6.Focus()

                    End If
                    CIERRABD()
                End If
               
        End Select

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If TextBox6.Text = "" Then
            MessageBox.Show("Ingresa El Nombre del Paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox6.Focus()

        End If



        If TextBox6.Text <> "" Then

            mysqlstring = ("SELECT * FROM Datos WHERE NOMBRE = '" & Trim(TextBox6.Text.ToLower) & "'")
            ABREBD()
            Cmd = New OleDb.OleDbCommand(mysqlstring, cnx)
            Cmd.Parameters.AddWithValue("@nombre", TextBox6.Text)
            Dim reader As OleDb.OleDbDataReader
            reader = Cmd.ExecuteReader
            If reader.Read Then
                TextBox1.Text = Convert.ToString(reader(1))
                TextBox2.Text = Convert.ToString(reader(2))
                TextBox7.Text = Convert.ToString(reader(3))
                TextBox3.Text = Convert.ToString(reader(4))
                TextBox4.Text = Convert.ToString(reader(5))
                TextBox5.Text = Convert.ToString(reader(6))
                DateTimePicker1.Value = Convert.ToString(reader(7))

                TextBox6.Focus()



            Else
                MessageBox.Show("El Paciente No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox6.Text = ""
                TextBox6.Focus()

            End If
            CIERRABD()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       

        If TextBox6.Text = "" Then
            MessageBox.Show("Ingresa El Nombre del Paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox6.Focus()

        End If



        If TextBox1.Text <> "" Then

            Dim result = MessageBox.Show("Deseas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If result = Windows.Forms.DialogResult.Yes Then

                mysqlstring = ("DELETE FROM Datos WHERE NOMBRE = '" & Trim(TextBox6.Text.ToLower) & "'")
                ABREBD()
                Cmd = New OleDb.OleDbCommand(mysqlstring, cnx)
                If Cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Paciente Eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox7.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""

                DateTimePicker1.Value = DateTime.Now

                TextBox6.Focus()

            Else

                Button1.Focus()


            End If


        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

        TextBox7.Text = ""

        TextBox6.Text = ""

        DateTimePicker1.Value = DateTime.Now

        TextBox6.Focus()

    End Sub

    Private Sub ConsultarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class