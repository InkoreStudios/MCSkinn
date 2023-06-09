﻿using MCSkinn.Scripts.Languages;

namespace MCSkinn
{
    partial class DarkenLightenOptions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            trackBar1 = new System.Windows.Forms.TrackBar();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            languageProvider1 = new LanguageProvider();
            label2 = new System.Windows.Forms.Label();
            BrushPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)languageProvider1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(361, 11);
            checkBox1.Margin = new System.Windows.Forms.Padding(4);
            checkBox1.Name = "checkBox1";
            languageProvider1.SetPropertyNames(checkBox1, "Text");
            checkBox1.Size = new System.Drawing.Size(129, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "O_INCREMENTAL";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(470, 12);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            languageProvider1.SetPropertyNames(label1, "Text");
            label1.Size = new System.Drawing.Size(86, 17);
            label1.TabIndex = 1;
            label1.Text = "O_EXPOSURE";
            // 
            // trackBar1
            // 
            trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            trackBar1.AutoSize = false;
            trackBar1.Location = new System.Drawing.Point(538, 11);
            trackBar1.Margin = new System.Windows.Forms.Padding(4);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(97, 29);
            trackBar1.TabIndex = 2;
            trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numericUpDown1.Location = new System.Drawing.Point(634, 9);
            numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(47, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(200, 10);
            radioButton1.Margin = new System.Windows.Forms.Padding(4);
            radioButton1.Name = "radioButton1";
            languageProvider1.SetPropertyNames(radioButton1, "Text");
            radioButton1.Size = new System.Drawing.Size(93, 21);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "O_LIGHTEN";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(273, 10);
            radioButton2.Margin = new System.Windows.Forms.Padding(4);
            radioButton2.Name = "radioButton2";
            languageProvider1.SetPropertyNames(radioButton2, "Text");
            radioButton2.Size = new System.Drawing.Size(91, 21);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "O_DARKEN";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // languageProvider1
            // 
            languageProvider1.BaseControl = this;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 12);
            label2.Name = "label2";
            languageProvider1.SetPropertyNames(label2, "Text");
            label2.Size = new System.Drawing.Size(63, 17);
            label2.TabIndex = 7;
            label2.Text = "G_BRUSH";
            // 
            // BrushPanel
            // 
            BrushPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            BrushPanel.Location = new System.Drawing.Point(60, 6);
            BrushPanel.Name = "BrushPanel";
            BrushPanel.Size = new System.Drawing.Size(120, 28);
            BrushPanel.TabIndex = 6;
            // 
            // DarkenLightenOptions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            Controls.Add(numericUpDown1);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(BrushPanel);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "DarkenLightenOptions";
            Size = new System.Drawing.Size(919, 40);
            Load += DodgeBurnOptions_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)languageProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        public LanguageProvider languageProvider1;
        private System.Windows.Forms.Panel BrushPanel;
        private System.Windows.Forms.Label label2;
    }
}
