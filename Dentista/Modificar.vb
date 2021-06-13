Public Class Modificar

    Dim TOTAL As String

    ''''' INGRESAR PUAS MAYUSCULAS''''''
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Me.TextBox6.Text = UCase(Me.TextBox6.Text)
        Me.TextBox6.SelectionStart = Me.TextBox6.TextLength + 1
    End Sub
    ''''' INGRESAR PUAS MAYUSCULAS''''''
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Me.TextBox7.Text = UCase(Me.TextBox7.Text)
        Me.TextBox7.SelectionStart = Me.TextBox7.TextLength + 1
    End Sub

    '''ÍNGRESAR PUROS NUMEROS''''
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '''ÍNGRESAR PUROS NUMEROS''''
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '''ÍNGRESAR PUROS NUMEROS''''
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    '''ÍNGRESAR PUROS NUMEROS''''
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyData
            Case Keys.Enter

                TextBox7.Focus()

        End Select

    End Sub

    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown
        Select Case e.KeyData
            Case Keys.Enter

                TextBox3.Focus()

        End Select
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        Select Case e.KeyData
            Case Keys.Enter

                TextBox4.Focus()

        End Select
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        Select Case e.KeyData
            Case Keys.Enter

                DateTimePicker1.Focus()

        End Select
    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter

                Button1.Focus()

        End Select
    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////////////////

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

                        TextBox2.Enabled = True
                        TextBox3.Enabled = True
                        TextBox4.Enabled = True
                        TextBox5.Enabled = True
                        TextBox7.Enabled = True
                        DateTimePicker1.Enabled = True

                        TextBox1.Text = Convert.ToString(reader(1))
                        TextBox2.Text = Convert.ToString(reader(2))
                        TextBox7.Text = Convert.ToString(reader(3))
                        TextBox3.Text = Convert.ToString(reader(4))
                        TextBox4.Text = Convert.ToString(reader(5))
                        TextBox5.Text = Convert.ToString(reader(6))
                        DateTimePicker1.Value = Convert.ToString(reader(7))

                        TextBox2.Focus()



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
                TextBox1.Enabled = True
                TextBox2.Enabled = True
                TextBox3.Enabled = True
                TextBox4.Enabled = True
                TextBox5.Enabled = True
                TextBox7.Enabled = True
                DateTimePicker1.Enabled = True

                TextBox1.Text = Convert.ToString(reader(1))
                TextBox2.Text = Convert.ToString(reader(2))
                TextBox7.Text = Convert.ToString(reader(3))
                TextBox3.Text = Convert.ToString(reader(4))
                TextBox4.Text = Convert.ToString(reader(5))
                TextBox5.Text = Convert.ToString(reader(6))
                DateTimePicker1.Value = Convert.ToString(reader(7))

                TextBox2.Focus()



            Else
                MessageBox.Show("El Paciente No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'TextBox14.Text = ""
                'TextBox14.Focus()
            End If
            CIERRABD()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TOTAL = Val(TextBox3.Text) - Val(TextBox4.Text)
        TextBox5.Text = Str(TOTAL)
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TOTAL = Val(TextBox3.Text) - Val(TextBox4.Text)
        TextBox5.Text = Str(TOTAL)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TOTAL = Val(TextBox3.Text) - Val(TextBox4.Text)
        TextBox5.Text = Str(TOTAL)
    End Sub

    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox6.Text = "" Then
            MessageBox.Show("Ingresa El Nombre del Paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox6.Focus()

        End If



        If TextBox1.Text <> "" Then


            mysqlstring = ("UPDATE Datos SET NOMBRE = '" & Trim(TextBox1.Text) & "' , TELEFONO = '" & Trim(TextBox2.Text) & "', SERVICIO = '" & (TextBox7.Text.ToLower) & "',COSTO = '" & Trim(TextBox3.Text.ToLower) & "',ANTICIPO = '" & Trim(TextBox4.Text.ToLower) & "',RESTA = '" & Trim(TextBox5.Text.ToLower) & "', FECHA = '" & Trim(DateTimePicker1.Value.ToString.ToLower) & "' WHERE nombre = '" & Trim(TextBox1.Text.ToLower) & "' ")


            ABREBD()
            Cmd = New OleDb.OleDbCommand(mysqlstring, cnx)
            If Cmd.ExecuteNonQuery Then
                MessageBox.Show("Cita modificada correctamente", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""

                TextBox7.Text = ""

                TextBox6.Text = ""

                DateTimePicker1.Value = DateTime.Now

                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = False
                TextBox7.Enabled = False
                DateTimePicker1.Enabled = False

                TextBox6.Focus()

            End If

            CIERRABD()

        Else

            TextBox1.Focus()

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
End Class