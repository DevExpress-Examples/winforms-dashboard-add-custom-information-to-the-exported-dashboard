<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581422/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T466558)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - How to Display Custom Information in the Exported Dashboard


This example demonstrates how to add a custom header and footer to the exported dashboard.

Handle the [CustomExport](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomExport) event. You can use the [e.Report](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomExportEventArgs.Report) property to get the [XtraReport](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport) instance before it is printed or exported, and modify it.

![screenshot](/images/screenshot.png)

## Files to Look At

* [Form1.cs](./CS/WinViewer_CustomExport/Form1.cs) (VB: [Form1.vb](./VB/WinViewer_CustomExport/Form1.vb))

## Documentation

* [Printing and Exporting](https://docs.devexpress.com/Dashboard/15181)
* [Custom Export](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomExport)

## More Examples
* [Dashboard for WinForms - How to add custom information to the exported Excel document](https://github.com/DevExpress-Examples/WinForms-DashboardDesigner-CustomizeExportDocument-example)
* [Web Dashboard - How to add custom information to the exported dashboard](https://github.com/DevExpress-Examples/web-dashboard-how-to-add-custom-information-to-the-exported-dashboard-t466585)
* [Dashboard for WinForms - How to Export Customized Pie Dashboard Item](https://github.com/DevExpress-Examples/WinForms-Dashboard-How-to-export-customized-Pie-Dashboard-Item)
* [Dashboard for WinForms - How to Handle the BeforeExportDocument Event to Hide the Dashboard Filter Items](https://github.com/DevExpress-Examples/winforms-dashboard-beforeexportdocument-event)





