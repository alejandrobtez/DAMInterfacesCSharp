namespace interfaz_LimpiaClase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraDeTitulo = new System.Windows.Forms.Panel();
            this.BarraLateralLeft = new System.Windows.Forms.Panel();
            this.PanelSubMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BarraDeTitulo.SuspendLayout();
            this.BarraLateralLeft.SuspendLayout();
            this.PanelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraDeTitulo
            // 
            this.BarraDeTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BarraDeTitulo.Controls.Add(this.Maximizar);
            this.BarraDeTitulo.Controls.Add(this.Minimizar);
            this.BarraDeTitulo.Controls.Add(this.Cerrar);
            this.BarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraDeTitulo.Name = "BarraDeTitulo";
            this.BarraDeTitulo.Size = new System.Drawing.Size(800, 35);
            this.BarraDeTitulo.TabIndex = 0;
            this.BarraDeTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraDeTitulo_Paint);
            this.BarraDeTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraDeTitulo_MouseDown);
            // 
            // BarraLateralLeft
            // 
            this.BarraLateralLeft.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BarraLateralLeft.Controls.Add(this.PanelSubMenu);
            this.BarraLateralLeft.Controls.Add(this.button2);
            this.BarraLateralLeft.Controls.Add(this.button1);
            this.BarraLateralLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraLateralLeft.Location = new System.Drawing.Point(0, 35);
            this.BarraLateralLeft.Name = "BarraLateralLeft";
            this.BarraLateralLeft.Size = new System.Drawing.Size(200, 415);
            this.BarraLateralLeft.TabIndex = 1;
            // 
            // PanelSubMenu
            // 
            this.PanelSubMenu.Controls.Add(this.button5);
            this.PanelSubMenu.Controls.Add(this.button4);
            this.PanelSubMenu.Controls.Add(this.button3);
            this.PanelSubMenu.Location = new System.Drawing.Point(26, 270);
            this.PanelSubMenu.Name = "PanelSubMenu";
            this.PanelSubMenu.Size = new System.Drawing.Size(150, 100);
            this.PanelSubMenu.TabIndex = 4;
            this.PanelSubMenu.Visible = false;
            this.PanelSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.Image = global::interfaz_LimpiaClase.Properties.Resources.CapturaA;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(107, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 75);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::interfaz_LimpiaClase.Properties.Resources.WIN_20241031_17_33_15_Pro;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(59, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 75);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(13, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 75);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(26, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 100);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(26, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.BackColor = System.Drawing.Color.Lime;
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Location = new System.Drawing.Point(732, 3);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(25, 25);
            this.Maximizar.TabIndex = 2;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Location = new System.Drawing.Point(701, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Red;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Location = new System.Drawing.Point(763, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(600, 415);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraLateralLeft);
            this.Controls.Add(this.BarraDeTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.BarraDeTitulo.ResumeLayout(false);
            this.BarraLateralLeft.ResumeLayout(false);
            this.PanelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraDeTitulo;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Panel BarraLateralLeft;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelSubMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}

