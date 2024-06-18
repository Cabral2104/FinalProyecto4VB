Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports System.Xml.Linq
Imports System.Xml

Public Class Form1
    Private connectionString As String = "Server=DESKTOP-UBTP0PR;Database=Tenis;Integrated Security=True;"
    Private connection As SqlConnection

    Public Sub New()
        InitializeComponent()
        DisplayData()
    End Sub

    Private Sub OpenConnection()
        If connection Is Nothing Then
            connection = New SqlConnection(connectionString)
        End If

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Private Sub CloseConnection()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Function LoadData() As DataTable
        OpenConnection()
        Dim query As String = "SELECT Id, Modelo, Precio, FechaCreacion, Cantidad, Descripcion FROM InventarioTenis"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        CloseConnection()
        Return dataTable
    End Function

    Private Sub DisplayData()
        dataGridView.DataSource = LoadData()
    End Sub

    Private Sub AddData(modelo As String, precio As Decimal, fechaCreacion As DateTime, cantidad As Integer, descripcion As String)
        OpenConnection()
        Dim query As String = "INSERT INTO InventarioTenis (Modelo, Precio, FechaCreacion, Cantidad, Descripcion) " & "VALUES (@Modelo, @Precio, @FechaCreacion, @Cantidad, @Descripcion)"
        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Modelo", modelo)
        cmd.Parameters.AddWithValue("@Precio", precio)
        cmd.Parameters.AddWithValue("@FechaCreacion", fechaCreacion)
        cmd.Parameters.AddWithValue("@Cantidad", cantidad)
        cmd.Parameters.AddWithValue("@Descripcion", descripcion)
        cmd.ExecuteNonQuery()
        CloseConnection()
        DisplayData()
    End Sub

    Private Sub UpdateData(id As Integer, modelo As String, precio As Decimal, fechaCreacion As DateTime, cantidad As Integer, descripcion As String)
        OpenConnection()
        Dim query As String = "UPDATE InventarioTenis SET Modelo = @Modelo, Precio = @Precio, FechaCreacion = @FechaCreacion, " & "Cantidad = @Cantidad, Descripcion = @Descripcion WHERE Id = @Id"
        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Id", id)
        cmd.Parameters.AddWithValue("@Modelo", modelo)
        cmd.Parameters.AddWithValue("@Precio", precio)
        cmd.Parameters.AddWithValue("@FechaCreacion", fechaCreacion)
        cmd.Parameters.AddWithValue("@Cantidad", cantidad)
        cmd.Parameters.AddWithValue("@Descripcion", descripcion)
        cmd.ExecuteNonQuery()
        CloseConnection()
        DisplayData()
    End Sub

    Private Sub DeleteData(id As Integer)
        OpenConnection()
        Dim query As String = "DELETE FROM InventarioTenis WHERE Id = @Id"
        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Id", id)
        cmd.ExecuteNonQuery()
        CloseConnection()
        DisplayData()
    End Sub

    Private Sub ImportFromCSV(filePath As String)
        Dim lines As String() = File.ReadAllLines(filePath)
        For Each line As String In lines.Skip(1)
            Dim values As String() = line.Split(","c)

            If values.Length < 5 Then
                MessageBox.Show("Formato de línea incorrecto: " & line)
                Continue For
            End If

            Dim modelo As String = values(0)

            Dim precio As Decimal
            If Not Decimal.TryParse(values(1), precio) Then
                MessageBox.Show($"Error al convertir '{values(1)}' a decimal para Precio.")
                Continue For
            End If

            Dim fechaCreacion As DateTime
            If Not DateTime.TryParse(values(2), fechaCreacion) Then
                Dim formats As String() = {"MM/dd/yyyy", "dd/MM/yyyy", "yyyy-MM-dd", "MM-dd-yyyy"}
                If Not DateTime.TryParseExact(values(2), formats, Nothing, Globalization.DateTimeStyles.None, fechaCreacion) Then
                    MessageBox.Show($"Error al convertir '{values(2)}' a DateTime para FechaCreacion.")
                    Continue For
                End If
            End If

            Dim cantidad As Integer
            If Not Integer.TryParse(values(3), cantidad) Then
                MessageBox.Show($"Error al convertir '{values(3)}' a int para Cantidad.")
                Continue For
            End If

            Dim descripcion As String = values(4)

            AddData(modelo, precio, fechaCreacion, cantidad, descripcion)
        Next
    End Sub

    Private Sub ImportFromJSON(filePath As String)
        Dim jsonData As String = File.ReadAllText(filePath)
        Dim dataList As YourDataModel() = JsonConvert.DeserializeObject(Of YourDataModel())(jsonData)
        For Each data As YourDataModel In dataList
            AddData(data.Modelo, data.Precio, data.FechaCreacion, data.Cantidad, data.Descripcion)
        Next
    End Sub

    Private Sub ImportFromXML(filePath As String)
        Dim xmlData As XDocument = XDocument.Load(filePath)
        Dim dataList As List(Of YourDataModel) = (From x In xmlData.Descendants("YourDataModel")
                                                  Select New YourDataModel With {
                                                      .Modelo = x.Element("Modelo").Value,
                                                      .Precio = Convert.ToDecimal(x.Element("Precio").Value),
                                                      .FechaCreacion = Convert.ToDateTime(x.Element("FechaCreacion").Value),
                                                      .Cantidad = Convert.ToInt32(x.Element("Cantidad").Value),
                                                      .Descripcion = x.Element("Descripcion").Value
                                                  }).ToList()

        For Each data As YourDataModel In dataList
            AddData(data.Modelo, data.Precio, data.FechaCreacion, data.Cantidad, data.Descripcion)
        Next
    End Sub

    Private Sub ExportToCSV(filePath As String)
        Dim dataTable As DataTable = LoadData()
        Dim lines(dataTable.Rows.Count) As String
        Dim columnNames As String = String.Join(",", dataTable.Columns.Cast(Of DataColumn)().Select(Function(column) column.ColumnName))
        lines(0) = columnNames
        Dim index As Integer = 1
        For Each row As DataRow In dataTable.Rows
            Dim values As String = String.Join(",", row.ItemArray.Select(Function(field) field.ToString()))
            lines(index) = values
            index += 1
        Next
        File.WriteAllLines(filePath, lines)
    End Sub

    Private Sub ExportToJSON(filePath As String)
        Dim dataTable = LoadData()
        Dim jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(dataTable, Newtonsoft.Json.Formatting.Indented)
        File.WriteAllText(filePath, jsonData)
    End Sub


    Private Sub ExportToXML(filePath As String)
        Dim dataTable As DataTable = LoadData()
        Dim xmlData As New XDocument(
            New XElement("InventarioTenis",
                From row In dataTable.AsEnumerable()
                Select New XElement("YourDataModel",
                    New XElement("Modelo", row.Field(Of String)("Modelo")),
                    New XElement("Precio", row.Field(Of Decimal)("Precio")),
                    New XElement("FechaCreacion", row.Field(Of DateTime)("FechaCreacion")),
                    New XElement("Cantidad", row.Field(Of Integer)("Cantidad")),
                    New XElement("Descripcion", row.Field(Of String)("Descripcion"))
                )
            )
        )
        xmlData.Save(filePath)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim modelo As String = txtModelo.Text
        Dim precio As Decimal = Convert.ToDecimal(txtPrecio.Text)
        Dim fechaCreacion As DateTime = dtFechaCreacion.Value
        Dim cantidad As Integer = Convert.ToInt32(txtCantidad.Text)
        Dim descripcion As String = txtDescripcion.Text
        AddData(modelo, precio, fechaCreacion, cantidad, descripcion)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As Integer = Convert.ToInt32(txtId.Text)
        Dim modelo As String = txtModelo.Text
        Dim precio As Decimal = Convert.ToDecimal(txtPrecio.Text)
        Dim fechaCreacion As DateTime = dtFechaCreacion.Value
        Dim cantidad As Integer = Convert.ToInt32(txtCantidad.Text)
        Dim descripcion As String = txtDescripcion.Text
        UpdateData(id, modelo, precio, fechaCreacion, cantidad, descripcion)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Convert.ToInt32(txtId.Text)
        DeleteData(id)
    End Sub

    Private Sub btnImportCSV_Click(sender As Object, e As EventArgs) Handles btnImportCSV.Click
        Dim openFileDialog As New OpenFileDialog()
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ImportFromCSV(openFileDialog.FileName)
        End If
    End Sub

    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        Dim saveFileDialog As New SaveFileDialog()
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ExportToCSV(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub btnImportJSON_Click(sender As Object, e As EventArgs) Handles btnImportJSON.Click
        Dim openFileDialog As New OpenFileDialog()
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ImportFromJSON(openFileDialog.FileName)
        End If
    End Sub

    Private Sub btnExportJSON_Click(sender As Object, e As EventArgs) Handles btnExportJSON.Click
        Dim saveFileDialog As New SaveFileDialog()
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ExportToJSON(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub btnImportXML_Click(sender As Object, e As EventArgs) Handles btnImportXML.Click
        Dim openFileDialog As New OpenFileDialog()
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ImportFromXML(openFileDialog.FileName)
        End If
    End Sub

    Private Sub btnExportXML_Click(sender As Object, e As EventArgs) Handles btnExportXML.Click
        Dim saveFileDialog As New SaveFileDialog()
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ExportToXML(saveFileDialog.FileName)
        End If
    End Sub

End Class
