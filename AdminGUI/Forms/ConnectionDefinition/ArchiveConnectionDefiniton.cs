using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI.Forms
{
    public partial class ArchiveConnectionDefiniton : ControlTemplete
    {
        public ArchiveConnectionDefiniton()
        {
            InitializeComponent();
        }

        public ArchiveConnectionDefiniton(Size s, Panel returnP) : base(s, returnP)
        {
        }
    }
}
