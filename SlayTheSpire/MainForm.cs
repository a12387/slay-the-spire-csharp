using SlayTheSpire.UI;
namespace SlayTheSpire
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ChangePage(new MainMenu());
            cursor = new Bitmap(Properties.Resources.cursor, 40, 40);
            Cursor = new Cursor(cursor.GetHicon());
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
        public void DeledePage(Control control)
        {
            MainPanel.Controls.Remove(control);
        }

        private readonly Bitmap cursor;
    }
}
