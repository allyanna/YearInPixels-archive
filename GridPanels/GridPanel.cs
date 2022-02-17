using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GridPanels
{
    public partial class GridPanel : UserControl
    {
        //Draws the panel grid for each pixel
/*        private DrawingPanel drawingPanel;*/

        public GridPanel()
        {
            InitializeComponent();

            //initialize our drawing panel
           /* drawingPanel = new DrawingPanel(this);
            drawingPanel.Location = new Point(0, 0); //start here

            Controls.Add(drawingPanel); //make drawing panel a part of the grid panel*/
        }
    }
}
