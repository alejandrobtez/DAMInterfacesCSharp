namespace CustomToggle
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
            this.toggleButton2 = new ToggleButton();
            this.SuspendLayout();
            // 
            // toggleButton2
            // 
            this.toggleButton2.AutoSize = true;
            this.toggleButton2.Location = new System.Drawing.Point(341, 221);
            this.toggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton2.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton2.OnToggleColor = System.Drawing.Color.White;
            this.toggleButton2.Size = new System.Drawing.Size(136, 24);
            this.toggleButton2.SolidStyle = true;
            this.toggleButton2.TabIndex = 0;
            this.toggleButton2.Text = "toggleButton2";
            this.toggleButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(823, 441);
            this.Controls.Add(this.toggleButton2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToggleButton toggleButton1;
        private ToggleButton toggleButton2;
    }
}

