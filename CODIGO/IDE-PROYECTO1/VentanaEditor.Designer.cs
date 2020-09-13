﻿namespace IDE_PROYECTO1
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
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFila = new System.Windows.Forms.TextBox();
            this.textBoxColumna = new System.Windows.Forms.TextBox();
            this.btnExportarErrores = new System.Windows.Forms.Button();
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
            this.guardarToolStripMenuItem,
            this.menuSalir});
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
            this.menuNuevoProyecto.Size = new System.Drawing.Size(224, 26);
            this.menuNuevoProyecto.Text = "Nuevo proyecto";
            this.menuNuevoProyecto.Click += new System.EventHandler(this.menuNuevoProyecto_Click);
            // 
            // menuAbrirProyecto
            // 
            this.menuAbrirProyecto.Name = "menuAbrirProyecto";
            this.menuAbrirProyecto.Size = new System.Drawing.Size(224, 26);
            this.menuAbrirProyecto.Text = "Abrir proyecto";
            this.menuAbrirProyecto.Click += new System.EventHandler(this.editarArchivoToolStripMenuItem_Click);
            // 
            // menuEliminarProyecto
            // 
            this.menuEliminarProyecto.Name = "menuEliminarProyecto";
            this.menuEliminarProyecto.Size = new System.Drawing.Size(224, 26);
            this.menuEliminarProyecto.Text = "Eliminar proyecto";
            this.menuEliminarProyecto.Click += new System.EventHandler(this.menuEliminarProyecto_Click);
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
            this.menuCrearCodigoFuente.Size = new System.Drawing.Size(224, 26);
            this.menuCrearCodigoFuente.Text = "Crear";
            this.menuCrearCodigoFuente.Click += new System.EventHandler(this.menuCrearCodigoFuente_Click);
            // 
            // menuAbrirCodigoFuente
            // 
            this.menuAbrirCodigoFuente.Name = "menuAbrirCodigoFuente";
            this.menuAbrirCodigoFuente.Size = new System.Drawing.Size(224, 26);
            this.menuAbrirCodigoFuente.Text = "Abrir ";
            this.menuAbrirCodigoFuente.Click += new System.EventHandler(this.menuAbrirCodigoFuente_Click);
            // 
            // menuEliminarCodigoFuente
            // 
            this.menuEliminarCodigoFuente.Name = "menuEliminarCodigoFuente";
            this.menuEliminarCodigoFuente.Size = new System.Drawing.Size(224, 26);
            this.menuEliminarCodigoFuente.Text = "Eliminar";
            this.menuEliminarCodigoFuente.Click += new System.EventHandler(this.menuEliminarCodigoFuente_Click);
            // 
            // menuCerrarCodigoFuente
            // 
            this.menuCerrarCodigoFuente.Name = "menuCerrarCodigoFuente";
            this.menuCerrarCodigoFuente.Size = new System.Drawing.Size(224, 26);
            this.menuCerrarCodigoFuente.Text = "Cerrar Archivo";
            this.menuCerrarCodigoFuente.Click += new System.EventHandler(this.menuCerrarCodigoFuente_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
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
            this.panelContenedor.Controls.Add(this.btnExportarErrores);
            this.panelContenedor.Controls.Add(this.textBoxColumna);
            this.panelContenedor.Controls.Add(this.txtBoxFila);
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.label1);
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
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(52, 24);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Errores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Columna";
            // 
            // txtBoxFila
            // 
            this.txtBoxFila.Location = new System.Drawing.Point(122, 495);
            this.txtBoxFila.Name = "txtBoxFila";
            this.txtBoxFila.Size = new System.Drawing.Size(52, 22);
            this.txtBoxFila.TabIndex = 5;
            // 
            // textBoxColumna
            // 
            this.textBoxColumna.Location = new System.Drawing.Point(276, 495);
            this.textBoxColumna.Name = "textBoxColumna";
            this.textBoxColumna.Size = new System.Drawing.Size(52, 22);
            this.textBoxColumna.TabIndex = 6;
            // 
            // btnExportarErrores
            // 
            this.btnExportarErrores.Location = new System.Drawing.Point(365, 492);
            this.btnExportarErrores.Name = "btnExportarErrores";
            this.btnExportarErrores.Size = new System.Drawing.Size(124, 23);
            this.btnExportarErrores.TabIndex = 7;
            this.btnExportarErrores.Text = "ExportarErrores";
            this.btnExportarErrores.UseVisualStyleBackColor = true;
            this.btnExportarErrores.Click += new System.EventHandler(this.btnExportarErrores_Click);
            // 
            // VentanaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 653);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "VentanaEditor";
            this.Text = "IDE";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.Button btnExportarErrores;
        private System.Windows.Forms.TextBox textBoxColumna;
        private System.Windows.Forms.TextBox txtBoxFila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

