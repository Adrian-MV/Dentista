Public Class Inicio

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                mysqlstring = ("SELECT * FROM Registro WHERE USUARIO = '" & Trim(TextBox1.Text.ToLower) & "'")
                ABREBD()
                Cmd = New OleDb.OleDbCommand(mysqlstring, cnx)
                Cmd.Parameters.AddWithValue("@usuario", TextBox1.Text)
                Dim reader As OleDb.OleDbDataReader
                reader = Cmd.ExecuteReader
                If reader.Read Then

                    Dim usuario, contraseña As String
                    usuario = Convert.ToString(reader(1))
                    contraseña = Convert.ToString(reader(2))
                    If usuario = TextBox1.Text And contraseña = TextBox2.Text Then



                        MDI.Show()
                        Me.Close()


                    Else
                        MessageBox.Show("Error de usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox1.Text = ""
                        TextBox2.Text = ""

                        TextBox1.Focus()
                        
                    End If


                Else
                    MessageBox.Show("Error de usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.Text = ""
                    TextBox2.Text = ""

                    TextBox1.Focus()
                    
                End If
                CIERRABD()

        End Select
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter

                TextBox2.Focus()

        End Select

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
                   mysqlstring = ("SELECT * FROM Registro WHERE USUARIO = '" & Trim(TextBox1.Text.ToLower) & "'")
        ABREBD()
        Cmd = New OleDb.OleDbCommand(mysqlstring, cnx)
        Cmd.Parameters.AddWithValue("@usuario", TextBox1.Text)
        Dim reader As OleDb.OleDbDataReader
        reader = Cmd.ExecuteReader
        If reader.Read Then

            Dim usuario, contraseña As String
            usuario = Convert.ToString(reader(1))
            contraseña = Convert.ToString(reader(2))
            If usuario = TextBox1.Text And contraseña = TextBox2.Text Then



                MDI.Show()
                Me.Close()

            Else
                MessageBox.Show("Error de usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Text = ""
                TextBox2.Text = ""

                TextBox1.Focus()

            End If


        Else
            MessageBox.Show("Error de usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Text = ""
            TextBox2.Text = ""

            TextBox1.Focus()

        End If
        CIERRABD()



    End Sub

    


   
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
