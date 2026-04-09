namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int totalCost = 0;
        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0;

            lstOrder.Items.Clear();


            if (rdoHam.Checked)
            {
                lstOrder.Items.Add("햄버거 5,000원");
                totalCost += 5000;
            }
            else if (rdoBulgogi.Checked)
            {
                lstOrder.Items.Add("불고기버거 4,000원");
                totalCost += 4000;
            }
            else if (rdoChicken.Checked)
            {
                lstOrder.Items.Add("치킨버거 3,000원");
                totalCost += 3000;
            }


            if (chkFries.Checked)
            {
                lstOrder.Items.Add("감자튀김 2,000원");
                totalCost += 2000;
            }

            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 1,500원");
                totalCost += 1500;
            }

            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈 추가 1,000원");
                totalCost += 1000;
            }

            if (chkSauce.Checked)
            {
                lstOrder.Items.Add("소스 추가 500원");
                totalCost += 500;
            }

            lblTotal.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
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
        }

        private void grpMenu_Enter(object sender, EventArgs e)
        {

        }
    }
}
