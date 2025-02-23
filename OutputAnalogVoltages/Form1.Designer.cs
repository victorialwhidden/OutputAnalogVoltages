namespace OutputAnalogVoltages
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
            this.lbl_labname = new System.Windows.Forms.Label();
            this.Cbx_AOports = new System.Windows.Forms.ComboBox();
            this.HscB_AnalogV = new System.Windows.Forms.HScrollBar();
            this.txtB_AOVoltage = new System.Windows.Forms.TextBox();
            this.lstB_DevVoltages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_labname
            // 
            this.lbl_labname.AutoSize = true;
            this.lbl_labname.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_labname.Location = new System.Drawing.Point(12, 25);
            this.lbl_labname.Name = "lbl_labname";
            this.lbl_labname.Size = new System.Drawing.Size(204, 23);
            this.lbl_labname.TabIndex = 0;
            this.lbl_labname.Text = "Lab: Analog Outputs";
            // 
            // Cbx_AOports
            // 
            this.Cbx_AOports.FormattingEnabled = true;
            this.Cbx_AOports.Location = new System.Drawing.Point(116, 135);
            this.Cbx_AOports.Name = "Cbx_AOports";
            this.Cbx_AOports.Size = new System.Drawing.Size(237, 21);
            this.Cbx_AOports.TabIndex = 1;
            this.Cbx_AOports.SelectedIndexChanged += new System.EventHandler(this.Cbx_AOports_SelectedIndexChanged);
            // 
            // HscB_AnalogV
            // 
            this.HscB_AnalogV.Location = new System.Drawing.Point(66, 195);
            this.HscB_AnalogV.Name = "HscB_AnalogV";
            this.HscB_AnalogV.Size = new System.Drawing.Size(336, 27);
            this.HscB_AnalogV.TabIndex = 2;
            this.HscB_AnalogV.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HscB_AnalogV_Scroll);
            // 
            // txtB_AOVoltage
            // 
            this.txtB_AOVoltage.BackColor = System.Drawing.SystemColors.Info;
            this.txtB_AOVoltage.Location = new System.Drawing.Point(150, 162);
            this.txtB_AOVoltage.Name = "txtB_AOVoltage";
            this.txtB_AOVoltage.ReadOnly = true;
            this.txtB_AOVoltage.Size = new System.Drawing.Size(168, 20);
            this.txtB_AOVoltage.TabIndex = 3;
            // 
            // lstB_DevVoltages
            // 
            this.lstB_DevVoltages.Enabled = false;
            this.lstB_DevVoltages.FormattingEnabled = true;
            this.lstB_DevVoltages.Location = new System.Drawing.Point(500, 64);
            this.lstB_DevVoltages.Name = "lstB_DevVoltages";
            this.lstB_DevVoltages.Size = new System.Drawing.Size(254, 251);
            this.lstB_DevVoltages.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstB_DevVoltages);
            this.Controls.Add(this.txtB_AOVoltage);
            this.Controls.Add(this.HscB_AnalogV);
            this.Controls.Add(this.Cbx_AOports);
            this.Controls.Add(this.lbl_labname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_labname;
        private System.Windows.Forms.ComboBox Cbx_AOports;
        private System.Windows.Forms.HScrollBar HscB_AnalogV;
        private System.Windows.Forms.TextBox txtB_AOVoltage;
        private System.Windows.Forms.ListBox lstB_DevVoltages;
    }
}

