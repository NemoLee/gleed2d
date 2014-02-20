namespace GLEED2D
{
    partial class AddCustomProperty
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.txbFreetext = new System.Windows.Forms.TextBox();
            this.cbbBoolean = new System.Windows.Forms.ComboBox();
            this.txbX = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numUDB = new System.Windows.Forms.NumericUpDown();
            this.numUDG = new System.Windows.Forms.NumericUpDown();
            this.numUDR = new System.Windows.Forms.NumericUpDown();
            this.cbxAddToAllSelected = new System.Windows.Forms.CheckBox();
            this.cbxAddMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 21);
            this.textBox1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(249, 218);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(168, 218);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 33);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 65);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(47, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Free text";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(47, 125);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 16);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Boolean";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(47, 146);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 16);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Vector2";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(47, 167);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 16);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.Text = "Color";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(47, 188);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.Text = "Item";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // txbFreetext
            // 
            this.txbFreetext.Location = new System.Drawing.Point(124, 103);
            this.txbFreetext.Name = "txbFreetext";
            this.txbFreetext.Size = new System.Drawing.Size(200, 21);
            this.txbFreetext.TabIndex = 10;
            // 
            // cbbBoolean
            // 
            this.cbbBoolean.FormattingEnabled = true;
            this.cbbBoolean.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbbBoolean.Location = new System.Drawing.Point(124, 125);
            this.cbbBoolean.Name = "cbbBoolean";
            this.cbbBoolean.Size = new System.Drawing.Size(63, 20);
            this.cbbBoolean.TabIndex = 11;
            this.cbbBoolean.Text = "true";
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(124, 146);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(88, 21);
            this.txbX.TabIndex = 12;
            this.txbX.Text = "0";
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(233, 145);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(88, 21);
            this.txbY.TabIndex = 13;
            this.txbY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "G";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "B";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(297, 165);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(27, 23);
            this.btnColor.TabIndex = 22;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // numUDB
            // 
            this.numUDB.Location = new System.Drawing.Point(245, 167);
            this.numUDB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDB.Name = "numUDB";
            this.numUDB.Size = new System.Drawing.Size(40, 21);
            this.numUDB.TabIndex = 23;
            this.numUDB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numUDG
            // 
            this.numUDG.Location = new System.Drawing.Point(186, 167);
            this.numUDG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDG.Name = "numUDG";
            this.numUDG.Size = new System.Drawing.Size(40, 21);
            this.numUDG.TabIndex = 24;
            this.numUDG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numUDR
            // 
            this.numUDR.Location = new System.Drawing.Point(129, 167);
            this.numUDR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDR.Name = "numUDR";
            this.numUDR.Size = new System.Drawing.Size(40, 21);
            this.numUDR.TabIndex = 25;
            this.numUDR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDR.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // cbxAddToAllSelected
            // 
            this.cbxAddToAllSelected.AutoSize = true;
            this.cbxAddToAllSelected.Location = new System.Drawing.Point(13, 209);
            this.cbxAddToAllSelected.Name = "cbxAddToAllSelected";
            this.cbxAddToAllSelected.Size = new System.Drawing.Size(138, 16);
            this.cbxAddToAllSelected.TabIndex = 26;
            this.cbxAddToAllSelected.Text = "add to all selected";
            this.cbxAddToAllSelected.UseVisualStyleBackColor = true;
            this.cbxAddToAllSelected.CheckedChanged += new System.EventHandler(this.cbxAddToAllSelected_CheckedChanged);
            // 
            // cbxAddMode
            // 
            this.cbxAddMode.AutoSize = true;
            this.cbxAddMode.Enabled = false;
            this.cbxAddMode.Location = new System.Drawing.Point(13, 231);
            this.cbxAddMode.Name = "cbxAddMode";
            this.cbxAddMode.Size = new System.Drawing.Size(132, 16);
            this.cbxAddMode.TabIndex = 27;
            this.cbxAddMode.Text = "overwrite conflict";
            this.cbxAddMode.UseVisualStyleBackColor = true;
            // 
            // AddCustomProperty
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(336, 250);
            this.ControlBox = false;
            this.Controls.Add(this.cbxAddMode);
            this.Controls.Add(this.cbxAddToAllSelected);
            this.Controls.Add(this.numUDR);
            this.Controls.Add(this.numUDG);
            this.Controls.Add(this.numUDB);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.txbX);
            this.Controls.Add(this.cbbBoolean);
            this.Controls.Add(this.txbFreetext);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCustomProperty";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Custom Property";
            this.Load += new System.EventHandler(this.AddCustomProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox txbFreetext;
        private System.Windows.Forms.ComboBox cbbBoolean;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numUDB;
        private System.Windows.Forms.NumericUpDown numUDG;
        private System.Windows.Forms.NumericUpDown numUDR;
        private System.Windows.Forms.CheckBox cbxAddToAllSelected;
        private System.Windows.Forms.CheckBox cbxAddMode;
    }
}