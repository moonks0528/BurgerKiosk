namespace BurgerKiosk
{
    public partial class BurgerKiosk : Form
    {
        public BurgerKiosk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoNone.Checked = true;
            this.ActiveControl = null;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0;
            bool isSelected = false;
            lblTitle.Focus();

            lstOrder.Items.Clear();

            if (rdoHam.Checked)
            {
                lstOrder.Items.Add("햄버거 5,000원");
                totalCost += 5000;
                isSelected = true;
            }
            else if (rdoBulgogi.Checked)
            {
                lstOrder.Items.Add("불고기버거 4,000원");
                totalCost += 4000;
                isSelected = true;
            }
            else if (rdoChicken.Checked)
            {
                lstOrder.Items.Add("치킨버거 3,000원");
                totalCost += 3000;
                isSelected = true;
            }

            if (chkFries.Checked)
            {
                lstOrder.Items.Add("감자튀김 2,000원");
                totalCost += 2000;
                isSelected = true;
            }

            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 1,500원");
                totalCost += 1500;
                isSelected = true;
            }

            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈 추가 1,000원");
                totalCost += 1000;
                isSelected = true;
            }

            if (chkSauce.Checked)
            {
                lstOrder.Items.Add("소스 추가 500원");
                totalCost += 500;
                isSelected = true;
            }

            if (!isSelected)
            {
                lblTotal.Text = "메뉴를 하나 이상 선택해주세요.";
                lblTotal.ForeColor = Color.Red;
                return;
            }

            lblTotal.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
            lblTotal.ForeColor = Color.Blue;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {

            rdoHam.Checked = false;
            rdoBulgogi.Checked = false;
            rdoChicken.Checked = false;


            chkFries.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;


            lstOrder.Items.Clear();
            lblTotal.Text = "총 금액 : 0원";

            rdoHam.Focus();
        }

        private void grpMenu_Enter(object sender, EventArgs e)
        {

        }
    }
}
