namespace BurgerKiosk
{
    partial class Form1
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
            lblTitle = new Label();
            rdoHam = new RadioButton();
            rdoBulgogi = new RadioButton();
            rdoChicken = new RadioButton();
            picHam = new PictureBox();
            grpMenu = new GroupBox();
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
            rdoHam.Location = new Point(6, 64);
            rdoHam.Name = "rdoHam";
            rdoHam.Size = new Size(147, 49);
            rdoHam.TabIndex = 1;
            rdoHam.TabStop = true;
            rdoHam.Text = "햄버거";
            rdoHam.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogi
            // 
            rdoBulgogi.AutoSize = true;
            rdoBulgogi.Location = new Point(0, 214);
            rdoBulgogi.Name = "rdoBulgogi";
            rdoBulgogi.Size = new Size(211, 49);
            rdoBulgogi.TabIndex = 2;
            rdoBulgogi.TabStop = true;
            rdoBulgogi.Text = "불고기버거";
            rdoBulgogi.UseVisualStyleBackColor = true;
            // 
            // rdoChicken
            // 
            rdoChicken.AutoSize = true;
            rdoChicken.Location = new Point(0, 385);
            rdoChicken.Name = "rdoChicken";
            rdoChicken.Size = new Size(179, 49);
            rdoChicken.TabIndex = 3;
            rdoChicken.TabStop = true;
            rdoChicken.Text = "치킨버거";
            rdoChicken.UseVisualStyleBackColor = true;
            // 
            // picHam
            // 
            picHam.Location = new Point(206, 38);
            picHam.Name = "picHam";
            picHam.Size = new Size(200, 152);
            picHam.TabIndex = 4;
            picHam.TabStop = false;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picChicken);
            grpMenu.Controls.Add(picBulgogi);
            grpMenu.Controls.Add(rdoHam);
            grpMenu.Controls.Add(rdoBulgogi);
            grpMenu.Controls.Add(rdoChicken);
            grpMenu.Controls.Add(picHam);
            grpMenu.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpMenu.Location = new Point(28, 159);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(441, 583);
            grpMenu.TabIndex = 11;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴선택";
            // 
            // picChicken
            // 
            picChicken.Location = new Point(206, 385);
            picChicken.Name = "picChicken";
            picChicken.Size = new Size(200, 152);
            picChicken.TabIndex = 6;
            picChicken.TabStop = false;
            // 
            // picBulgogi
            // 
            picBulgogi.Location = new Point(206, 214);
            picBulgogi.Name = "picBulgogi";
            picBulgogi.Size = new Size(200, 152);
            picBulgogi.TabIndex = 5;
            picBulgogi.TabStop = false;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkFries);
            grpOption.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOption.Location = new Point(503, 159);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(293, 396);
            grpOption.TabIndex = 12;
            grpOption.TabStop = false;
            grpOption.Text = "추가옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Location = new Point(16, 327);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(191, 49);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(16, 256);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(191, 49);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Location = new Point(16, 180);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(116, 49);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.Location = new Point(16, 90);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(180, 49);
            chkFries.TabIndex = 0;
            chkFries.Text = "감자튀김";
            chkFries.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotal);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpOrder.Location = new Point(871, 173);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(535, 401);
            grpOrder.TabIndex = 13;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문내역";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTotal.Location = new Point(26, 313);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(275, 59);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(26, 50);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(486, 184);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOrder.Location = new Point(897, 629);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(220, 89);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnReset.Location = new Point(1160, 629);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(223, 89);
            btnReset.TabIndex = 14;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 771);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
