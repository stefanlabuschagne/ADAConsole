using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Reflection;


namespace VS2005Components
{
    /// <summary>
    /// A custom collection editor that emulates the 
    /// </summary>
    public class CustomCollectionEditor : CollectionEditor
    {

        #region Constructors
        
        /// <summary>
        /// Creates a new instance of the <see cref="CustomCollectionEditor"/> class
        /// </summary>
        /// <param name="type"></param>
        public CustomCollectionEditor(Type type)
            : base(type) { }

        #endregion

        #region Protected Overridden Methods

        /// <summary>
        /// Creates a new CollectionForm to display the collection editor
        /// </summary>
        /// <remarks>
        /// This methods uses reflection to access non-public fields/properties within the collectionform.
        /// This method can also be used to alter other visual aspects of the form.
        /// </remarks>
        /// <returns>CollectionForm</returns>
        protected override CollectionForm CreateCollectionForm()
        {

            //Get a reference top new collection form
            CollectionEditor.CollectionForm form = base.CreateCollectionForm();
            
            //Center the form 
            form.StartPosition = FormStartPosition.CenterParent;
         
            //Get the forms type
            Type formType = form.GetType();

            //Get a reference to the private fieldtype propertyBrowser
            //This is the propertgrid inside the collectionform
            FieldInfo fieldInfo = formType.GetField("propertyBrowser", BindingFlags.NonPublic | BindingFlags.Instance);

            if (fieldInfo != null)
            {

                //get a reference to the propertygrid instance located on the form
                PropertyGrid propertyGrid = (PropertyGrid)fieldInfo.GetValue(form);
                
                if (propertyGrid != null)
                {

                    //Make the tool bar visible
                    propertyGrid.ToolbarVisible = true;

                    //Make the help/description visible
                    propertyGrid.HelpVisible = true;

                    //Get the property grid's type.
                    //Note that this is a vsPropertyGrid located in System.Windows.Forms.Design
                    Type propertyGridType = propertyGrid.GetType();

                    //Get a reference to the non-public property ToolStripRenderer
                    PropertyInfo propertyInfo = propertyGridType.GetProperty("ToolStripRenderer",BindingFlags.NonPublic | BindingFlags.Instance);
                    
                    if (propertyInfo != null)
                    {
                        //Assign a ToolStripProfessionalRenderer with our custom color table
                        propertyInfo.SetValue(propertyGrid,new ToolStripProfessionalRenderer(new CustomColorTable()),null);
                    }
                }
            }

            //Return the form
            return form;
        }

        #endregion

    }
}
