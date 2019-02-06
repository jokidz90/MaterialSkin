using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = ColorScheme.ColorSwatches[ColorType.PRIMARY];

            // Add dummy data to the listview
            seedListView();

            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.WindowState = FormWindowState.Maximized;
        }

	    private void seedListView()
	    {
			//Define
			var data = new[]
	        {
		        new []{"Lollipop", "392", "0.2", "0"},
				new []{"KitKat", "518", "26.0", "7"},
				new []{"Ice cream sandwich", "237", "9.0", "4.3"},
				new []{"Jelly Bean", "375", "0.0", "0.0"},
				new []{"Honeycomb", "408", "3.2", "6.5"}
	        };

			//Add
			foreach (string[] version in data)
			{
				var item = new ListViewItem(version);
			}
	    }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

	    private int colorSchemeIndex;
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
	        colorSchemeIndex++;
	        if (colorSchemeIndex >= ColorScheme.ColorSwatches.Count)
                colorSchemeIndex = 0;
            materialSkinManager.ColorScheme = ColorScheme.ColorSwatches[((ColorType)colorSchemeIndex)];
        }

        private void materialCheckBox7_Click(object sender, EventArgs e)
        {
            grpDisabled.Enabled = !grpDisabled.Enabled;
        }
    }
}
