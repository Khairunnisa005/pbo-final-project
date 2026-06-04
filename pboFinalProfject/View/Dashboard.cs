using System;
using System.Drawing;
using System.Windows.Forms;

namespace pboFinalProfject.View
{
    public partial class Dashboard : Form
    {
        private Panel containerPanel;
        private FlowLayoutPanel flowPanel;

        public Dashboard()
        {
            InitializeComponent();
        }

        //private void InitializeDashboard()
        //{
        //    // Outer container that keeps fixed client size but allows flowPanel to be scrollable
        //    containerPanel = new Panel
        //    {
        //        Dock = DockStyle.Fill,
        //        AutoScroll = true,
        //        BackColor = SystemColors.ControlLight,
        //    };

        //    // FlowLayoutPanel to arrange dashboard items vertically
        //    flowPanel = new FlowLayoutPanel
        //    {
        //        FlowDirection = FlowDirection.TopDown,
        //        WrapContents = false,
        //        AutoSize = true,
        //        Padding = new Padding(10),
        //    };

        //    containerPanel.Controls.Add(flowPanel);
        //    this.Controls.Add(containerPanel);

        //    // Add sample cards to demonstrate scrolling
        //    for (int i = 0; i < 12; i++)
        //    {
        //        var card = CreateCard($"Panel {i + 1}", "Konten contoh...");
        //        flowPanel.Controls.Add(card);
        //    }

        //    // Optional: set a preferred starting size similar to typical login form
        //    this.ClientSize = new Size(880, 503);
        //}

        //private Control CreateCard(string title, string content)
        //{
        //    var panel = new Panel
        //    {
        //        Width = 800,
        //        Height = 80,
        //        BackColor = Color.White,
        //        Margin = new Padding(0, 0, 0, 10),
        //    };

        //    var lblTitle = new Label
        //    {
        //        Text = title,
        //        Font = new Font("Segoe UI", 9F, FontStyle.Bold),
        //        Location = new Point(10, 10),
        //        AutoSize = true,
        //    };

        //    var lblContent = new Label
        //    {
        //        Text = content,
        //        Font = new Font("Segoe UI", 8F),
        //        Location = new Point(10, 35),
        //        AutoSize = true,
        //    };

        //    panel.Controls.Add(lblTitle);
        //    panel.Controls.Add(lblContent);

        //    return panel;
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1535, 864);
        }
    }
}
