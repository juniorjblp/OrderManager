
namespace OrderManager.ChildForms
{
    partial class FrmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrders));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.GbOrders = new System.Windows.Forms.GroupBox();
            this.DtOrders = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteOrders = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNewOrder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.GbOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbOrders
            // 
            this.GbOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbOrders.Controls.Add(this.DtOrders);
            this.GbOrders.ForeColor = System.Drawing.Color.DimGray;
            this.GbOrders.Location = new System.Drawing.Point(12, 102);
            this.GbOrders.Name = "GbOrders";
            this.GbOrders.Size = new System.Drawing.Size(1099, 544);
            this.GbOrders.TabIndex = 4;
            this.GbOrders.TabStop = false;
            this.GbOrders.Text = "Vendas cadastradas";
            // 
            // DtOrders
            // 
            this.DtOrders.AllowUserToAddRows = false;
            this.DtOrders.AllowUserToOrderColumns = true;
            this.DtOrders.AutoGenerateColumns = false;
            this.DtOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.customerCpfDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.DtOrders.DataSource = this.orderBindingSource;
            this.DtOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtOrders.Location = new System.Drawing.Point(3, 16);
            this.DtOrders.Name = "DtOrders";
            this.DtOrders.ReadOnly = true;
            this.DtOrders.Size = new System.Drawing.Size(1093, 525);
            this.DtOrders.TabIndex = 0;
            this.DtOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtOrders_CellDoubleClick);
            this.DtOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtOrders_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Id do comprador";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Nome do comprador";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerCpfDataGridViewTextBoxColumn
            // 
            this.customerCpfDataGridViewTextBoxColumn.DataPropertyName = "CustomerCpf";
            this.customerCpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.customerCpfDataGridViewTextBoxColumn.Name = "customerCpfDataGridViewTextBoxColumn";
            this.customerCpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Data da venda";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Data.Order);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDeleteOrders);
            this.groupBox2.Location = new System.Drawing.Point(389, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 82);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluir venda";
            // 
            // BtnDeleteOrders
            // 
            this.BtnDeleteOrders.AllowAnimations = true;
            this.BtnDeleteOrders.AllowMouseEffects = true;
            this.BtnDeleteOrders.AllowToggling = false;
            this.BtnDeleteOrders.AnimationSpeed = 200;
            this.BtnDeleteOrders.AutoGenerateColors = false;
            this.BtnDeleteOrders.AutoRoundBorders = false;
            this.BtnDeleteOrders.AutoSizeLeftIcon = true;
            this.BtnDeleteOrders.AutoSizeRightIcon = true;
            this.BtnDeleteOrders.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteOrders.BackColor1 = System.Drawing.Color.SeaGreen;
            this.BtnDeleteOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteOrders.BackgroundImage")));
            this.BtnDeleteOrders.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteOrders.ButtonText = "";
            this.BtnDeleteOrders.ButtonTextMarginLeft = 0;
            this.BtnDeleteOrders.ColorContrastOnClick = 45;
            this.BtnDeleteOrders.ColorContrastOnHover = 45;
            this.BtnDeleteOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.BtnDeleteOrders.CustomizableEdges = borderEdges3;
            this.BtnDeleteOrders.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDeleteOrders.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDeleteOrders.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDeleteOrders.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDeleteOrders.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnDeleteOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteOrders.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteOrders.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteOrders.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteOrders.IconLeftPadding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.BtnDeleteOrders.IconMarginLeft = 11;
            this.BtnDeleteOrders.IconPadding = 5;
            this.BtnDeleteOrders.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeleteOrders.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteOrders.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnDeleteOrders.IconSize = 25;
            this.BtnDeleteOrders.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteOrders.IdleBorderRadius = 10;
            this.BtnDeleteOrders.IdleBorderThickness = 1;
            this.BtnDeleteOrders.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteOrders.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_remover_tag_64;
            this.BtnDeleteOrders.IdleIconRightImage = null;
            this.BtnDeleteOrders.IndicateFocus = false;
            this.BtnDeleteOrders.Location = new System.Drawing.Point(19, 19);
            this.BtnDeleteOrders.Name = "BtnDeleteOrders";
            this.BtnDeleteOrders.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDeleteOrders.OnDisabledState.BorderRadius = 10;
            this.BtnDeleteOrders.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteOrders.OnDisabledState.BorderThickness = 1;
            this.BtnDeleteOrders.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDeleteOrders.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDeleteOrders.OnDisabledState.IconLeftImage = null;
            this.BtnDeleteOrders.OnDisabledState.IconRightImage = null;
            this.BtnDeleteOrders.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDeleteOrders.onHoverState.BorderRadius = 10;
            this.BtnDeleteOrders.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteOrders.onHoverState.BorderThickness = 1;
            this.BtnDeleteOrders.onHoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDeleteOrders.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteOrders.onHoverState.IconLeftImage = null;
            this.BtnDeleteOrders.onHoverState.IconRightImage = null;
            this.BtnDeleteOrders.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteOrders.OnIdleState.BorderRadius = 10;
            this.BtnDeleteOrders.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteOrders.OnIdleState.BorderThickness = 1;
            this.BtnDeleteOrders.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteOrders.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteOrders.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_remover_tag_64;
            this.BtnDeleteOrders.OnIdleState.IconRightImage = null;
            this.BtnDeleteOrders.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.BtnDeleteOrders.OnPressedState.BorderRadius = 10;
            this.BtnDeleteOrders.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteOrders.OnPressedState.BorderThickness = 1;
            this.BtnDeleteOrders.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.BtnDeleteOrders.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteOrders.OnPressedState.IconLeftImage = null;
            this.BtnDeleteOrders.OnPressedState.IconRightImage = null;
            this.BtnDeleteOrders.Size = new System.Drawing.Size(55, 55);
            this.BtnDeleteOrders.TabIndex = 31;
            this.BtnDeleteOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeleteOrders.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDeleteOrders.TextMarginLeft = 0;
            this.BtnDeleteOrders.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnDeleteOrders.UseDefaultRadiusAndThickness = true;
            this.BtnDeleteOrders.Click += new System.EventHandler(this.BtnDeleteOrders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnNewOrder);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 82);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova venda";
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.AllowAnimations = true;
            this.BtnNewOrder.AllowMouseEffects = true;
            this.BtnNewOrder.AllowToggling = false;
            this.BtnNewOrder.AnimationSpeed = 200;
            this.BtnNewOrder.AutoGenerateColors = false;
            this.BtnNewOrder.AutoRoundBorders = false;
            this.BtnNewOrder.AutoSizeLeftIcon = true;
            this.BtnNewOrder.AutoSizeRightIcon = true;
            this.BtnNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.BtnNewOrder.BackColor1 = System.Drawing.Color.SeaGreen;
            this.BtnNewOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewOrder.BackgroundImage")));
            this.BtnNewOrder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewOrder.ButtonText = "";
            this.BtnNewOrder.ButtonTextMarginLeft = 0;
            this.BtnNewOrder.ColorContrastOnClick = 45;
            this.BtnNewOrder.ColorContrastOnHover = 45;
            this.BtnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.BtnNewOrder.CustomizableEdges = borderEdges4;
            this.BtnNewOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnNewOrder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNewOrder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNewOrder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNewOrder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnNewOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNewOrder.ForeColor = System.Drawing.Color.White;
            this.BtnNewOrder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewOrder.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewOrder.IconLeftPadding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.BtnNewOrder.IconMarginLeft = 11;
            this.BtnNewOrder.IconPadding = 5;
            this.BtnNewOrder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewOrder.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewOrder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnNewOrder.IconSize = 25;
            this.BtnNewOrder.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.BtnNewOrder.IdleBorderRadius = 10;
            this.BtnNewOrder.IdleBorderThickness = 1;
            this.BtnNewOrder.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.BtnNewOrder.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_adicionar_etiqueta_64;
            this.BtnNewOrder.IdleIconRightImage = null;
            this.BtnNewOrder.IndicateFocus = false;
            this.BtnNewOrder.Location = new System.Drawing.Point(15, 19);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNewOrder.OnDisabledState.BorderRadius = 10;
            this.BtnNewOrder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewOrder.OnDisabledState.BorderThickness = 1;
            this.BtnNewOrder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNewOrder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNewOrder.OnDisabledState.IconLeftImage = null;
            this.BtnNewOrder.OnDisabledState.IconRightImage = null;
            this.BtnNewOrder.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNewOrder.onHoverState.BorderRadius = 10;
            this.BtnNewOrder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewOrder.onHoverState.BorderThickness = 1;
            this.BtnNewOrder.onHoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNewOrder.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnNewOrder.onHoverState.IconLeftImage = null;
            this.BtnNewOrder.onHoverState.IconRightImage = null;
            this.BtnNewOrder.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnNewOrder.OnIdleState.BorderRadius = 10;
            this.BtnNewOrder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewOrder.OnIdleState.BorderThickness = 1;
            this.BtnNewOrder.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnNewOrder.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnNewOrder.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_adicionar_etiqueta_64;
            this.BtnNewOrder.OnIdleState.IconRightImage = null;
            this.BtnNewOrder.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.BtnNewOrder.OnPressedState.BorderRadius = 10;
            this.BtnNewOrder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewOrder.OnPressedState.BorderThickness = 1;
            this.BtnNewOrder.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.BtnNewOrder.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnNewOrder.OnPressedState.IconLeftImage = null;
            this.BtnNewOrder.OnPressedState.IconRightImage = null;
            this.BtnNewOrder.Size = new System.Drawing.Size(55, 55);
            this.BtnNewOrder.TabIndex = 31;
            this.BtnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNewOrder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnNewOrder.TextMarginLeft = 0;
            this.BtnNewOrder.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnNewOrder.UseDefaultRadiusAndThickness = true;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            this.GbOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbOrders;
        private System.Windows.Forms.DataGridView DtOrders;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnDeleteOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnNewOrder;
    }
}