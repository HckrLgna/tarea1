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
            this.posx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxOperation = new System.Windows.Forms.ComboBox();
            this.XSlider = new System.Windows.Forms.TrackBar();
            this.YSlider = new System.Windows.Forms.TrackBar();
            this.ZSlider = new System.Windows.Forms.TrackBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generarJson
            // 
            this.generarJson.Location = new System.Drawing.Point(214, 567);
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
            this.cmbxObjets.Items.AddRange(new object[] {
            "Escenario"});
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
            this.panel1.Location = new System.Drawing.Point(131, 579);
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
            this.cmbxParts.Items.AddRange(new object[] {
            "Objeto"});
            this.cmbxParts.Location = new System.Drawing.Point(131, 88);
            this.cmbxParts.Name = "cmbxParts";
            this.cmbxParts.Size = new System.Drawing.Size(137, 24);
            this.cmbxParts.TabIndex = 8;
            this.cmbxParts.SelectedIndexChanged += new System.EventHandler(this.cmbxParts_SelectedIndexChanged);
            // 
            // cmbxFaces
            // 
            this.cmbxFaces.FormattingEnabled = true;
            this.cmbxFaces.Items.AddRange(new object[] {
            "Parte"});
            this.cmbxFaces.Location = new System.Drawing.Point(131, 132);
            this.cmbxFaces.Name = "cmbxFaces";
            this.cmbxFaces.Size = new System.Drawing.Size(137, 24);
            this.cmbxFaces.TabIndex = 9;
            this.cmbxFaces.SelectedIndexChanged += new System.EventHandler(this.cmbxFaces_SelectedIndexChanged);
            // 
            // posx
            // 
            this.posx.AutoSize = true;
            this.posx.Location = new System.Drawing.Point(17, 242);
            this.posx.Name = "posx";
            this.posx.Size = new System.Drawing.Size(68, 16);
            this.posx.TabIndex = 10;
            this.posx.Text = "Posicion x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Posicion Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Posicion Z";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Operation";
            // 
            // cmbxOperation
            // 
            this.cmbxOperation.FormattingEnabled = true;
            this.cmbxOperation.Items.AddRange(new object[] {
            "Traslate",
            "Rotate",
            "Escale"});
            this.cmbxOperation.Location = new System.Drawing.Point(131, 182);
            this.cmbxOperation.Name = "cmbxOperation";
            this.cmbxOperation.Size = new System.Drawing.Size(137, 24);
            this.cmbxOperation.TabIndex = 23;
            this.cmbxOperation.SelectedIndexChanged += new System.EventHandler(this.cmbxOperation_SelectedIndexChanged);
            // 
            // XSlider
            // 
            this.XSlider.Location = new System.Drawing.Point(39, 269);
            this.XSlider.Maximum = 1000;
            this.XSlider.Minimum = -1000;
            this.XSlider.Name = "XSlider";
            this.XSlider.Size = new System.Drawing.Size(273, 56);
            this.XSlider.TabIndex = 24;
            this.XSlider.Scroll += new System.EventHandler(this.XSlider_Scroll);
            // 
            // YSlider
            // 
            this.YSlider.Location = new System.Drawing.Point(39, 360);
            this.YSlider.Maximum = 1000;
            this.YSlider.Minimum = -1000;
            this.YSlider.Name = "YSlider";
            this.YSlider.Size = new System.Drawing.Size(273, 56);
            this.YSlider.TabIndex = 25;
            this.YSlider.Scroll += new System.EventHandler(this.YSlider_Scroll);
            // 
            // ZSlider
            // 
            this.ZSlider.Location = new System.Drawing.Point(39, 451);
            this.ZSlider.Maximum = 1000;
            this.ZSlider.Minimum = -1000;
            this.ZSlider.Name = "ZSlider";
            this.ZSlider.Size = new System.Drawing.Size(273, 56);
            this.ZSlider.TabIndex = 26;
            this.ZSlider.Scroll += new System.EventHandler(this.ZSlider_Scroll);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(104, 513);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 27;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Animation";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 628);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.ZSlider);
            this.Controls.Add(this.YSlider);
            this.Controls.Add(this.XSlider);
            this.Controls.Add(this.cmbxOperation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.posx);
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
            ((System.ComponentModel.ISupportInitialize)(this.XSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZSlider)).EndInit();
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
        private System.Windows.Forms.Label posx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxOperation;
        private System.Windows.Forms.TrackBar XSlider;
        private System.Windows.Forms.TrackBar YSlider;
        private System.Windows.Forms.TrackBar ZSlider;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label7;
    }
}