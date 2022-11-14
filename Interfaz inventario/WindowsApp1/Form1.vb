Imports System.Data.SqlClient

Public Class Form1

    'Codigo necesario para la conexion con MSSQL'
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Crear un objeto de conexion'
        myConn = New SqlConnection("Initial Catalog=Ejemplo;" & "Data Source=localhost;Integrated Security=SSPI;")

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * from empleados"

        'Open the connection.
        myConn.Open()


        'Recuperacion de los datos'
        myReader = myCmd.ExecuteReader()


        'Concatenate the query result into a string.
        Do While myReader.Read()
            results = results & myReader.GetString(0) & vbTab &
            myReader.GetString(1) & vbLf
        Loop
        'Display results.
        MsgBox(results)


        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()




    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class
