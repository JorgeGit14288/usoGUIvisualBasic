<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOperaciones
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
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvPersona = New System.Windows.Forms.DataGridView()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tbxApellidos = New System.Windows.Forms.TextBox()
        Me.tbxNombres = New System.Windows.Forms.TextBox()
        Me.DataSet1 = New System.Data.DataSet()
        Me.btnLImpiar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(21, 477)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 0
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(57, 32)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(39, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Label1"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(138, 22)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvPersona)
        Me.Panel1.Location = New System.Drawing.Point(21, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 298)
        Me.Panel1.TabIndex = 3
        '
        'dgvPersona
        '
        Me.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersona.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNombre, Me.cApellidos})
        Me.dgvPersona.Location = New System.Drawing.Point(0, 3)
        Me.dgvPersona.Name = "dgvPersona"
        Me.dgvPersona.Size = New System.Drawing.Size(331, 281)
        Me.dgvPersona.TabIndex = 0
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        '
        'cApellidos
        '
        Me.cApellidos.HeaderText = "Apellidos"
        Me.cApellidos.Name = "cApellidos"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnLImpiar)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.tbxApellidos)
        Me.Panel2.Controls.Add(Me.tbxNombres)
        Me.Panel2.Location = New System.Drawing.Point(379, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 298)
        Me.Panel2.TabIndex = 4
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(50, 159)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(50, 118)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'tbxApellidos
        '
        Me.tbxApellidos.Location = New System.Drawing.Point(36, 76)
        Me.tbxApellidos.Name = "tbxApellidos"
        Me.tbxApellidos.Size = New System.Drawing.Size(100, 20)
        Me.tbxApellidos.TabIndex = 1
        '
        'tbxNombres
        '
        Me.tbxNombres.Location = New System.Drawing.Point(36, 28)
        Me.tbxNombres.Name = "tbxNombres"
        Me.tbxNombres.Size = New System.Drawing.Size(100, 20)
        Me.tbxNombres.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'btnLImpiar
        '
        Me.btnLImpiar.Location = New System.Drawing.Point(50, 200)
        Me.btnLImpiar.Name = "btnLImpiar"
        Me.btnLImpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLImpiar.TabIndex = 4
        Me.btnLImpiar.Text = "Eliminar todo"
        Me.btnLImpiar.UseVisualStyleBackColor = True
        '
        'formOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 527)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnRegresar)
        Me.Name = "formOperaciones"
        Me.Text = "formOperaciones"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvPersona As System.Windows.Forms.DataGridView
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents tbxApellidos As System.Windows.Forms.TextBox
    Friend WithEvents tbxNombres As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnLImpiar As System.Windows.Forms.Button
End Class
