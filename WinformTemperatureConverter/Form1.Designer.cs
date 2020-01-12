namespace WinformTemperatureConverter
{
    partial class Form1
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
            this.inputTemp = new System.Windows.Forms.TextBox();
            this.btnCelciusToFahrenheit = new System.Windows.Forms.Button();
            this.btnFahrenheitToCelcius = new System.Windows.Forms.Button();
            this.listBoxConversions = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsXML = new System.Windows.Forms.SaveFileDialog();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTemp
            // 
            this.inputTemp.Font = new System.Drawing.Font("Rawline", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTemp.Location = new System.Drawing.Point(13, 39);
            this.inputTemp.Name = "inputTemp";
            this.inputTemp.Size = new System.Drawing.Size(188, 23);
            this.inputTemp.TabIndex = 0;
            // 
            // btnCelciusToFahrenheit
            // 
            this.btnCelciusToFahrenheit.Font = new System.Drawing.Font("Rawline", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelciusToFahrenheit.Location = new System.Drawing.Point(13, 69);
            this.btnCelciusToFahrenheit.Name = "btnCelciusToFahrenheit";
            this.btnCelciusToFahrenheit.Size = new System.Drawing.Size(75, 25);
            this.btnCelciusToFahrenheit.TabIndex = 1;
            this.btnCelciusToFahrenheit.Text = "C to F";
            this.btnCelciusToFahrenheit.UseVisualStyleBackColor = true;
            this.btnCelciusToFahrenheit.Click += new System.EventHandler(this.btnCelciusToFahrenheit_Click);
            // 
            // btnFahrenheitToCelcius
            // 
            this.btnFahrenheitToCelcius.Font = new System.Drawing.Font("Rawline", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrenheitToCelcius.Location = new System.Drawing.Point(126, 69);
            this.btnFahrenheitToCelcius.Name = "btnFahrenheitToCelcius";
            this.btnFahrenheitToCelcius.Size = new System.Drawing.Size(75, 25);
            this.btnFahrenheitToCelcius.TabIndex = 2;
            this.btnFahrenheitToCelcius.Text = "F to C";
            this.btnFahrenheitToCelcius.UseVisualStyleBackColor = true;
            this.btnFahrenheitToCelcius.Click += new System.EventHandler(this.btnFahrenheitToCelcius_Click);
            // 
            // listBoxConversions
            // 
            this.listBoxConversions.Font = new System.Drawing.Font("Rawline", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxConversions.FormattingEnabled = true;
            this.listBoxConversions.ItemHeight = 16;
            this.listBoxConversions.Location = new System.Drawing.Point(13, 101);
            this.listBoxConversions.Name = "listBoxConversions";
            this.listBoxConversions.Size = new System.Drawing.Size(188, 340);
            this.listBoxConversions.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(215, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Rawline", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Rawline", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.Location = new System.Drawing.Point(13, 471);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(0, 16);
            this.lblSaveStatus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 496);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.listBoxConversions);
            this.Controls.Add(this.btnFahrenheitToCelcius);
            this.Controls.Add(this.btnCelciusToFahrenheit);
            this.Controls.Add(this.inputTemp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTemp;
        private System.Windows.Forms.Button btnCelciusToFahrenheit;
        private System.Windows.Forms.Button btnFahrenheitToCelcius;
        private System.Windows.Forms.ListBox listBoxConversions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveAsXML;
        private System.Windows.Forms.Label lblSaveStatus;
    }
}

