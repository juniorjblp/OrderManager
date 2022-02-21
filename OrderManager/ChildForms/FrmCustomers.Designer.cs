
namespace OrderManager.ChildForms
{
    partial class FrmCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.GbCustomers = new System.Windows.Forms.GroupBox();
            this.DtCustomers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnNewCustomer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteCustomer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.GbCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbCustomers
            // 
            this.GbCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbCustomers.Controls.Add(this.DtCustomers);
            this.GbCustomers.ForeColor = System.Drawing.Color.DimGray;
            this.GbCustomers.Location = new System.Drawing.Point(12, 100);
            this.GbCustomers.Name = "GbCustomers";
            this.GbCustomers.Size = new System.Drawing.Size(1095, 572);
            this.GbCustomers.TabIndex = 2;
            this.GbCustomers.TabStop = false;
            this.GbCustomers.Text = "Clientes cadastrados";
            // 
            // DtCustomers
            // 
            this.DtCustomers.AllowUserToOrderColumns = true;
            this.DtCustomers.AutoGenerateColumns = false;
            this.DtCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DtCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.CpfDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DtCustomers.DataSource = this.customerBindingSource;
            this.DtCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtCustomers.Location = new System.Drawing.Point(3, 16);
            this.DtCustomers.Name = "DtCustomers";
            this.DtCustomers.Size = new System.Drawing.Size(1089, 553);
            this.DtCustomers.TabIndex = 30;
            this.DtCustomers.TabStop = false;
            this.DtCustomers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtCustomers_CellEndEdit);
            this.DtCustomers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtCustomers_CellFormatting);
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
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Sobrenome";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // CpfDataGridViewTextBoxColumn
            // 
            this.CpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.CpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.CpfDataGridViewTextBoxColumn.Name = "CpfDataGridViewTextBoxColumn";
            this.CpfDataGridViewTextBoxColumn.ToolTipText = "CPF";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Data de nascimento";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Data.Customer);
            // 
            // BtnNewCustomer
            // 
            this.BtnNewCustomer.AllowAnimations = true;
            this.BtnNewCustomer.AllowMouseEffects = true;
            this.BtnNewCustomer.AllowToggling = false;
            this.BtnNewCustomer.AnimationSpeed = 200;
            this.BtnNewCustomer.AutoGenerateColors = false;
            this.BtnNewCustomer.AutoRoundBorders = false;
            this.BtnNewCustomer.AutoSizeLeftIcon = true;
            this.BtnNewCustomer.AutoSizeRightIcon = true;
            this.BtnNewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.BtnNewCustomer.BackColor1 = System.Drawing.Color.SeaGreen;
            this.BtnNewCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewCustomer.BackgroundImage")));
            this.BtnNewCustomer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewCustomer.ButtonText = "";
            this.BtnNewCustomer.ButtonTextMarginLeft = 0;
            this.BtnNewCustomer.ColorContrastOnClick = 45;
            this.BtnNewCustomer.ColorContrastOnHover = 45;
            this.BtnNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnNewCustomer.CustomizableEdges = borderEdges1;
            this.BtnNewCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnNewCustomer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNewCustomer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNewCustomer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNewCustomer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNewCustomer.ForeColor = System.Drawing.Color.White;
            this.BtnNewCustomer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewCustomer.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewCustomer.IconLeftPadding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.BtnNewCustomer.IconMarginLeft = 11;
            this.BtnNewCustomer.IconPadding = 5;
            this.BtnNewCustomer.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewCustomer.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewCustomer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnNewCustomer.IconSize = 25;
            this.BtnNewCustomer.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.BtnNewCustomer.IdleBorderRadius = 10;
            this.BtnNewCustomer.IdleBorderThickness = 1;
            this.BtnNewCustomer.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.BtnNewCustomer.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_adicionar_usuário_masculino_50;
            this.BtnNewCustomer.IdleIconRightImage = null;
            this.BtnNewCustomer.IndicateFocus = false;
            this.BtnNewCustomer.Location = new System.Drawing.Point(15, 19);
            this.BtnNewCustomer.Name = "BtnNewCustomer";
            this.BtnNewCustomer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNewCustomer.OnDisabledState.BorderRadius = 10;
            this.BtnNewCustomer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewCustomer.OnDisabledState.BorderThickness = 1;
            this.BtnNewCustomer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNewCustomer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNewCustomer.OnDisabledState.IconLeftImage = null;
            this.BtnNewCustomer.OnDisabledState.IconRightImage = null;
            this.BtnNewCustomer.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNewCustomer.onHoverState.BorderRadius = 10;
            this.BtnNewCustomer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewCustomer.onHoverState.BorderThickness = 1;
            this.BtnNewCustomer.onHoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNewCustomer.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnNewCustomer.onHoverState.IconLeftImage = null;
            this.BtnNewCustomer.onHoverState.IconRightImage = null;
            this.BtnNewCustomer.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnNewCustomer.OnIdleState.BorderRadius = 10;
            this.BtnNewCustomer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewCustomer.OnIdleState.BorderThickness = 1;
            this.BtnNewCustomer.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnNewCustomer.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnNewCustomer.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_adicionar_usuário_masculino_50;
            this.BtnNewCustomer.OnIdleState.IconRightImage = null;
            this.BtnNewCustomer.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.BtnNewCustomer.OnPressedState.BorderRadius = 10;
            this.BtnNewCustomer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNewCustomer.OnPressedState.BorderThickness = 1;
            this.BtnNewCustomer.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.BtnNewCustomer.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnNewCustomer.OnPressedState.IconLeftImage = null;
            this.BtnNewCustomer.OnPressedState.IconRightImage = null;
            this.BtnNewCustomer.Size = new System.Drawing.Size(55, 55);
            this.BtnNewCustomer.TabIndex = 31;
            this.BtnNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNewCustomer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnNewCustomer.TextMarginLeft = 0;
            this.BtnNewCustomer.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnNewCustomer.UseDefaultRadiusAndThickness = true;
            this.BtnNewCustomer.Click += new System.EventHandler(this.BtnNewCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnNewCustomer);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 82);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDeleteCustomer);
            this.groupBox2.Location = new System.Drawing.Point(389, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 82);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluir cliente";
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.AllowAnimations = true;
            this.BtnDeleteCustomer.AllowMouseEffects = true;
            this.BtnDeleteCustomer.AllowToggling = false;
            this.BtnDeleteCustomer.AnimationSpeed = 200;
            this.BtnDeleteCustomer.AutoGenerateColors = false;
            this.BtnDeleteCustomer.AutoRoundBorders = false;
            this.BtnDeleteCustomer.AutoSizeLeftIcon = true;
            this.BtnDeleteCustomer.AutoSizeRightIcon = true;
            this.BtnDeleteCustomer.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteCustomer.BackColor1 = System.Drawing.Color.SeaGreen;
            this.BtnDeleteCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteCustomer.BackgroundImage")));
            this.BtnDeleteCustomer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteCustomer.ButtonText = "";
            this.BtnDeleteCustomer.ButtonTextMarginLeft = 0;
            this.BtnDeleteCustomer.ColorContrastOnClick = 45;
            this.BtnDeleteCustomer.ColorContrastOnHover = 45;
            this.BtnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnDeleteCustomer.CustomizableEdges = borderEdges2;
            this.BtnDeleteCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDeleteCustomer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDeleteCustomer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDeleteCustomer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDeleteCustomer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteCustomer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteCustomer.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteCustomer.IconLeftPadding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.BtnDeleteCustomer.IconMarginLeft = 11;
            this.BtnDeleteCustomer.IconPadding = 5;
            this.BtnDeleteCustomer.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeleteCustomer.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteCustomer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnDeleteCustomer.IconSize = 25;
            this.BtnDeleteCustomer.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteCustomer.IdleBorderRadius = 10;
            this.BtnDeleteCustomer.IdleBorderThickness = 1;
            this.BtnDeleteCustomer.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteCustomer.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_remover_usuário_masculino_64;
            this.BtnDeleteCustomer.IdleIconRightImage = null;
            this.BtnDeleteCustomer.IndicateFocus = false;
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(15, 19);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDeleteCustomer.OnDisabledState.BorderRadius = 10;
            this.BtnDeleteCustomer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteCustomer.OnDisabledState.BorderThickness = 1;
            this.BtnDeleteCustomer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDeleteCustomer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDeleteCustomer.OnDisabledState.IconLeftImage = null;
            this.BtnDeleteCustomer.OnDisabledState.IconRightImage = null;
            this.BtnDeleteCustomer.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDeleteCustomer.onHoverState.BorderRadius = 10;
            this.BtnDeleteCustomer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteCustomer.onHoverState.BorderThickness = 1;
            this.BtnDeleteCustomer.onHoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDeleteCustomer.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteCustomer.onHoverState.IconLeftImage = null;
            this.BtnDeleteCustomer.onHoverState.IconRightImage = null;
            this.BtnDeleteCustomer.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteCustomer.OnIdleState.BorderRadius = 10;
            this.BtnDeleteCustomer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteCustomer.OnIdleState.BorderThickness = 1;
            this.BtnDeleteCustomer.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteCustomer.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteCustomer.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_remover_usuário_masculino_64;
            this.BtnDeleteCustomer.OnIdleState.IconRightImage = null;
            this.BtnDeleteCustomer.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.BtnDeleteCustomer.OnPressedState.BorderRadius = 10;
            this.BtnDeleteCustomer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteCustomer.OnPressedState.BorderThickness = 1;
            this.BtnDeleteCustomer.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.BtnDeleteCustomer.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteCustomer.OnPressedState.IconLeftImage = null;
            this.BtnDeleteCustomer.OnPressedState.IconRightImage = null;
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(55, 55);
            this.BtnDeleteCustomer.TabIndex = 31;
            this.BtnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeleteCustomer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDeleteCustomer.TextMarginLeft = 0;
            this.BtnDeleteCustomer.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnDeleteCustomer.UseDefaultRadiusAndThickness = true;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 684);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.GbCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbCustomers;
        private System.Windows.Forms.DataGridView DtCustomers;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnNewCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnDeleteCustomer;
    }
}