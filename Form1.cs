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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0;

            lstOrder.Items.Clear();

   
            if (rdoHam.Checked)
            {
                lstOrder.Items.Add("햄버거 5000원");
                totalCost += 5000;
            }
            else if (rdoBulgogi.Checked)
            {
                lstOrder.Items.Add("불고기버거 6000원");
                totalCost += 6000;
            }
            else if (rdoChicken.Checked)
            {
                lstOrder.Items.Add("치킨버거 6500원");
                totalCost += 6500;
            }

       
            if (chkFries.Checked)
            {
                lstOrder.Items.Add("감자튀김 2000원");
                totalCost += 2000;
            }

            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 1500원");
                totalCost += 1500;
            }

            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈 추가 1000원");
                totalCost += 1000;
            }

            if (chkSauce.Checked)
            {
                lstOrder.Items.Add("소스 추가 500원");
                totalCost += 500;
            }

            lblTotal.Text = "총 금액 : " + totalCost + "원";
        }
    }
}
