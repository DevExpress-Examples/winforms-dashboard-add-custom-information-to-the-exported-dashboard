using System.Windows.Forms;
using DevExpress.DashboardCommon;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace WinViewer_CustomExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dashboardViewer1_CustomExport(object sender, CustomExportEventArgs e)
        {
            XtraReport report = e.Report as XtraReport;
            PageHeaderBand headerBand = new PageHeaderBand();
            report.Bands.Add(headerBand);

            XRPictureBox icon = new XRPictureBox();
            icon.Image = Properties.Resources.dxLogo;
            icon.HeightF = 50;
            icon.WidthF = 300;
            headerBand.Controls.Add(icon);

            XRLabel customHeader = new XRLabel();
            customHeader.Text = "Additioanl Header Text";
            customHeader.LeftF = 300;
            customHeader.WidthF = 300;
            headerBand.Controls.Add(customHeader);

            XRPageInfo dateInfo = new XRPageInfo();
            dateInfo.PageInfo = PageInfo.DateTime;
            dateInfo.Format = "Created at {0:h:mm tt dd MMMM yyyy}";
            dateInfo.TopF = 100;
            dateInfo.WidthF = 200;
            headerBand.Controls.Add(dateInfo);

            XRPageInfo userInfo = new XRPageInfo();
            userInfo.PageInfo = PageInfo.UserName;
            userInfo.Format = "Current User: {0}";
            userInfo.TopF = 100;
            userInfo.LeftF = 250;
            userInfo.WidthF = 200;
            headerBand.Controls.Add(userInfo);

            PageFooterBand footerBand = new PageFooterBand();
            report.Bands.Add(footerBand);
            XRPageInfo pageInfo = new XRPageInfo();
            pageInfo.Format = "Page {0} of {1}";
            footerBand.Controls.Add(pageInfo);
        }
    }
}
