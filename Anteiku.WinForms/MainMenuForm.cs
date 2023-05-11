using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteiku.WinForms
{
    public partial class MainMenuForm : Form
    {
        private readonly string _positionTitle;

        public MainMenuForm()
        {
            InitializeComponent();
            ((Control)this.tabPage1).Enabled = false;
        }

        public MainMenuForm(string positionTitle)
        {
            InitializeComponent();
            _positionTitle = positionTitle;

            if (_positionTitle != "Administrator")
            {
                ((Control)this.userOperationTabpage).Enabled = false;
            }

            if (_positionTitle != "Cook")
            {
                ((Control)this.kitchenTabpage).Enabled = false;
            }

            ((Control)this.tabPage1).Enabled = false;
        }
    }
}
