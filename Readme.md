<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication2/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication2/Form1.vb))
<!-- default file list end -->
# How to individually adjust scrolling along the axes

This example demonstrates how you can individually adjust scrolling along the X and Y axes. A chart with two [panes](https://docs.devexpress.com/WindowsForms/5879/controls-and-libraries/chart-control/diagram/panes?p=netframework) is used to demonstrate this feature.

In this example, the chart with two series is created. The second series is assigned to an additional pane. 

In addition, to show scrolling bars along axes, the axis whole range and axis visible range is specified and the [ScrollingOptions2D.UseScrollBars](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScrollingOptions2D.UseScrollBars?p=netframework) property is set to **true**. To learn more on axis ranges, refer to [Axis Ranges](https://docs.devexpress.com/WindowsForms/5803/controls-and-libraries/chart-control/axis-ranges?p=netframework).

To specify scrolling along the axes of the diagram's panes, the [XYDiagram2D.EnableAxisXScrolling](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.XYDiagram2D.EnableAxisXScrolling?p=netframework) and [XYDiagram2D.EnableAxisYScrolling](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.XYDiagram2D.EnableAxisYScrolling?p=netframework) properties are used.

For more information, refer to [Zoom and Scroll in 2D XY-Charts](https://docs.devexpress.com/WindowsForms/2954/controls-and-libraries/chart-control/end-user-features/basic-end-users-interaction/zoom-and-scroll-in-2D-xy-charts?p=netframework).
