
namespace OrderManager.ChildForms
{
    partial class FrmNewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewProduct));
            this.GbproductInfo = new System.Windows.Forms.GroupBox();
            this.BtnNewCategory = new Bunifu.UI.WinForms.BunifuImageButton();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtProdValor = new System.Windows.Forms.TextBox();
            this.TxtProdQuant = new System.Windows.Forms.TextBox();
            this.TxtProdNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GbproductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbproductInfo
            // 
            this.GbproductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbproductInfo.Controls.Add(this.BtnNewCategory);
            this.GbproductInfo.Controls.Add(this.CmbCategory);
            this.GbproductInfo.Controls.Add(this.label4);
            this.GbproductInfo.Controls.Add(this.label3);
            this.GbproductInfo.Controls.Add(this.label2);
            this.GbproductInfo.Controls.Add(this.label1);
            this.GbproductInfo.Controls.Add(this.BtnCancelar);
            this.GbproductInfo.Controls.Add(this.BtnSalvar);
            this.GbproductInfo.Controls.Add(this.TxtProdValor);
            this.GbproductInfo.Controls.Add(this.TxtProdQuant);
            this.GbproductInfo.Controls.Add(this.TxtProdNome);
            this.GbproductInfo.Controls.Add(this.label5);
            this.GbproductInfo.ForeColor = System.Drawing.Color.DimGray;
            this.GbproductInfo.Location = new System.Drawing.Point(11, 12);
            this.GbproductInfo.Name = "GbproductInfo";
            this.GbproductInfo.Size = new System.Drawing.Size(740, 312);
            this.GbproductInfo.TabIndex = 3;
            this.GbproductInfo.TabStop = false;
            this.GbproductInfo.Text = "Novo Produto";
            // 
            // BtnNewCategory
            // 
            this.BtnNewCategory.ActiveImage = null;
            this.BtnNewCategory.AllowAnimations = true;
            this.BtnNewCategory.AllowBuffering = false;
            this.BtnNewCategory.AllowToggling = false;
            this.BtnNewCategory.AllowZooming = true;
            this.BtnNewCategory.AllowZoomingOnFocus = false;
            this.BtnNewCategory.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNewCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnNewCategory.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnNewCategory.ErrorImage")));
            this.BtnNewCategory.FadeWhenInactive = false;
            this.BtnNewCategory.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnNewCategory.Image = global::OrderManager.Properties.Resources.icons8_adicionar_etiqueta_64;
            this.BtnNewCategory.ImageActive = null;
            this.BtnNewCategory.ImageLocation = null;
            this.BtnNewCategory.ImageMargin = 5;
            this.BtnNewCategory.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnNewCategory.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.BtnNewCategory.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnNewCategory.InitialImage")));
            this.BtnNewCategory.Location = new System.Drawing.Point(306, 126);
            this.BtnNewCategory.Name = "BtnNewCategory";
            this.BtnNewCategory.Rotation = 0;
            this.BtnNewCategory.ShowActiveImage = true;
            this.BtnNewCategory.ShowCursorChanges = true;
            this.BtnNewCategory.ShowImageBorders = true;
            this.BtnNewCategory.ShowSizeMarkers = false;
            this.BtnNewCategory.Size = new System.Drawing.Size(30, 30);
            this.BtnNewCategory.TabIndex = 17;
            this.BtnNewCategory.ToolTipText = "";
            this.BtnNewCategory.WaitOnLoad = false;
            this.BtnNewCategory.Zoom = 5;
            this.BtnNewCategory.ZoomSpeed = 10;
            this.BtnNewCategory.Click += new System.EventHandler(this.BtnNewCategory_Click);
            // 
            // CmbCategory
            // 
            this.CmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategory.ForeColor = System.Drawing.Color.DimGray;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(9, 128);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(291, 26);
            this.CmbCategory.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(204, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do produto";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(577, 258);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(145, 39);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Fechar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(426, 258);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(145, 39);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtProdValor
            // 
            this.TxtProdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProdValor.ForeColor = System.Drawing.Color.DimGray;
            this.TxtProdValor.Location = new System.Drawing.Point(207, 196);
            this.TxtProdValor.Name = "TxtProdValor";
            this.TxtProdValor.Size = new System.Drawing.Size(93, 24);
            this.TxtProdValor.TabIndex = 3;
            // 
            // TxtProdQuant
            // 
            this.TxtProdQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProdQuant.ForeColor = System.Drawing.Color.DimGray;
            this.TxtProdQuant.Location = new System.Drawing.Point(6, 196);
            this.TxtProdQuant.Name = "TxtProdQuant";
            this.TxtProdQuant.Size = new System.Drawing.Size(93, 24);
            this.TxtProdQuant.TabIndex = 2;
            // 
            // TxtProdNome
            // 
            this.TxtProdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProdNome.ForeColor = System.Drawing.Color.DimGray;
            this.TxtProdNome.Location = new System.Drawing.Point(6, 62);
            this.TxtProdNome.Name = "TxtProdNome";
            this.TxtProdNome.Size = new System.Drawing.Size(294, 24);
            this.TxtProdNome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "R$";
            // 
            // FrmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 345);
            this.Controls.Add(this.GbproductInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditProduct";
            this.Load += new System.EventHandler(this.FrmEditProduct_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmEditProduct_MouseDown);
            this.GbproductInfo.ResumeLayout(false);
            this.GbproductInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbproductInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        public System.Windows.Forms.ComboBox CmbCategory;
        public System.Windows.Forms.TextBox TxtProdValor;
        public System.Windows.Forms.TextBox TxtProdQuant;
        public System.Windows.Forms.TextBox TxtProdNome;
        public System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuImageButton BtnNewCategory;
    }
}