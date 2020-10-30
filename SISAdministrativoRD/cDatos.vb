Imports System.Data.SqlClient
Imports System.Collections.Generic

Imports System.Configuration
Imports System.IO


Public Class cDatos
    Dim connectionString As String
    Public Function GetModificarMarcaRow(ByVal strIdMarca As Integer, ByVal StrDescripcionMarca As [String], ByVal blnEstatus As Boolean) As DataSet
        Try

     
        Dim datos As New DataSet()
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "spUpdateMarca"
        command.Parameters.Add("@IdMarca", SqlDbType.Int).Value = strIdMarca
        command.Parameters.Add("@DescripcionMarca", SqlDbType.NVarChar, 100).Value = StrDescripcionMarca
        command.Parameters.Add("@Estatus", SqlDbType.Bit).Value = blnEstatus
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
        Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetModificarProveedorRow(ByVal intIdProveedor As Integer, ByVal strCodigo As String, ByVal strRCN As String, ByVal strDesProveedor As String, ByVal strContacto As String, ByVal strDireccion As String, ByVal strTelefono As String, ByVal strTelefonoMovil As String, ByVal strEmail As String, ByVal strBalance As String, ByVal dtmFechaIngreso As DateTime, ByVal blnEstatusMarca As Boolean) As DataSet
        Try

       
        Dim datos As New DataSet()
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "spUpdateProveedor"
        command.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = intIdProveedor
        command.Parameters.Add("@Codigo", SqlDbType.NVarChar, 12).Value = strCodigo
        command.Parameters.Add("@Rcn", SqlDbType.NChar, 10).Value = strRCN
        command.Parameters.Add("@DesProveedor", SqlDbType.NVarChar, 100).Value = strDesProveedor
        command.Parameters.Add("@Contacto", SqlDbType.NVarChar, 100).Value = strContacto
        command.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = strDireccion
        command.Parameters.Add("@Telefono", SqlDbType.NVarChar, 80).Value = strTelefono
        command.Parameters.Add("@TelefonoMovil", SqlDbType.NVarChar, 80).Value = strTelefonoMovil
        command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = strEmail
        command.Parameters.Add("@Balance", SqlDbType.NVarChar, 100).Value = strBalance
        command.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = dtmFechaIngreso
        command.Parameters.Add("@Estatus", SqlDbType.Bit).Value = blnEstatusMarca

        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
        Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetModificarUnidadRow(ByVal strIdMarca As Integer, ByVal StrDescripcionMarca As [String], ByVal blnEstatus As Boolean) As DataSet
        Try

   
        Dim datos As New DataSet()
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "spUpdateUnidades"
        command.Parameters.Add("@IdUnidadMedida", SqlDbType.Int).Value = strIdMarca
        command.Parameters.Add("@DescripcionUnidadMedida", SqlDbType.NVarChar, 100).Value = StrDescripcionMarca
        command.Parameters.Add("@EstatusUnidad", SqlDbType.Bit).Value = blnEstatus
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
        Return datos
        Catch ex As Exception

        End Try
    End Function

    Public Function GetModificarCategoriaRow(ByVal strIdCategoria As Integer, ByVal StrDescripcionCategoria As [String], ByVal blnEstatus As Boolean) As DataSet
        Try

            Dim datos As New DataSet()
            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spUpdateCategoria"
            command.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = strIdCategoria
            command.Parameters.Add("@DescripcionCategoria", SqlDbType.NVarChar, 100).Value = StrDescripcionCategoria
            command.Parameters.Add("@EstatusCategoria", SqlDbType.Bit).Value = blnEstatus
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Public Function GetModificarArticuloRow(ByVal IdArticulo As Integer, ByVal strCodigo As String, ByVal imgCodigoEtiqueta As Byte(), ByVal strArticulo As String, ByVal PrecioCompra As Decimal, ByVal Precio1 As Decimal, ByVal Precio2 As Decimal, ByVal IdUnidad As Integer, ByVal IdCategoria As Integer, ByVal IdMarca As Integer, ByVal IdProveedor As Integer, ByVal Existencia As Decimal, ByVal IdAlmacen As Integer, ByVal EstatusArticulo As Boolean) As DataSet
        Try

            Dim datos As New DataSet()
            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spUpdateArticulo"
            command.Parameters.Add("@IdArticulo", SqlDbType.Int).Value = IdArticulo
            command.Parameters.Add("@Codigo", SqlDbType.NVarChar, 100).Value = strCodigo
            command.Parameters.Add("@CodigoEtiqueta", SqlDbType.Image).Value = imgCodigoEtiqueta
            command.Parameters.Add("@DescripcionArt", SqlDbType.NVarChar, 80).Value = strArticulo
            command.Parameters.Add("@Precio", SqlDbType.Decimal).Value = PrecioCompra
            command.Parameters.Add("@Precio1", SqlDbType.Decimal).Value = Precio1
            command.Parameters.Add("@Precio2", SqlDbType.Decimal).Value = Precio2
            command.Parameters.Add("@IdUnidad", SqlDbType.Int).Value = IdUnidad
            command.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = IdCategoria
            command.Parameters.Add("@IdMarca", SqlDbType.Int).Value = IdMarca
            command.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = IdProveedor
            command.Parameters.Add("@Existencia", SqlDbType.Decimal).Value = Existencia
            command.Parameters.Add("@IdAlmacen", SqlDbType.Int).Value = IdAlmacen
            command.Parameters.Add("@Estatus", SqlDbType.Int).Value = EstatusArticulo
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Friend Function IncDecFunc(ByVal Number As String) As String
        Try

            Dim long_post As Integer = 0
            Dim long_total As Integer = 0
            Dim i As Integer = 0
            Dim n As Long = 0
            Dim mask As String = ""
            Dim temp As String = ""
            Dim t1 As String = ""

            long_total = Len(Number)
            For i = 1 To long_total
                t1 = Mid(Number, (long_total - i + 1), 1)
                If (IsNumeric(t1)) And (t1 <> "-") Then
                    temp = temp + Mid(Number, (long_total - i + 1), 1)
                Else
                    mask = Mid(Number, 1, (long_total - i + 1))
                    temp = Mid(Number, (long_total - i + 1) + 1, long_total - (long_total - i + 1))
                    i = long_total
                End If
            Next
            If mask = "" Then
                temp = Number
            End If
            long_post = Len(temp)
            n = Val(temp)
            n += 1
            temp = Trim(Str(n))
            While Len(temp) < long_post
                temp = "0" & Trim(temp)
            End While
            Return mask & temp


        Catch ex As Exception

        End Try
    End Function
    Public Function GetNextArticulo() As String
        Try

      
        Dim connexion As New SqlConnection
        Dim command As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim datos As New DataSet
        Dim siguiente As String
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetNextArticulo"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        If IsDBNull(datos.Tables(0).Rows(0).Item(0)) Then
            siguiente = "00000001"
        Else
            siguiente = IncDecFunc(datos.Tables(0).Rows(0).Item(0))
        End If
        Return siguiente
        command.Connection.Close()
            command.Connection.Dispose()

        Catch ex As Exception

        End Try
    End Function
    Public Function GetNextProveedor() As String
        Try

       
        Dim connexion As New SqlConnection
        Dim command As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim datos As New DataSet
        Dim siguiente As String
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetNextProveedor"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        If IsDBNull(datos.Tables(0).Rows(0).Item(0)) Then
            siguiente = "00000001"
        Else
            siguiente = IncDecFunc(datos.Tables(0).Rows(0).Item(0))
        End If
        Return siguiente
        command.Connection.Close()
            command.Connection.Dispose()

        Catch ex As Exception

        End Try
    End Function

    Public Function GetModificarAlmacenRow(ByVal strIdAlmacen As Integer, ByVal StrDescripcionAlmacen As [String], ByVal blnEstatus As Boolean) As DataSet
        Try

    
        Dim datos As New DataSet()
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "spUpdateAlmacen"
        command.Parameters.Add("@IdAlmacen", SqlDbType.Int).Value = strIdAlmacen
        command.Parameters.Add("@DescripcionAlmacen", SqlDbType.NVarChar, 100).Value = StrDescripcionAlmacen
        command.Parameters.Add("@EstatusAlmacen", SqlDbType.Bit).Value = blnEstatus
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
        Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetModificarConfigEtiquetaRow(ByVal IdConfiEtiqueta As Integer, ByVal Altuta As String, ByVal Anchura As String, ByVal NEtiquetas As Integer, ByVal ArribaAbajo As String, ByVal DerechaIzquierda00 As String, ByVal DerechaIzquierda01 As String, ByVal DerechaIzquierda02 As String, ByVal DerechaIzquierda03 As String) As DataSet
        Try


            Dim datos As New DataSet()
            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spUpdateConfigEtiqueta"
            command.Parameters.Add("@IdConfiEtiqueta", SqlDbType.Int).Value = IdConfiEtiqueta
            command.Parameters.Add("@Altura", SqlDbType.NVarChar, 12).Value = Altuta
            command.Parameters.Add("@Anchura", SqlDbType.NVarChar, 12).Value = Anchura
            command.Parameters.Add("@NEtiquetas", SqlDbType.Int).Value = NEtiquetas
            command.Parameters.Add("@ArribaAbajo", SqlDbType.NVarChar, 12).Value = ArribaAbajo

            command.Parameters.Add("@DerechaIzquierda00", SqlDbType.NVarChar, 12).Value = DerechaIzquierda00
            command.Parameters.Add("@DerechaIzquierda01", SqlDbType.NVarChar, 12).Value = DerechaIzquierda01
            command.Parameters.Add("@DerechaIzquierda02", SqlDbType.NVarChar, 12).Value = DerechaIzquierda02
            command.Parameters.Add("@DerechaIzquierda03", SqlDbType.NVarChar, 12).Value = DerechaIzquierda03

            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function

    Public Function GetMarcasAll() As DataSet
        Try

       
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetMarcasAll"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetMarcasAllAct() As DataSet
        Try

    
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetMarcasAllAct"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetProveedoresAll() As DataSet
        Try

     
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetProveedoresAll"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
            command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetProveedoresAllAct() As DataSet
        Try

      
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetProveedoresAllAct"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetUnidadesAll() As DataSet
        Try

            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            Dim datos As New DataSet()
            connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "SPGetUnidadesAll"
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Public Function GetUnidadesAllAct() As DataSet
        Try

    
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetUnidadesAllAct"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetCategoriasAll() As DataSet
        Try

      
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetCategoriasAll"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetArticulosAll() As DataSet
        Try

       
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetArticulosAll"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetEtiquetasConfigAll() As DataSet
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetConfigEtiquetasAll"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
        Return datos
    End Function
    Public Function GetEtiquetasConfigSelect(ByVal Codigo As String) As DataSet
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "GetEtiquetasConfigSelect"
        command.Parameters.Add("@Codigo", SqlDbType.NVarChar, 12).Value = Codigo
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
        Return datos
    End Function
    Public Function GetArticulosEtiquetasAll() As DataSet
        Try

            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            Dim datos As New DataSet()
            connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "SPGetArticulosEquetiquetasAll"
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Public Function GetCategoriasAllAct() As DataSet
        Try

        
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetCategoriasAllAct"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetAlmacenAll() As DataSet
        Try

            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            Dim datos As New DataSet()
            connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "SPGetAlmacenAll"
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Public Function GetAlmacenAllAct() As DataSet
        Try

      
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim datos As New DataSet()
        connectionString = ConfigurationManager.ConnectionStrings("BDSISAdmin").ConnectionString
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "SPGetAlmacenAllAct"
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
            Return datos
        Catch ex As Exception

        End Try
    End Function


    Public Function GetInsertMarcaRow(ByVal strUnidad As String, ByVal blnEstatusMarca As Boolean) As DataSet
        Try

            Dim datos As New DataSet()
            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spInsertMarca"
            command.Parameters.Add("@DescripcionMarca", SqlDbType.NVarChar, 100).Value = strUnidad
            command.Parameters.Add("@EstatusMarca", SqlDbType.Bit).Value = blnEstatusMarca
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Public Function GetInsertProveedorRow(ByVal strCodigo As String, ByVal strRCN As String, ByVal strDesProveedor As String, ByVal strContacto As String, ByVal strDireccion As String, ByVal strTelefono As String, ByVal strTelefonoMovil As String, ByVal strEmail As String, ByVal strBalance As String, ByVal dtmFechaIngreso As DateTime, ByVal blnEstatusMarca As Boolean) As DataSet
        Try

            Dim datos As New DataSet()
            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spInsertProveedor"
            command.Parameters.Add("@Codigo", SqlDbType.NVarChar, 12).Value = strCodigo
            command.Parameters.Add("@Rcn", SqlDbType.NChar, 10).Value = strRCN
            command.Parameters.Add("@DesProveedor", SqlDbType.NVarChar, 100).Value = strDesProveedor
            command.Parameters.Add("@Contacto", SqlDbType.NVarChar, 100).Value = strContacto
            command.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = strDireccion
            command.Parameters.Add("@Telefono", SqlDbType.NVarChar, 80).Value = strTelefono
            command.Parameters.Add("@TelefonoMovil", SqlDbType.NVarChar, 80).Value = strTelefonoMovil
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = strEmail
            command.Parameters.Add("@Balance", SqlDbType.NVarChar, 100).Value = strBalance
            command.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = dtmFechaIngreso
            command.Parameters.Add("@EstatusProveedor", SqlDbType.Bit).Value = blnEstatusMarca

            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Public Function GetInsertUnidadRow(ByVal strUnidad As String, ByVal blnEstatusUnidad As Boolean) As DataSet
        Try

            Dim datos As New DataSet()
            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spInsertUnidades"
            command.Parameters.Add("@DescripcionUnidadMedida", SqlDbType.NVarChar, 100).Value = strUnidad
            command.Parameters.Add("@EstatusUnidadMedida", SqlDbType.Bit).Value = blnEstatusUnidad
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Public Function GetInsertCategoriaRow(ByVal strCategoria As String, ByVal blnEstatusCategoria As Boolean) As DataSet
        Try

            Dim datos As New DataSet()
            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spInsertCategoria"
            command.Parameters.Add("@DescripcionCategoria", SqlDbType.NVarChar, 100).Value = strCategoria
            command.Parameters.Add("@EstatusCategoria", SqlDbType.Bit).Value = blnEstatusCategoria
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Public Function GetInsertArticuloRow(ByVal strCodigo As String, ByVal imgCodigoEtiqueta As Byte(), ByVal strArticulo As String, ByVal PrecioCompra As Decimal, ByVal Precio1 As Decimal, ByVal Precio2 As Decimal, ByVal IdUnidad As Integer, ByVal IdCategoria As Integer, ByVal IdMarca As Integer, ByVal IdProveedor As Integer, ByVal Existencia As Decimal, ByVal IdAlmacen As Integer, ByVal EstatusArticulo As Boolean) As DataSet
        Try

            Dim datos As New DataSet()
            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()

            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spInsertArticulo"
            command.Parameters.Add("@Codigo", SqlDbType.NVarChar, 100).Value = strCodigo
            command.Parameters.Add("@CodigoEtiqueta", SqlDbType.Image).Value = imgCodigoEtiqueta
            command.Parameters.Add("@DescripcionArt", SqlDbType.NVarChar, 80).Value = strArticulo
            command.Parameters.Add("@Precio", SqlDbType.Decimal).Value = PrecioCompra
            command.Parameters.Add("@Precio1", SqlDbType.Decimal).Value = Precio1
            command.Parameters.Add("@Precio2", SqlDbType.Decimal).Value = Precio2
            command.Parameters.Add("@IdUnidad", SqlDbType.Int).Value = IdUnidad
            command.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = IdCategoria
            command.Parameters.Add("@IdMarca", SqlDbType.Int).Value = IdMarca
            command.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = IdProveedor
            command.Parameters.Add("@Existencia", SqlDbType.Decimal).Value = Existencia
            command.Parameters.Add("@IdAlmacen", SqlDbType.Int).Value = IdAlmacen
            command.Parameters.Add("@EstatusArticulo", SqlDbType.Int).Value = EstatusArticulo

            command.Parameters.Add("@Altura", SqlDbType.Int).Value = 1000
            command.Parameters.Add("@Anchura", SqlDbType.Int).Value = 1000
            command.Parameters.Add("@NEtiquetas", SqlDbType.Int).Value = 1
            command.Parameters.Add("@ArribaAbajo", SqlDbType.Int).Value = 250
            command.Parameters.Add("@DerechaIzquierda00", SqlDbType.Int).Value = 650
            command.Parameters.Add("@DerechaIzquierda01", SqlDbType.Int).Value = 3500
            command.Parameters.Add("@DerechaIzquierda02", SqlDbType.Int).Value = 6800
            command.Parameters.Add("@DerechaIzquierda03", SqlDbType.Int).Value = 9600

            command.Parameters.Add("@Fechahora", SqlDbType.DateTime).Value = Now.Date
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)
            command.Connection.Close()
            command.Connection.Dispose()
            Return datos

        Catch ex As Exception

        End Try
    End Function
    Public Function GetInsertAlmacenRow(ByVal strAlmacen As String, ByVal blnEstatusAlmacen As Boolean) As DataSet
        Try

       
        Dim datos As New DataSet()
        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "spInsertAlmacen"
        command.Parameters.Add("@DescripcionAlmacen", SqlDbType.NVarChar, 100).Value = strAlmacen
        command.Parameters.Add("@EstatusAlmacen", SqlDbType.Bit).Value = blnEstatusAlmacen
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)
        command.Connection.Close()
        command.Connection.Dispose()
        Return datos
        Catch ex As Exception

        End Try
    End Function
    Public Function GetBuscarArticuloSelect(ByVal strcodigo As [String]) As [Boolean]

        Try


            Dim Buscar As [Boolean]
            Dim datos As New DataSet()

            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spBuscarArticulo"
            command.Parameters.Add("@codigo", SqlDbType.NVarChar, 10).Value = strcodigo
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)

            If datos.Tables(0).Rows.Count > 0 Then
                Buscar = True
            Else
                Buscar = False
            End If
            command.Connection.Close()
            command.Connection.Dispose()
            Return Buscar


        Catch ex As Exception

        End Try
    End Function
    Public Function GetBuscarMarcaSelect(ByVal strMarca As [String]) As [Boolean]

        Try

            Dim Buscar As [Boolean]
            Dim datos As New DataSet()

            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spBuscarMarca"
            command.Parameters.Add("@DescripcionMarca", SqlDbType.NVarChar, 50).Value = strMarca
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)

            If datos.Tables(0).Rows.Count > 0 Then
                Buscar = True
            Else
                Buscar = False
            End If
            command.Connection.Close()
            command.Connection.Dispose()
            Return Buscar


        Catch ex As Exception

        End Try
    End Function

    Public Function GetBuscarProveedorSelect(ByVal strRCN As [String]) As [Boolean]

        Try

  

        Dim Buscar As [Boolean]
        Dim datos As New DataSet()

        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "spBuscarProveedor"
        command.Parameters.Add("@RCN", SqlDbType.NVarChar, 50).Value = strRCN
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)

        If datos.Tables(0).Rows.Count > 0 Then
            Buscar = True
        Else
            Buscar = False
        End If
        command.Connection.Close()
        command.Connection.Dispose()
            Return Buscar

        Catch ex As Exception

        End Try
    End Function

    Public Function GetBuscarAlmacenSelect(ByVal strAlmacen As [String]) As [Boolean]

        Try

            Dim Buscar As [Boolean]
            Dim datos As New DataSet()

            Dim connexion As New SqlConnection()
            Dim command As New SqlCommand()
            Dim da As New SqlDataAdapter()
            connexion.ConnectionString = connectionString
            command.Connection = connexion
            command.CommandText = "spBuscarAlmacen"
            command.Parameters.Add("@DescripcionAlmacen", SqlDbType.NVarChar, 50).Value = strAlmacen
            command.CommandType = CommandType.StoredProcedure
            da.SelectCommand = command
            da.Fill(datos)

            If datos.Tables(0).Rows.Count > 0 Then




                Buscar = True
            Else




                Buscar = False
            End If

            command.Connection.Close()
            command.Connection.Dispose()


            Return Buscar


        Catch ex As Exception

        End Try
    End Function


    Public Function GetBuscarUnidadSelect(ByVal strUnidad As [String]) As [Boolean]
        Try

   

        Dim Buscar As [Boolean]
        Dim datos As New DataSet()

        Dim connexion As New SqlConnection()
        Dim command As New SqlCommand()
        Dim da As New SqlDataAdapter()
        connexion.ConnectionString = connectionString
        command.Connection = connexion
        command.CommandText = "spBuscarUnidades"
        command.Parameters.Add("@DescripcionUnidadMedida", SqlDbType.NVarChar, 50).Value = strUnidad
        command.CommandType = CommandType.StoredProcedure
        da.SelectCommand = command
        da.Fill(datos)

        If datos.Tables(0).Rows.Count > 0 Then

            Buscar = True
        Else
            Buscar = False
        End If

        command.Connection.Close()
        command.Connection.Dispose()

            Return Buscar
        Catch ex As Exception

        End Try
    End Function

End Class
