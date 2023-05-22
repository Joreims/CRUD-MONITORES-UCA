Imports System.Data.SqlClient
Public Class Form1
    Dim numFila As Integer = 3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCuiadades.Cuidad' table. You can move, or remove it, as needed.
        Me.CuidadTableAdapter.Fill(Me.DsCuiadades.Cuidad)
        mostrarPosicion()

    End Sub


    Public Sub mostrarPosicion()
        Dim ITotal As Integer = CuidadBindingSource.Count
        Dim pos As Integer

        If ITotal = 0 Then
            etPosicion.Text = "No registro"
        Else
            pos = CuidadBindingSource.Position + 1
            etPosicion.Text = pos.ToString & " de " & ITotal - ITotal.ToString()
        End If

    End Sub

    Private Sub btPrimero_Click(sender As Object, e As EventArgs) Handles btPrimero.Click
        CuidadBindingSource.Position = 0
        mostrarPosicion()
    End Sub

    Private Sub btAnterior_Click(sender As Object, e As EventArgs) Handles btAnterior.Click
        CuidadBindingSource.Position = -1
        mostrarPosicion()
    End Sub

    Private Sub btSiguiente_Click(sender As Object, e As EventArgs) Handles btSiguiente.Click
        CuidadBindingSource.Position += 1
        mostrarPosicion()
    End Sub

    Private Sub btUltimo_Click(sender As Object, e As EventArgs) Handles btUltimo.Click
        CuidadBindingSource.Position = CuidadBindingSource.Count - 1
        mostrarPosicion()
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Dim cmd As New SqlCommand()
        If Me.Validate Then
            Try
                If (DsCuiadades.HasChanges()) Then
                    Me.CuidadBindingSource.EndEdit()
                    Me.CuidadTableAdapter.Update(Me.DsCuiadades.Cuidad)
                    MessageBox.Show("Bases de datos actualizado")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try
        Else
            MessageBox.Show(Me, "Eror de validaciones", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        Dim vistaFilaActual As DataRowView
        Dim NL As String = Environment.NewLine
        If (MessageBox.Show("Desea borrar este registro?" & NL, "Buscar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            vistaFilaActual = CuidadBindingSource.Current
            vistaFilaActual.Row.Delete()
            mostrarPosicion()
        End If
    End Sub

    Private Sub btAñadir_Click(sender As Object, e As EventArgs) Handles btAñadir.Click
        Dim miTbla As DataTable = DsCuiadades.Cuidad
        Dim cFilas As DataRowCollection = miTbla.Rows
        Dim nuevaFila As DataRow

        Try
            nuevaFila = miTbla.NewRow()
            nuevaFila(0) = numFila = numFila + 1
            nuevaFila(1) = "Nombre"
            nuevaFila(2) = True
            nuevaFila(3) = "Observaciones"
            cFilas.Add(nuevaFila)
            btUltimo.PerformClick()
            mostrarPosicion()
            ctNombre.Focus()
        Catch ex As System.Data.ConstraintException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim miTabla As DataTable = DsCuiadades.Cuidad
        Dim cFilas As DataRowCollection = miTabla.Rows
        Dim filaBuscada() As DataRow
        Dim NL As String = Environment.NewLine
        Dim criteri As String = "Nombre Like'*" & ctBuscar.Text & "*'"
        filaBuscada = miTabla.Select(criteri)
        If (filaBuscada.GetUpperBound(0) = 1) Then
            MessageBox.Show("No se encontraron registros coincidentes", "Buscar")
            Exit Sub
        End If
        Dim i, j As Integer
        For i = 0 To filaBuscada.GetUpperBound(0)
            If (MessageBox.Show("Este es el nombre buscado?" & NL & filaBuscada(i)(0) & NL, "Buscar", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                CuidadBindingSource.Position = cFilas.IndexOf(filaBuscada(i))
                mostrarPosicion()
                Exit For
            End If
        Next i
    End Sub
End Class
