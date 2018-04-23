Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace WindowsFormsApplication2
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new Chart control and add it to the form.
            Dim chart As New ChartControl()
            chart.Dock = DockStyle.Fill
            Me.Controls.AddRange(New Control() { chart })

            ' Create a Bar series and add points to it.
            Dim series1 As New Series("Bar", ViewType.Bar)
            series1.Points.Add(New SeriesPoint("A", New Double() { 10 }))
            series1.Points.Add(New SeriesPoint("B", New Double() { 32 }))
            series1.Points.Add(New SeriesPoint("C", New Double() { 44 }))
            series1.Points.Add(New SeriesPoint("D", New Double() { 67 }))

            ' Create a Line series and add points to it.
            Dim series2 As New Series("Line", ViewType.Line)
            series2.Points.Add(New SeriesPoint("A", New Double() { 15 }))
            series2.Points.Add(New SeriesPoint("B", New Double() { 18 }))
            series2.Points.Add(New SeriesPoint("C", New Double() { 21 }))
            series2.Points.Add(New SeriesPoint("D", New Double() { 27 }))

            ' Add the series to the chart.
            chart.Series.Add(series1)
            chart.Series.Add(series2)

            ' Cast the chart's diagram to the XYDiagram type, to access its axes.
            Dim diagram As XYDiagram = CType(chart.Diagram, XYDiagram)

            ' Add a new additional pane to the diagram.
            diagram.Panes.Add(New XYDiagramPane("My Pane"))

            ' Assign the additional pane  to the second series. 
            ' Note that the created pane has the zero index in the collection,
            ' because the existing Default pane is a separate entity.
            Dim myView As LineSeriesView = CType(series2.View, LineSeriesView)
            myView.Pane = diagram.Panes(0)

            ' Define the whole range for the axes.
            diagram.AxisX.WholeRange.Auto = False
            diagram.AxisX.WholeRange.SetMinMaxValues("A", "D")
            diagram.AxisY.WholeRange.Auto = False
            diagram.AxisY.WholeRange.SetMinMaxValues(0, 70)

            ' Define the visible range for the axes.  
            diagram.AxisX.VisualRange.Auto = False
            diagram.AxisX.VisualRange.SetMinMaxValues("B", "C")
            diagram.AxisY.VisualRange.Auto = False
            diagram.AxisY.VisualRange.SetMinMaxValues(7, 50)

            ' Specify the axes scrolling at the diagram's level.
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisYScrolling = False

            ' Individually specify the axes scrolling for the panes.
            diagram.DefaultPane.EnableAxisXScrolling = DefaultBoolean.Default
            diagram.Panes(0).EnableAxisXScrolling = DefaultBoolean.False
            diagram.Panes(0).EnableAxisYScrolling = DefaultBoolean.True

            ' Adjust how the scrolling can be performed.
            diagram.ScrollingOptions.UseKeyboard = False
            diagram.ScrollingOptions.UseMouse = False
            diagram.ScrollingOptions.UseScrollBars = True
        End Sub
    End Class
End Namespace
