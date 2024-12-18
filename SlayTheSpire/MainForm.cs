using SlayTheSpire.UI;
namespace SlayTheSpire
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ChangePage(new MainMenu());
        }

        public void AddPage(Control control, Control parent)
        {
            MainPanel.Controls.Add(control);
            control.Parent = parent;
            control.BringToFront();
        }
        public void ChangePage(Control control)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(control);
        }
    }
}
