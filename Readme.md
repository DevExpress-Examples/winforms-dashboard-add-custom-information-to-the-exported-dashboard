<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinViewer_CustomExport/Form1.cs) (VB: [Form1.vb](./VB/WinViewer_CustomExport/Form1.vb))
<!-- default file list end -->
# How to Display Custom Information in the Exported Dashboard


This example demonstrates how to add a custom header and footer to the exported dashboard.

Handle the [CustomExport](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomExport) event. You can use the [e.Report](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomExportEventArgs.Report) property to get the [XtraReport](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport) instance before it is printed or exported, and modify it.

![screenshot](/images/screenshot.png)

See also:
* [Web Dashboard - How to add custom information to the exported dashboard](https://github.com/DevExpress-Examples/web-dashboard-how-to-add-custom-information-to-the-exported-dashboard-t466585)



