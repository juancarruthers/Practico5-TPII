Public Class Form1
    Private sexo As String = "n"
    Private filaElegida As Integer
    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        verificar(e)
    End Sub

    Private Sub TNombre_LostFocus(sender As Object, e As EventArgs) Handles TNombre.LostFocus
        Dim texto As String = TNombre.Text.ToLower()
        TNombre.Text = cambiar(texto)
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        verificar(e)
    End Sub

    Private Sub TApellido_LostFocus(sender As Object, e As EventArgs) Handles TApellido.LostFocus
        Dim texto As String = TApellido.Text.ToLower()
        TApellido.Text = cambiar(texto)
    End Sub

    Private Sub verificar(e As KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled() = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled() = False
        Else
            e.Handled() = True
        End If
    End Sub

    Private Function cambiar(texto As String)
        Dim cadena As String = ""
        For i = 0 To (texto.Length - 1)
            If (i = 0) Then
                cadena = UCase(texto(i))
            Else
                cadena = cadena + texto(i)
            End If
        Next
        Return cadena
    End Function

    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        PBFoto.ImageLocation = OpenFileDialog.FileName
        Dim cadena As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6) 'Obtiene la ruta del direcotiro donde esta el proyecto
        Dim Source As String = OpenFileDialog.FileName.ToString() 'Obtiene el nombre copleto de la ruta donde esta el archivo que vamos a copiar
        Dim archivo As String = StrSacaValoresString(Source) 'Obtiene el nombre del archivo
        Dim Destination As String = cadena + "\Fotos\" + archivo 'Es la carpeta destino donde voy a copiar los archivos 
        TFoto.Text = Destination
    End Sub

    Private Sub BFoto_Click(sender As Object, e As EventArgs) Handles BFoto.Click
        OpenFileDialog.ShowDialog()
    End Sub

    Function StrSacaValoresString(ByVal RutaPathFichero As String) As String ' Esta funcion obtiene el nombre del aricho que selecciono 

        Dim ChrsIn As String, ChrsOut As String = "", IdX As Integer, Chrs As Integer
        On Error GoTo StrSacaValoresString_General_ErrTrap
        If RutaPathFichero = "" Then
            MsgBox("Debe seleccionar un archivo")
        End If
        ChrsIn = RutaPathFichero 'Devuelve el nombre del fichero original
        If InStr(ChrsIn, "\") Then

            For IdX = Len(ChrsIn) To 1 Step -1
                If Mid(ChrsIn, IdX, 1) = "\" Then
                    ChrsOut = Mid(ChrsIn, IdX + 1)

                    Exit For
                End If

            Next IdX
        ElseIf InStr(ChrsIn, ":") = 2 Then
            ChrsOut = Mid(ChrsIn, 3)
        Else
            ChrsOut = ChrsIn
        End If
        StrSacaValoresString = ChrsOut
        Exit Function
StrSacaValoresString_General_ErrTrap:
        MsgBox("Error: " & Err.Number & " - Procedimiento: StrSacaValoresString" & vbCrLf & Err.Description, vbExclamation + vbOKOnly, "AVISO DE ERROR")
    End Function

    Private Sub TSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TSaldo.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled() = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled() = False
            'ElseIf e.KeyChar.ToString = "." Then
            'e.Handled() = False
        Else
            e.Handled() = True
        End If
    End Sub

    Private Sub TSaldo_LostFocus(sender As Object, e As EventArgs) Handles TSaldo.LostFocus
        If Not (TSaldo.Text.Equals("")) Then
            Dim saldo As Double = TSaldo.Text
            TSaldo.Text = saldo
        End If
    End Sub

    Private Sub RBHombre_CheckedChanged(sender As Object, e As EventArgs) Handles RBHombre.CheckedChanged
        sexo = "Hombre"
    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        sexo = "Mujer"
    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        BAgregar.Enabled = True
        'BModificar.Enabled = False
        TNombre.Text = ""
        TApellido.Text = ""
        sexo = "n"
        RBHombre.Checked = False
        RBMujer.Checked = False
        TSaldo.Text = ""
        TFoto.Text = ""
        DateFechaNac.Value = New Date(1977, 1, 1, 0, 0, 0, 0)
        PBFoto.Image = Practico5.My.Resources.avatar
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If ((TNombre.Text <> "") And (TApellido.Text <> "") And (sexo <> "n") And (TSaldo.Text <> "") And (TFoto.Text <> "")) Then
            If Not (My.Computer.FileSystem.FileExists(TFoto.Text)) Then
                My.Computer.FileSystem.CopyFile(PBFoto.ImageLocation, TFoto.Text)
                DataGridView.Rows.Add(TApellido.Text, TNombre.Text, DateFechaNac.Value.ToShortDateString, sexo, "Eliminar", TSaldo.Text, PBFoto.Image, TFoto.Text)
                TNombre.Text = ""
                TApellido.Text = ""
                sexo = "n"
                RBHombre.Checked = False
                RBMujer.Checked = False
                TSaldo.Text = ""
                TFoto.Text = ""
                DateFechaNac.Value = New Date(1977, 1, 1, 0, 0, 0, 0)
                PBFoto.Image = Practico5.My.Resources.avatar
            Else
                MsgBox("Esa imagen ya esta guardada", vbExclamation + vbOKOnly, "ERROR")
            End If
        Else
            MsgBox("Tiene campos sin completar", vbExclamation + vbOKOnly, "ERROR")
        End If
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(DataGridView.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion 
            Dim bc As DataGridViewButtonColumn = TryCast(DataGridView.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid 
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
            End If
            If DataGridView.CurrentRow.Index <> filaElegida Then
                Select Case bc.Name
                    Case "ColEliminar" 'Poner el nombre de la columna donde se desa dar un evento
                        'aquí dentro poner las acciones cuando se precione el botón eliminar 
                        My.Computer.FileSystem.DeleteFile(DataGridView.Rows(DataGridView.CurrentRow.Index).Cells.Item(7).Value)
                        DataGridView.Rows.Remove(DataGridView.CurrentRow)
                End Select
            Else
                MsgBox("No puede eliminar el registro que tiene abierto", vbExclamation + vbOKOnly, "ERROR")
            End If
        End If
    End Sub
End Class
