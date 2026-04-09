namespace BurgerKiosk
{
    partial class BurgerKiosk
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurgerKiosk));
            lblTitle = new Label();
            rdoHam = new RadioButton();
            rdoBulgogi = new RadioButton();
            rdoChicken = new RadioButton();
            picHam = new PictureBox();
            grpMenu = new GroupBox();
            rdoNone = new RadioButton();
            picChicken = new PictureBox();
            picBulgogi = new PictureBox();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkFries = new CheckBox();
            grpOrder = new GroupBox();
            lblTotal = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)picHam).BeginInit();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogi).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(60, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(677, 86);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거　주문　키오스크";
            // 
            // rdoHam
            // 
            rdoHam.AutoSize = true;
            rdoHam.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoHam.ForeColor = Color.Black;
            rdoHam.Location = new Point(15, 70);
            rdoHam.Name = "rdoHam";
            rdoHam.Size = new Size(164, 54);
            rdoHam.TabIndex = 1;
            rdoHam.TabStop = true;
            rdoHam.Text = "햄버거";
            rdoHam.UseVisualStyleBackColor = true;
            rdoHam.CheckedChanged += SelectionChanged;
            // 
            // rdoBulgogi
            // 
            rdoBulgogi.AutoSize = true;
            rdoBulgogi.Font = new Font("맑은 고딕", 12F);
            rdoBulgogi.ForeColor = Color.Black;
            rdoBulgogi.Location = new Point(0, 214);
            rdoBulgogi.Name = "rdoBulgogi";
            rdoBulgogi.Size = new Size(211, 49);
            rdoBulgogi.TabIndex = 2;
            rdoBulgogi.TabStop = true;
            rdoBulgogi.Text = "불고기버거";
            rdoBulgogi.UseVisualStyleBackColor = true;
            rdoBulgogi.CheckedChanged += SelectionChanged;
            // 
            // rdoChicken
            // 
            rdoChicken.AutoSize = true;
            rdoChicken.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoChicken.ForeColor = Color.Black;
            rdoChicken.Location = new Point(0, 385);
            rdoChicken.Name = "rdoChicken";
            rdoChicken.Size = new Size(201, 54);
            rdoChicken.TabIndex = 3;
            rdoChicken.TabStop = true;
            rdoChicken.Text = "치킨버거";
            rdoChicken.UseVisualStyleBackColor = true;
            rdoChicken.CheckedChanged += SelectionChanged;
            // 
            // picHam
            // 
            picHam.Image = (Image)resources.GetObject("picHam.Image");
            picHam.Location = new Point(222, 38);
            picHam.Name = "picHam";
            picHam.Size = new Size(184, 152);
            picHam.SizeMode = PictureBoxSizeMode.StretchImage;
            picHam.TabIndex = 4;
            picHam.TabStop = false;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(rdoNone);
            grpMenu.Controls.Add(picChicken);
            grpMenu.Controls.Add(picBulgogi);
            grpMenu.Controls.Add(rdoHam);
            grpMenu.Controls.Add(rdoBulgogi);
            grpMenu.Controls.Add(rdoChicken);
            grpMenu.Controls.Add(picHam);
            grpMenu.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.DarkRed;
            grpMenu.Location = new Point(28, 146);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(441, 596);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴선택";
            grpMenu.Enter += grpMenu_Enter;
            // 
            // rdoNone
            // 
            rdoNone.AutoSize = true;
            rdoNone.Location = new Point(-182, 503);
            rdoNone.Name = "rdoNone";
            rdoNone.Size = new Size(27, 26);
            rdoNone.TabIndex = 7;
            rdoNone.TabStop = true;
            rdoNone.UseVisualStyleBackColor = true;
            // 
            // picChicken
            // 
            picChicken.Image = (Image)resources.GetObject("picChicken.Image");
            picChicken.Location = new Point(222, 385);
            picChicken.Name = "picChicken";
            picChicken.Size = new Size(184, 152);
            picChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            picChicken.TabIndex = 6;
            picChicken.TabStop = false;
            // 
            // picBulgogi
            // 
            picBulgogi.Image = (Image)resources.GetObject("picBulgogi.Image");
            picBulgogi.Location = new Point(222, 214);
            picBulgogi.Name = "picBulgogi";
            picBulgogi.Size = new Size(184, 152);
            picBulgogi.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogi.TabIndex = 5;
            picBulgogi.TabStop = false;
            picBulgogi.UseWaitCursor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkFries);
            grpOption.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.DarkRed;
            grpOption.Location = new Point(503, 159);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(293, 396);
            grpOption.TabIndex = 2;
            grpOption.TabStop = false;
            grpOption.Text = "추가옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 13.875F);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(16, 327);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(215, 54);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += SelectionChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 13.875F);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(16, 251);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(215, 54);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += SelectionChanged;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 13.875F);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(16, 180);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(128, 54);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += SelectionChanged;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.Font = new Font("맑은 고딕", 13.875F);
            chkFries.ForeColor = Color.Black;
            chkFries.Location = new Point(16, 106);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(202, 54);
            chkFries.TabIndex = 0;
            chkFries.Text = "감자튀김";
            chkFries.UseVisualStyleBackColor = true;
            chkFries.CheckedChanged += SelectionChanged;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotal);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.DarkRed;
            grpOrder.Location = new Point(819, 159);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(691, 401);
            grpOrder.TabIndex = 5;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문내역";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(26, 323);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(260, 59);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "총 금액: 0원";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(26, 81);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(538, 229);
            lstOrder.TabIndex = 0;
            lstOrder.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(0, 192, 0);
            btnOrder.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(897, 629);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(220, 89);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Chocolate;
            btnReset.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(1160, 629);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(223, 89);
            btnReset.TabIndex = 4;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // BurgerKiosk
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 771);
            Controls.Add(grpOption);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpMenu);
            Controls.Add(lblTitle);
            Name = "BurgerKiosk";
            Text = "BurgerKiosk";
            Load += BurgerKiosk_Load;
            ((System.ComponentModel.ISupportInitialize)picHam).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogi).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RadioButton rdoHam;
        private RadioButton rdoBulgogi;
        private RadioButton rdoChicken;
        private PictureBox picHam;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private CheckBox chkCola;
        private CheckBox chkFries;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private GroupBox grpOrder;
        private Label lblTotal;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnReset;
        private PictureBox picChicken;
        private PictureBox picBulgogi;
        private RadioButton rdoNone;
    }
}
