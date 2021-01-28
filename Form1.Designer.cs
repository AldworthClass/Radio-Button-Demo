namespace Radio_Button_Demo
{
    partial class FormRadioDemo
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
            this.grpSaber = new System.Windows.Forms.GroupBox();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblShip = new System.Windows.Forms.Label();
            this.btnSubmitShip = new System.Windows.Forms.Button();
            this.radTitanic = new System.Windows.Forms.RadioButton();
            this.radFalcon = new System.Windows.Forms.RadioButton();
            this.radEnterprise = new System.Windows.Forms.RadioButton();
            this.imgShip = new System.Windows.Forms.PictureBox();
            this.imgSaber = new System.Windows.Forms.PictureBox();
            this.grpSaber.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSaber)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSaber
            // 
            this.grpSaber.Controls.Add(this.radGreen);
            this.grpSaber.Controls.Add(this.radBlue);
            this.grpSaber.Controls.Add(this.radRed);
            this.grpSaber.Location = new System.Drawing.Point(12, 13);
            this.grpSaber.Name = "grpSaber";
            this.grpSaber.Size = new System.Drawing.Size(99, 92);
            this.grpSaber.TabIndex = 0;
            this.grpSaber.TabStop = false;
            this.grpSaber.Text = "Choose Saber";
            this.grpSaber.Visible = false;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(6, 65);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 2;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(6, 42);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 1;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(6, 19);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblShip);
            this.groupBox2.Controls.Add(this.btnSubmitShip);
            this.groupBox2.Controls.Add(this.radTitanic);
            this.groupBox2.Controls.Add(this.radFalcon);
            this.groupBox2.Controls.Add(this.radEnterprise);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 149);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose The Correct Ship";
            // 
            // lblShip
            // 
            this.lblShip.AutoSize = true;
            this.lblShip.Location = new System.Drawing.Point(7, 120);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(45, 13);
            this.lblShip.TabIndex = 4;
            this.lblShip.Text = "Answer:";
            // 
            // btnSubmitShip
            // 
            this.btnSubmitShip.Location = new System.Drawing.Point(6, 88);
            this.btnSubmitShip.Name = "btnSubmitShip";
            this.btnSubmitShip.Size = new System.Drawing.Size(177, 23);
            this.btnSubmitShip.TabIndex = 3;
            this.btnSubmitShip.Text = "Submit Guess";
            this.btnSubmitShip.UseVisualStyleBackColor = true;
            this.btnSubmitShip.Click += new System.EventHandler(this.btnSubmitShip_Click);
            // 
            // radTitanic
            // 
            this.radTitanic.AutoSize = true;
            this.radTitanic.Location = new System.Drawing.Point(6, 65);
            this.radTitanic.Name = "radTitanic";
            this.radTitanic.Size = new System.Drawing.Size(57, 17);
            this.radTitanic.TabIndex = 2;
            this.radTitanic.TabStop = true;
            this.radTitanic.Text = "Titanic";
            this.radTitanic.UseVisualStyleBackColor = true;
            // 
            // radFalcon
            // 
            this.radFalcon.AutoSize = true;
            this.radFalcon.Location = new System.Drawing.Point(6, 42);
            this.radFalcon.Name = "radFalcon";
            this.radFalcon.Size = new System.Drawing.Size(105, 17);
            this.radFalcon.TabIndex = 1;
            this.radFalcon.TabStop = true;
            this.radFalcon.Text = "Millenium Falcom";
            this.radFalcon.UseVisualStyleBackColor = true;
            // 
            // radEnterprise
            // 
            this.radEnterprise.AutoSize = true;
            this.radEnterprise.Location = new System.Drawing.Point(6, 19);
            this.radEnterprise.Name = "radEnterprise";
            this.radEnterprise.Size = new System.Drawing.Size(94, 17);
            this.radEnterprise.TabIndex = 0;
            this.radEnterprise.TabStop = true;
            this.radEnterprise.Text = "The Enterprise";
            this.radEnterprise.UseVisualStyleBackColor = true;
            // 
            // imgShip
            // 
            this.imgShip.Image = global::Radio_Button_Demo.Properties.Resources.Enterprise;
            this.imgShip.Location = new System.Drawing.Point(230, 120);
            this.imgShip.Name = "imgShip";
            this.imgShip.Size = new System.Drawing.Size(169, 139);
            this.imgShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShip.TabIndex = 2;
            this.imgShip.TabStop = false;
            // 
            // imgSaber
            // 
            this.imgSaber.Location = new System.Drawing.Point(131, 13);
            this.imgSaber.Name = "imgSaber";
            this.imgSaber.Size = new System.Drawing.Size(269, 92);
            this.imgSaber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSaber.TabIndex = 1;
            this.imgSaber.TabStop = false;
            this.imgSaber.Visible = false;
            // 
            // FormRadioDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 283);
            this.Controls.Add(this.imgShip);
            this.Controls.Add(this.imgSaber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSaber);
            this.Name = "FormRadioDemo";
            this.Text = "Radio Button Demo";
            this.grpSaber.ResumeLayout(false);
            this.grpSaber.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSaber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSaber;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.Button btnSubmitShip;
        private System.Windows.Forms.RadioButton radTitanic;
        private System.Windows.Forms.RadioButton radFalcon;
        private System.Windows.Forms.RadioButton radEnterprise;
        private System.Windows.Forms.PictureBox imgSaber;
        private System.Windows.Forms.PictureBox imgShip;
    }
}

