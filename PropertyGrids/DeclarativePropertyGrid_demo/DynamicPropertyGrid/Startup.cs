using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using Mtc.SimpleSerializer;

using MycroXaml.Parser;
using MycroXaml.MxContainer;

namespace PropertyGridDemo
{
	public class Startup
	{
		protected MxDataContainer container;
		protected PropertyGrid propertyGrid;

		[STAThread]
		static void Main() 
		{
			new Startup();
		}

		public Startup()
		{
			Parser mp=new Parser();
			StreamReader sr;
			string text;
			XmlDocument doc;
			
			sr=new StreamReader("propertyGrid.xml");
			text=sr.ReadToEnd();
			sr.Close();
			doc=new XmlDocument();
			try
			{
				doc.LoadXml(text);
			}
			catch(Exception e)
			{
				Trace.Fail("Malformed xml:\r\n"+e.Message);
			}

			Form form=(Form)mp.Load(doc, "Form", this);
			container=(MxDataContainer)mp.GetInstance("Container");
			propertyGrid=(PropertyGrid)mp.GetInstance("PropertyGrid");
			form.ShowDialog();

			// using MyXaml
//			Parser p=new Parser();
//			Form form=(Form)p.LoadForm("propertyGrid.myxaml", "AppMainForm", this, null);
//			form.ShowDialog();
		}

		public void OnSerialize(object sender, EventArgs e)
		{
			Serializer s=new Serializer();
			s.Start();
			s.Serialize(container);
			string text=s.Finish();
			StreamWriter sw=new StreamWriter("data.xml");
			sw.Write(text);
			sw.Close();
			Trace.WriteLine(text);
		}

		public void OnDeserialize(object sender, EventArgs e)
		{
			StreamReader sr=new StreamReader("data.xml");
			string text=sr.ReadToEnd();
			sr.Close();
			Deserializer d=new Deserializer();
			d.Start(text);
			d.Deserialize(container, 0);
			propertyGrid.Refresh();
			container.BeginEdit();					// rebind controls with the new values
		}

		public void OnOutputDirectoryChanged(object sender, ContainerEventArgs cea)
		{
		}
	}
}


