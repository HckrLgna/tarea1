namespace Proyecto1_01
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.generarJson = new System.Windows.Forms.Button();
            this.cmbxObjets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxParts = new System.Windows.Forms.ComboBox();
            this.cmbxFaces = new System.Windows.Forms.ComboBox();
            this.Position = new System.Windows.Forms.Label();
            this.inptPosX = new System.Windows.Forms.NumericUpDown();
            this.inptPosY = new System.Windows.Forms.NumericUpDown();
            this.inptPosZ = new System.Windows.Forms.NumericUpDown();
            this.inptRotX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inptRotY = new System.Windows.Forms.NumericUpDown();
            this.inptRotZ = new System.Windows.Forms.NumericUpDown();
            this.inptScalX = new System.Windows.Forms.NumericUpDown();
            this.inptScalY = new System.Windows.Forms.NumericUpDown();
            this.inptScalZ = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inptPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptScalX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptScalY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptScalZ)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generarJson
            // 
            this.generarJson.Location = new System.Drawing.Point(214, 513);
            this.generarJson.Name = "generarJson";
            this.generarJson.Size = new System.Drawing.Size(98, 34);
            this.generarJson.TabIndex = 1;
            this.generarJson.Text = "Save json";
            this.generarJson.UseVisualStyleBackColor = true;
            this.generarJson.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbxObjets
            // 
            this.cmbxObjets.FormattingEnabled = true;
            this.cmbxObjets.Location = new System.Drawing.Point(131, 46);
            this.cmbxObjets.Name = "cmbxObjets";
            this.cmbxObjets.Size = new System.Drawing.Size(137, 24);
            this.cmbxObjets.TabIndex = 3;
            this.cmbxObjets.Text = "choose an object";
            this.cmbxObjets.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Objects:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(131, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 23);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parts";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Faces";
            // 
            // cmbxParts
            // 
            this.cmbxParts.FormattingEnabled = true;
            this.cmbxParts.Location = new System.Drawing.Point(131, 88);
            this.cmbxParts.Name = "cmbxParts";
            this.cmbxParts.Size = new System.Drawing.Size(137, 24);
            this.cmbxParts.TabIndex = 8;
            this.cmbxParts.SelectedIndexChanged += new System.EventHandler(this.cmbxParts_SelectedIndexChanged);
            // 
            // cmbxFaces
            // 
            this.cmbxFaces.FormattingEnabled = true;
            this.cmbxFaces.Location = new System.Drawing.Point(131, 132);
            this.cmbxFaces.Name = "cmbxFaces";
            this.cmbxFaces.Size = new System.Drawing.Size(137, 24);
            this.cmbxFaces.TabIndex = 9;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(14, 201);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(55, 16);
            this.Position.TabIndex = 10;
            this.Position.Text = "Position";
            // 
            // inptPosX
            // 
            this.inptPosX.DecimalPlaces = 2;
            this.inptPosX.Location = new System.Drawing.Point(148, 197);
            this.inptPosX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inptPosX.Name = "inptPosX";
            this.inptPosX.Size = new System.Drawing.Size(120, 22);
            this.inptPosX.TabIndex = 11;
            this.inptPosX.ThousandsSeparator = true;
            this.inptPosX.ValueChanged += new System.EventHandler(this.inptPosX_ValueChanged);
            // 
            // inptPosY
            // 
            this.inptPosY.Location = new System.Drawing.Point(148, 226);
            this.inptPosY.Name = "inptPosY";
            this.inptPosY.Size = new System.Drawing.Size(120, 22);
            this.inptPosY.TabIndex = 12;
            // 
            // inptPosZ
            // 
            this.inptPosZ.Location = new System.Drawing.Point(148, 255);
            this.inptPosZ.Name = "inptPosZ";
            this.inptPosZ.Size = new System.Drawing.Size(120, 22);
            this.inptPosZ.TabIndex = 13;
            // 
            // inptRotX
            // 
            this.inptRotX.Location = new System.Drawing.Point(148, 307);
            this.inptRotX.Name = "inptRotX";
            this.inptRotX.Size = new System.Drawing.Size(120, 22);
            this.inptRotX.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rotation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Scale";
            // 
            // inptRotY
            // 
            this.inptRotY.Location = new System.Drawing.Point(148, 336);
            this.inptRotY.Name = "inptRotY";
            this.inptRotY.Size = new System.Drawing.Size(120, 22);
            this.inptRotY.TabIndex = 17;
            // 
            // inptRotZ
            // 
            this.inptRotZ.Location = new System.Drawing.Point(148, 365);
            this.inptRotZ.Name = "inptRotZ";
            this.inptRotZ.Size = new System.Drawing.Size(120, 22);
            this.inptRotZ.TabIndex = 18;
            // 
            // inptScalX
            // 
            this.inptScalX.Location = new System.Drawing.Point(148, 410);
            this.inptScalX.Name = "inptScalX";
            this.inptScalX.Size = new System.Drawing.Size(120, 22);
            this.inptScalX.TabIndex = 19;
            // 
            // inptScalY
            // 
            this.inptScalY.Location = new System.Drawing.Point(148, 439);
            this.inptScalY.Name = "inptScalY";
            this.inptScalY.Size = new System.Drawing.Size(120, 22);
            this.inptScalY.TabIndex = 20;
            // 
            // inptScalZ
            // 
            this.inptScalZ.Location = new System.Drawing.Point(148, 468);
            this.inptScalZ.Name = "inptScalZ";
            this.inptScalZ.Size = new System.Drawing.Size(120, 22);
            this.inptScalZ.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 580);
            this.Controls.Add(this.inptScalZ);
            this.Controls.Add(this.inptScalY);
            this.Controls.Add(this.inptScalX);
            this.Controls.Add(this.inptRotZ);
            this.Controls.Add(this.inptRotY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inptRotX);
            this.Controls.Add(this.inptPosZ);
            this.Controls.Add(this.inptPosY);
            this.Controls.Add(this.inptPosX);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.cmbxFaces);
            this.Controls.Add(this.cmbxParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxObjets);
            this.Controls.Add(this.generarJson);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inptPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptScalX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptScalY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptScalZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button generarJson;
        private System.Windows.Forms.ComboBox cmbxObjets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxParts;
        private System.Windows.Forms.ComboBox cmbxFaces;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.NumericUpDown inptPosX;
        private System.Windows.Forms.NumericUpDown inptPosY;
        private System.Windows.Forms.NumericUpDown inptPosZ;
        private System.Windows.Forms.NumericUpDown inptRotX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inptRotY;
        private System.Windows.Forms.NumericUpDown inptRotZ;
        private System.Windows.Forms.NumericUpDown inptScalX;
        private System.Windows.Forms.NumericUpDown inptScalY;
        private System.Windows.Forms.NumericUpDown inptScalZ;
    }
}