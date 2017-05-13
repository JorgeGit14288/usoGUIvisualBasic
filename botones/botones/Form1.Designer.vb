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
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.lstAgregar = New System.Windows.Forms.ListBox()
        Me.btnAgregarLista = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEliminarSel = New System.Windows.Forms.Button()
        Me.btnLimpiarcbx = New System.Windows.Forms.Button()
        Me.btnAgregarcbx = New System.Windows.Forms.Button()
        Me.tbxAgregarcbx = New System.Windows.Forms.TextBox()
        Me.lblVerFrutas = New System.Windows.Forms.Label()
        Me.btnVerch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxFrutas = New System.Windows.Forms.CheckedListBox()
        Me.btnIr = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(13, 29)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbxNombre.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(147, 29)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Location = New System.Drawing.Point(145, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(77, 13)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Text = "Su Nombre es:"
        '
        'lstAgregar
        '
        Me.lstAgregar.FormattingEnabled = True
        Me.lstAgregar.Items.AddRange(New Object() {"Jorge" & Global.Microsoft.VisualBasic.ChrW(9), "Luis" & Global.Microsoft.VisualBasic.ChrW(9), "Carlos"})
        Me.lstAgregar.Location = New System.Drawing.Point(13, 81)
        Me.lstAgregar.Name = "lstAgregar"
        Me.lstAgregar.Size = New System.Drawing.Size(120, 95)
        Me.lstAgregar.TabIndex = 3
        '
        'btnAgregarLista
        '
        Me.btnAgregarLista.Location = New System.Drawing.Point(147, 81)
        Me.btnAgregarLista.Name = "btnAgregarLista"
        Me.btnAgregarLista.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarLista.TabIndex = 4
        Me.btnAgregarLista.Text = "Agregar"
        Me.btnAgregarLista.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(147, 110)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(147, 153)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "INGRESE SU NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "EJEMPLO DE LISTBOX"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tbxNombre)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.lstAgregar)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnAgregarLista)
        Me.Panel1.Location = New System.Drawing.Point(12, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 252)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEliminarSel)
        Me.Panel2.Controls.Add(Me.btnLimpiarcbx)
        Me.Panel2.Controls.Add(Me.btnAgregarcbx)
        Me.Panel2.Controls.Add(Me.tbxAgregarcbx)
        Me.Panel2.Controls.Add(Me.lblVerFrutas)
        Me.Panel2.Controls.Add(Me.btnVerch)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cbxFrutas)
        Me.Panel2.Location = New System.Drawing.Point(304, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(313, 252)
        Me.Panel2.TabIndex = 10
        '
        'btnEliminarSel
        '
        Me.btnEliminarSel.Location = New System.Drawing.Point(163, 95)
        Me.btnEliminarSel.Name = "btnEliminarSel"
        Me.btnEliminarSel.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarSel.TabIndex = 7
        Me.btnEliminarSel.Text = "Eliminar Se"
        Me.btnEliminarSel.UseVisualStyleBackColor = True
        '
        'btnLimpiarcbx
        '
        Me.btnLimpiarcbx.Location = New System.Drawing.Point(163, 119)
        Me.btnLimpiarcbx.Name = "btnLimpiarcbx"
        Me.btnLimpiarcbx.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarcbx.TabIndex = 6
        Me.btnLimpiarcbx.Text = "Limpiar"
        Me.btnLimpiarcbx.UseVisualStyleBackColor = True
        '
        'btnAgregarcbx
        '
        Me.btnAgregarcbx.Location = New System.Drawing.Point(163, 65)
        Me.btnAgregarcbx.Name = "btnAgregarcbx"
        Me.btnAgregarcbx.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarcbx.TabIndex = 5
        Me.btnAgregarcbx.Text = "Agregar"
        Me.btnAgregarcbx.UseVisualStyleBackColor = True
        '
        'tbxAgregarcbx
        '
        Me.tbxAgregarcbx.Location = New System.Drawing.Point(163, 39)
        Me.tbxAgregarcbx.Name = "tbxAgregarcbx"
        Me.tbxAgregarcbx.Size = New System.Drawing.Size(100, 20)
        Me.tbxAgregarcbx.TabIndex = 4
        '
        'lblVerFrutas
        '
        Me.lblVerFrutas.AutoSize = True
        Me.lblVerFrutas.Location = New System.Drawing.Point(85, 193)
        Me.lblVerFrutas.Name = "lblVerFrutas"
        Me.lblVerFrutas.Size = New System.Drawing.Size(16, 13)
        Me.lblVerFrutas.TabIndex = 3
        Me.lblVerFrutas.Text = "er"
        '
        'btnVerch
        '
        Me.btnVerch.Location = New System.Drawing.Point(78, 153)
        Me.btnVerch.Name = "btnVerch"
        Me.btnVerch.Size = New System.Drawing.Size(75, 23)
        Me.btnVerch.TabIndex = 2
        Me.btnVerch.Text = "Ver Checks"
        Me.btnVerch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ejemplo de CheckListBox"
        '
        'cbxFrutas
        '
        Me.cbxFrutas.FormattingEnabled = True
        Me.cbxFrutas.Items.AddRange(New Object() {"Manzanas", "Peras", "Uvas", "Dulces"})
        Me.cbxFrutas.Location = New System.Drawing.Point(13, 39)
        Me.cbxFrutas.Name = "cbxFrutas"
        Me.cbxFrutas.Size = New System.Drawing.Size(120, 94)
        Me.cbxFrutas.TabIndex = 0
        '
        'btnIr
        '
        Me.btnIr.Location = New System.Drawing.Point(574, 451)
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(75, 23)
        Me.btnIr.TabIndex = 11
        Me.btnIr.Text = "ir a form 2"
        Me.btnIr.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 503)
        Me.Controls.Add(Me.btnIr)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Prueb de elementos basicos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbxNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.Label
    Friend WithEvents lstAgregar As System.Windows.Forms.ListBox
    Friend WithEvents btnAgregarLista As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxFrutas As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnVerch As System.Windows.Forms.Button
    Friend WithEvents btnAgregarcbx As System.Windows.Forms.Button
    Friend WithEvents tbxAgregarcbx As System.Windows.Forms.TextBox
    Friend WithEvents lblVerFrutas As System.Windows.Forms.Label
    Friend WithEvents btnLimpiarcbx As System.Windows.Forms.Button
    Friend WithEvents btnEliminarSel As System.Windows.Forms.Button
    Friend WithEvents btnIr As System.Windows.Forms.Button

End Class
