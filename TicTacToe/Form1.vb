Public Class Form1

    Dim turno As Integer = 0
    Dim p1point As Integer = 0
    Dim p2point As Integer = 0
    Dim emjogo As Boolean = True
    Dim bot As Boolean = False
    Dim cont As Integer = 0
    Dim play1 As String = "Jogador 1"
    Dim play2 As String = "Jogador 2"
    Dim mtx(9) As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mtx(0) = btn1
        mtx(1) = btn2
        mtx(2) = btn3
        mtx(3) = btn4
        mtx(4) = btn5
        mtx(5) = btn6
        mtx(6) = btn7
        mtx(7) = btn8
        mtx(8) = btn9

        For i As Integer = 0 To 8
            mtx(i).Text = ""
        Next

        ' Não está funcionando corretamente
        If bot Then
            ' chbBot.Checked = True
        Else
            ' chbBot.Checked = False
        End If

        btnReplay.Visible = False
        lblVitoria.Visible = False

        txtName1.Text = play1
        txtName2.Text = play2

        lblPoint1.Text = CStr(p1point)
        lblPoint2.Text = CStr(p2point)

        emjogo = True
        cont = 0

        turno = 1
        trocaturno()

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If turno = 0 And mtx(0).Text = "" And emjogo Then
            btn1.Text = "X"
            cont += 1
            checkvit()
            trocaturno()
        ElseIf turno = 1 And mtx(0).Text = "" And emjogo Then
            btn1.Text = "O"
            cont += 1
            checkvit()
            trocaturno()
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If turno = 0 And mtx(1).Text = "" And emjogo Then
            btn2.Text = "X"
            cont += 1
            checkvit()
            trocaturno()
        ElseIf turno = 1 And mtx(1).Text = "" And emjogo Then
            btn2.Text = "O"
            cont += 1
            checkvit()
            trocaturno()
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If turno = 0 And mtx(2).Text = "" And emjogo Then
            btn3.Text = "X"
            cont += 1
            checkvit()
            trocaturno()
        ElseIf turno = 1 And mtx(2).Text = "" And emjogo Then
            btn3.Text = "O"
            cont += 1
            checkvit()
            trocaturno()
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If turno = 0 And mtx(3).Text = "" And emjogo Then
            btn4.Text = "X"
            cont += 1
            checkvit()
            trocaturno()
        ElseIf turno = 1 And mtx(3).Text = "" And emjogo Then
            btn4.Text = "O"
            cont += 1
            checkvit()
            trocaturno()
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If turno = 0 And mtx(4).Text = "" And emjogo Then
            btn5.Text = "X"
            cont += 1
            checkvit()
            trocaturno()
        ElseIf turno = 1 And mtx(4).Text = "" And emjogo Then
            btn5.Text = "O"
            cont += 1
            checkvit()
            trocaturno()
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If turno = 0 And mtx(5).Text = "" And emjogo Then
            btn6.Text = "X"
            cont += 1
            checkvit()
            trocaturno()
        ElseIf turno = 1 And mtx(5).Text = "" And emjogo Then
            btn6.Text = "O"
            cont += 1
            checkvit()
            trocaturno()
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If turno = 0 And mtx(6).Text = "" And emjogo Then
            btn7.Text = "X"
            cont += 1
            checkvit()
            trocaturno()
        ElseIf turno = 1 And mtx(6).Text = "" And emjogo Then
            btn7.Text = "O"
            cont += 1
            checkvit()
            trocaturno()
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If turno = 0 And mtx(7).Text = "" And emjogo Then
            btn8.Text = "X"
            cont += 1
            checkvit()
            trocaturno()
        ElseIf turno = 1 And mtx(7).Text = "" And emjogo Then
            btn8.Text = "O"
            cont += 1
            checkvit()
            trocaturno()
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If turno = 0 And mtx(8).Text = "" And emjogo Then
            btn9.Text = "X"
            cont += 1
            checkvit()
            trocaturno()
        ElseIf turno = 1 And mtx(8).Text = "" And emjogo Then
            btn9.Text = "O"
            cont += 1
            checkvit()
            trocaturno()
        End If
    End Sub

    Private Sub trocaturno()

        If turno = 0 Then

            If bot And cont < 9 And emjogo Then

                turno = 1

                Dim x As Integer = Math.Ceiling(Rnd() * 8)
                While mtx(x).Text <> ""
                    x = Math.Ceiling(Rnd() * 8)
                End While
                mtx(x).Text = "O"
                checkvit()
                trocaturno()

            Else
                turno = 1
                lblTurn.Text = "Vez de: " & txtName2.Text
            End If

        ElseIf turno = 1 Then

            turno = 0
            lblTurn.Text = "Vez de: " & txtName1.Text

        End If

    End Sub

    Private Sub checkvit()

        If turno = 0 Then

            If mtx(0).Text = "X" And mtx(1).Text = "X" And mtx(2).Text = "X" Then vitoria(1)
            If mtx(3).Text = "X" And mtx(4).Text = "X" And mtx(5).Text = "X" Then vitoria(1)
            If mtx(6).Text = "X" And mtx(7).Text = "X" And mtx(8).Text = "X" Then vitoria(1)

            If mtx(0).Text = "X" And mtx(3).Text = "X" And mtx(6).Text = "X" Then vitoria(1)
            If mtx(1).Text = "X" And mtx(4).Text = "X" And mtx(7).Text = "X" Then vitoria(1)
            If mtx(2).Text = "X" And mtx(5).Text = "X" And mtx(8).Text = "X" Then vitoria(1)

            If mtx(0).Text = "X" And mtx(4).Text = "X" And mtx(8).Text = "X" Then vitoria(1)
            If mtx(2).Text = "X" And mtx(4).Text = "X" And mtx(6).Text = "X" Then vitoria(1)

        ElseIf turno = 1 Then

            If mtx(0).Text = "O" And mtx(1).Text = "O" And mtx(2).Text = "O" Then vitoria(2)
            If mtx(3).Text = "O" And mtx(4).Text = "O" And mtx(5).Text = "O" Then vitoria(2)
            If mtx(6).Text = "O" And mtx(7).Text = "O" And mtx(8).Text = "O" Then vitoria(2)

            If mtx(0).Text = "O" And mtx(3).Text = "O" And mtx(6).Text = "O" Then vitoria(2)
            If mtx(1).Text = "O" And mtx(4).Text = "O" And mtx(7).Text = "O" Then vitoria(2)
            If mtx(2).Text = "O" And mtx(5).Text = "O" And mtx(8).Text = "O" Then vitoria(2)

            If mtx(0).Text = "O" And mtx(4).Text = "O" And mtx(8).Text = "O" Then vitoria(2)
            If mtx(2).Text = "O" And mtx(4).Text = "O" And mtx(6).Text = "O" Then vitoria(2)

        End If

        If cont = 9 And emjogo Then vitoria(3)

    End Sub

    Private Sub vitoria(vit As Integer)

        play1 = txtName1.Text
        play2 = txtName2.Text

        If vit = 1 Then

            p1point += 1
            lblPoint1.Text = CStr(p1point)
            lblVitoria.Text = "VITÓRIA DE " & UCase(txtName1.Text)

        ElseIf vit = 2 Then

            p2point += 1
            lblPoint2.Text = CStr(p2point)
            lblVitoria.Text = "VITÓRIA DE " & UCase(txtName2.Text)

        ElseIf vit = 3 Then

            lblVitoria.Text = "!!! EMPATE !!!"

        End If

        lblVitoria.Visible = True
        btnReplay.Visible = True
        emjogo = False

    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click

        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If emjogo And cont > 0 Then
            play1 = txtName1.Text
            play2 = txtName2.Text

            Me.Controls.Clear()
            InitializeComponent()
            Form1_Load(e, e)
        End If

    End Sub

    Private Sub chbBot_CheckedChanged(sender As Object, e As EventArgs) Handles chbBot.CheckedChanged

        If bot Then
            bot = False
        Else
            bot = True
        End If

    End Sub
End Class
