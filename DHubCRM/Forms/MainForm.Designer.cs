namespace DHubCRM
{
    partial class MainForm
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
            BunifuAnimatorNS.Animation animation25 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BunifuAnimatorNS.Animation animation27 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation28 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation26 = new BunifuAnimatorNS.Animation();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Logo2Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Panel4Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.Support = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Accounting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CRM = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sidemenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation25.AnimateOnlyDifferences = true;
            animation25.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation25.BlindCoeff")));
            animation25.LeafCoeff = 0F;
            animation25.MaxTime = 1F;
            animation25.MinTime = 0F;
            animation25.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation25.MosaicCoeff")));
            animation25.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation25.MosaicShift")));
            animation25.MosaicSize = 0;
            animation25.Padding = new System.Windows.Forms.Padding(30);
            animation25.RotateCoeff = 0.5F;
            animation25.RotateLimit = 0.2F;
            animation25.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation25.ScaleCoeff")));
            animation25.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation25.SlideCoeff")));
            animation25.TimeCoeff = 0F;
            animation25.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation25;
            this.LogoAnimator.MaxAnimationTime = 1000;
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidemenu.Controls.Add(this.Support);
            this.sidemenu.Controls.Add(this.Accounting);
            this.sidemenu.Controls.Add(this.CRM);
            this.sidemenu.Controls.Add(this.btnMenu);
            this.sidemenu.Controls.Add(this.logo);
            this.Panel4Animator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 32);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(50, 599);
            this.sidemenu.TabIndex = 3;
            this.sidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.richTextBox1);
            this.Panel4Animator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(50, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 599);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.logo2);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.Panel4Animator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 32);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation27.AnimateOnlyDifferences = true;
            animation27.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation27.BlindCoeff")));
            animation27.LeafCoeff = 0F;
            animation27.MaxTime = 1F;
            animation27.MinTime = 0F;
            animation27.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation27.MosaicCoeff")));
            animation27.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation27.MosaicShift")));
            animation27.MosaicSize = 1;
            animation27.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation27.RotateCoeff = 0F;
            animation27.RotateLimit = 0F;
            animation27.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation27.ScaleCoeff")));
            animation27.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation27.SlideCoeff")));
            animation27.TimeCoeff = 2F;
            animation27.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation27;
            this.PanelAnimator.MaxAnimationTime = 3000;
            this.PanelAnimator.TimeStep = 0.4F;
            // 
            // Logo2Animator
            // 
            this.Logo2Animator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Logo2Animator.Cursor = null;
            animation28.AnimateOnlyDifferences = true;
            animation28.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation28.BlindCoeff")));
            animation28.LeafCoeff = 0F;
            animation28.MaxTime = 1F;
            animation28.MinTime = 0F;
            animation28.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation28.MosaicCoeff")));
            animation28.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation28.MosaicShift")));
            animation28.MosaicSize = 0;
            animation28.Padding = new System.Windows.Forms.Padding(0);
            animation28.RotateCoeff = 0F;
            animation28.RotateLimit = 0F;
            animation28.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation28.ScaleCoeff")));
            animation28.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation28.SlideCoeff")));
            animation28.TimeCoeff = 0F;
            animation28.TransparencyCoeff = 0F;
            this.Logo2Animator.DefaultAnimation = animation28;
            this.Logo2Animator.MaxAnimationTime = 2000;
            this.Logo2Animator.TimeStep = 0.04F;
            // 
            // Panel4Animator
            // 
            this.Panel4Animator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.Panel4Animator.Cursor = null;
            animation26.AnimateOnlyDifferences = true;
            animation26.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation26.BlindCoeff")));
            animation26.LeafCoeff = 0F;
            animation26.MaxTime = 1F;
            animation26.MinTime = 0F;
            animation26.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation26.MosaicCoeff")));
            animation26.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation26.MosaicShift")));
            animation26.MosaicSize = 0;
            animation26.Padding = new System.Windows.Forms.Padding(30);
            animation26.RotateCoeff = 0.5F;
            animation26.RotateLimit = 0.2F;
            animation26.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation26.ScaleCoeff")));
            animation26.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation26.SlideCoeff")));
            animation26.TimeCoeff = 0F;
            animation26.TransparencyCoeff = 0F;
            this.Panel4Animator.DefaultAnimation = animation26;
            this.Panel4Animator.MaxAnimationTime = 1000;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // Support
            // 
            this.Support.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Support.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Support.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Support.BorderRadius = 0;
            this.Support.ButtonText = "         Support ";
            this.Support.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel4Animator.SetDecoration(this.Support, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Support, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Support, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.Support, BunifuAnimatorNS.DecorationType.None);
            this.Support.DisabledColor = System.Drawing.Color.Gray;
            this.Support.Iconcolor = System.Drawing.Color.Transparent;
            this.Support.Iconimage = global::DHubCRM.Properties.Resources.f089e33d_2bdf_48d7_8053_2d48f281a66b;
            this.Support.Iconimage_right = null;
            this.Support.Iconimage_right_Selected = null;
            this.Support.Iconimage_Selected = null;
            this.Support.IconMarginLeft = 0;
            this.Support.IconMarginRight = 0;
            this.Support.IconRightVisible = true;
            this.Support.IconRightZoom = 0D;
            this.Support.IconVisible = true;
            this.Support.IconZoom = 90D;
            this.Support.IsTab = true;
            this.Support.Location = new System.Drawing.Point(0, 240);
            this.Support.Name = "Support";
            this.Support.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Support.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Support.OnHoverTextColor = System.Drawing.Color.White;
            this.Support.selected = false;
            this.Support.Size = new System.Drawing.Size(260, 48);
            this.Support.TabIndex = 6;
            this.Support.Text = "         Support ";
            this.Support.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Support.Textcolor = System.Drawing.Color.White;
            this.Support.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Support.Click += new System.EventHandler(this.Support_Click);
            // 
            // Accounting
            // 
            this.Accounting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Accounting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Accounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Accounting.BorderRadius = 0;
            this.Accounting.ButtonText = "         Accounting";
            this.Accounting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel4Animator.SetDecoration(this.Accounting, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Accounting, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Accounting, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.Accounting, BunifuAnimatorNS.DecorationType.None);
            this.Accounting.DisabledColor = System.Drawing.Color.Gray;
            this.Accounting.Iconcolor = System.Drawing.Color.Transparent;
            this.Accounting.Iconimage = global::DHubCRM.Properties.Resources.c65ef334_b5ac_4430_be5d_f5ba2c91a733;
            this.Accounting.Iconimage_right = null;
            this.Accounting.Iconimage_right_Selected = null;
            this.Accounting.Iconimage_Selected = null;
            this.Accounting.IconMarginLeft = 0;
            this.Accounting.IconMarginRight = 0;
            this.Accounting.IconRightVisible = true;
            this.Accounting.IconRightZoom = 0D;
            this.Accounting.IconVisible = true;
            this.Accounting.IconZoom = 90D;
            this.Accounting.IsTab = true;
            this.Accounting.Location = new System.Drawing.Point(0, 186);
            this.Accounting.Name = "Accounting";
            this.Accounting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Accounting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Accounting.OnHoverTextColor = System.Drawing.Color.White;
            this.Accounting.selected = false;
            this.Accounting.Size = new System.Drawing.Size(260, 48);
            this.Accounting.TabIndex = 5;
            this.Accounting.Text = "         Accounting";
            this.Accounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accounting.Textcolor = System.Drawing.Color.White;
            this.Accounting.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounting.Click += new System.EventHandler(this.Accounting_Click);
            // 
            // CRM
            // 
            this.CRM.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CRM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CRM.BorderRadius = 0;
            this.CRM.ButtonText = "         CRM";
            this.CRM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel4Animator.SetDecoration(this.CRM, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.CRM, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.CRM, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.CRM, BunifuAnimatorNS.DecorationType.None);
            this.CRM.DisabledColor = System.Drawing.Color.Gray;
            this.CRM.Iconcolor = System.Drawing.Color.Transparent;
            this.CRM.Iconimage = global::DHubCRM.Properties.Resources.dc41c199_afe8_4655_99cf_b4fa74dabde9;
            this.CRM.Iconimage_right = null;
            this.CRM.Iconimage_right_Selected = null;
            this.CRM.Iconimage_Selected = null;
            this.CRM.IconMarginLeft = 0;
            this.CRM.IconMarginRight = 0;
            this.CRM.IconRightVisible = true;
            this.CRM.IconRightZoom = 0D;
            this.CRM.IconVisible = true;
            this.CRM.IconZoom = 90D;
            this.CRM.IsTab = true;
            this.CRM.Location = new System.Drawing.Point(0, 132);
            this.CRM.Name = "CRM";
            this.CRM.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CRM.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CRM.OnHoverTextColor = System.Drawing.Color.White;
            this.CRM.selected = false;
            this.CRM.Size = new System.Drawing.Size(260, 48);
            this.CRM.TabIndex = 4;
            this.CRM.Text = "         CRM";
            this.CRM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CRM.Textcolor = System.Drawing.Color.White;
            this.CRM.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRM.Click += new System.EventHandler(this.CRM_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.Panel4Animator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::DHubCRM.Properties.Resources.threelines;
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(9, 29);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 30);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // logo
            // 
            this.Logo2Animator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.Panel4Animator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = global::DHubCRM.Properties.Resources._3426c95e_93d2_4aa7_b301_0c9b7cef9523;
            this.logo.Location = new System.Drawing.Point(-52, -29);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(296, 146);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // logo2
            // 
            this.Logo2Animator.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.Panel4Animator.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.logo2.Image = global::DHubCRM.Properties.Resources._04f70de7_3ff5_4caf_9710_9b13ac320480;
            this.logo2.Location = new System.Drawing.Point(0, 3);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(166, 28);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo2.TabIndex = 6;
            this.logo2.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.Panel4Animator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::DHubCRM.Properties.Resources.x_close_icon_white;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(879, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.Panel4Animator.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Panel4Animator.SetDecoration(this.richTextBox1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.richTextBox1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.richTextBox1, BunifuAnimatorNS.DecorationType.None);
            this.Logo2Animator.SetDecoration(this.richTextBox1, BunifuAnimatorNS.DecorationType.None);
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(43, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(732, 380);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel2);
            this.Logo2Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Panel4Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidemenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuFlatButton CRM;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton Accounting;
        private Bunifu.Framework.UI.BunifuFlatButton Support;
        private System.Windows.Forms.PictureBox logo2;
        private BunifuAnimatorNS.BunifuTransition Logo2Animator;
        private BunifuAnimatorNS.BunifuTransition Panel4Animator;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

