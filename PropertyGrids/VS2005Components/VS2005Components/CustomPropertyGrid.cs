using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
namespace VS2005Components
{
    public class CustomPropertyGrid : PropertyGrid
    {
        public CustomPropertyGrid()
        {
            
            this.ToolStripRenderer = new ToolStripProfessionalRenderer(new CustomColorTable());
        }
       
        
    }
}
