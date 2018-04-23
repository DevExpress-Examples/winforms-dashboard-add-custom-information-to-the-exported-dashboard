Namespace WinViewer_CustomExport
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim allColumns1 As New DevExpress.DataAccess.Sql.AllColumns()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.dashboardSqlDataSource2 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
            DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dashboardSqlDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' pivotDashboardItem1
            ' 
            dimension1.DataMember = "OrderDate"
            Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
            dimension2.DataMember = "ProductName"
            measure1.DataMember = "ProductAmount"
            Me.pivotDashboardItem1.DataItemRepository.Clear()
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2")
            Me.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem3")
            Me.pivotDashboardItem1.DataMember = "CustomerReports"
            Me.pivotDashboardItem1.DataSource = Me.dashboardSqlDataSource2
            Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pivotDashboardItem1.Name = "Pivot 1"
            Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
            Me.pivotDashboardItem1.ShowCaption = True
            Me.pivotDashboardItem1.ShowColumnGrandTotals = False
            Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1})
            ' 
            ' dashboardSqlDataSource2
            ' 
            Me.dashboardSqlDataSource2.ComponentName = "dashboardSqlDataSource2"
            Me.dashboardSqlDataSource2.ConnectionName = "nwind"
            Me.dashboardSqlDataSource2.Name = "SQL Data Source 1"
            table1.MetaSerializable = "30|30|125|134"
            table1.Name = "CustomerReports"
            allColumns1.Table = table1
            selectQuery1.Columns.Add(allColumns1)
            selectQuery1.Name = "CustomerReports"
            selectQuery1.Tables.Add(table1)
            Me.dashboardSqlDataSource2.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dashboardSqlDataSource2.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource2.ResultSchemaSerializable")
            ' 
            ' pieDashboardItem1
            ' 
            dimension3.DataMember = "OrderDate"
            Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
            Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
            measure2.DataMember = "ProductAmount"
            dimension4.DataMember = "ProductName"
            dimension4.TopNOptions.Count = 10
            dimension4.TopNOptions.Enabled = True
            dimension4.TopNOptions.Measure = measure2
            Me.pieDashboardItem1.DataItemRepository.Clear()
            Me.pieDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
            Me.pieDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2")
            Me.pieDashboardItem1.DataItemRepository.Add(dimension4, "DataItem1")
            Me.pieDashboardItem1.DataMember = "CustomerReports"
            Me.pieDashboardItem1.DataSource = Me.dashboardSqlDataSource2
            Me.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pieDashboardItem1.Name = "Pies 1"
            Me.pieDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
            Me.pieDashboardItem1.ShowCaption = True
            Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure2})
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardSqlDataSource2})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pivotDashboardItem1, Me.pieDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.pivotDashboardItem1
            dashboardLayoutItem1.Weight = 50.042408821034776R
            dashboardLayoutItem2.DashboardItem = Me.pieDashboardItem1
            dashboardLayoutItem2.Weight = 49.957591178965224R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dashboardSqlDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Private dashboardSqlDataSource2 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Private pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
    End Class
End Namespace
