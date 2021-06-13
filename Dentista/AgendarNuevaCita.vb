Public Class Agendar_Nueva_Cita
    Dim TOTAL As String

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

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter

                TextBox2.Focus()

        End Select

    End Sub
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





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            'MsgBox("INGRESE NOMBRE DEL CLIENTE")
            MessageBox.Show("Ingrese el Nombre del Paciente", "Informacion Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()

        ElseIf TextBox2.Text = "" Then
            'MsgBox("INGRESE DOMICILIO")
            MessageBox.Show("Ingresar Numero Telefonico del Paciente", "Informacion Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox2.Focus()

        ElseIf TextBox7.Text = "" Then
            'MsgBox("INGRESE EL MODELO")
            MessageBox.Show("Ingrese el Servicio que Requiere el Peciente", "Informacion Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox7.Focus()

        ElseIf TextBox3.Text = "" Then
            'MsgBox("INGRESE TELEFONO")
            MessageBox.Show("Ingrese el Costo del Servicio", "Informacion Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox3.Focus()

            'ElseIf TextBox4.Text = "" Then
            '    'MsgBox("AGREGE LA COMPAÑIA")
            '    MessageBox.Show("Ingrese el Anticipo por el Servicio ", "Informacion Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    TextBox4.Focus()

        End If

        mysqlstring = ("SELECT * FROM Datos  WHERE NOMBRE = '" & Trim(TextBox1.Text.ToLower) & "'")

        ABREBD()
        Cmd = New OleDb.OleDbCommand(mysqlstring, cnx)
        Cmd.Parameters.AddWithValue("@NOMBRE", TextBox3.Text)
        Dim reader As OleDb.OleDbDataReader
        reader = Cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Nombre ya se Encuentra Registrado con Otro Paciente", "Verifica Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox1.Text = ""


            TextBox1.Focus()


        Else

            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox7.Text <> "" Then
                'And TextBox4.Text <> "" And TextBox5.Text <> ""

                mysqlstring = ("INSERT INTO Datos(NOMBRE,TELEFONO,SERVICIO,COSTO,ANTICIPO,RESTA,FECHA) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox7.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Value & "')")
                ABREBD()
                Cmd = New OleDb.OleDbCommand(mysqlstring, cnx)
                Cmd.ExecuteNonQuery()
                CIERRABD()
                MessageBox.Show("Cita Guardada Correctamente", "Guardado con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox7.Text = ""
                DateTimePicker1.Value = DateTime.Now

            End If

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

  

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

        TextBox7.Text = ""

        DateTimePicker1.Value = DateTime.Now

        TextBox1.Focus()


    End Sub

    Private Sub Agendar_Nueva_Cita_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class