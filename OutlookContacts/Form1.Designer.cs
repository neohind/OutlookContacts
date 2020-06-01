namespace OutlookContacts
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.consoleWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(68, 29);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(68, 70);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 26);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 251);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 26);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(162, 29);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(334, 283);
            this.txtResults.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(503, 29);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(447, 283);
            this.propertyGrid1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consoleWebBrowser
            // 
            this.consoleWebBrowser.Location = new System.Drawing.Point(162, 329);
            this.consoleWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.consoleWebBrowser.Name = "consoleWebBrowser";
            this.consoleWebBrowser.Size = new System.Drawing.Size(788, 250);
            this.consoleWebBrowser.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 593);
            this.Controls.Add(this.consoleWebBrowser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser consoleWebBrowser;
    }
}

