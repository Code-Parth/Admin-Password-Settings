
namespace AdminPasswordSettings
{
    partial class Form1
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.RoundCorner = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Drag1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Drag2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Drag3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BtnMinimize = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.Admin_Password_Remove = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Admin_Password_Set = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Exit_Application = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TitleBar.SuspendLayout();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.AppName);
            this.TitleBar.Controls.Add(this.BtnMinimize);
            this.TitleBar.Controls.Add(this.BtnClose);
            this.TitleBar.Controls.Add(this.AppIcon);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(400, 30);
            this.TitleBar.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.Exit_Application);
            this.Settings.Controls.Add(this.Admin_Password_Set);
            this.Settings.Controls.Add(this.Admin_Password_Remove);
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.Location = new System.Drawing.Point(0, 30);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(400, 152);
            this.Settings.TabIndex = 1;
            // 
            // AppName
            // 
            this.AppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppName.Font = new System.Drawing.Font("Iniya Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Location = new System.Drawing.Point(30, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(310, 30);
            this.AppName.TabIndex = 3;
            this.AppName.Text = "Admin  Password  Settings";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoundCorner
            // 
            this.RoundCorner.ElipseRadius = 12;
            this.RoundCorner.TargetControl = this;
            // 
            // Drag1
            // 
            this.Drag1.Fixed = true;
            this.Drag1.Horizontal = true;
            this.Drag1.TargetControl = this.AppIcon;
            this.Drag1.Vertical = true;
            // 
            // Drag2
            // 
            this.Drag2.Fixed = true;
            this.Drag2.Horizontal = true;
            this.Drag2.TargetControl = this.AppName;
            this.Drag2.Vertical = true;
            // 
            // Drag3
            // 
            this.Drag3.Fixed = true;
            this.Drag3.Horizontal = true;
            this.Drag3.TargetControl = this.Settings;
            this.Drag3.Vertical = true;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.ErrorImage = null;
            this.BtnMinimize.Image = global::AdminPasswordSettings.Properties.Resources.BtnMinimize;
            this.BtnMinimize.InitialImage = null;
            this.BtnMinimize.Location = new System.Drawing.Point(340, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.TabStop = false;
            this.ToolTip.SetToolTip(this.BtnMinimize, "Minimize Window");
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.ErrorImage = null;
            this.BtnClose.Image = global::AdminPasswordSettings.Properties.Resources.BtnClose;
            this.BtnClose.InitialImage = null;
            this.BtnClose.Location = new System.Drawing.Point(370, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 1;
            this.BtnClose.TabStop = false;
            this.ToolTip.SetToolTip(this.BtnClose, "Close Window");
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AppIcon
            // 
            this.AppIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppIcon.ErrorImage = null;
            this.AppIcon.Image = global::AdminPasswordSettings.Properties.Resources.Admin;
            this.AppIcon.InitialImage = null;
            this.AppIcon.Location = new System.Drawing.Point(0, 0);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(30, 30);
            this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppIcon.TabIndex = 0;
            this.AppIcon.TabStop = false;
            this.ToolTip.SetToolTip(this.AppIcon, "Admin Password Settings");
            // 
            // Admin_Password_Remove
            // 
            this.Admin_Password_Remove.AllowAnimations = true;
            this.Admin_Password_Remove.AllowMouseEffects = true;
            this.Admin_Password_Remove.AllowToggling = false;
            this.Admin_Password_Remove.AnimationSpeed = 200;
            this.Admin_Password_Remove.AutoGenerateColors = false;
            this.Admin_Password_Remove.AutoRoundBorders = false;
            this.Admin_Password_Remove.AutoSizeLeftIcon = true;
            this.Admin_Password_Remove.AutoSizeRightIcon = true;
            this.Admin_Password_Remove.BackColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.BackColor1 = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Admin_Password_Remove.BackgroundImage")));
            this.Admin_Password_Remove.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Remove.ButtonText = "Admin Password Remove";
            this.Admin_Password_Remove.ButtonTextMarginLeft = 0;
            this.Admin_Password_Remove.ColorContrastOnClick = 45;
            this.Admin_Password_Remove.ColorContrastOnHover = 45;
            this.Admin_Password_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.Admin_Password_Remove.CustomizableEdges = borderEdges4;
            this.Admin_Password_Remove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Admin_Password_Remove.DisabledBorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Remove.DisabledFillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.DisabledForecolor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Admin_Password_Remove.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Admin_Password_Remove.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin_Password_Remove.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Admin_Password_Remove.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Admin_Password_Remove.IconMarginLeft = 11;
            this.Admin_Password_Remove.IconPadding = 10;
            this.Admin_Password_Remove.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Admin_Password_Remove.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Admin_Password_Remove.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Admin_Password_Remove.IconSize = 0;
            this.Admin_Password_Remove.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Remove.IdleBorderRadius = 35;
            this.Admin_Password_Remove.IdleBorderThickness = 2;
            this.Admin_Password_Remove.IdleFillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.IdleIconLeftImage = null;
            this.Admin_Password_Remove.IdleIconRightImage = null;
            this.Admin_Password_Remove.IndicateFocus = false;
            this.Admin_Password_Remove.Location = new System.Drawing.Point(10, 56);
            this.Admin_Password_Remove.Name = "Admin_Password_Remove";
            this.Admin_Password_Remove.OnDisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Remove.OnDisabledState.BorderRadius = 35;
            this.Admin_Password_Remove.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Remove.OnDisabledState.BorderThickness = 2;
            this.Admin_Password_Remove.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.OnDisabledState.IconLeftImage = null;
            this.Admin_Password_Remove.OnDisabledState.IconRightImage = null;
            this.Admin_Password_Remove.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Remove.onHoverState.BorderRadius = 35;
            this.Admin_Password_Remove.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Remove.onHoverState.BorderThickness = 2;
            this.Admin_Password_Remove.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.Admin_Password_Remove.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.onHoverState.IconLeftImage = null;
            this.Admin_Password_Remove.onHoverState.IconRightImage = null;
            this.Admin_Password_Remove.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Remove.OnIdleState.BorderRadius = 35;
            this.Admin_Password_Remove.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Remove.OnIdleState.BorderThickness = 2;
            this.Admin_Password_Remove.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.OnIdleState.IconLeftImage = null;
            this.Admin_Password_Remove.OnIdleState.IconRightImage = null;
            this.Admin_Password_Remove.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Remove.OnPressedState.BorderRadius = 35;
            this.Admin_Password_Remove.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Remove.OnPressedState.BorderThickness = 2;
            this.Admin_Password_Remove.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Remove.OnPressedState.IconLeftImage = null;
            this.Admin_Password_Remove.OnPressedState.IconRightImage = null;
            this.Admin_Password_Remove.Size = new System.Drawing.Size(380, 40);
            this.Admin_Password_Remove.TabIndex = 0;
            this.Admin_Password_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin_Password_Remove.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Admin_Password_Remove.TextMarginLeft = 0;
            this.Admin_Password_Remove.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.Admin_Password_Remove, "Admin Password Remove");
            this.Admin_Password_Remove.UseDefaultRadiusAndThickness = true;
            this.Admin_Password_Remove.Click += new System.EventHandler(this.Admin_Password_Remove_Click);
            // 
            // Admin_Password_Set
            // 
            this.Admin_Password_Set.AllowAnimations = true;
            this.Admin_Password_Set.AllowMouseEffects = true;
            this.Admin_Password_Set.AllowToggling = false;
            this.Admin_Password_Set.AnimationSpeed = 200;
            this.Admin_Password_Set.AutoGenerateColors = false;
            this.Admin_Password_Set.AutoRoundBorders = false;
            this.Admin_Password_Set.AutoSizeLeftIcon = true;
            this.Admin_Password_Set.AutoSizeRightIcon = true;
            this.Admin_Password_Set.BackColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.BackColor1 = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Admin_Password_Set.BackgroundImage")));
            this.Admin_Password_Set.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Set.ButtonText = "Admin Password Set";
            this.Admin_Password_Set.ButtonTextMarginLeft = 0;
            this.Admin_Password_Set.ColorContrastOnClick = 45;
            this.Admin_Password_Set.ColorContrastOnHover = 45;
            this.Admin_Password_Set.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.Admin_Password_Set.CustomizableEdges = borderEdges5;
            this.Admin_Password_Set.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Admin_Password_Set.DisabledBorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Set.DisabledFillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.DisabledForecolor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Admin_Password_Set.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Admin_Password_Set.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin_Password_Set.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Admin_Password_Set.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Admin_Password_Set.IconMarginLeft = 11;
            this.Admin_Password_Set.IconPadding = 10;
            this.Admin_Password_Set.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Admin_Password_Set.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Admin_Password_Set.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Admin_Password_Set.IconSize = 0;
            this.Admin_Password_Set.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Set.IdleBorderRadius = 35;
            this.Admin_Password_Set.IdleBorderThickness = 2;
            this.Admin_Password_Set.IdleFillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.IdleIconLeftImage = null;
            this.Admin_Password_Set.IdleIconRightImage = null;
            this.Admin_Password_Set.IndicateFocus = false;
            this.Admin_Password_Set.Location = new System.Drawing.Point(10, 10);
            this.Admin_Password_Set.Name = "Admin_Password_Set";
            this.Admin_Password_Set.OnDisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Set.OnDisabledState.BorderRadius = 35;
            this.Admin_Password_Set.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Set.OnDisabledState.BorderThickness = 2;
            this.Admin_Password_Set.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.OnDisabledState.IconLeftImage = null;
            this.Admin_Password_Set.OnDisabledState.IconRightImage = null;
            this.Admin_Password_Set.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Set.onHoverState.BorderRadius = 35;
            this.Admin_Password_Set.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Set.onHoverState.BorderThickness = 2;
            this.Admin_Password_Set.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.Admin_Password_Set.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.onHoverState.IconLeftImage = null;
            this.Admin_Password_Set.onHoverState.IconRightImage = null;
            this.Admin_Password_Set.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Set.OnIdleState.BorderRadius = 35;
            this.Admin_Password_Set.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Set.OnIdleState.BorderThickness = 2;
            this.Admin_Password_Set.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.OnIdleState.IconLeftImage = null;
            this.Admin_Password_Set.OnIdleState.IconRightImage = null;
            this.Admin_Password_Set.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Admin_Password_Set.OnPressedState.BorderRadius = 35;
            this.Admin_Password_Set.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Admin_Password_Set.OnPressedState.BorderThickness = 2;
            this.Admin_Password_Set.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.Admin_Password_Set.OnPressedState.IconLeftImage = null;
            this.Admin_Password_Set.OnPressedState.IconRightImage = null;
            this.Admin_Password_Set.Size = new System.Drawing.Size(380, 40);
            this.Admin_Password_Set.TabIndex = 0;
            this.Admin_Password_Set.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin_Password_Set.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Admin_Password_Set.TextMarginLeft = 0;
            this.Admin_Password_Set.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.Admin_Password_Set, "Admin Password Set");
            this.Admin_Password_Set.UseDefaultRadiusAndThickness = true;
            this.Admin_Password_Set.Click += new System.EventHandler(this.Admin_Password_Set_Click);
            // 
            // Exit_Application
            // 
            this.Exit_Application.AllowAnimations = true;
            this.Exit_Application.AllowMouseEffects = true;
            this.Exit_Application.AllowToggling = false;
            this.Exit_Application.AnimationSpeed = 200;
            this.Exit_Application.AutoGenerateColors = false;
            this.Exit_Application.AutoRoundBorders = false;
            this.Exit_Application.AutoSizeLeftIcon = true;
            this.Exit_Application.AutoSizeRightIcon = true;
            this.Exit_Application.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Application.BackColor1 = System.Drawing.Color.Transparent;
            this.Exit_Application.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_Application.BackgroundImage")));
            this.Exit_Application.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_Application.ButtonText = "Exit Application";
            this.Exit_Application.ButtonTextMarginLeft = 0;
            this.Exit_Application.ColorContrastOnClick = 45;
            this.Exit_Application.ColorContrastOnHover = 45;
            this.Exit_Application.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.Exit_Application.CustomizableEdges = borderEdges6;
            this.Exit_Application.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit_Application.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.Exit_Application.DisabledFillColor = System.Drawing.Color.Transparent;
            this.Exit_Application.DisabledForecolor = System.Drawing.Color.Transparent;
            this.Exit_Application.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Exit_Application.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Exit_Application.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_Application.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_Application.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Exit_Application.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Exit_Application.IconMarginLeft = 11;
            this.Exit_Application.IconPadding = 10;
            this.Exit_Application.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_Application.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Exit_Application.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Exit_Application.IconSize = 0;
            this.Exit_Application.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.Exit_Application.IdleBorderRadius = 35;
            this.Exit_Application.IdleBorderThickness = 2;
            this.Exit_Application.IdleFillColor = System.Drawing.Color.Transparent;
            this.Exit_Application.IdleIconLeftImage = null;
            this.Exit_Application.IdleIconRightImage = null;
            this.Exit_Application.IndicateFocus = false;
            this.Exit_Application.Location = new System.Drawing.Point(10, 102);
            this.Exit_Application.Name = "Exit_Application";
            this.Exit_Application.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.Exit_Application.OnDisabledState.BorderRadius = 35;
            this.Exit_Application.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_Application.OnDisabledState.BorderThickness = 2;
            this.Exit_Application.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.Exit_Application.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_Application.OnDisabledState.IconLeftImage = null;
            this.Exit_Application.OnDisabledState.IconRightImage = null;
            this.Exit_Application.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.Exit_Application.onHoverState.BorderRadius = 35;
            this.Exit_Application.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_Application.onHoverState.BorderThickness = 2;
            this.Exit_Application.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.Exit_Application.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_Application.onHoverState.IconLeftImage = null;
            this.Exit_Application.onHoverState.IconRightImage = null;
            this.Exit_Application.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.Exit_Application.OnIdleState.BorderRadius = 35;
            this.Exit_Application.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_Application.OnIdleState.BorderThickness = 2;
            this.Exit_Application.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Exit_Application.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_Application.OnIdleState.IconLeftImage = null;
            this.Exit_Application.OnIdleState.IconRightImage = null;
            this.Exit_Application.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.Exit_Application.OnPressedState.BorderRadius = 35;
            this.Exit_Application.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_Application.OnPressedState.BorderThickness = 2;
            this.Exit_Application.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Exit_Application.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_Application.OnPressedState.IconLeftImage = null;
            this.Exit_Application.OnPressedState.IconRightImage = null;
            this.Exit_Application.Size = new System.Drawing.Size(380, 40);
            this.Exit_Application.TabIndex = 0;
            this.Exit_Application.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_Application.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exit_Application.TextMarginLeft = 0;
            this.Exit_Application.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.Exit_Application, "Exit Application");
            this.Exit_Application.UseDefaultRadiusAndThickness = true;
            this.Exit_Application.Click += new System.EventHandler(this.Exit_Application_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(400, 182);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addmin  Password  Settings";
            this.TitleBar.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox BtnMinimize;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.PictureBox AppIcon;
        private System.Windows.Forms.Panel Settings;
        private Bunifu.Framework.UI.BunifuElipse RoundCorner;
        private Bunifu.Framework.UI.BunifuDragControl Drag1;
        private Bunifu.Framework.UI.BunifuDragControl Drag2;
        private Bunifu.Framework.UI.BunifuDragControl Drag3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Admin_Password_Remove;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Exit_Application;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Admin_Password_Set;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

