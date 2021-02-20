namespace WinCamController
{
    partial class CamController
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialCombo = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTestDrop = new System.Windows.Forms.Button();
            this.buttonTestFlash = new System.Windows.Forms.Button();
            this.LabelFlashDelay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownFlashDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDrop1Size = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDrop2Delay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDrop2Size = new System.Windows.Forms.NumericUpDown();
            this.checkDrop2Property = new System.Windows.Forms.CheckBox();
            this.trackBarFlashDelay = new System.Windows.Forms.TrackBar();
            this.trackBarDrop1Size = new System.Windows.Forms.TrackBar();
            this.numericUpDownDrop3Delay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDrop3Size = new System.Windows.Forms.NumericUpDown();
            this.checkDrop3Property = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarDrop2Delay = new System.Windows.Forms.TrackBar();
            this.trackBarDrop2Size = new System.Windows.Forms.TrackBar();
            this.trackBarDrop3Delay = new System.Windows.Forms.TrackBar();
            this.trackBarDrop3Size = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlashDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop1Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop2Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop2Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFlashDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop1Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop3Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop3Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop2Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop2Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop3Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop3Size)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(10, 416);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 32);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Drop";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port";
            // 
            // serialCombo
            // 
            this.serialCombo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.serialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialCombo.FormattingEnabled = true;
            this.serialCombo.Location = new System.Drawing.Point(107, 35);
            this.serialCombo.Name = "serialCombo";
            this.serialCombo.Size = new System.Drawing.Size(120, 21);
            this.serialCombo.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(259, 28);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(120, 32);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.btnCOnnect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.serialCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 82);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // buttonTestDrop
            // 
            this.buttonTestDrop.Location = new System.Drawing.Point(143, 416);
            this.buttonTestDrop.Name = "buttonTestDrop";
            this.buttonTestDrop.Size = new System.Drawing.Size(120, 32);
            this.buttonTestDrop.TabIndex = 16;
            this.buttonTestDrop.Text = "TestDrop";
            this.buttonTestDrop.UseVisualStyleBackColor = true;
            // 
            // buttonTestFlash
            // 
            this.buttonTestFlash.Location = new System.Drawing.Point(276, 416);
            this.buttonTestFlash.Name = "buttonTestFlash";
            this.buttonTestFlash.Size = new System.Drawing.Size(120, 32);
            this.buttonTestFlash.TabIndex = 17;
            this.buttonTestFlash.Text = "TestFlash";
            this.buttonTestFlash.UseVisualStyleBackColor = true;
            // 
            // LabelFlashDelay
            // 
            this.LabelFlashDelay.AutoSize = true;
            this.LabelFlashDelay.Location = new System.Drawing.Point(15, 26);
            this.LabelFlashDelay.Name = "LabelFlashDelay";
            this.LabelFlashDelay.Size = new System.Drawing.Size(62, 13);
            this.LabelFlashDelay.TabIndex = 2;
            this.LabelFlashDelay.Text = "Flash Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Drop1 Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drop2 Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Drop2 Size";
            // 
            // numericUpDownFlashDelay
            // 
            this.numericUpDownFlashDelay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericUpDownFlashDelay.Location = new System.Drawing.Point(108, 26);
            this.numericUpDownFlashDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFlashDelay.Name = "numericUpDownFlashDelay";
            this.numericUpDownFlashDelay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFlashDelay.TabIndex = 7;
            // 
            // numericUpDownDrop1Size
            // 
            this.numericUpDownDrop1Size.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericUpDownDrop1Size.Location = new System.Drawing.Point(108, 68);
            this.numericUpDownDrop1Size.Name = "numericUpDownDrop1Size";
            this.numericUpDownDrop1Size.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrop1Size.TabIndex = 8;
            // 
            // numericUpDownDrop2Delay
            // 
            this.numericUpDownDrop2Delay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericUpDownDrop2Delay.Location = new System.Drawing.Point(108, 108);
            this.numericUpDownDrop2Delay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDrop2Delay.Name = "numericUpDownDrop2Delay";
            this.numericUpDownDrop2Delay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrop2Delay.TabIndex = 9;
            // 
            // numericUpDownDrop2Size
            // 
            this.numericUpDownDrop2Size.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericUpDownDrop2Size.Location = new System.Drawing.Point(108, 151);
            this.numericUpDownDrop2Size.Name = "numericUpDownDrop2Size";
            this.numericUpDownDrop2Size.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrop2Size.TabIndex = 10;
            // 
            // checkDrop2Property
            // 
            this.checkDrop2Property.AutoSize = true;
            this.checkDrop2Property.Checked = true;
            this.checkDrop2Property.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDrop2Property.Location = new System.Drawing.Point(239, 134);
            this.checkDrop2Property.Name = "checkDrop2Property";
            this.checkDrop2Property.Size = new System.Drawing.Size(15, 14);
            this.checkDrop2Property.TabIndex = 11;
            this.checkDrop2Property.UseVisualStyleBackColor = true;
            this.checkDrop2Property.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // trackBarFlashDelay
            // 
            this.trackBarFlashDelay.Location = new System.Drawing.Point(260, 26);
            this.trackBarFlashDelay.Name = "trackBarFlashDelay";
            this.trackBarFlashDelay.Size = new System.Drawing.Size(104, 45);
            this.trackBarFlashDelay.TabIndex = 13;
            // 
            // trackBarDrop1Size
            // 
            this.trackBarDrop1Size.Location = new System.Drawing.Point(260, 68);
            this.trackBarDrop1Size.Name = "trackBarDrop1Size";
            this.trackBarDrop1Size.Size = new System.Drawing.Size(104, 45);
            this.trackBarDrop1Size.TabIndex = 14;
            // 
            // numericUpDownDrop3Delay
            // 
            this.numericUpDownDrop3Delay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericUpDownDrop3Delay.Location = new System.Drawing.Point(108, 196);
            this.numericUpDownDrop3Delay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDrop3Delay.Name = "numericUpDownDrop3Delay";
            this.numericUpDownDrop3Delay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrop3Delay.TabIndex = 15;
            // 
            // numericUpDownDrop3Size
            // 
            this.numericUpDownDrop3Size.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericUpDownDrop3Size.Location = new System.Drawing.Point(108, 237);
            this.numericUpDownDrop3Size.Name = "numericUpDownDrop3Size";
            this.numericUpDownDrop3Size.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrop3Size.TabIndex = 16;
            // 
            // checkDrop3Property
            // 
            this.checkDrop3Property.AutoSize = true;
            this.checkDrop3Property.Checked = true;
            this.checkDrop3Property.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDrop3Property.Location = new System.Drawing.Point(239, 220);
            this.checkDrop3Property.Name = "checkDrop3Property";
            this.checkDrop3Property.Size = new System.Drawing.Size(15, 14);
            this.checkDrop3Property.TabIndex = 17;
            this.checkDrop3Property.UseVisualStyleBackColor = true;
            this.checkDrop3Property.CheckedChanged += new System.EventHandler(this.checkDrop3Property_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Drop3 Delay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Drop3 Size";
            // 
            // trackBarDrop2Delay
            // 
            this.trackBarDrop2Delay.Location = new System.Drawing.Point(260, 108);
            this.trackBarDrop2Delay.Maximum = 100;
            this.trackBarDrop2Delay.Name = "trackBarDrop2Delay";
            this.trackBarDrop2Delay.Size = new System.Drawing.Size(104, 45);
            this.trackBarDrop2Delay.TabIndex = 21;
            // 
            // trackBarDrop2Size
            // 
            this.trackBarDrop2Size.Location = new System.Drawing.Point(260, 151);
            this.trackBarDrop2Size.Name = "trackBarDrop2Size";
            this.trackBarDrop2Size.Size = new System.Drawing.Size(104, 45);
            this.trackBarDrop2Size.TabIndex = 22;
            // 
            // trackBarDrop3Delay
            // 
            this.trackBarDrop3Delay.Location = new System.Drawing.Point(260, 196);
            this.trackBarDrop3Delay.Name = "trackBarDrop3Delay";
            this.trackBarDrop3Delay.Size = new System.Drawing.Size(104, 45);
            this.trackBarDrop3Delay.TabIndex = 23;
            // 
            // trackBarDrop3Size
            // 
            this.trackBarDrop3Size.Location = new System.Drawing.Point(260, 237);
            this.trackBarDrop3Size.Name = "trackBarDrop3Size";
            this.trackBarDrop3Size.Size = new System.Drawing.Size(104, 45);
            this.trackBarDrop3Size.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.trackBarDrop3Size);
            this.groupBox2.Controls.Add(this.trackBarDrop3Delay);
            this.groupBox2.Controls.Add(this.trackBarDrop2Size);
            this.groupBox2.Controls.Add(this.trackBarDrop2Delay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkDrop3Property);
            this.groupBox2.Controls.Add(this.numericUpDownDrop3Size);
            this.groupBox2.Controls.Add(this.numericUpDownDrop3Delay);
            this.groupBox2.Controls.Add(this.trackBarDrop1Size);
            this.groupBox2.Controls.Add(this.trackBarFlashDelay);
            this.groupBox2.Controls.Add(this.checkDrop2Property);
            this.groupBox2.Controls.Add(this.numericUpDownDrop2Size);
            this.groupBox2.Controls.Add(this.numericUpDownDrop2Delay);
            this.groupBox2.Controls.Add(this.numericUpDownDrop1Size);
            this.groupBox2.Controls.Add(this.numericUpDownFlashDelay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LabelFlashDelay);
            this.groupBox2.Location = new System.Drawing.Point(10, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 288);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // CamController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(409, 468);
            this.Controls.Add(this.buttonTestFlash);
            this.Controls.Add(this.buttonTestDrop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CamController";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlashDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop1Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop2Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop2Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFlashDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop1Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop3Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop3Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop2Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop2Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop3Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop3Size)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialCombo;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTestDrop;
        private System.Windows.Forms.Button buttonTestFlash;
        private System.Windows.Forms.Label LabelFlashDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownFlashDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownDrop1Size;
        private System.Windows.Forms.NumericUpDown numericUpDownDrop2Delay;
        private System.Windows.Forms.NumericUpDown numericUpDownDrop2Size;
        private System.Windows.Forms.CheckBox checkDrop2Property;
        private System.Windows.Forms.TrackBar trackBarFlashDelay;
        private System.Windows.Forms.TrackBar trackBarDrop1Size;
        private System.Windows.Forms.NumericUpDown numericUpDownDrop3Delay;
        private System.Windows.Forms.NumericUpDown numericUpDownDrop3Size;
        private System.Windows.Forms.CheckBox checkDrop3Property;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarDrop2Delay;
        private System.Windows.Forms.TrackBar trackBarDrop2Size;
        private System.Windows.Forms.TrackBar trackBarDrop3Delay;
        private System.Windows.Forms.TrackBar trackBarDrop3Size;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

