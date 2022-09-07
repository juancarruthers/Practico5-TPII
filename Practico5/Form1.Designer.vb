<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BFoto = New System.Windows.Forms.Button()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.RBHombre = New System.Windows.Forms.RadioButton()
        Me.DateFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.TFoto = New System.Windows.Forms.TextBox()
        Me.TSaldo = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LSaldo = New System.Windows.Forms.Label()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.LFechaNac = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ColApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFoto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.Panel.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel.Controls.Add(Me.BAgregar)
        Me.Panel.Controls.Add(Me.BNuevo)
        Me.Panel.Controls.Add(Me.BFoto)
        Me.Panel.Controls.Add(Me.RBMujer)
        Me.Panel.Controls.Add(Me.RBHombre)
        Me.Panel.Controls.Add(Me.DateFechaNac)
        Me.Panel.Controls.Add(Me.TFoto)
        Me.Panel.Controls.Add(Me.TSaldo)
        Me.Panel.Controls.Add(Me.TApellido)
        Me.Panel.Controls.Add(Me.TNombre)
        Me.Panel.Controls.Add(Me.LSaldo)
        Me.Panel.Controls.Add(Me.LSexo)
        Me.Panel.Controls.Add(Me.LFechaNac)
        Me.Panel.Controls.Add(Me.LApellido)
        Me.Panel.Controls.Add(Me.LNombre)
        Me.Panel.Location = New System.Drawing.Point(36, 18)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(344, 358)
        Me.Panel.TabIndex = 0
        '
        'BNuevo
        '
        Me.BNuevo.AutoSize = True
        Me.BNuevo.Image = Global.Practico5.My.Resources.Resources.alumno
        Me.BNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNuevo.Location = New System.Drawing.Point(16, 11)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BNuevo.Size = New System.Drawing.Size(93, 45)
        Me.BNuevo.TabIndex = 16
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'BFoto
        '
        Me.BFoto.Location = New System.Drawing.Point(16, 266)
        Me.BFoto.Name = "BFoto"
        Me.BFoto.Size = New System.Drawing.Size(75, 25)
        Me.BFoto.TabIndex = 13
        Me.BFoto.Text = "Foto"
        Me.BFoto.UseVisualStyleBackColor = True
        '
        'RBMujer
        '
        Me.RBMujer.AutoSize = True
        Me.RBMujer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBMujer.ForeColor = System.Drawing.Color.White
        Me.RBMujer.Location = New System.Drawing.Point(211, 194)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(53, 18)
        Me.RBMujer.TabIndex = 12
        Me.RBMujer.TabStop = True
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = True
        '
        'RBHombre
        '
        Me.RBHombre.AutoSize = True
        Me.RBHombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBHombre.ForeColor = System.Drawing.Color.White
        Me.RBHombre.Location = New System.Drawing.Point(126, 194)
        Me.RBHombre.Name = "RBHombre"
        Me.RBHombre.Size = New System.Drawing.Size(65, 18)
        Me.RBHombre.TabIndex = 11
        Me.RBHombre.TabStop = True
        Me.RBHombre.Text = "Hombre"
        Me.RBHombre.UseVisualStyleBackColor = True
        '
        'DateFechaNac
        '
        Me.DateFechaNac.CalendarFont = New System.Drawing.Font("Microsoft Uighur", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaNac.Location = New System.Drawing.Point(200, 146)
        Me.DateFechaNac.Name = "DateFechaNac"
        Me.DateFechaNac.Size = New System.Drawing.Size(128, 26)
        Me.DateFechaNac.TabIndex = 10
        Me.DateFechaNac.Value = New Date(1977, 1, 1, 0, 0, 0, 0)
        '
        'TFoto
        '
        Me.TFoto.Enabled = False
        Me.TFoto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFoto.Location = New System.Drawing.Point(103, 266)
        Me.TFoto.Multiline = True
        Me.TFoto.Name = "TFoto"
        Me.TFoto.Size = New System.Drawing.Size(225, 25)
        Me.TFoto.TabIndex = 9
        '
        'TSaldo
        '
        Me.TSaldo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSaldo.Location = New System.Drawing.Point(103, 226)
        Me.TSaldo.Multiline = True
        Me.TSaldo.Name = "TSaldo"
        Me.TSaldo.Size = New System.Drawing.Size(225, 25)
        Me.TSaldo.TabIndex = 8
        '
        'TApellido
        '
        Me.TApellido.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TApellido.Location = New System.Drawing.Point(103, 106)
        Me.TApellido.Multiline = True
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(225, 25)
        Me.TApellido.TabIndex = 6
        '
        'TNombre
        '
        Me.TNombre.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(103, 66)
        Me.TNombre.Multiline = True
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(225, 25)
        Me.TNombre.TabIndex = 5
        '
        'LSaldo
        '
        Me.LSaldo.AutoSize = True
        Me.LSaldo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSaldo.ForeColor = System.Drawing.Color.White
        Me.LSaldo.Location = New System.Drawing.Point(12, 228)
        Me.LSaldo.Name = "LSaldo"
        Me.LSaldo.Size = New System.Drawing.Size(65, 24)
        Me.LSaldo.TabIndex = 4
        Me.LSaldo.Text = "Saldo"
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSexo.ForeColor = System.Drawing.Color.White
        Me.LSexo.Location = New System.Drawing.Point(12, 188)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(59, 24)
        Me.LSexo.TabIndex = 3
        Me.LSexo.Text = "Sexo"
        '
        'LFechaNac
        '
        Me.LFechaNac.AutoSize = True
        Me.LFechaNac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaNac.ForeColor = System.Drawing.Color.White
        Me.LFechaNac.Location = New System.Drawing.Point(12, 148)
        Me.LFechaNac.Name = "LFechaNac"
        Me.LFechaNac.Size = New System.Drawing.Size(182, 24)
        Me.LFechaNac.TabIndex = 2
        Me.LFechaNac.Text = "Fecha Nacimiento"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(12, 108)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(87, 24)
        Me.LApellido.TabIndex = 1
        Me.LApellido.Text = "Apellido"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(12, 68)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(85, 24)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColApellido, Me.ColNombre, Me.ColFechaNac, Me.ColSexo, Me.ColEliminar, Me.ColSaldo, Me.ColFoto, Me.ColRuta})
        Me.DataGridView.Location = New System.Drawing.Point(36, 382)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.Size = New System.Drawing.Size(692, 150)
        Me.DataGridView.TabIndex = 1
        '
        'ColApellido
        '
        Me.ColApellido.DataPropertyName = "juan"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColApellido.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColApellido.HeaderText = "Apellido"
        Me.ColApellido.Name = "ColApellido"
        Me.ColApellido.ReadOnly = True
        '
        'ColNombre
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNombre.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColNombre.HeaderText = "Nombre"
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.ReadOnly = True
        '
        'ColFechaNac
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColFechaNac.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColFechaNac.HeaderText = "Fecha de Nacimiento"
        Me.ColFechaNac.Name = "ColFechaNac"
        Me.ColFechaNac.ReadOnly = True
        '
        'ColSexo
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColSexo.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColSexo.HeaderText = "Sexo"
        Me.ColSexo.Name = "ColSexo"
        Me.ColSexo.ReadOnly = True
        '
        'ColEliminar
        '
        Me.ColEliminar.HeaderText = "Eliminar"
        Me.ColEliminar.Name = "ColEliminar"
        Me.ColEliminar.ReadOnly = True
        '
        'ColSaldo
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColSaldo.DefaultCellStyle = DataGridViewCellStyle11
        Me.ColSaldo.HeaderText = "Saldo"
        Me.ColSaldo.Name = "ColSaldo"
        Me.ColSaldo.ReadOnly = True
        Me.ColSaldo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColSaldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColFoto
        '
        Me.ColFoto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColFoto.HeaderText = "Foto"
        Me.ColFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ColFoto.Name = "ColFoto"
        Me.ColFoto.ReadOnly = True
        '
        'ColRuta
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ColRuta.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColRuta.HeaderText = "Ruta"
        Me.ColRuta.Name = "ColRuta"
        Me.ColRuta.ReadOnly = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        Me.OpenFileDialog.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png"
        '
        'PBFoto
        '
        Me.PBFoto.Image = Global.Practico5.My.Resources.Resources.avatar
        Me.PBFoto.Location = New System.Drawing.Point(447, 43)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(281, 294)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBFoto.TabIndex = 2
        Me.PBFoto.TabStop = False
        '
        'BAgregar
        '
        Me.BAgregar.Image = Global.Practico5.My.Resources.Resources.guardar
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(16, 297)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(93, 45)
        Me.BAgregar.TabIndex = 17
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(762, 540)
        Me.Controls.Add(Me.PBFoto)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Panel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents LNombre As Label
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents RBHombre As RadioButton
    Friend WithEvents DateFechaNac As DateTimePicker
    Friend WithEvents TFoto As TextBox
    Friend WithEvents TSaldo As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LSaldo As Label
    Friend WithEvents LSexo As Label
    Friend WithEvents LFechaNac As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents BFoto As Button
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents BNuevo As Button
    Friend WithEvents ColApellido As DataGridViewTextBoxColumn
    Friend WithEvents ColNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColFechaNac As DataGridViewTextBoxColumn
    Friend WithEvents ColSexo As DataGridViewTextBoxColumn
    Friend WithEvents ColEliminar As DataGridViewButtonColumn
    Friend WithEvents ColSaldo As DataGridViewTextBoxColumn
    Friend WithEvents ColFoto As DataGridViewImageColumn
    Friend WithEvents ColRuta As DataGridViewTextBoxColumn
    Friend WithEvents BAgregar As Button
End Class
