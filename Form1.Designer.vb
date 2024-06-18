<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnExportXML = New System.Windows.Forms.Button()
        Me.btnImportXML = New System.Windows.Forms.Button()
        Me.btnExportJSON = New System.Windows.Forms.Button()
        Me.btnImportJSON = New System.Windows.Forms.Button()
        Me.btnExportCSV = New System.Windows.Forms.Button()
        Me.btnImportCSV = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.dtFechaCreacion = New System.Windows.Forms.DateTimePicker()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(38, 415)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(16, 13)
        Me.label6.TabIndex = 43
        Me.label6.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(80, 412)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(147, 20)
        Me.txtId.TabIndex = 42
        '
        'btnExportXML
        '
        Me.btnExportXML.Location = New System.Drawing.Point(632, 351)
        Me.btnExportXML.Name = "btnExportXML"
        Me.btnExportXML.Size = New System.Drawing.Size(111, 59)
        Me.btnExportXML.TabIndex = 41
        Me.btnExportXML.Text = "ExportXML"
        Me.btnExportXML.UseVisualStyleBackColor = True
        '
        'btnImportXML
        '
        Me.btnImportXML.Location = New System.Drawing.Point(632, 270)
        Me.btnImportXML.Name = "btnImportXML"
        Me.btnImportXML.Size = New System.Drawing.Size(111, 59)
        Me.btnImportXML.TabIndex = 40
        Me.btnImportXML.Text = "ImportXML"
        Me.btnImportXML.UseVisualStyleBackColor = True
        '
        'btnExportJSON
        '
        Me.btnExportJSON.Location = New System.Drawing.Point(776, 270)
        Me.btnExportJSON.Name = "btnExportJSON"
        Me.btnExportJSON.Size = New System.Drawing.Size(111, 59)
        Me.btnExportJSON.TabIndex = 39
        Me.btnExportJSON.Text = "ExportJSON"
        Me.btnExportJSON.UseVisualStyleBackColor = True
        '
        'btnImportJSON
        '
        Me.btnImportJSON.Location = New System.Drawing.Point(776, 189)
        Me.btnImportJSON.Name = "btnImportJSON"
        Me.btnImportJSON.Size = New System.Drawing.Size(111, 59)
        Me.btnImportJSON.TabIndex = 38
        Me.btnImportJSON.Text = "ImportJSON"
        Me.btnImportJSON.UseVisualStyleBackColor = True
        '
        'btnExportCSV
        '
        Me.btnExportCSV.Location = New System.Drawing.Point(776, 101)
        Me.btnExportCSV.Name = "btnExportCSV"
        Me.btnExportCSV.Size = New System.Drawing.Size(111, 59)
        Me.btnExportCSV.TabIndex = 37
        Me.btnExportCSV.Text = "ExportCSV"
        Me.btnExportCSV.UseVisualStyleBackColor = True
        '
        'btnImportCSV
        '
        Me.btnImportCSV.Location = New System.Drawing.Point(776, 12)
        Me.btnImportCSV.Name = "btnImportCSV"
        Me.btnImportCSV.Size = New System.Drawing.Size(111, 59)
        Me.btnImportCSV.TabIndex = 36
        Me.btnImportCSV.Text = "ImportCSV"
        Me.btnImportCSV.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(261, 492)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 13)
        Me.label5.TabIndex = 35
        Me.label5.Text = "Description"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(327, 489)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(450, 20)
        Me.txtDescripcion.TabIndex = 34
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(31, 492)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 33
        Me.label4.Text = "Amount"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(80, 489)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(147, 20)
        Me.txtCantidad.TabIndex = 32
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(518, 450)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(74, 13)
        Me.label3.TabIndex = 31
        Me.label3.Text = "Deeation date"
        '
        'dtFechaCreacion
        '
        Me.dtFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCreacion.Location = New System.Drawing.Point(598, 447)
        Me.dtFechaCreacion.Name = "dtFechaCreacion"
        Me.dtFechaCreacion.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaCreacion.TabIndex = 30
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(285, 450)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(31, 13)
        Me.label2.TabIndex = 29
        Me.label2.Text = "Price"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(327, 447)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(147, 20)
        Me.txtPrecio.TabIndex = 28
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(38, 450)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 13)
        Me.label1.TabIndex = 27
        Me.label1.Text = "Model"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(80, 447)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(147, 20)
        Me.txtModelo.TabIndex = 26
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(632, 189)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 59)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(632, 101)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 59)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(632, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 59)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dataGridView
        '
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Location = New System.Drawing.Point(12, 12)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(600, 385)
        Me.dataGridView.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 518)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnExportXML)
        Me.Controls.Add(Me.btnImportXML)
        Me.Controls.Add(Me.btnExportJSON)
        Me.Controls.Add(Me.btnImportJSON)
        Me.Controls.Add(Me.btnExportCSV)
        Me.Controls.Add(Me.btnImportCSV)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.dtFechaCreacion)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dataGridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label6 As Label
    Private WithEvents txtId As TextBox
    Private WithEvents btnExportXML As Button
    Private WithEvents btnImportXML As Button
    Private WithEvents btnExportJSON As Button
    Private WithEvents btnImportJSON As Button
    Private WithEvents btnExportCSV As Button
    Private WithEvents btnImportCSV As Button
    Private WithEvents label5 As Label
    Private WithEvents txtDescripcion As TextBox
    Private WithEvents label4 As Label
    Private WithEvents txtCantidad As TextBox
    Private WithEvents label3 As Label
    Private WithEvents dtFechaCreacion As DateTimePicker
    Private WithEvents label2 As Label
    Private WithEvents txtPrecio As TextBox
    Private WithEvents label1 As Label
    Private WithEvents txtModelo As TextBox
    Private WithEvents btnDelete As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents btnAdd As Button
    Private WithEvents dataGridView As DataGridView
End Class
