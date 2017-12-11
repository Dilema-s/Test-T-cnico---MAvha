Public Class Frm_Principal
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        'recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra

        Dim frm As Form
        'codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
        'If frm = Nothing Then

        '    frm.Select()

        '    frm.Show()
        '    frm.WindowState = FormWindowState.Normal

        'Else

        frm = New Form1()
        frm.ShowDialog()
        frm.WindowState = FormWindowState.Normal
        'End If

    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Dim frm As Form
        'codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
        'If frm = Nothing Then

        '    frm.Select()

        '    frm.Show()
        '    frm.WindowState = FormWindowState.Normal

        'Else

        frm = New Frm_bajaModificar()
        frm.ShowDialog()
        frm.WindowState = FormWindowState.Normal
        'End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub
End Class