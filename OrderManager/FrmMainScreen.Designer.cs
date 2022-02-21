
namespace OrderManager
{
    partial class FrmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainScreen));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.BtnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PanlBotton = new System.Windows.Forms.Panel();
            this.PnlMenuLeft = new System.Windows.Forms.Panel();
            this.PBIndicator = new System.Windows.Forms.PictureBox();
            this.BtnOrders = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnProducts = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnCustomers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Separator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.PnlHeader.SuspendLayout();
            this.PanlBotton.SuspendLayout();
            this.PnlMenuLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIndicator)).BeginInit();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.ActiveImage = null;
            this.BtnClose.AllowAnimations = true;
            this.BtnClose.AllowBuffering = false;
            this.BtnClose.AllowToggling = false;
            this.BtnClose.AllowZooming = true;
            this.BtnClose.AllowZoomingOnFocus = false;
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.ErrorImage")));
            this.BtnClose.FadeWhenInactive = false;
            this.BtnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnClose.Image = global::OrderManager.Properties.Resources.icons8_fechar_janela_64;
            this.BtnClose.ImageActive = null;
            this.BtnClose.ImageLocation = null;
            this.BtnClose.ImageMargin = -5;
            this.BtnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnClose.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.BtnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.InitialImage")));
            this.BtnClose.Location = new System.Drawing.Point(1208, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0;
            this.BtnClose.ShowActiveImage = true;
            this.BtnClose.ShowCursorChanges = true;
            this.BtnClose.ShowImageBorders = true;
            this.BtnClose.ShowSizeMarkers = false;
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.ToolTipText = "";
            this.BtnClose.WaitOnLoad = false;
            this.BtnClose.Zoom = -5;
            this.BtnClose.ZoomSpeed = 10;
            this.BtnClose.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PnlHeader.Controls.Add(this.BtnClose);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1236, 28);
            this.PnlHeader.TabIndex = 1;
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // PanlBotton
            // 
            this.PanlBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanlBotton.Controls.Add(this.LblName);
            this.PanlBotton.Controls.Add(this.label1);
            this.PanlBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanlBotton.Location = new System.Drawing.Point(0, 701);
            this.PanlBotton.Name = "PanlBotton";
            this.PanlBotton.Size = new System.Drawing.Size(1236, 20);
            this.PanlBotton.TabIndex = 2;
            // 
            // PnlMenuLeft
            // 
            this.PnlMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.PnlMenuLeft.Controls.Add(this.PBIndicator);
            this.PnlMenuLeft.Controls.Add(this.BtnOrders);
            this.PnlMenuLeft.Controls.Add(this.BtnProducts);
            this.PnlMenuLeft.Controls.Add(this.BtnCustomers);
            this.PnlMenuLeft.Controls.Add(this.BtnDashboard);
            this.PnlMenuLeft.Controls.Add(this.BtnLogout);
            this.PnlMenuLeft.Controls.Add(this.Separator);
            this.PnlMenuLeft.Controls.Add(this.PnlLogo);
            this.PnlMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuLeft.Location = new System.Drawing.Point(0, 28);
            this.PnlMenuLeft.Name = "PnlMenuLeft";
            this.PnlMenuLeft.Size = new System.Drawing.Size(200, 673);
            this.PnlMenuLeft.TabIndex = 3;
            // 
            // PBIndicator
            // 
            this.PBIndicator.BackColor = System.Drawing.Color.SeaGreen;
            this.PBIndicator.Location = new System.Drawing.Point(1, 114);
            this.PBIndicator.Name = "PBIndicator";
            this.PBIndicator.Size = new System.Drawing.Size(5, 40);
            this.PBIndicator.TabIndex = 14;
            this.PBIndicator.TabStop = false;
            // 
            // BtnOrders
            // 
            this.BtnOrders.AllowAnimations = true;
            this.BtnOrders.AllowMouseEffects = true;
            this.BtnOrders.AllowToggling = false;
            this.BtnOrders.AnimationSpeed = 200;
            this.BtnOrders.AutoGenerateColors = false;
            this.BtnOrders.AutoRoundBorders = false;
            this.BtnOrders.AutoSizeLeftIcon = true;
            this.BtnOrders.AutoSizeRightIcon = true;
            this.BtnOrders.BackColor = System.Drawing.Color.Transparent;
            this.BtnOrders.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOrders.BackgroundImage")));
            this.BtnOrders.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnOrders.ButtonText = "Vendas";
            this.BtnOrders.ButtonTextMarginLeft = 0;
            this.BtnOrders.ColorContrastOnClick = 45;
            this.BtnOrders.ColorContrastOnHover = 45;
            this.BtnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.BtnOrders.CustomizableEdges = borderEdges6;
            this.BtnOrders.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnOrders.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnOrders.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnOrders.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOrders.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrders.ForeColor = System.Drawing.Color.White;
            this.BtnOrders.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrders.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrders.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.BtnOrders.IconMarginLeft = 11;
            this.BtnOrders.IconPadding = 5;
            this.BtnOrders.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOrders.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrders.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnOrders.IconSize = 25;
            this.BtnOrders.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnOrders.IdleBorderRadius = 1;
            this.BtnOrders.IdleBorderThickness = 1;
            this.BtnOrders.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnOrders.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_caixa_registradora_50;
            this.BtnOrders.IdleIconRightImage = null;
            this.BtnOrders.IndicateFocus = false;
            this.BtnOrders.Location = new System.Drawing.Point(0, 234);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnOrders.OnDisabledState.BorderRadius = 1;
            this.BtnOrders.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnOrders.OnDisabledState.BorderThickness = 1;
            this.BtnOrders.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnOrders.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnOrders.OnDisabledState.IconLeftImage = null;
            this.BtnOrders.OnDisabledState.IconRightImage = null;
            this.BtnOrders.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnOrders.onHoverState.BorderRadius = 1;
            this.BtnOrders.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnOrders.onHoverState.BorderThickness = 1;
            this.BtnOrders.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnOrders.onHoverState.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnOrders.onHoverState.IconLeftImage = null;
            this.BtnOrders.onHoverState.IconRightImage = null;
            this.BtnOrders.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnOrders.OnIdleState.BorderRadius = 1;
            this.BtnOrders.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnOrders.OnIdleState.BorderThickness = 1;
            this.BtnOrders.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnOrders.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnOrders.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_caixa_registradora_50;
            this.BtnOrders.OnIdleState.IconRightImage = null;
            this.BtnOrders.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnOrders.OnPressedState.BorderRadius = 1;
            this.BtnOrders.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnOrders.OnPressedState.BorderThickness = 1;
            this.BtnOrders.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnOrders.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnOrders.OnPressedState.IconLeftImage = null;
            this.BtnOrders.OnPressedState.IconRightImage = null;
            this.BtnOrders.Size = new System.Drawing.Size(200, 40);
            this.BtnOrders.TabIndex = 16;
            this.BtnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrders.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnOrders.TextMarginLeft = 0;
            this.BtnOrders.TextPadding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnOrders.UseDefaultRadiusAndThickness = true;
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.AllowAnimations = true;
            this.BtnProducts.AllowMouseEffects = true;
            this.BtnProducts.AllowToggling = false;
            this.BtnProducts.AnimationSpeed = 200;
            this.BtnProducts.AutoGenerateColors = false;
            this.BtnProducts.AutoRoundBorders = false;
            this.BtnProducts.AutoSizeLeftIcon = true;
            this.BtnProducts.AutoSizeRightIcon = true;
            this.BtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.BtnProducts.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProducts.BackgroundImage")));
            this.BtnProducts.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnProducts.ButtonText = "Produtos";
            this.BtnProducts.ButtonTextMarginLeft = 0;
            this.BtnProducts.ColorContrastOnClick = 45;
            this.BtnProducts.ColorContrastOnHover = 45;
            this.BtnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.BtnProducts.CustomizableEdges = borderEdges7;
            this.BtnProducts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnProducts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnProducts.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnProducts.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProducts.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducts.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProducts.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.BtnProducts.IconMarginLeft = 11;
            this.BtnProducts.IconPadding = 5;
            this.BtnProducts.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProducts.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProducts.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnProducts.IconSize = 25;
            this.BtnProducts.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnProducts.IdleBorderRadius = 1;
            this.BtnProducts.IdleBorderThickness = 1;
            this.BtnProducts.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnProducts.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_etiqueta_de_preço_50;
            this.BtnProducts.IdleIconRightImage = null;
            this.BtnProducts.IndicateFocus = false;
            this.BtnProducts.Location = new System.Drawing.Point(0, 194);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnProducts.OnDisabledState.BorderRadius = 1;
            this.BtnProducts.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnProducts.OnDisabledState.BorderThickness = 1;
            this.BtnProducts.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnProducts.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnProducts.OnDisabledState.IconLeftImage = null;
            this.BtnProducts.OnDisabledState.IconRightImage = null;
            this.BtnProducts.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnProducts.onHoverState.BorderRadius = 1;
            this.BtnProducts.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnProducts.onHoverState.BorderThickness = 1;
            this.BtnProducts.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnProducts.onHoverState.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnProducts.onHoverState.IconLeftImage = null;
            this.BtnProducts.onHoverState.IconRightImage = null;
            this.BtnProducts.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnProducts.OnIdleState.BorderRadius = 1;
            this.BtnProducts.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnProducts.OnIdleState.BorderThickness = 1;
            this.BtnProducts.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnProducts.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_etiqueta_de_preço_50;
            this.BtnProducts.OnIdleState.IconRightImage = null;
            this.BtnProducts.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnProducts.OnPressedState.BorderRadius = 1;
            this.BtnProducts.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnProducts.OnPressedState.BorderThickness = 1;
            this.BtnProducts.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnProducts.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.OnPressedState.IconLeftImage = null;
            this.BtnProducts.OnPressedState.IconRightImage = null;
            this.BtnProducts.Size = new System.Drawing.Size(200, 40);
            this.BtnProducts.TabIndex = 15;
            this.BtnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducts.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnProducts.TextMarginLeft = 0;
            this.BtnProducts.TextPadding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnProducts.UseDefaultRadiusAndThickness = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.AllowAnimations = true;
            this.BtnCustomers.AllowMouseEffects = true;
            this.BtnCustomers.AllowToggling = false;
            this.BtnCustomers.AnimationSpeed = 200;
            this.BtnCustomers.AutoGenerateColors = false;
            this.BtnCustomers.AutoRoundBorders = false;
            this.BtnCustomers.AutoSizeLeftIcon = true;
            this.BtnCustomers.AutoSizeRightIcon = true;
            this.BtnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.BtnCustomers.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCustomers.BackgroundImage")));
            this.BtnCustomers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCustomers.ButtonText = "Clientes";
            this.BtnCustomers.ButtonTextMarginLeft = 0;
            this.BtnCustomers.ColorContrastOnClick = 45;
            this.BtnCustomers.ColorContrastOnHover = 45;
            this.BtnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.BtnCustomers.CustomizableEdges = borderEdges8;
            this.BtnCustomers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCustomers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCustomers.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCustomers.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustomers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.ForeColor = System.Drawing.Color.White;
            this.BtnCustomers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomers.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomers.IconLeftPadding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.BtnCustomers.IconMarginLeft = 11;
            this.BtnCustomers.IconPadding = 5;
            this.BtnCustomers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCustomers.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomers.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnCustomers.IconSize = 25;
            this.BtnCustomers.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnCustomers.IdleBorderRadius = 1;
            this.BtnCustomers.IdleBorderThickness = 1;
            this.BtnCustomers.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnCustomers.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_empresa_cliente_50;
            this.BtnCustomers.IdleIconRightImage = null;
            this.BtnCustomers.IndicateFocus = false;
            this.BtnCustomers.Location = new System.Drawing.Point(0, 154);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCustomers.OnDisabledState.BorderRadius = 1;
            this.BtnCustomers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCustomers.OnDisabledState.BorderThickness = 1;
            this.BtnCustomers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCustomers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnCustomers.OnDisabledState.IconLeftImage = null;
            this.BtnCustomers.OnDisabledState.IconRightImage = null;
            this.BtnCustomers.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnCustomers.onHoverState.BorderRadius = 1;
            this.BtnCustomers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCustomers.onHoverState.BorderThickness = 1;
            this.BtnCustomers.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnCustomers.onHoverState.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnCustomers.onHoverState.IconLeftImage = null;
            this.BtnCustomers.onHoverState.IconRightImage = null;
            this.BtnCustomers.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnCustomers.OnIdleState.BorderRadius = 1;
            this.BtnCustomers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCustomers.OnIdleState.BorderThickness = 1;
            this.BtnCustomers.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnCustomers.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnCustomers.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_empresa_cliente_50;
            this.BtnCustomers.OnIdleState.IconRightImage = null;
            this.BtnCustomers.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnCustomers.OnPressedState.BorderRadius = 1;
            this.BtnCustomers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCustomers.OnPressedState.BorderThickness = 1;
            this.BtnCustomers.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnCustomers.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnCustomers.OnPressedState.IconLeftImage = null;
            this.BtnCustomers.OnPressedState.IconRightImage = null;
            this.BtnCustomers.Size = new System.Drawing.Size(200, 40);
            this.BtnCustomers.TabIndex = 2;
            this.BtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCustomers.TextMarginLeft = 0;
            this.BtnCustomers.TextPadding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnCustomers.UseDefaultRadiusAndThickness = true;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.AllowAnimations = true;
            this.BtnDashboard.AllowMouseEffects = true;
            this.BtnDashboard.AllowToggling = false;
            this.BtnDashboard.AnimationSpeed = 200;
            this.BtnDashboard.AutoGenerateColors = false;
            this.BtnDashboard.AutoRoundBorders = false;
            this.BtnDashboard.AutoSizeLeftIcon = true;
            this.BtnDashboard.AutoSizeRightIcon = true;
            this.BtnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.BtnDashboard.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.BackgroundImage")));
            this.BtnDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDashboard.ButtonText = "Dashboard";
            this.BtnDashboard.ButtonTextMarginLeft = 0;
            this.BtnDashboard.ColorContrastOnClick = 45;
            this.BtnDashboard.ColorContrastOnHover = 45;
            this.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.BtnDashboard.CustomizableEdges = borderEdges9;
            this.BtnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDashboard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDashboard.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDashboard.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.IconLeftPadding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.BtnDashboard.IconMarginLeft = 11;
            this.BtnDashboard.IconPadding = 5;
            this.BtnDashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDashboard.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnDashboard.IconSize = 25;
            this.BtnDashboard.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnDashboard.IdleBorderRadius = 1;
            this.BtnDashboard.IdleBorderThickness = 1;
            this.BtnDashboard.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnDashboard.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_dados_de_saúde_50;
            this.BtnDashboard.IdleIconRightImage = null;
            this.BtnDashboard.IndicateFocus = false;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 114);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDashboard.OnDisabledState.BorderRadius = 1;
            this.BtnDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDashboard.OnDisabledState.BorderThickness = 1;
            this.BtnDashboard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDashboard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDashboard.OnDisabledState.IconLeftImage = null;
            this.BtnDashboard.OnDisabledState.IconRightImage = null;
            this.BtnDashboard.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnDashboard.onHoverState.BorderRadius = 1;
            this.BtnDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDashboard.onHoverState.BorderThickness = 1;
            this.BtnDashboard.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnDashboard.onHoverState.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDashboard.onHoverState.IconLeftImage = null;
            this.BtnDashboard.onHoverState.IconRightImage = null;
            this.BtnDashboard.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnDashboard.OnIdleState.BorderRadius = 1;
            this.BtnDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDashboard.OnIdleState.BorderThickness = 1;
            this.BtnDashboard.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnDashboard.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_dados_de_saúde_50;
            this.BtnDashboard.OnIdleState.IconRightImage = null;
            this.BtnDashboard.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnDashboard.OnPressedState.BorderRadius = 1;
            this.BtnDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDashboard.OnPressedState.BorderThickness = 1;
            this.BtnDashboard.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnDashboard.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.OnPressedState.IconLeftImage = null;
            this.BtnDashboard.OnPressedState.IconRightImage = null;
            this.BtnDashboard.Size = new System.Drawing.Size(200, 40);
            this.BtnDashboard.TabIndex = 18;
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDashboard.TextMarginLeft = 0;
            this.BtnDashboard.TextPadding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnDashboard.UseDefaultRadiusAndThickness = true;
            this.BtnDashboard.Load += new System.EventHandler(this.BtnDashboard_Load);
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.AllowAnimations = true;
            this.BtnLogout.AllowMouseEffects = true;
            this.BtnLogout.AllowToggling = false;
            this.BtnLogout.AnimationSpeed = 200;
            this.BtnLogout.AutoGenerateColors = false;
            this.BtnLogout.AutoRoundBorders = false;
            this.BtnLogout.AutoSizeLeftIcon = true;
            this.BtnLogout.AutoSizeRightIcon = true;
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogout.BackgroundImage")));
            this.BtnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLogout.ButtonText = "Sair";
            this.BtnLogout.ButtonTextMarginLeft = 0;
            this.BtnLogout.ColorContrastOnClick = 45;
            this.BtnLogout.ColorContrastOnHover = 45;
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.BtnLogout.CustomizableEdges = borderEdges10;
            this.BtnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnLogout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnLogout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.BtnLogout.IconMarginLeft = 11;
            this.BtnLogout.IconPadding = 5;
            this.BtnLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogout.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnLogout.IconSize = 25;
            this.BtnLogout.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnLogout.IdleBorderRadius = 1;
            this.BtnLogout.IdleBorderThickness = 1;
            this.BtnLogout.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnLogout.IdleIconLeftImage = global::OrderManager.Properties.Resources.icons8_logout_arredondado_50;
            this.BtnLogout.IdleIconRightImage = null;
            this.BtnLogout.IndicateFocus = false;
            this.BtnLogout.Location = new System.Drawing.Point(0, 633);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnLogout.OnDisabledState.BorderRadius = 1;
            this.BtnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLogout.OnDisabledState.BorderThickness = 1;
            this.BtnLogout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnLogout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnLogout.OnDisabledState.IconLeftImage = null;
            this.BtnLogout.OnDisabledState.IconRightImage = null;
            this.BtnLogout.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnLogout.onHoverState.BorderRadius = 1;
            this.BtnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLogout.onHoverState.BorderThickness = 1;
            this.BtnLogout.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnLogout.onHoverState.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnLogout.onHoverState.IconLeftImage = null;
            this.BtnLogout.onHoverState.IconRightImage = null;
            this.BtnLogout.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnLogout.OnIdleState.BorderRadius = 1;
            this.BtnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLogout.OnIdleState.BorderThickness = 1;
            this.BtnLogout.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnLogout.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.OnIdleState.IconLeftImage = global::OrderManager.Properties.Resources.icons8_logout_arredondado_50;
            this.BtnLogout.OnIdleState.IconRightImage = null;
            this.BtnLogout.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnLogout.OnPressedState.BorderRadius = 1;
            this.BtnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLogout.OnPressedState.BorderThickness = 1;
            this.BtnLogout.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.BtnLogout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.OnPressedState.IconLeftImage = null;
            this.BtnLogout.OnPressedState.IconRightImage = null;
            this.BtnLogout.Size = new System.Drawing.Size(200, 40);
            this.BtnLogout.TabIndex = 17;
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnLogout.TextMarginLeft = 0;
            this.BtnLogout.TextPadding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnLogout.UseDefaultRadiusAndThickness = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Separator.BackgroundImage")));
            this.Separator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Separator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separator.LineColor = System.Drawing.Color.DimGray;
            this.Separator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.Separator.LineThickness = 1;
            this.Separator.Location = new System.Drawing.Point(0, 100);
            this.Separator.Name = "Separator";
            this.Separator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator.Size = new System.Drawing.Size(200, 14);
            this.Separator.TabIndex = 1;
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.SeaGreen;
            this.PnlLogo.Controls.Add(this.PbLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(200, 100);
            this.PnlLogo.TabIndex = 0;
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbLogo.Image = global::OrderManager.Properties.Resources.channels4_profile_removebg_preview;
            this.PbLogo.Location = new System.Drawing.Point(0, 0);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(200, 100);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // PnlContent
            // 
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(200, 28);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(1036, 673);
            this.PnlContent.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(1180, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "V: 0.0.1";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.DarkGray;
            this.LblName.Location = new System.Drawing.Point(923, 3);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(52, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "V: 0.0.1";
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 721);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlMenuLeft);
            this.Controls.Add(this.PanlBotton);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainScreen";
            this.PnlHeader.ResumeLayout(false);
            this.PanlBotton.ResumeLayout(false);
            this.PanlBotton.PerformLayout();
            this.PnlMenuLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBIndicator)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton BtnClose;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PanlBotton;
        private System.Windows.Forms.Panel PnlMenuLeft;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnCustomers;
        private Bunifu.UI.WinForms.BunifuSeparator Separator;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.PictureBox PBIndicator;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnOrders;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnProducts;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnLogout;
        private System.Windows.Forms.Panel PnlContent;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnDashboard;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label1;
    }
}