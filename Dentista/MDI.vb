Public Class MDI

    Private Sub AgendarNuevaCitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendarNuevaCitaToolStripMenuItem.Click
        Agendar_Nueva_Cita.MdiParent = Me
        Agendar_Nueva_Cita.Show()

        ConsultarEliminar.Close()
        Modificar.Close()
        Ayuda.Close()

    End Sub

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        Me.ToolStripStatusLabel2.Text = Inicio.TextBox1.Text


    End Sub

    Private Sub ConsultarOEliminarCitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarOEliminarCitaToolStripMenuItem.Click
        ConsultarEliminar.MdiParent = Me
        ConsultarEliminar.Show()

        Agendar_Nueva_Cita.Close()
        Modificar.Close()
        Ayuda.Close()

    End Sub

    Private Sub ModificarCitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarCitaToolStripMenuItem.Click
        Modificar.MdiParent = Me
        Modificar.Show()

        Agendar_Nueva_Cita.Close()
        ConsultarEliminar.Close()
        Ayuda.Close()

    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Ayuda.MdiParent = Me
        Ayuda.Show()


        Agendar_Nueva_Cita.Close()
        ConsultarEliminar.Close()
        Modificar.Close()

    End Sub
End Class