Public Class Form1
    Dim DATO1 As Double
    Dim DATO2 As Double
    Dim OPE As Double
    Dim RES As Double
    Dim CADENA As Double


    Private Sub Button34_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnuno_Click(sender As Object, e As EventArgs) Handles btnuno.Click
        txtpantalla.Text = txtpantalla.Text & "1"

    End Sub

    Private Sub btndos_Click(sender As Object, e As EventArgs) Handles btndos.Click
        txtpantalla.Text = txtpantalla.Text & "2"
    End Sub

    Private Sub btntres_Click(sender As Object, e As EventArgs) Handles btntres.Click
        txtpantalla.Text = txtpantalla.Text & "3"
    End Sub

    Private Sub btncuatro_Click(sender As Object, e As EventArgs) Handles btncuatro.Click
        txtpantalla.Text = txtpantalla.Text & "4"
    End Sub

    Private Sub btncinco_Click(sender As Object, e As EventArgs) Handles btncinco.Click
        txtpantalla.Text = txtpantalla.Text & "5"
    End Sub

    Private Sub btnseis_Click(sender As Object, e As EventArgs) Handles btnseis.Click
        txtpantalla.Text = txtpantalla.Text & "6"
    End Sub

    Private Sub btnsiete_Click(sender As Object, e As EventArgs) Handles btnsiete.Click
        txtpantalla.Text = txtpantalla.Text & "7"
    End Sub

    Private Sub btnocho_Click(sender As Object, e As EventArgs) Handles btnocho.Click
        txtpantalla.Text = txtpantalla.Text & "8"
    End Sub

    Private Sub btnnueve_Click(sender As Object, e As EventArgs) Handles btnnueve.Click
        txtpantalla.Text = txtpantalla.Text & "9"
    End Sub

    Private Sub btncero_Click(sender As Object, e As EventArgs) Handles btncero.Click
        txtpantalla.Text = txtpantalla.Text & "0"
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        Try
            If txtpantalla.Text.IndexOf(".") > 0 Then
                Beep()
            ElseIf txtpantalla.Text <> "." Then
                txtpantalla.Text = txtpantalla.Text & "."
            Else
                txtpantalla.Text = "0."

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        OPE = 1
        DATO1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtRef.Text = DATO1 & "+"


    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        OPE = 2
        DATO1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtRef.Text = DATO1 & "-"
    End Sub

    Private Sub btnmultiplicacion_Click(sender As Object, e As EventArgs) Handles btnmultiplicacion.Click
        OPE = 3
        DATO1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtRef.Text = DATO1 & "×"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        OPE = 4
        DATO1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtRef.Text = DATO1 & "÷"
    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        DATO2 = Val(txtpantalla.Text)

        If OPE = 1 Then
            RES = DATO1 + DATO2
            txtpantalla.Text = RES
            txtRef.Text = txtRef.Text & DATO2

        Else
            If OPE = 2 Then
                RES = DATO1 - DATO2
                txtpantalla.Text = RES
                txtRef.Text = txtRef.Text & DATO2
            Else
                If OPE = 3 Then
                    RES = DATO1 * DATO2
                    txtpantalla.Text = RES
                    txtRef.Text = txtRef.Text & DATO2
                Else
                    If OPE = 4 Then
                        RES = DATO1 / DATO2
                        txtpantalla.Text = RES
                        txtRef.Text = txtRef.Text & DATO2
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        If txtpantalla.Text <> " " Then
            CADENA = txtpantalla.Text.Length
            txtpantalla.Text = Mid(txtpantalla.Text, 1, CADENA - 1)
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtpantalla.Text = " "
        txtRef.Text = " "

    End Sub
End Class
