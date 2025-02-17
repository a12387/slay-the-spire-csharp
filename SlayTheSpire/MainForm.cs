using SlayTheSpire.UI;
namespace SlayTheSpire
{
    public partial class MainForm : Form
    {
        // MainForm 是游戏的主界面
        // 在这里实现了光标的重绘
        public MainForm()
        {
            InitializeComponent();
            ChangePage(new MainMenu());
            cursor = new Bitmap(Properties.Resources.cursor, 40, 40);
            Cursor = new Cursor(cursor.GetHicon());
        }

        public void AddPage(Control control, Control parent)
        {
            control.Parent = parent;
            control.BringToFront();
        }
        public void ChangePage(Control control)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(control);
        }
        public void DeletePage(Control control)
        {
            control.Dispose();
            Refresh();
        }

        private readonly Bitmap cursor;
    }
}
