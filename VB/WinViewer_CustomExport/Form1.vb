Imports DevExpress.DashboardCommon
Imports DevExpress.XtraReports.UI

Namespace WinViewer_CustomExport
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub dashboardViewer1_CustomExport(ByVal sender As Object, ByVal e As CustomExportEventArgs) Handles dashboardViewer1.CustomExport
			Dim report = TryCast(e.Report, XtraReport)
			Dim topMarginBand = report.Bands(BandKind.TopMargin)

			Dim picture = New XRPictureBox()
			topMarginBand.Controls.Add(picture)
			picture.Image = My.Resources.dxLogo
			picture.HeightF = 50
			picture.WidthF = 300

			Dim customHeader = New XRLabel()
			topMarginBand.Controls.Add(customHeader)
			customHeader.Text = "TEST TEST TEST"
			customHeader.LeftF = 300
			customHeader.WidthF = 300

			Dim dateInfo = New XRPageInfo()
			topMarginBand.Controls.Add(dateInfo)
			dateInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			dateInfo.Format = "Created at {0:h:mm tt dd MMMM yyyy}"
			dateInfo.WidthF = 200
			dateInfo.LeftF = report.PageSize.Width - report.Margins.Left - report.Margins.Right - dateInfo.WidthF
			dateInfo.TopF = dateInfo.Band.HeightF - dateInfo.HeightF

			Dim footerBand = New PageFooterBand()
			report.Bands.Add(footerBand)
			footerBand.HeightF = 30
			Dim pageInfo = New XRPageInfo()
			footerBand.Controls.Add(pageInfo)
			pageInfo.Format = "Page {0} of {1}"
		End Sub
    End Class
End Namespace
