using System.Collections.Generic;
using System.Drawing;
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

        public ArchiveConnectionDefiniton(Size s, Panel returnP ,Admin.AdminClient ac, Task<List<DomainModel.Models.Station>> l) : base(s, returnP,ac,l)
        {
        }
    }
}
