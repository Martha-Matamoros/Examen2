
namespace Examen2
{
    partial class ProductoFrm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoTxt = new System.Windows.Forms.TextBox();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.existenciaTxt = new System.Windows.Forms.TextBox();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.nuevoBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencia:";
            // 
            // codigoTxt
            // 
            this.codigoTxt.Enabled = false;
            this.codigoTxt.Location = new System.Drawing.Point(171, 16);
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.Size = new System.Drawing.Size(259, 26);
            this.codigoTxt.TabIndex = 4;
            this.codigoTxt.TextChanged += new System.EventHandler(this.codigoTxt_TextChanged);
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Enabled = false;
            this.descripcionTxt.Location = new System.Drawing.Point(171, 57);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(259, 26);
            this.descripcionTxt.TabIndex = 5;
            this.descripcionTxt.TextChanged += new System.EventHandler(this.descripcionTxt_TextChanged);
            // 
            // precioTxt
            // 
            this.precioTxt.Enabled = false;
            this.precioTxt.Location = new System.Drawing.Point(171, 98);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(259, 26);
            this.precioTxt.TabIndex = 6;
            this.precioTxt.TextChanged += new System.EventHandler(this.precioTxt_TextChanged);
            // 
            // existenciaTxt
            // 
            this.existenciaTxt.Enabled = false;
            this.existenciaTxt.Location = new System.Drawing.Point(171, 140);
            this.existenciaTxt.Name = "existenciaTxt";
            this.existenciaTxt.Size = new System.Drawing.Size(259, 26);
            this.existenciaTxt.TabIndex = 7;
            this.existenciaTxt.TextChanged += new System.EventHandler(this.existenciaTxt_TextChanged);
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImagenPictureBox.Enabled = false;
            this.ImagenPictureBox.Location = new System.Drawing.Point(455, 12);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(258, 154);
            this.ImagenPictureBox.TabIndex = 8;
            this.ImagenPictureBox.TabStop = false;
            this.ImagenPictureBox.Click += new System.EventHandler(this.ImagenPictureBox_Click);
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Enabled = false;
            this.siguienteBtn.Location = new System.Drawing.Point(668, 172);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(45, 35);
            this.siguienteBtn.TabIndex = 9;
            this.siguienteBtn.Text = "...";
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click);
            // 
            // nuevoBtn
            // 
            this.nuevoBtn.Location = new System.Drawing.Point(72, 199);
            this.nuevoBtn.Name = "nuevoBtn";
            this.nuevoBtn.Size = new System.Drawing.Size(92, 35);
            this.nuevoBtn.TabIndex = 10;
            this.nuevoBtn.Text = "Nuevo";
            this.nuevoBtn.UseVisualStyleBackColor = true;
            this.nuevoBtn.Click += new System.EventHandler(this.nuevoBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(179, 199);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(92, 35);
            this.modificarBtn.TabIndex = 11;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Enabled = false;
            this.guardarBtn.Location = new System.Drawing.Point(287, 199);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(92, 35);
            this.guardarBtn.TabIndex = 12;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(400, 199);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(92, 35);
            this.eliminarBtn.TabIndex = 13;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Enabled = false;
            this.salirBtn.Location = new System.Drawing.Point(513, 199);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(92, 35);
            this.salirBtn.TabIndex = 14;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // ProductosDataGridView
            // 
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView.Location = new System.Drawing.Point(12, 240);
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.Size = new System.Drawing.Size(715, 175);
            this.ProductosDataGridView.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 431);
            this.Controls.Add(this.ProductosDataGridView);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.nuevoBtn);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.existenciaTxt);
            this.Controls.Add(this.precioTxt);
            this.Controls.Add(this.descripcionTxt);
            this.Controls.Add(this.codigoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductoFrm";
            this.Text = "ProductoFrm";
            this.Load += new System.EventHandler(this.ProductoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigoTxt;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.TextBox precioTxt;
        private System.Windows.Forms.TextBox existenciaTxt;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Button nuevoBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.DataGridView ProductosDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}