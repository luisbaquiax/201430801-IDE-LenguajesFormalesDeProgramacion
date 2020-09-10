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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuProyectos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNuevoProyecto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbrirProyecto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEliminarProyecto = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCrearCodigoFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbrirCodigoFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEliminarCodigoFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarCodigoFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtErrores = new System.Windows.Forms.RichTextBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEditorCodigo = new System.Windows.Forms.RichTextBox();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProyectos,
            this.códigoFuenteToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1523, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // menuProyectos
            // 
            this.menuProyectos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevoProyecto,
            this.menuAbrirProyecto,
            this.menuEliminarProyecto});
            this.menuProyectos.Name = "menuProyectos";
            this.menuProyectos.Size = new System.Drawing.Size(87, 24);
            this.menuProyectos.Text = "Proyectos";
            // 
            // menuNuevoProyecto
            // 
            this.menuNuevoProyecto.Name = "menuNuevoProyecto";
            this.menuNuevoProyecto.Size = new System.Drawing.Size(209, 26);
            this.menuNuevoProyecto.Text = "Nuevo proyecto";
            // 
            // menuAbrirProyecto
            // 
            this.menuAbrirProyecto.Name = "menuAbrirProyecto";
            this.menuAbrirProyecto.Size = new System.Drawing.Size(209, 26);
            this.menuAbrirProyecto.Text = "Abrir proyecto";
            this.menuAbrirProyecto.Click += new System.EventHandler(this.editarArchivoToolStripMenuItem_Click);
            // 
            // menuEliminarProyecto
            // 
            this.menuEliminarProyecto.Name = "menuEliminarProyecto";
            this.menuEliminarProyecto.Size = new System.Drawing.Size(209, 26);
            this.menuEliminarProyecto.Text = "Eliminar proyecto";
            // 
            // códigoFuenteToolStripMenuItem
            // 
            this.códigoFuenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCrearCodigoFuente,
            this.menuAbrirCodigoFuente,
            this.menuEliminarCodigoFuente,
            this.menuCerrarCodigoFuente});
            this.códigoFuenteToolStripMenuItem.Name = "códigoFuenteToolStripMenuItem";
            this.códigoFuenteToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.códigoFuenteToolStripMenuItem.Text = "Código fuente";
            this.códigoFuenteToolStripMenuItem.Click += new System.EventHandler(this.códigoFuenteToolStripMenuItem_Click);
            // 
            // menuCrearCodigoFuente
            // 
            this.menuCrearCodigoFuente.Name = "menuCrearCodigoFuente";
            this.menuCrearCodigoFuente.Size = new System.Drawing.Size(186, 26);
            this.menuCrearCodigoFuente.Text = "Crear";
            // 
            // menuAbrirCodigoFuente
            // 
            this.menuAbrirCodigoFuente.Name = "menuAbrirCodigoFuente";
            this.menuAbrirCodigoFuente.Size = new System.Drawing.Size(186, 26);
            this.menuAbrirCodigoFuente.Text = "Abrir ";
            // 
            // menuEliminarCodigoFuente
            // 
            this.menuEliminarCodigoFuente.Name = "menuEliminarCodigoFuente";
            this.menuEliminarCodigoFuente.Size = new System.Drawing.Size(186, 26);
            this.menuEliminarCodigoFuente.Text = "Eliminar";
            // 
            // menuCerrarCodigoFuente
            // 
            this.menuCerrarCodigoFuente.Name = "menuCerrarCodigoFuente";
            this.menuCerrarCodigoFuente.Size = new System.Drawing.Size(186, 26);
            this.menuCerrarCodigoFuente.Text = "Cerrar Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtErrores);
            this.panel2.Location = new System.Drawing.Point(3, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1520, 129);
            this.panel2.TabIndex = 1;
            // 
            // txtErrores
            // 
            this.txtErrores.Enabled = false;
            this.txtErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrores.Location = new System.Drawing.Point(3, 0);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.Size = new System.Drawing.Size(1514, 109);
            this.txtErrores.TabIndex = 0;
            this.txtErrores.Text = "";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Location = new System.Drawing.Point(0, 31);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1523, 664);
            this.panelContenedor.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEditorCodigo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1508, 476);
            this.panel1.TabIndex = 0;
            // 
            // txtEditorCodigo
            // 
            this.txtEditorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorCodigo.Location = new System.Drawing.Point(3, 3);
            this.txtEditorCodigo.Name = "txtEditorCodigo";
            this.txtEditorCodigo.Size = new System.Drawing.Size(1505, 473);
            this.txtEditorCodigo.TabIndex = 0;
            this.txtEditorCodigo.Text = "";
            // 
            // VentanaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 684);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "VentanaEditor";
            this.Text = "IDE";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuProyectos;
        private System.Windows.Forms.ToolStripMenuItem menuNuevoProyecto;
        private System.Windows.Forms.ToolStripMenuItem menuAbrirProyecto;
        private System.Windows.Forms.ToolStripMenuItem menuEliminarProyecto;
        private System.Windows.Forms.ToolStripMenuItem códigoFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCrearCodigoFuente;
        private System.Windows.Forms.ToolStripMenuItem menuAbrirCodigoFuente;
        private System.Windows.Forms.ToolStripMenuItem menuEliminarCodigoFuente;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarCodigoFuente;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtErrores;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtEditorCodigo;
    }
}

