Imports System.Data
Imports System.Data.OleDb
Imports StokBengkel.Clsmy
Imports DevExpress.XtraEditors

Public Class fpr_perbaikan_n

    Private dvmanager As Data.DataViewManager
    Private dv1 As Data.DataView

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        open_wait()

        If RadioGroup1.EditValue = 1 Then
            BandedGridView1.Bands(0).Caption = "No Polisi / Supir"
            BandedGridView1.Columns("nopol").Width = 80

            grid1.Visible = True
            grid2.Visible = False
            grid1.Dock = DockStyle.Fill

        ElseIf RadioGroup1.EditValue = 2 Then
            BandedGridView1.Bands(0).Caption = "Mekanik"
            BandedGridView1.Columns("nopol").Width = 130

            grid1.Visible = True
            grid2.Visible = False
            grid1.Dock = DockStyle.Fill

        Else
            BandedGridView2.Bands(0).Caption = "Mekanik / No Polisi"
            BandedGridView2.Columns("nopol").Width = 80
            BandedGridView2.Columns("nama_mekanik").Width = 130

            grid1.Visible = False
            grid2.Visible = True
            grid2.Dock = DockStyle.Fill

        End If

        grid1.DataSource = Nothing
        grid2.DataSource = Nothing

        Dim cn As OleDbConnection = Nothing
        Try


            dv1 = Nothing

            cn = New OleDbConnection
            cn = Clsmy.open_conn

            Dim sql As String = ""

            If RadioGroup1.EditValue = 1 Then

                sql = "select nopol,nama_pengambil, "
                sql = String.Format("{0} SUM([1]) as '1_a', " &
                    "SUM([2]) as '2_a', " & _
                    "SUM([3]) as '3_a', " & _
                    "SUM([4]) as '4_a', " & _
                    "SUM([5]) as '5_a', " & _
                    "SUM([6]) as '6_a', " & _
                    "SUM([7]) as '7_a', " & _
                    "SUM([8]) as '8_a', " & _
                    "SUM([9]) as '9_a', " & _
                    "SUM([10]) as '10_a', " & _
                    "SUM([11]) as '11_a', " & _
                    " SUM([12]) as '12_a', " & _
                    "SUM([13]) as '13_a', " & _
                    " SUM([14]) as '14_a', " & _
                    "SUM([15]) as '15_a', " & _
                    "SUM([16]) as '16_a', " & _
                    "SUM([17]) as '17_a', " & _
                    "SUM([18]) as '18_a', " & _
                    "SUM([19]) as '19_a', " & _
                    "SUM([20]) as '20_a', " & _
                    "SUM([21]) as '21_a', " & _
                    "SUM([22]) as '22_a', " & _
                    "SUM([23]) as '23_a', " & _
                    "SUM([24]) as '24_a', " & _
                    "SUM([25]) as '25_a', " & _
                    "SUM([26]) as '26_a', " & _
                    "SUM([27]) as '27_a', " & _
                    "SUM([28]) as '28_a', " & _
                    "SUM([29]) as '29_a', " & _
                    "SUM([30]) as '30_a', " & _
                    "SUM([31]) as '31_a', " & _
                    "case when sum([1_t])>=86400 then  cast(sum([1_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([1_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([1_t])), '19000101'), 108) end  as '1_t', " & _
                    "case when sum([2_t])>=86400 then  cast(sum([2_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([2_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([2_t])), '19000101'), 108) end as '2_t', " & _
                    "case when sum([3_t])>=86400 then  cast(sum([3_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([3_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([3_t])), '19000101'), 108) end as '3_t', " & _
                    "case when sum([4_t])>=86400 then  cast(sum([4_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([4_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([4_t])), '19000101'), 108) end as '4_t', " & _
                    "case when sum([5_t])>=86400 then  cast(sum([5_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([5_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([5_t])), '19000101'), 108) end as '5_t', " & _
                    "case when sum([6_t])>=86400 then  cast(sum([6_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([6_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([6_t])), '19000101'), 108) end as '6_t', " & _
                    "case when sum([7_t])>=86400 then  cast(sum([7_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([7_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([7_t])), '19000101'), 108) end as '7_t', " & _
                    "case when sum([8_t])>=86400 then  cast(sum([8_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([8_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([8_t])), '19000101'), 108) end as '8_t', " & _
                    "case when sum([9_t])>=86400 then  cast(sum([9_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([9_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([9_t])), '19000101'), 108) end as '9_t', " & _
                    "case when sum([10_t])>=86400 then  cast(sum([10_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([10_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([10_t])), '19000101'), 108) end as '10_t', " & _
                    "case when sum([11_t])>=86400 then  cast(sum([11_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([11_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([11_t])), '19000101'), 108) end as '11_t', " & _
                    "case when sum([12_t])>=86400 then  cast(sum([12_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([12_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([12_t])), '19000101'), 108) end as '12_t', " & _
                    "case when sum([13_t])>=86400 then  cast(sum([13_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([13_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([13_t])), '19000101'), 108) end as '13_t', " & _
                    "case when sum([14_t])>=86400 then  cast(sum([14_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([14_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([14_t])), '19000101'), 108) end as '14_t', " & _
                    "case when sum([15_t])>=86400 then  cast(sum([15_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([15_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([15_t])), '19000101'), 108) end as '15_t', " & _
                    "case when sum([16_t])>=86400 then  cast(sum([16_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([16_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([16_t])), '19000101'), 108) end as '16_t', " & _
                    "case when sum([17_t])>=86400 then  cast(sum([17_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([17_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([17_t])), '19000101'), 108) end as '17_t', " & _
                    "case when sum([18_t])>=86400 then  cast(sum([18_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([18_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([18_t])), '19000101'), 108) end as '18_t', " & _
                    "case when sum([19_t])>=86400 then  cast(sum([19_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([19_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([19_t])), '19000101'), 108) end as '19_t', " & _
                    "case when sum([20_t])>=86400 then  cast(sum([20_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([20_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([20_t])), '19000101'), 108) end as '20_t', " & _
                    "case when sum([21_t])>=86400 then  cast(sum([21_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([21_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([21_t])), '19000101'), 108) end as '21_t', " & _
                    "case when sum([22_t])>=86400 then  cast(sum([22_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([22_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([22_t])), '19000101'), 108) end as '22_t', " & _
                    "case when sum([23_t])>=86400 then  cast(sum([23_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([23_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([23_t])), '19000101'), 108) end as '23_t', " & _
                    "case when sum([24_t])>=86400 then  cast(sum([24_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([24_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([24_t])), '19000101'), 108) end as '24_t', " & _
                    "case when sum([25_t])>=86400 then  cast(sum([25_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([25_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([25_t])), '19000101'), 108) end as '25_t', " & _
                    "case when sum([26_t])>=86400 then  cast(sum([26_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([26_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([26_t])), '19000101'), 108) end as '26_t', " & _
                    "case when sum([27_t])>=86400 then  cast(sum([27_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([27_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([27_t])), '19000101'), 108) end as '27_t', " & _
                    "case when sum([28_t])>=86400 then  cast(sum([28_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([28_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([28_t])), '19000101'), 108) end as '28_t', " & _
                    "case when sum([29_t])>=86400 then  cast(sum([29_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([29_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([29_t])), '19000101'), 108) end as '29_t', " & _
                    "case when sum([30_t])>=86400 then  cast(sum([30_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([30_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([30_t])), '19000101'), 108) end as '30_t', " & _
                    "case when sum([31_t])>=86400 then  cast(sum([31_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([31_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([31_t])), '19000101'), 108) end as '31_t', " & _
                    "SUM([tot]) as 'tot_a', " & _
                    "cast(sum([tot_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([tot_t]), 0), 108) as 'tot_t' " & _
                    "        from v_perbaikan " & _
                    "        where thn ={1} And bln = {2} group by nopol,nama_pengambil", sql, tthn.EditValue, tbln.SelectedIndex + 1)

            ElseIf RadioGroup1.EditValue = 2 Or RadioGroup1.EditValue = 3 Then

                If RadioGroup1.EditValue = 2 Then
                    sql = "select nama_mekanik as nopol, "
                ElseIf RadioGroup1.EditValue = 3 Then
                    sql = "select nopol,nama_mekanik, "
                End If

                ''" CONVERT(char(5), DATEADD(second, convert(int,sum([1_t])), '19000101'), 108) as '1_t', " & _

                sql = String.Format("{0} SUM([1]) as '1_a', " &
                    "SUM([2]) as '2_a', " & _
                    "SUM([3]) as '3_a', " & _
                    "SUM([4]) as '4_a', " & _
                    "SUM([5]) as '5_a', " & _
                    "SUM([6]) as '6_a', " & _
                    "SUM([7]) as '7_a', " & _
                    "SUM([8]) as '8_a', " & _
                    "SUM([9]) as '9_a', " & _
                    "SUM([10]) as '10_a', " & _
                    "SUM([11]) as '11_a', " & _
                    " SUM([12]) as '12_a', " & _
                    "SUM([13]) as '13_a', " & _
                    " SUM([14]) as '14_a', " & _
                    "SUM([15]) as '15_a', " & _
                    "SUM([16]) as '16_a', " & _
                    "SUM([17]) as '17_a', " & _
                    "SUM([18]) as '18_a', " & _
                    "SUM([19]) as '19_a', " & _
                    "SUM([20]) as '20_a', " & _
                    "SUM([21]) as '21_a', " & _
                    "SUM([22]) as '22_a', " & _
                    "SUM([23]) as '23_a', " & _
                    "SUM([24]) as '24_a', " & _
                    "SUM([25]) as '25_a', " & _
                    "SUM([26]) as '26_a', " & _
                    "SUM([27]) as '27_a', " & _
                    "SUM([28]) as '28_a', " & _
                    "SUM([29]) as '29_a', " & _
                    "SUM([30]) as '30_a', " & _
                    "SUM([31]) as '31_a', " & _
                    "case when sum([1_t])>=86400 then  cast(sum([1_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([1_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([1_t])), '19000101'), 108) end  as '1_t', " & _
                    "case when sum([2_t])>=86400 then  cast(sum([2_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([2_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([2_t])), '19000101'), 108) end as '2_t', " & _
                    "case when sum([3_t])>=86400 then  cast(sum([3_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([3_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([3_t])), '19000101'), 108) end as '3_t', " & _
                    "case when sum([4_t])>=86400 then  cast(sum([4_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([4_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([4_t])), '19000101'), 108) end as '4_t', " & _
                    "case when sum([5_t])>=86400 then  cast(sum([5_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([5_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([5_t])), '19000101'), 108) end as '5_t', " & _
                    "case when sum([6_t])>=86400 then  cast(sum([6_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([6_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([6_t])), '19000101'), 108) end as '6_t', " & _
                    "case when sum([7_t])>=86400 then  cast(sum([7_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([7_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([7_t])), '19000101'), 108) end as '7_t', " & _
                    "case when sum([8_t])>=86400 then  cast(sum([8_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([8_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([8_t])), '19000101'), 108) end as '8_t', " & _
                    "case when sum([9_t])>=86400 then  cast(sum([9_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([9_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([9_t])), '19000101'), 108) end as '9_t', " & _
                    "case when sum([10_t])>=86400 then  cast(sum([10_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([10_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([10_t])), '19000101'), 108) end as '10_t', " & _
                    "case when sum([11_t])>=86400 then  cast(sum([11_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([11_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([11_t])), '19000101'), 108) end as '11_t', " & _
                    "case when sum([12_t])>=86400 then  cast(sum([12_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([12_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([12_t])), '19000101'), 108) end as '12_t', " & _
                    "case when sum([13_t])>=86400 then  cast(sum([13_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([13_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([13_t])), '19000101'), 108) end as '13_t', " & _
                    "case when sum([14_t])>=86400 then  cast(sum([14_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([14_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([14_t])), '19000101'), 108) end as '14_t', " & _
                    "case when sum([15_t])>=86400 then  cast(sum([15_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([15_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([15_t])), '19000101'), 108) end as '15_t', " & _
                    "case when sum([16_t])>=86400 then  cast(sum([16_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([16_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([16_t])), '19000101'), 108) end as '16_t', " & _
                    "case when sum([17_t])>=86400 then  cast(sum([17_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([17_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([17_t])), '19000101'), 108) end as '17_t', " & _
                    "case when sum([18_t])>=86400 then  cast(sum([18_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([18_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([18_t])), '19000101'), 108) end as '18_t', " & _
                    "case when sum([19_t])>=86400 then  cast(sum([19_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([19_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([19_t])), '19000101'), 108) end as '19_t', " & _
                    "case when sum([20_t])>=86400 then  cast(sum([20_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([20_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([20_t])), '19000101'), 108) end as '20_t', " & _
                    "case when sum([21_t])>=86400 then  cast(sum([21_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([21_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([21_t])), '19000101'), 108) end as '21_t', " & _
                    "case when sum([22_t])>=86400 then  cast(sum([22_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([22_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([22_t])), '19000101'), 108) end as '22_t', " & _
                    "case when sum([23_t])>=86400 then  cast(sum([23_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([23_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([23_t])), '19000101'), 108) end as '23_t', " & _
                    "case when sum([24_t])>=86400 then  cast(sum([24_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([24_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([24_t])), '19000101'), 108) end as '24_t', " & _
                    "case when sum([25_t])>=86400 then  cast(sum([25_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([25_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([25_t])), '19000101'), 108) end as '25_t', " & _
                    "case when sum([26_t])>=86400 then  cast(sum([26_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([26_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([26_t])), '19000101'), 108) end as '26_t', " & _
                    "case when sum([27_t])>=86400 then  cast(sum([27_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([27_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([27_t])), '19000101'), 108) end as '27_t', " & _
                    "case when sum([28_t])>=86400 then  cast(sum([28_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([28_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([28_t])), '19000101'), 108) end as '28_t', " & _
                    "case when sum([29_t])>=86400 then  cast(sum([29_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([29_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([29_t])), '19000101'), 108) end as '29_t', " & _
                    "case when sum([30_t])>=86400 then  cast(sum([30_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([30_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([30_t])), '19000101'), 108) end as '30_t', " & _
                    "case when sum([31_t])>=86400 then  cast(sum([31_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([31_t]), 0), 108) else CONVERT(char(5), DATEADD(second, convert(int,sum([31_t])), '19000101'), 108) end as '31_t', " & _
                    "SUM([tot]) as 'tot_a', " & _
                    "cast(sum([tot_t])/86400 as varchar(50))+':'+ Convert(varchar, DateAdd(second, sum([tot_t]), 0), 108) as 'tot_t' " & _
                    "        from v_perbaikan2 " & _
                    "        where thn ={1} And bln = {2} group by ", sql, tthn.EditValue, tbln.SelectedIndex + 1)


                If RadioGroup1.EditValue = 2 Then
                    sql = String.Format("{0} nama_mekanik", sql)
                ElseIf RadioGroup1.EditValue = 3 Then
                    sql = String.Format("{0} nopol,nama_mekanik", sql)
                End If

            End If

            Dim ds As DataSet
            ds = New DataSet()
            ds = Clsmy.GetDataSet(sql, cn)

            dvmanager = New DataViewManager(ds)
            dv1 = dvmanager.CreateDataView(ds.Tables(0))

            If RadioGroup1.EditValue = 3 Then
                grid2.DataSource = dv1
            Else
                grid1.DataSource = dv1
            End If


            close_wait()


        Catch ex As Exception
            close_wait()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Informasi")
        Finally


            If Not cn Is Nothing Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End If
        End Try

    End Sub

    Private Sub setwidth()
        BandedGridView1.Columns("1_a").Width = 27
        BandedGridView1.Columns("2_a").Width = 27
        BandedGridView1.Columns("3_a").Width = 27
        BandedGridView1.Columns("4_a").Width = 27
        BandedGridView1.Columns("5_a").Width = 27
        BandedGridView1.Columns("6_a").Width = 27
        BandedGridView1.Columns("7_a").Width = 27
        BandedGridView1.Columns("8_a").Width = 27
        BandedGridView1.Columns("9_a").Width = 27
        BandedGridView1.Columns("10_a").Width = 27
        BandedGridView1.Columns("11_a").Width = 27
        BandedGridView1.Columns("12_a").Width = 27
        BandedGridView1.Columns("13_a").Width = 27
        BandedGridView1.Columns("14_a").Width = 27
        BandedGridView1.Columns("15_a").Width = 27
        BandedGridView1.Columns("16_a").Width = 27
        BandedGridView1.Columns("17_a").Width = 27
        BandedGridView1.Columns("18_a").Width = 27
        BandedGridView1.Columns("19_a").Width = 27
        BandedGridView1.Columns("20_a").Width = 27
        BandedGridView1.Columns("21_a").Width = 27
        BandedGridView1.Columns("22_a").Width = 27
        BandedGridView1.Columns("23_a").Width = 27
        BandedGridView1.Columns("24_a").Width = 27
        BandedGridView1.Columns("25_a").Width = 27
        BandedGridView1.Columns("26_a").Width = 27
        BandedGridView1.Columns("27_a").Width = 27
        BandedGridView1.Columns("28_a").Width = 27
        BandedGridView1.Columns("29_a").Width = 27
        BandedGridView1.Columns("30_a").Width = 27
        BandedGridView1.Columns("31_a").Width = 27
        BandedGridView1.Columns("tot_a").Width = 33

        BandedGridView1.Columns("1_t").Width = 75
        BandedGridView1.Columns("2_t").Width = 75
        BandedGridView1.Columns("3_t").Width = 75
        BandedGridView1.Columns("4_t").Width = 75
        BandedGridView1.Columns("5_t").Width = 75
        BandedGridView1.Columns("6_t").Width = 75
        BandedGridView1.Columns("7_t").Width = 75
        BandedGridView1.Columns("8_t").Width = 75
        BandedGridView1.Columns("9_t").Width = 75
        BandedGridView1.Columns("10_t").Width = 75
        BandedGridView1.Columns("11_t").Width = 75
        BandedGridView1.Columns("12_t").Width = 75
        BandedGridView1.Columns("13_t").Width = 75
        BandedGridView1.Columns("14_t").Width = 75
        BandedGridView1.Columns("15_t").Width = 75
        BandedGridView1.Columns("16_t").Width = 75
        BandedGridView1.Columns("17_t").Width = 75
        BandedGridView1.Columns("18_t").Width = 75
        BandedGridView1.Columns("19_t").Width = 75
        BandedGridView1.Columns("20_t").Width = 75
        BandedGridView1.Columns("21_t").Width = 75
        BandedGridView1.Columns("22_t").Width = 75
        BandedGridView1.Columns("23_t").Width = 75
        BandedGridView1.Columns("24_t").Width = 75
        BandedGridView1.Columns("25_t").Width = 75
        BandedGridView1.Columns("26_t").Width = 75
        BandedGridView1.Columns("27_t").Width = 75
        BandedGridView1.Columns("28_t").Width = 75
        BandedGridView1.Columns("29_t").Width = 75
        BandedGridView1.Columns("30_t").Width = 75
        BandedGridView1.Columns("31_t").Width = 75
        BandedGridView1.Columns("tot_t").Width = 80

        BandedGridView2.Columns("1_a").Width = 27
        BandedGridView2.Columns("2_a").Width = 27
        BandedGridView2.Columns("3_a").Width = 27
        BandedGridView2.Columns("4_a").Width = 27
        BandedGridView2.Columns("5_a").Width = 27
        BandedGridView2.Columns("6_a").Width = 27
        BandedGridView2.Columns("7_a").Width = 27
        BandedGridView2.Columns("8_a").Width = 27
        BandedGridView2.Columns("9_a").Width = 27
        BandedGridView2.Columns("10_a").Width = 27
        BandedGridView2.Columns("11_a").Width = 27
        BandedGridView2.Columns("12_a").Width = 27
        BandedGridView2.Columns("13_a").Width = 27
        BandedGridView2.Columns("14_a").Width = 27
        BandedGridView2.Columns("15_a").Width = 27
        BandedGridView2.Columns("16_a").Width = 27
        BandedGridView2.Columns("17_a").Width = 27
        BandedGridView2.Columns("18_a").Width = 27
        BandedGridView2.Columns("19_a").Width = 27
        BandedGridView2.Columns("20_a").Width = 27
        BandedGridView2.Columns("21_a").Width = 27
        BandedGridView2.Columns("22_a").Width = 27
        BandedGridView2.Columns("23_a").Width = 27
        BandedGridView2.Columns("24_a").Width = 27
        BandedGridView2.Columns("25_a").Width = 27
        BandedGridView2.Columns("26_a").Width = 27
        BandedGridView2.Columns("27_a").Width = 27
        BandedGridView2.Columns("28_a").Width = 27
        BandedGridView2.Columns("29_a").Width = 27
        BandedGridView2.Columns("30_a").Width = 27
        BandedGridView2.Columns("31_a").Width = 27
        BandedGridView2.Columns("tot_a").Width = 33

        BandedGridView2.Columns("1_t").Width = 75
        BandedGridView2.Columns("2_t").Width = 75
        BandedGridView2.Columns("3_t").Width = 75
        BandedGridView2.Columns("4_t").Width = 75
        BandedGridView2.Columns("5_t").Width = 75
        BandedGridView2.Columns("6_t").Width = 75
        BandedGridView2.Columns("7_t").Width = 75
        BandedGridView2.Columns("8_t").Width = 75
        BandedGridView2.Columns("9_t").Width = 75
        BandedGridView2.Columns("10_t").Width = 75
        BandedGridView2.Columns("11_t").Width = 75
        BandedGridView2.Columns("12_t").Width = 75
        BandedGridView2.Columns("13_t").Width = 75
        BandedGridView2.Columns("14_t").Width = 75
        BandedGridView2.Columns("15_t").Width = 75
        BandedGridView2.Columns("16_t").Width = 75
        BandedGridView2.Columns("17_t").Width = 75
        BandedGridView2.Columns("18_t").Width = 75
        BandedGridView2.Columns("19_t").Width = 75
        BandedGridView2.Columns("20_t").Width = 75
        BandedGridView2.Columns("21_t").Width = 75
        BandedGridView2.Columns("22_t").Width = 75
        BandedGridView2.Columns("23_t").Width = 75
        BandedGridView2.Columns("24_t").Width = 75
        BandedGridView2.Columns("25_t").Width = 75
        BandedGridView2.Columns("26_t").Width = 75
        BandedGridView2.Columns("27_t").Width = 75
        BandedGridView2.Columns("28_t").Width = 75
        BandedGridView2.Columns("29_t").Width = 75
        BandedGridView2.Columns("30_t").Width = 75
        BandedGridView2.Columns("31_t").Width = 75
        BandedGridView2.Columns("tot_t").Width = 80

    End Sub

    Private Sub fpr_perbaikan_n_Load(sender As Object, e As EventArgs) Handles Me.Load

        tthn.EditValue = Year(Now)
        tbln.SelectedIndex = Month(Now) - 1

        setwidth()

        RadioGroup1.EditValue = 1
        BandedGridView1.Bands(0).Caption = "No Polisi"
        BandedGridView1.Columns("nopol").Width = 90

        grid1.Visible = True
        grid2.Visible = False
        grid1.Dock = DockStyle.Fill

    End Sub


    Private Sub BandedGridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles BandedGridView1.CustomColumnDisplayText, BandedGridView2.CustomColumnDisplayText

        If e.Column.FieldName = "1_a" Or e.Column.FieldName = "2_a" Or e.Column.FieldName = "3_a" _
            Or e.Column.FieldName = "4_a" Or e.Column.FieldName = "5_a" Or e.Column.FieldName = "6_a" _
            Or e.Column.FieldName = "7_a" Or e.Column.FieldName = "8_a" Or e.Column.FieldName = "9_a" _
            Or e.Column.FieldName = "10_a" Or e.Column.FieldName = "11_a" Or e.Column.FieldName = "12_a" _
            Or e.Column.FieldName = "13_a" Or e.Column.FieldName = "14_a" Or e.Column.FieldName = "15_a" _
            Or e.Column.FieldName = "16_a" Or e.Column.FieldName = "17_a" Or e.Column.FieldName = "18_a" _
            Or e.Column.FieldName = "19_a" Or e.Column.FieldName = "20_a" Or e.Column.FieldName = "21_a" _
            Or e.Column.FieldName = "22_a" Or e.Column.FieldName = "23_a" Or e.Column.FieldName = "24_a" _
            Or e.Column.FieldName = "25_a" Or e.Column.FieldName = "26_a" Or e.Column.FieldName = "27_a" _
            Or e.Column.FieldName = "28_a" Or e.Column.FieldName = "29_a" Or e.Column.FieldName = "30_a" Or e.Column.FieldName = "31_a" Then

            If Convert.ToInt32(e.Value) = 0 Then
                e.DisplayText = ""
            End If

        End If

        If e.Column.FieldName = "1_t" Or e.Column.FieldName = "2_t" Or e.Column.FieldName = "3_t" _
            Or e.Column.FieldName = "4_t" Or e.Column.FieldName = "5_t" Or e.Column.FieldName = "6_t" _
            Or e.Column.FieldName = "7_t" Or e.Column.FieldName = "8_t" Or e.Column.FieldName = "9_t" _
            Or e.Column.FieldName = "10_t" Or e.Column.FieldName = "11_t" Or e.Column.FieldName = "12_t" _
            Or e.Column.FieldName = "13_t" Or e.Column.FieldName = "14_t" Or e.Column.FieldName = "15_t" _
            Or e.Column.FieldName = "16_t" Or e.Column.FieldName = "17_t" Or e.Column.FieldName = "18_t" _
            Or e.Column.FieldName = "19_t" Or e.Column.FieldName = "20_t" Or e.Column.FieldName = "21_t" _
            Or e.Column.FieldName = "22_t" Or e.Column.FieldName = "23_t" Or e.Column.FieldName = "24_t" _
            Or e.Column.FieldName = "25_t" Or e.Column.FieldName = "26_t" Or e.Column.FieldName = "27_t" _
            Or e.Column.FieldName = "28_t" Or e.Column.FieldName = "29_t" Or e.Column.FieldName = "30_t" Or e.Column.FieldName = "31_t" Then

            If e.Value = "00:00" Or e.Value = "00:00:00" Or e.Value = "0:00:00:00" Then
                e.DisplayText = ""
            End If

        End If

    End Sub

    Private Sub OpenFile(ByVal fileName As String)
        If XtraMessageBox.Show("Anda ingin membuka file ?", "Export To...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim process As New System.Diagnostics.Process()
                process.StartInfo.FileName = fileName
                process.StartInfo.Verb = "Open"
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                process.Start()
            Catch
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Data tidak ditemukan", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        '   progressBarControl1.Position = 0
    End Sub

    Private Function ShowSaveFileDialog(ByVal title As String, ByVal filter As String) As String
        Dim dlg As New SaveFileDialog()
        Dim name As String = Application.ProductName
        Dim n As Integer = name.LastIndexOf(".") + 1
        If n > 0 Then
            name = name.Substring(n, name.Length - n)
        End If
        dlg.Title = "Export To " & title
        dlg.FileName = name
        dlg.Filter = filter
        If dlg.ShowDialog() = DialogResult.OK Then
            Return dlg.FileName
        End If
        Return ""
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick

        If IsNothing(dv1) Then
            Return
        End If

        If dv1.Count <= 0 Then
            Return
        End If

        Dim fileName As String = ShowSaveFileDialog("Excel 2007", "Microsoft Excel|*.xlsx")

        If fileName = String.Empty Then
            Return
        End If

        If RadioGroup1.EditValue = 3 Then
            BandedGridView2.ExportToXlsx(fileName)
        Else
            BandedGridView1.ExportToXlsx(fileName)
        End If


        OpenFile(fileName)

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick

        If IsNothing(dv1) Then
            Return
        End If

        If dv1.Count <= 0 Then
            Return
        End If

        Dim fileName As String = ShowSaveFileDialog("Text Files", "Text Files|*.txt")

        If fileName = String.Empty Then
            Return
        End If

        If RadioGroup1.EditValue = 3 Then
            BandedGridView2.ExportToXlsx(fileName)
        Else
            BandedGridView1.ExportToXlsx(fileName)
        End If

        OpenFile(fileName)

    End Sub

End Class