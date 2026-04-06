Public Class Form1
    Dim formato As Boolean = True
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""
        'Crear una variable, le asigna un valor, el valor es la fecha del dia de hoy convertida a string
        'En el formato de "dd 'de' MMM ' del' yyyy" [dd- numero de dia, MMM- el mes en texto, yyy- para el año
        ' Este es el formato de 24h
        If formato = True Then
            ' "08:06:56"
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_Mod = Time_o.Split(":")
        ' Time_Mod(0) = "08"
        ' Time_Mod(1) = "06"
        ' Time_Mod(2) = "56"
        ' Time_Mod(3) = "56"
        horas.Text = Time_Mod(0)
        minutos.Text = Time_Mod(1)
        segundo.Text = Time_Mod(2)
        dia.Text = Day_o
        fecha.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "Blanco" Then
            horas.ForeColor = Color.White
            minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            dia.ForeColor = Color.White
            fecha.ForeColor = Color.White
            segundo.ForeColor = Color.White
        ElseIf color_texto = "Rojo" Then
            horas.ForeColor = Color.Red
            minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            dia.ForeColor = Color.Red
            fecha.ForeColor = Color.Red
            segundo.ForeColor = Color.Red
        ElseIf color_texto = "Azul" Then
            horas.ForeColor = Color.Blue
            minutos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            dia.ForeColor = Color.Blue
            fecha.ForeColor = Color.Blue
            segundo.ForeColor = Color.Blue
        ElseIf color_texto = "Amarillo" Then
            horas.ForeColor = Color.Yellow
            minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            dia.ForeColor = Color.Yellow
            fecha.ForeColor = Color.Yellow
            segundo.ForeColor = Color.Yellow
        ElseIf color_texto = "Verde" Then
            horas.ForeColor = Color.Green
            minutos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            dia.ForeColor = Color.Green
            fecha.ForeColor = Color.Green
            segundo.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub


    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        If boton_start = False Then
            Timer3.Enabled = True
            boton_start = True
            start.Text = "Stop"
            startTime = DateTime.Now
        ElseIf boton_start = True Then
            Timer3.Enabled = False
            boton_start = False
            start.Text = "Start"
            elapsed += DateTime.Now - startTime
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        tiempo_crono = 0
        Timer3.Enabled = False
        tiempo.Text = "0"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        tiempo_crono = tiempo_crono + 1
        tiempo.Text = tiempo_crono.ToString()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub
End Class
