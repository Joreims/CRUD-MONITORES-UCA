<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ctId = New System.Windows.Forms.TextBox()
        Me.CuidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCuiadades = New MonitoresUCA1.dsCuiadades()
        Me.ctNombre = New System.Windows.Forms.TextBox()
        Me.ctEstado = New System.Windows.Forms.TextBox()
        Me.ctObservaciones = New System.Windows.Forms.TextBox()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btAñadir = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btBorrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ctBuscar = New System.Windows.Forms.TextBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btPrimero = New System.Windows.Forms.Button()
        Me.btAnterior = New System.Windows.Forms.Button()
        Me.btSiguiente = New System.Windows.Forms.Button()
        Me.btUltimo = New System.Windows.Forms.Button()
        Me.etPosicion = New System.Windows.Forms.Label()
        Me.CuidadTableAdapter = New MonitoresUCA1.dsCuiadadesTableAdapters.CuidadTableAdapter()
        CType(Me.CuidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCuiadades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listado cuidades"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Observaciones"
        '
        'ctId
        '
        Me.ctId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuidadBindingSource, "id", True))
        Me.ctId.Location = New System.Drawing.Point(147, 49)
        Me.ctId.Name = "ctId"
        Me.ctId.Size = New System.Drawing.Size(155, 20)
        Me.ctId.TabIndex = 5
        '
        'CuidadBindingSource
        '
        Me.CuidadBindingSource.DataMember = "Cuidad"
        Me.CuidadBindingSource.DataSource = Me.DsCuiadades
        '
        'DsCuiadades
        '
        Me.DsCuiadades.DataSetName = "dsCuiadades"
        Me.DsCuiadades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ctNombre
        '
        Me.ctNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuidadBindingSource, "nombre", True))
        Me.ctNombre.Location = New System.Drawing.Point(147, 87)
        Me.ctNombre.Name = "ctNombre"
        Me.ctNombre.Size = New System.Drawing.Size(155, 20)
        Me.ctNombre.TabIndex = 6
        '
        'ctEstado
        '
        Me.ctEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuidadBindingSource, "estado", True))
        Me.ctEstado.Location = New System.Drawing.Point(147, 128)
        Me.ctEstado.Name = "ctEstado"
        Me.ctEstado.Size = New System.Drawing.Size(155, 20)
        Me.ctEstado.TabIndex = 7
        '
        'ctObservaciones
        '
        Me.ctObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuidadBindingSource, "observacion", True))
        Me.ctObservaciones.Location = New System.Drawing.Point(147, 175)
        Me.ctObservaciones.Multiline = True
        Me.ctObservaciones.Name = "ctObservaciones"
        Me.ctObservaciones.Size = New System.Drawing.Size(155, 107)
        Me.ctObservaciones.TabIndex = 8
        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(555, 49)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(97, 23)
        Me.btAgregar.TabIndex = 9
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'btAñadir
        '
        Me.btAñadir.Location = New System.Drawing.Point(555, 85)
        Me.btAñadir.Name = "btAñadir"
        Me.btAñadir.Size = New System.Drawing.Size(97, 23)
        Me.btAñadir.TabIndex = 10
        Me.btAñadir.Text = "Añadir"
        Me.btAñadir.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.Location = New System.Drawing.Point(555, 128)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(97, 23)
        Me.btEditar.TabIndex = 11
        Me.btEditar.Text = "Editar"
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btBorrar
        '
        Me.btBorrar.Location = New System.Drawing.Point(555, 170)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(97, 23)
        Me.btBorrar.TabIndex = 12
        Me.btBorrar.Text = "Borrar"
        Me.btBorrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(490, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Buscar"
        '
        'ctBuscar
        '
        Me.ctBuscar.Location = New System.Drawing.Point(555, 240)
        Me.ctBuscar.Name = "ctBuscar"
        Me.ctBuscar.Size = New System.Drawing.Size(155, 20)
        Me.ctBuscar.TabIndex = 14
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(587, 278)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(97, 23)
        Me.btBuscar.TabIndex = 15
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btPrimero
        '
        Me.btPrimero.Location = New System.Drawing.Point(76, 362)
        Me.btPrimero.Name = "btPrimero"
        Me.btPrimero.Size = New System.Drawing.Size(97, 23)
        Me.btPrimero.TabIndex = 16
        Me.btPrimero.Text = "Primero"
        Me.btPrimero.UseVisualStyleBackColor = True
        '
        'btAnterior
        '
        Me.btAnterior.Location = New System.Drawing.Point(214, 362)
        Me.btAnterior.Name = "btAnterior"
        Me.btAnterior.Size = New System.Drawing.Size(97, 23)
        Me.btAnterior.TabIndex = 17
        Me.btAnterior.Text = "Anterior"
        Me.btAnterior.UseVisualStyleBackColor = True
        '
        'btSiguiente
        '
        Me.btSiguiente.Location = New System.Drawing.Point(463, 362)
        Me.btSiguiente.Name = "btSiguiente"
        Me.btSiguiente.Size = New System.Drawing.Size(97, 23)
        Me.btSiguiente.TabIndex = 18
        Me.btSiguiente.Text = "Siguiente"
        Me.btSiguiente.UseVisualStyleBackColor = True
        '
        'btUltimo
        '
        Me.btUltimo.Location = New System.Drawing.Point(587, 362)
        Me.btUltimo.Name = "btUltimo"
        Me.btUltimo.Size = New System.Drawing.Size(97, 23)
        Me.btUltimo.TabIndex = 19
        Me.btUltimo.Text = "Ultimo"
        Me.btUltimo.UseVisualStyleBackColor = True
        '
        'etPosicion
        '
        Me.etPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etPosicion.Location = New System.Drawing.Point(337, 361)
        Me.etPosicion.Name = "etPosicion"
        Me.etPosicion.Size = New System.Drawing.Size(100, 23)
        Me.etPosicion.TabIndex = 20
        Me.etPosicion.Text = "No registro"
        Me.etPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CuidadTableAdapter
        '
        Me.CuidadTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.etPosicion)
        Me.Controls.Add(Me.btUltimo)
        Me.Controls.Add(Me.btSiguiente)
        Me.Controls.Add(Me.btAnterior)
        Me.Controls.Add(Me.btPrimero)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.ctBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btBorrar)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btAñadir)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.ctObservaciones)
        Me.Controls.Add(Me.ctEstado)
        Me.Controls.Add(Me.ctNombre)
        Me.Controls.Add(Me.ctId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        CType(Me.CuidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCuiadades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ctId As TextBox
    Friend WithEvents ctNombre As TextBox
    Friend WithEvents ctEstado As TextBox
    Friend WithEvents ctObservaciones As TextBox
    Friend WithEvents btAgregar As Button
    Friend WithEvents btAñadir As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ctBuscar As TextBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents btPrimero As Button
    Friend WithEvents btAnterior As Button
    Friend WithEvents btSiguiente As Button
    Friend WithEvents btUltimo As Button
    Friend WithEvents etPosicion As Label
    Friend WithEvents DsCuiadades As dsCuiadades
    Friend WithEvents CuidadBindingSource As BindingSource
    Friend WithEvents CuidadTableAdapter As dsCuiadadesTableAdapters.CuidadTableAdapter
End Class
