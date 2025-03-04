using System.Windows.Forms;
using DevExpress.DashboardCommon;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace WinViewer_CustomExport {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void dashboardViewer1_CustomExport(object sender, CustomExportEventArgs e) {
            var report = e.Report as XtraReport;
            var topMarginBand = report.Bands[BandKind.TopMargin];

            var icon = new XRPictureBox();
            topMarginBand.Controls.Add(icon);
            icon.Image = Properties.Resources.dxLogo;
            icon.HeightF = 50;
            icon.WidthF = 300;

            var customHeader = new XRLabel();
            topMarginBand.Controls.Add(customHeader);
            customHeader.Text = "TEST TEST TEST";
            customHeader.LeftF = 300;
            customHeader.WidthF = 300;

            var dateInfo = new XRPageInfo();
            topMarginBand.Controls.Add(dateInfo);
            dateInfo.PageInfo = PageInfo.DateTime;
            dateInfo.Format = "Created at {0:h:mm tt dd MMMM yyyy}";
            dateInfo.WidthF = 200;
            dateInfo.LeftF = report.PageSize.Width - report.Margins.Left - report.Margins.Right - dateInfo.WidthF;
            dateInfo.TopF = dateInfo.Band.HeightF - dateInfo.HeightF;

            var footerBand = new PageFooterBand();
            report.Bands.Add(footerBand);
            footerBand.HeightF = 30;
            var pageInfo = new XRPageInfo();
            footerBand.Controls.Add(pageInfo);
            pageInfo.Format = "Page {0} of {1}";
        }
    }
}
