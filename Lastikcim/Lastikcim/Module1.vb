Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module AyarlarModule
    Public Function SqlBaglantiCumlesi() As String
        Dim SqlBaglantiCumlesiOlusturucu As New SqlConnectionStringBuilder
        SqlBaglantiCumlesiOlusturucu.DataSource = "."
        SqlBaglantiCumlesiOlusturucu.InitialCatalog = "Lastikcim"
        SqlBaglantiCumlesiOlusturucu.IntegratedSecurity = False
        SqlBaglantiCumlesiOlusturucu.PersistSecurityInfo = False
        Return SqlBaglantiCumlesiOlusturucu.ConnectionString
    End Function

End Module
