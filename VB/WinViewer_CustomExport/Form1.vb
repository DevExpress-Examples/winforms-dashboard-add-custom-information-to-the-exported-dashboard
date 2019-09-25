Imports DevExpress.DashboardCommon
Imports DevExpress.XtraReports.UI


Namespace WinViewer_CustomExport
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub dashboardViewer1_CustomExport(ByVal sender As Object, ByVal e As CustomExportEventArgs) Handles dashboardViewer1.CustomExport

            Dim report As XtraReport = e.Report
            Dim headerBand As New PageHeaderBand()
            report.Bands.Add(headerBand)

            'INSTANT VB NOTE: The variable icon was renamed since Visual Basic does not handle local variables named the same as class members well:
            Dim icon_Renamed As New XRPictureBox()
            icon_Renamed.Image = My.Resources.dxLogo
            icon_Renamed.HeightF = 50
            icon_Renamed.WidthF = 300
            headerBand.Controls.Add(icon_Renamed)

            Dim customHeader As New XRLabel()
            customHeader.Text = "TEST TEST TEST"
            customHeader.LeftF = 300
            customHeader.WidthF = 300
            headerBand.Controls.Add(customHeader)

            Dim dateInfo As New XRPageInfo()
            dateInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            dateInfo.Format = "Created at {0:h:mm tt dd MMMM yyyy}"
            dateInfo.TopF = 50
            dateInfo.WidthF = 200
            headerBand.Controls.Add(dateInfo)

            Dim footerBand As New PageFooterBand()
            report.Bands.Add(footerBand)
            Dim pageInfo As New XRPageInfo()
            pageInfo.Format = "Page {0} of {1}"
            footerBand.Controls.Add(pageInfo)
        End Sub
    End Class
End Namespace
