Imports System.Windows.Forms
Imports DevExpress.DashboardCommon
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace WinViewer_CustomExport
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub dashboardViewer1_CustomExport(ByVal sender As Object, ByVal e As CustomExportEventArgs) _
            Handles dashboardViewer1.CustomExport
            Dim report As XtraReport = TryCast(e.Report, XtraReport)
            Dim headerBand As New PageHeaderBand()
            report.Bands.Add(headerBand)

            Dim icon_Renamed As New XRPictureBox()
            icon_Renamed.Image = My.Resources.dxLogo
            icon_Renamed.HeightF = 50
            icon_Renamed.WidthF = 300
            headerBand.Controls.Add(icon_Renamed)

            Dim customHeader As New XRLabel()
            customHeader.Text = "Additioanl Header Text"
            customHeader.LeftF = 300
            customHeader.WidthF = 300
            headerBand.Controls.Add(customHeader)

            Dim dateInfo As New XRPageInfo()
            dateInfo.PageInfo = pageInfo.DateTime
            dateInfo.Format = "Created at {0:h:mm tt dd MMMM yyyy}"
            dateInfo.TopF = 100
            dateInfo.WidthF = 200
            headerBand.Controls.Add(dateInfo)

            Dim userInfo As New XRPageInfo()
            userInfo.PageInfo = pageInfo.UserName
            userInfo.Format = "Current User: {0}"
            userInfo.TopF = 100
            userInfo.LeftF = 250
            userInfo.WidthF = 200
            headerBand.Controls.Add(userInfo)

            Dim footerBand As New PageFooterBand()
            report.Bands.Add(footerBand)
            Dim pageInfo_1 As New XRPageInfo()
            pageInfo_1.Format = "Page {0} of {1}"
            footerBand.Controls.Add(pageInfo_1)
        End Sub
    End Class
End Namespace
