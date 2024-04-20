namespace SimpleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getUserInput(string input){

            return input;
        }
        private void genereateResult_Click(object sender, EventArgs e)
        {
            string getCountry = countryInput.Text;
            string getHarbor = harborOrigin.Text;
            

            string countryCode = getCountry.Substring(0, 3).ToUpper();
            string harborCode = getHarbor.Substring(0, 3).ToUpper();
            int getItemId;
            int itemPrice;

            if(!itemId.Text.All(Char.IsDigit) && !priceInput.Text.All(Char.IsDigit)) {
                MessageBox.Show("Please input only number on Item ID & Price !");
            } else
            {
                int.TryParse(itemId.Text, out getItemId);
                int.TryParse(priceInput.Text, out itemPrice);
                showResults(countryCode, harborCode, getItemId, itemPrice);
            }
        }

        private void showResults(string countryCode, string harborCode, int itemId, int itemPrice)
        {
            country.Text = countryCode;
            pelabuhan.Text = harborCode;
            barang.Text = itemId.ToString();
            hargaBarang.Text = itemPrice.ToString();

            resultLabel.Visible = true;
            country.Visible = true;
            pelabuhan.Visible = true;
            barang.Visible = true;
            detailBarang.Visible = true;
            hargaBarang.Visible = true;
            persenPajak.Visible = true;
            nominalPajak.Visible = true;
        }
    }
}