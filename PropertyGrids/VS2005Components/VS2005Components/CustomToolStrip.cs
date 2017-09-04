using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VS2005Components
{
    public class CustomToolStrip : ToolStrip
    {
        public CustomToolStrip()
        {
            
            this.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
        }
    }
}
