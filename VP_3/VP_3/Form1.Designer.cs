namespace VP_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.CarName = new System.Windows.Forms.TextBox();
            this.ManufactureYear = new System.Windows.Forms.NumericUpDown();
            this.EngineNumber = new System.Windows.Forms.TextBox();
            this.BodyNumber = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.Button();
            this.Numberplate = new System.Windows.Forms.TextBox();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureYear)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(14, 14);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 260);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CarName
            // 
            this.CarName.Location = new System.Drawing.Point(718, 14);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(168, 30);
            this.CarName.TabIndex = 1;
            // 
            // ManufactureYear
            // 
            this.ManufactureYear.Location = new System.Drawing.Point(718, 52);
            this.ManufactureYear.Name = "ManufactureYear";
            this.ManufactureYear.Size = new System.Drawing.Size(169, 30);
            this.ManufactureYear.TabIndex = 2;
            this.ManufactureYear.ValueChanged += new System.EventHandler(this.ManufactureYear_ValueChanged);
            // 
            // EngineNumber
            // 
            this.EngineNumber.Location = new System.Drawing.Point(718, 90);
            this.EngineNumber.Name = "EngineNumber";
            this.EngineNumber.Size = new System.Drawing.Size(168, 30);
            this.EngineNumber.TabIndex = 3;
            // 
            // BodyNumber
            // 
            this.BodyNumber.Location = new System.Drawing.Point(718, 128);
            this.BodyNumber.Name = "BodyNumber";
            this.BodyNumber.Size = new System.Drawing.Size(168, 30);
            this.BodyNumber.TabIndex = 4;
            // 
            // Color
            // 
            this.Color.BackColor = System.Drawing.SystemColors.Control;
            this.Color.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Color.Location = new System.Drawing.Point(718, 166);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(169, 33);
            this.Color.TabIndex = 5;
            this.Color.UseVisualStyleBackColor = false;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Numberplate
            // 
            this.Numberplate.Location = new System.Drawing.Point(718, 206);
            this.Numberplate.Name = "Numberplate";
            this.Numberplate.Size = new System.Drawing.Size(168, 30);
            this.Numberplate.TabIndex = 6;
            // 
            // OwnerName
            // 
            this.OwnerName.Location = new System.Drawing.Point(718, 244);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(168, 30);
            this.OwnerName.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(441, 14);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(270, 23);
            this.textBox6.TabIndex = 8;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Car Brand";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(441, 52);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(270, 23);
            this.textBox7.TabIndex = 9;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Manufacture Year";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(441, 90);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(270, 23);
            this.textBox8.TabIndex = 10;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Engine Number";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(441, 128);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(270, 23);
            this.textBox9.TabIndex = 11;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Body Number";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(441, 166);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(270, 23);
            this.textBox10.TabIndex = 12;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Color";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(441, 206);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(270, 23);
            this.textBox11.TabIndex = 13;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Numberplate";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(441, 244);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(270, 23);
            this.textBox12.TabIndex = 14;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "Owner Name";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(441, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(446, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 33);
            this.button3.TabIndex = 16;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 33);
            this.button4.TabIndex = 17;
            this.button4.Text = "Open";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(441, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 33);
            this.button6.TabIndex = 19;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 284);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 74);
            this.button8.TabIndex = 21;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(549, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 33);
            this.button5.TabIndex = 22;
            this.button5.Text = "Use As Filter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "Disable Filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(804, 324);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 33);
            this.button7.TabIndex = 24;
            this.button7.Text = "Avg";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 371);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.OwnerName);
            this.Controls.Add(this.Numberplate);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.BodyNumber);
            this.Controls.Add(this.EngineNumber);
            this.Controls.Add(this.ManufactureYear);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Data Editor";
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private TextBox CarName;
        private NumericUpDown ManufactureYear;
        private TextBox EngineNumber;
        private TextBox BodyNumber;
        private Button Color;
        private TextBox Numberplate;
        private TextBox OwnerName;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button8;
        private Button button5;
        private Button button1;
        private Button button7;
    }
}