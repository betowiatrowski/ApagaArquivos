Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports System
Imports System.Data
Imports System.IO
Imports System.IO.Compression
Imports System.Math
Imports System.DirectoryServices

Module Module1

    Sub Main()
        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo("D:\Backups\ImagensCode")

        Dim oFileInfoCollection() As FileInfo
        Dim oFileInfo As FileInfo
        Dim i As Integer

        oFileInfoCollection = DirDiretorio.GetFiles("*.*")

        For i = 0 To oFileInfoCollection.Length() - 1

            oFileInfo = oFileInfoCollection.GetValue(i)
            Console.Write("Apagando..." + oFileInfo.FullName)

            IO.File.Delete(oFileInfo.FullName)
        Next

        End
    End Sub

End Module
