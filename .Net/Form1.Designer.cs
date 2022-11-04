namespace clienteSD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.probeName = new System.Windows.Forms.TextBox();
            this.dataProbe = new System.Windows.Forms.TextBox();
            this.addProbe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.consultProbe = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.updateProbe = new System.Windows.Forms.Button();
            this.newValue = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.probeName);
            this.groupBox1.Controls.Add(this.dataProbe);
            this.groupBox1.Controls.Add(this.addProbe);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir Sondas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(844, 184);
            this.listBox1.TabIndex = 4;
            // 
            // probeName
            // 
            this.probeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.probeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.probeName.ForeColor = System.Drawing.Color.DarkGray;
            this.probeName.Location = new System.Drawing.Point(419, 21);
            this.probeName.Name = "probeName";
            this.probeName.Size = new System.Drawing.Size(125, 19);
            this.probeName.TabIndex = 3;
            this.probeName.Text = "sonda1";
            // 
            // dataProbe
            // 
            this.dataProbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dataProbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProbe.ForeColor = System.Drawing.Color.DarkGray;
            this.dataProbe.Location = new System.Drawing.Point(7, 24);
            this.dataProbe.Name = "dataProbe";
            this.dataProbe.Size = new System.Drawing.Size(262, 19);
            this.dataProbe.TabIndex = 1;
            this.dataProbe.Text = "192.168.56.101:9080";
            this.dataProbe.TextChanged += new System.EventHandler(this.dataProbe_TextChanged);
            // 
            // addProbe
            // 
            this.addProbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addProbe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addProbe.FlatAppearance.BorderSize = 0;
            this.addProbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProbe.ForeColor = System.Drawing.Color.DarkGray;
            this.addProbe.Location = new System.Drawing.Point(717, 21);
            this.addProbe.Name = "addProbe";
            this.addProbe.Size = new System.Drawing.Size(133, 26);
            this.addProbe.TabIndex = 0;
            this.addProbe.Text = "Añadir Sonda";
            this.addProbe.UseVisualStyleBackColor = false;
            this.addProbe.Click += new System.EventHandler(this.addProbe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.consultProbe);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(13, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar valores de los sensoores de Sonda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // consultProbe
            // 
            this.consultProbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.consultProbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultProbe.Location = new System.Drawing.Point(7, 140);
            this.consultProbe.Name = "consultProbe";
            this.consultProbe.Size = new System.Drawing.Size(99, 30);
            this.consultProbe.TabIndex = 2;
            this.consultProbe.Text = "Consultar";
            this.consultProbe.UseVisualStyleBackColor = false;
            this.consultProbe.Click += new System.EventHandler(this.consultProbe_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(255, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 28);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.updateProbe);
            this.groupBox3.Controls.Add(this.newValue);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Location = new System.Drawing.Point(436, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 177);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar valor LED sonda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 21);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 28);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // updateProbe
            // 
            this.updateProbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.updateProbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProbe.Location = new System.Drawing.Point(6, 140);
            this.updateProbe.Name = "updateProbe";
            this.updateProbe.Size = new System.Drawing.Size(101, 31);
            this.updateProbe.TabIndex = 4;
            this.updateProbe.Text = "Establecer";
            this.updateProbe.UseVisualStyleBackColor = false;
            this.updateProbe.Click += new System.EventHandler(this.updateProbe_Click);
            // 
            // newValue
            // 
            this.newValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.newValue.ForeColor = System.Drawing.Color.DarkGray;
            this.newValue.Location = new System.Drawing.Point(272, 23);
            this.newValue.Name = "newValue";
            this.newValue.Size = new System.Drawing.Size(155, 26);
            this.newValue.TabIndex = 5;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(850, 230);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DarkGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 5;
            this.lineShape1.X2 = 262;
            this.lineShape1.Y1 = 21;
            this.lineShape1.Y2 = 21;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DarkGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 416;
            this.lineShape2.X2 = 555;
            this.lineShape2.Y1 = 21;
            this.lineShape2.Y2 = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(881, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aparcamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dataProbe;
        private System.Windows.Forms.Button addProbe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button consultProbe;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox newValue;
        private System.Windows.Forms.Button updateProbe;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox probeName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}

