namespace IDE_PROYECTO1
{
    partial class VentanaEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.editarArchivoToolStripMenuItem,
            this.eliminarProyectoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.archivoToolStripMenuItem.Text = "Proyectos";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirArchivoToolStripMenuItem.Text = "Nuevo proyecto";
            // 
            // editarArchivoToolStripMenuItem
            // 
            this.editarArchivoToolStripMenuItem.Name = "editarArchivoToolStripMenuItem";
            this.editarArchivoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editarArchivoToolStripMenuItem.Text = "Abrir proyecto";
            this.editarArchivoToolStripMenuItem.Click += new System.EventHandler(this.editarArchivoToolStripMenuItem_Click);
            // 
            // eliminarProyectoToolStripMenuItem
            // 
            this.eliminarProyectoToolStripMenuItem.Name = "eliminarProyectoToolStripMenuItem";
            this.eliminarProyectoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarProyectoToolStripMenuItem.Text = "Eliminar proyecto";
            // 
            // panelEditor
            // 
            this.panelEditor.Location = new System.Drawing.Point(0, 31);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(1158, 423);
            this.panelEditor.TabIndex = 1;
            // 
            // panelInformacion
            // 
            this.panelInformacion.Location = new System.Drawing.Point(0, 477);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(1158, 128);
            this.panelInformacion.TabIndex = 2;
            // 
            // VentanaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 617);
            this.Controls.Add(this.panelInformacion);
            this.Controls.Add(this.panelEditor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaEditor";
            this.Text = "IDE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProyectoToolStripMenuItem;
        private System.Windows.Forms.Panel panelEditor;
        private System.Windows.Forms.Panel panelInformacion;
    }
}

