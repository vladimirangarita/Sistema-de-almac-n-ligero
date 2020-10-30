Public Class cGlobales
    Public Sub FormatearGrid(ByVal DgView As DataGridView)
        Dim columnHeaderStyle As New DataGridViewCellStyle

        DgView.EnableHeadersVisualStyles = False

        columnHeaderStyle.BackColor = Color.LightBlue

        columnHeaderStyle.ForeColor = Color.Black

        DgView.DefaultCellStyle.BackColor = Color.White

        DgView.DefaultCellStyle.ForeColor = Color.Black

        DgView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        DgView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black

        DgView.BackgroundColor = Color.White

        DgView.CellBorderStyle = DataGridViewCellBorderStyle.Raised

        DgView.RowHeadersVisible = False

        DgView.ColumnHeadersDefaultCellStyle = columnHeaderStyle

        DgView.MultiSelect = False
        'DgView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Black

        'DgView.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White

        'DgView.DefaultCellStyle.SelectionBackColor = Color.Black

        'DgView.DefaultCellStyle.SelectionForeColor = Color.White



    End Sub
End Class
