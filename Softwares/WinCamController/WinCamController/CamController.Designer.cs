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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFlashDelay = new System.Windows.Forms.Label();
            this.serialCombo = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownFlashDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDrop1Size = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDrop2Delay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDrop2Size = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlashDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop1Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop2Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop2Size)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port";
            // 
            // LabelFlashDelay
            // 
            this.LabelFlashDelay.AutoSize = true;
            this.LabelFlashDelay.Location = new System.Drawing.Point(33, 68);
            this.LabelFlashDelay.Name = "LabelFlashDelay";
            this.LabelFlashDelay.Size = new System.Drawing.Size(62, 13);
            this.LabelFlashDelay.TabIndex = 2;
            this.LabelFlashDelay.Text = "Flash Delay";
            // 
            // serialCombo
            // 
            this.serialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialCombo.FormattingEnabled = true;
            this.serialCombo.Location = new System.Drawing.Point(118, 22);
            this.serialCombo.Name = "serialCombo";
            this.serialCombo.Size = new System.Drawing.Size(120, 21);
            this.serialCombo.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(253, 15);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 32);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.btnCOnnect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Drop1 Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drop2 Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Drop2 Size";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(118, 231);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 32);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Drop";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // numericUpDownFlashDelay
            // 
            this.numericUpDownFlashDelay.Location = new System.Drawing.Point(118, 65);
            this.numericUpDownFlashDelay.Name = "numericUpDownFlashDelay";
            this.numericUpDownFlashDelay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFlashDelay.TabIndex = 7;
            // 
            // numericUpDownDrop1Size
            // 
            this.numericUpDownDrop1Size.Location = new System.Drawing.Point(118, 107);
            this.numericUpDownDrop1Size.Name = "numericUpDownDrop1Size";
            this.numericUpDownDrop1Size.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrop1Size.TabIndex = 8;
            // 
            // numericUpDownDrop2Delay
            // 
            this.numericUpDownDrop2Delay.Location = new System.Drawing.Point(118, 149);
            this.numericUpDownDrop2Delay.Name = "numericUpDownDrop2Delay";
            this.numericUpDownDrop2Delay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrop2Delay.TabIndex = 9;
            // 
            // numericUpDownDrop2Size
            // 
            this.numericUpDownDrop2Size.Location = new System.Drawing.Point(118, 191);
            this.numericUpDownDrop2Size.Name = "numericUpDownDrop2Size";
            this.numericUpDownDrop2Size.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrop2Size.TabIndex = 10;
            // 
            // CamController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 272);
            this.Controls.Add(this.numericUpDownDrop2Size);
            this.Controls.Add(this.numericUpDownDrop2Delay);
            this.Controls.Add(this.numericUpDownDrop1Size);
            this.Controls.Add(this.numericUpDownFlashDelay);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.serialCombo);
            this.Controls.Add(this.LabelFlashDelay);
            this.Controls.Add(this.label1);
            this.Name = "CamController";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlashDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop1Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop2Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrop2Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelFlashDelay;
        private System.Windows.Forms.ComboBox serialCombo;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NumericUpDown numericUpDownFlashDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownDrop1Size;
        private System.Windows.Forms.NumericUpDown numericUpDownDrop2Delay;
        private System.Windows.Forms.NumericUpDown numericUpDownDrop2Size;
    }
}

