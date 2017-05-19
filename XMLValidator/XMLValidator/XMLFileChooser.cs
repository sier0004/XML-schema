using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml; //Include this name space inorder to use SqlBulkCopy<
using System.Xml.Schema;

namespace XMLValidator
{
    public partial class XMLFileChooser : Form
    {
        String fileName;
        String schemaName;
        static ArrayList errors = new ArrayList();
        static bool valid;

        public XMLFileChooser()
        {
            InitializeComponent();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            openFDforFile.ShowDialog();
        }

        private void schemaButton_Click(object sender, EventArgs e)
        {
            openFDforSchema.ShowDialog();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                MessageBox.Show("Select an XML file!");
            }
            else if (schemaName == null)
            {
                // validate the XML file
                if (validate(fileName))
                {
                    MessageBox.Show("valid XML!");
                }
                else
                {
                    MessageBox.Show("Not valid XML");
                }
            }
            else
            {
                // validate the XML file against XSD
                if (validateUsingXSD(fileName, schemaName))
                {
                    MessageBox.Show("valid XML!");
                }
                else
                {
                    MessageBox.Show("Not valid XML");
                }
            }

        }

        private void openFDforFile_FileOk(object sender, CancelEventArgs e)
        {
            fileName = openFDforFile.FileName;
            filePathTextBox.Text = fileName;
        }

        private void openFDforSchema_FileOk(object sender, CancelEventArgs e)
        {
            schemaName = openFDforSchema.FileName;
            schemaPathTextBox.Text = schemaName;
        }

        private static bool validate(string xmlUri)
        {
            XmlReaderSettings xmlSettings = new XmlReaderSettings();
            //xmlSettings.Schemas = new XmlSchemaSet();
            //xmlSettings.ValidationType = ValidationType.Schema;
            XmlReader reader = XmlReader.Create(xmlUri, xmlSettings);
            try
            {
                errors.Clear();
                valid = true;

                // Parse the file
                while (reader.Read()) ;

                return true;
            }
            catch (XmlException e)
            {
                valid = false;
                errors.Add(e.Message);
                foreach (var error in errors)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            finally
            {
                //Close the reader
                reader.Close();
            }
            return valid;
        }

        private static bool validateUsingXSD(string xmlUri, string xsdUri)
        {
            try
            {
                errors.Clear();
                valid = true;

                XmlDocument xmlDoc = new XmlDocument();

                XmlTextReader schemaReader = new XmlTextReader(xsdUri);
                XmlSchema schema = XmlSchema.Read(schemaReader, SchemaValidationHandler);

                xmlDoc.Schemas.Add(schema);

                xmlDoc.Load(xmlUri);
                xmlDoc.Validate(DocumentValidationHandler);

                return true;
            }
            catch (XmlException e)
            {
                valid = false;
                errors.Add(e.Message);
                foreach (var error in errors)
                {
                    MessageBox.Show(error.ToString());
                }
                return valid;
            }
        }

        private static void SchemaValidationHandler(object sender, ValidationEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private static void DocumentValidationHandler(object sender, ValidationEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
