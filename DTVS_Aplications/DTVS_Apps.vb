Imports Library_2

Public Class DTVS_Apps
    Private Sub DTVS_Apps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL = "USE FAS SELECT [App_Caption] as 'Название приложения',format([App_CreateDate], 'dd.MM.yyyy') as 'Дата создания', App_Path FROM [FAS].[dbo].[FAS_Applications]
                WHERE App_Path IS NOT NULL"
        LoadGridFromDB(DG_Applications, SQL)
        My.Computer.FileSystem.CreateDirectory("C:\App")
    End Sub
    'Опредеяем номер выбранной строки в таблице лотов
    Dim selRowNum As Integer
    Dim Path_Out, Path_In As String
    Private Sub DG_LOTListPresent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Applications.CellClick
        selRowNum = DG_Applications.CurrentCell.RowIndex
        If MsgBox("Запустить приложение " & DG_Applications.Rows(selRowNum).Cells(0).Value & " ?", vbYesNo) = vbYes Then
            Path_Out = DG_Applications.Rows(selRowNum).Cells(2).Value
            Path_In = "C:\App\" & Mid(Path_Out, 36)
            FileCopy(Path_Out, Path_In)
            FileCopy("\\192.168.180.9\prodsoft\DTVS_Apps\Library_2.dll", "C:\App\Library_2.dll")
            Process.Start(Path_In)
            Me.Close()
        End If
    End Sub
End Class
