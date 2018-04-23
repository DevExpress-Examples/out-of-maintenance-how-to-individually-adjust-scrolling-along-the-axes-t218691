using DevExpress.Utils;
using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new Chart control and add it to the form.
            ChartControl chart = new ChartControl();
            chart.Dock = DockStyle.Fill;
            this.Controls.AddRange(new Control[] { chart });

            // Create a Bar series and add points to it.
            Series series1 = new Series("Bar", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("A", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("B", new double[] { 32 }));
            series1.Points.Add(new SeriesPoint("C", new double[] { 44 }));
            series1.Points.Add(new SeriesPoint("D", new double[] { 67 }));

            // Create a Line series and add points to it.
            Series series2 = new Series("Line", ViewType.Line);
            series2.Points.Add(new SeriesPoint("A", new double[] { 15 }));
            series2.Points.Add(new SeriesPoint("B", new double[] { 18 }));
            series2.Points.Add(new SeriesPoint("C", new double[] { 21 }));
            series2.Points.Add(new SeriesPoint("D", new double[] { 27 }));

            // Add the series to the chart.
            chart.Series.Add(series1);
            chart.Series.Add(series2);

            // Cast the chart's diagram to the XYDiagram type, to access its axes.
            XYDiagram diagram = (XYDiagram)chart.Diagram;

            // Add a new additional pane to the diagram.
            diagram.Panes.Add(new XYDiagramPane("My Pane"));

            // Assign the additional pane  to the second series. 
            // Note that the created pane has the zero index in the collection,
            // because the existing Default pane is a separate entity.
            LineSeriesView myView = (LineSeriesView)series2.View;
            myView.Pane = diagram.Panes[0];

            // Define the whole range for the axes.
            diagram.AxisX.WholeRange.Auto = false;
            diagram.AxisX.WholeRange.SetMinMaxValues("A", "D");
            diagram.AxisY.WholeRange.Auto = false;
            diagram.AxisY.WholeRange.SetMinMaxValues(0, 70);

            // Define the visible range for the axes.  
            diagram.AxisX.VisualRange.Auto = false;
            diagram.AxisX.VisualRange.SetMinMaxValues("B", "C");
            diagram.AxisY.VisualRange.Auto = false;
            diagram.AxisY.VisualRange.SetMinMaxValues(7, 50);

            // Specify the axes scrolling at the diagram's level.
            diagram.EnableAxisXScrolling = true;
            diagram.EnableAxisYScrolling = false;

            // Individually specify the axes scrolling for the panes.
            diagram.DefaultPane.EnableAxisXScrolling = DefaultBoolean.Default;
            diagram.Panes[0].EnableAxisXScrolling = DefaultBoolean.False;
            diagram.Panes[0].EnableAxisYScrolling = DefaultBoolean.True;

            // Adjust how the scrolling can be performed.
            diagram.ScrollingOptions.UseKeyboard = false;
            diagram.ScrollingOptions.UseMouse = false;
            diagram.ScrollingOptions.UseScrollBars = true;
        }
    }
}
