using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddraig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripContainer1.TopToolStripPanel.Controls.Add(menu());
        }

        ToolStrip menu()
        {
            //Tool Strip to return
            ToolStrip ts = new ToolStrip();
            /* File Menu */
            ToolStripMenuItem fileMenu = new ToolStripMenuItem();
            fileMenu.Name = "FileMenu";
            fileMenu.Text = "&File";
            ToolStripMenuItem fileMenu_Close = new ToolStripMenuItem();
            fileMenu_Close.Name = "FileMenuClose";
            fileMenu_Close.Text = "&Close";
            fileMenu_Close.Click += tsi_Click;
            fileMenu.DropDownItems.Add(fileMenu_Close);
            ts.Items.Add(fileMenu);
            /*End File Menu*/
            /* Edit Menu */
            ToolStripMenuItem editMenu = new ToolStripMenuItem();
            editMenu.Name = "EditMenu";
            editMenu.Text = "&Edit";
            ToolStripMenuItem editMenu_Preferences = new ToolStripMenuItem();
            editMenu_Preferences.Name = "EditMenuPreferences";
            editMenu_Preferences.Text = "&Preferences";
            editMenu.DropDownItems.Add(editMenu_Preferences);
            ts.Items.Add(editMenu);
            /*Edit File Menu*/
            return ts;
        }

        void tsi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
