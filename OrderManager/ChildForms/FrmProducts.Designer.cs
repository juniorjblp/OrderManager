
namespace OrderManager.ChildForms
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.GbCustomers = new System.Windows.Forms.GroupBox();
            this.DtProducts = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnNewProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbCategoria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GbCustomers
            // 
            this.GbCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbCustomers.Controls.Add(this.DtProducts);
            this.GbCustomers.ForeColor = System.Drawing.Color.DimGray;
            this.GbCustomers.Location = new System.Drawing.Point(25, 96);
            this.GbCustomers.Name = "GbCustomers";
            this.GbCustomers.Size = new System.Drawing.Size(1095, 572);
            this.GbCustomers.TabIndex = 34;
            this.GbCustomers.TabStop = false;
            this.GbCustomers.Text = "Clientes cadastrados";
            // 
            // DtProducts
            // 
            this.DtProducts.AllowUserToAddRows = false;
            this.DtProducts.AllowUserToOrderColumns = true;
            this.DtProducts.AutoGenerateColumns = false;
            this.DtProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Category,
            this.quantityDataGridViewTextBoxColumn1,
            this.valueDataGridViewTextBoxColumn1});
            this.DtProducts.DataSource = this.productBindingSource;
            this.DtProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtProducts.Location = new System.Drawing.Point(3, 16);
            this.DtProducts.Name = "DtProducts";
            this.DtProducts.Size = new System.Drawing.Size(1089, 553);
            this.DtProducts.TabIndex = 0;
            this.DtProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtProducts_CellEndEdit);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Data.Product);
            // 
            // BtnNewProduct
            // 
            this.BtnNewProduct.AllowAnimations = true;
            this.BtnNewProduct.AllowMouseEffects = true;
            this.BtnNewProduct.AllowToggling = false;
            this.BtnNewProduct.AnimationSpeed = 200;
            this.BtnNewProduct.AutoGenerateColors = false;
            this.BtnNewProduct.AutoRoundBorders = false;
            this.BtnNewProduct.AutoSizeLeftIcon = true;
            this.BtnNewProduct.AutoSizeRightIcon = true;
            this.BtnNewProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnNewProduct.BackColor1 = System.Drawing.Color.SeaGreen;
            this.BtnNewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewProduct.BackgroundImage")));
            this.BtnNewProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewProduct.ButtonText = "";
            this.BtnNewProduct.ButtonTextMarginLeft = 0;
            this.BtnNewProduct.ColorContrastOnClick = 45;
            this.BtnNewProduct.ColorContrastOnHover = 45;
            this.BtnNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnNewProduct.CustomizableEdges = borderEdges1;
            this.BtnNewProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnNewProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNewProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNewProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNewProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnNewProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNewProduct.ForeColor = System.Drawing.Color.White;
            this.BtnNewProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewProduct.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewProduct.IconLeftPadding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.BtnNewProduct.IconMarginLeft = 11;
            this.BtnNewProduct.IconPadding = 5;
            this.BtnNewProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewProduct.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnNewProduct.IconSize = 25;
            this.BtnNewProduct.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.BtnNewProduct.IdleBorderRadius = 10;
            this.BtnNewProduct.IdleBorderThickness = 1;
            this.BtnNewProduct.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.BtnNewProduct.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_adicionar_etiqueta_64;
            this.BtnNewProduct.IdleIconRightImage = null;
            this.BtnNewProduct.IndicateFocus = false;
            this.BtnNewProduct.Location = new System.Drawing.Point(15, 19);
            this.BtnNewProduct.Name = "BtnNewProduct";
            this.BtnNewProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNewProduct.OnDisabledState.BorderRadius = 10;
            this.BtnNewProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewProduct.OnDisabledState.BorderThickness = 1;
            this.BtnNewProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNewProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNewProduct.OnDisabledState.IconLeftImage = null;
            this.BtnNewProduct.OnDisabledState.IconRightImage = null;
            this.BtnNewProduct.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNewProduct.onHoverState.BorderRadius = 10;
            this.BtnNewProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewProduct.onHoverState.BorderThickness = 1;
            this.BtnNewProduct.onHoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNewProduct.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnNewProduct.onHoverState.IconLeftImage = null;
            this.BtnNewProduct.onHoverState.IconRightImage = null;
            this.BtnNewProduct.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnNewProduct.OnIdleState.BorderRadius = 10;
            this.BtnNewProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewProduct.OnIdleState.BorderThickness = 1;
            this.BtnNewProduct.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnNewProduct.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnNewProduct.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_adicionar_etiqueta_64;
            this.BtnNewProduct.OnIdleState.IconRightImage = null;
            this.BtnNewProduct.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.BtnNewProduct.OnPressedState.BorderRadius = 10;
            this.BtnNewProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewProduct.OnPressedState.BorderThickness = 1;
            this.BtnNewProduct.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.BtnNewProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnNewProduct.OnPressedState.IconLeftImage = null;
            this.BtnNewProduct.OnPressedState.IconRightImage = null;
            this.BtnNewProduct.Size = new System.Drawing.Size(55, 55);
            this.BtnNewProduct.TabIndex = 31;
            this.BtnNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNewProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnNewProduct.TextMarginLeft = 0;
            this.BtnNewProduct.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnNewProduct.UseDefaultRadiusAndThickness = true;
            this.BtnNewProduct.Click += new System.EventHandler(this.BtnNewProduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDeleteProduct);
            this.groupBox2.Location = new System.Drawing.Point(402, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 82);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluir produto";
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.AllowAnimations = true;
            this.BtnDeleteProduct.AllowMouseEffects = true;
            this.BtnDeleteProduct.AllowToggling = false;
            this.BtnDeleteProduct.AnimationSpeed = 200;
            this.BtnDeleteProduct.AutoGenerateColors = false;
            this.BtnDeleteProduct.AutoRoundBorders = false;
            this.BtnDeleteProduct.AutoSizeLeftIcon = true;
            this.BtnDeleteProduct.AutoSizeRightIcon = true;
            this.BtnDeleteProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteProduct.BackColor1 = System.Drawing.Color.SeaGreen;
            this.BtnDeleteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteProduct.BackgroundImage")));
            this.BtnDeleteProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteProduct.ButtonText = "";
            this.BtnDeleteProduct.ButtonTextMarginLeft = 0;
            this.BtnDeleteProduct.ColorContrastOnClick = 45;
            this.BtnDeleteProduct.ColorContrastOnHover = 45;
            this.BtnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnDeleteProduct.CustomizableEdges = borderEdges2;
            this.BtnDeleteProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDeleteProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDeleteProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDeleteProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDeleteProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteProduct.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteProduct.IconLeftPadding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.BtnDeleteProduct.IconMarginLeft = 11;
            this.BtnDeleteProduct.IconPadding = 5;
            this.BtnDeleteProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeleteProduct.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnDeleteProduct.IconSize = 25;
            this.BtnDeleteProduct.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteProduct.IdleBorderRadius = 10;
            this.BtnDeleteProduct.IdleBorderThickness = 1;
            this.BtnDeleteProduct.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteProduct.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_remover_tag_64;
            this.BtnDeleteProduct.IdleIconRightImage = null;
            this.BtnDeleteProduct.IndicateFocus = false;
            this.BtnDeleteProduct.Location = new System.Drawing.Point(19, 19);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDeleteProduct.OnDisabledState.BorderRadius = 10;
            this.BtnDeleteProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteProduct.OnDisabledState.BorderThickness = 1;
            this.BtnDeleteProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDeleteProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDeleteProduct.OnDisabledState.IconLeftImage = null;
            this.BtnDeleteProduct.OnDisabledState.IconRightImage = null;
            this.BtnDeleteProduct.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDeleteProduct.onHoverState.BorderRadius = 10;
            this.BtnDeleteProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteProduct.onHoverState.BorderThickness = 1;
            this.BtnDeleteProduct.onHoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDeleteProduct.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProduct.onHoverState.IconLeftImage = null;
            this.BtnDeleteProduct.onHoverState.IconRightImage = null;
            this.BtnDeleteProduct.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteProduct.OnIdleState.BorderRadius = 10;
            this.BtnDeleteProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteProduct.OnIdleState.BorderThickness = 1;
            this.BtnDeleteProduct.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteProduct.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProduct.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_remover_tag_64;
            this.BtnDeleteProduct.OnIdleState.IconRightImage = null;
            this.BtnDeleteProduct.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.BtnDeleteProduct.OnPressedState.BorderRadius = 10;
            this.BtnDeleteProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteProduct.OnPressedState.BorderThickness = 1;
            this.BtnDeleteProduct.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.BtnDeleteProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProduct.OnPressedState.IconLeftImage = null;
            this.BtnDeleteProduct.OnPressedState.IconRightImage = null;
            this.BtnDeleteProduct.Size = new System.Drawing.Size(55, 55);
            this.BtnDeleteProduct.TabIndex = 31;
            this.BtnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeleteProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDeleteProduct.TextMarginLeft = 0;
            this.BtnDeleteProduct.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnDeleteProduct.UseDefaultRadiusAndThickness = true;
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnNewProduct);
            this.groupBox1.Location = new System.Drawing.Point(28, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 82);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo produto";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmbCategoria.DataPropertyName = "Id";
            this.CmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbCategoria.HeaderText = "Categoria";
            this.CmbCategoria.Name = "CmbCategoria";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Data.Category);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Categoria";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn1
            // 
            this.valueDataGridViewTextBoxColumn1.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.valueDataGridViewTextBoxColumn1.Name = "valueDataGridViewTextBoxColumn1";
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 677);
            this.Controls.Add(this.GbCustomers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.GbCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbCustomers;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnNewProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnDeleteProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn CmbCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DtProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn1;
    }
}