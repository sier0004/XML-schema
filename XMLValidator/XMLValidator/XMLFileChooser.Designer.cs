namespace XMLValidator
{
    partial class XMLFileChooser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.openFDforFile = new System.Windows.Forms.OpenFileDialog();
            this.schemaLabel = new System.Windows.Forms.Label();
            this.schemaPathTextBox = new System.Windows.Forms.TextBox();
            this.schemaButton = new System.Windows.Forms.Button();
            this.openFDforSchema = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fileLabel.Location = new System.Drawing.Point(57, 67);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(175, 13);
            this.fileLabel.TabIndex = 2;
            this.fileLabel.Text = "Choose the XML file to be validated";
            // 
            // schemaLabel
            // 
            this.schemaLabel.AutoSize = true;
            this.schemaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schemaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.schemaLabel.Location = new System.Drawing.Point(74, 135);
            this.schemaLabel.Name = "schemaLabel";
            this.schemaLabel.Size = new System.Drawing.Size(144, 13);
            this.schemaLabel.TabIndex = 6;
            this.schemaLabel.Text = "Choose the XML Schema file";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(24, 44);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(243, 20);
            this.filePathTextBox.TabIndex = 1;
            // 
            // schemaPathTextBox
            // 
            this.schemaPathTextBox.Location = new System.Drawing.Point(24, 112);
            this.schemaPathTextBox.Name = "schemaPathTextBox";
            this.schemaPathTextBox.Size = new System.Drawing.Size(243, 20);
            this.schemaPathTextBox.TabIndex = 5;
            // 
            // openFDforFile
            // 
            this.openFDforFile.Filter = "XML|*.xml";
            this.openFDforFile.Title = "Choose the XML file to be validated";
            this.openFDforFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFDforFile_FileOk);
            // 
            // openFDforSchema
            // 
            this.openFDforSchema.FileName = "openFDforschema";
            this.openFDforSchema.Filter = "Schema XSD|*.xsd";
            this.openFDforSchema.FileOk += new System.ComponentModel.CancelEventHandler(this.openFDforSchema_FileOk);
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(273, 44);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(87, 23);
            this.fileButton.TabIndex = 0;
            this.fileButton.Text = "XML File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // schemaButton
            // 
            this.schemaButton.Location = new System.Drawing.Point(273, 112);
            this.schemaButton.Name = "schemaButton";
            this.schemaButton.Size = new System.Drawing.Size(87, 23);
            this.schemaButton.TabIndex = 4;
            this.schemaButton.Text = "XML Schema";
            this.schemaButton.UseVisualStyleBackColor = true;
            this.schemaButton.Click += new System.EventHandler(this.schemaButton_Click);
            // 
            // validateButton
            // 
            this.validateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(91, 180);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(207, 30);
            this.validateButton.TabIndex = 3;
            this.validateButton.Text = "Validate";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // XMLFileChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.schemaLabel);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.schemaPathTextBox);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.schemaButton);
            this.Controls.Add(this.validateButton);
            this.Name = "XMLFileChoice";
            this.Text = "XML Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label schemaLabel;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.TextBox schemaPathTextBox;
        private System.Windows.Forms.OpenFileDialog openFDforFile;
        private System.Windows.Forms.OpenFileDialog openFDforSchema;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Button schemaButton;
        private System.Windows.Forms.Button validateButton;
    }
}

