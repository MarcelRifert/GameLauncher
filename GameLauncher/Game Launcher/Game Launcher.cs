using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create icon.
            Icon newIcon = new Icon(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");

            // Create rectangle for icon.
            Rectangle rect = new Rectangle(100, 100, 200, 200);

            // Draw icon to screen.
            e.Graphics.DrawIcon(newIcon, rect);
        }
    }
}
