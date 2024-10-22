namespace WinFormsApp_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product product = new Product();
        List<Product> products = new List<Product>();
        private void Form1_Load(object sender, EventArgs e)
        {
            products = product.GetAllProducts();
            for (int i = 0; i < products.Count; i++)
            {
                lvProducts.Items.Add(products[i].Id.ToString());  //yeni bir satýr açar ve ilk kolon olarak Id ekler.
                lvProducts.Items[i].SubItems.Add(products[i].Name);
                lvProducts.Items[i].SubItems.Add(products[i].Stock.ToString());
                lvProducts.Items[i].SubItems.Add(products[i].Price.ToString());
                lvProducts.Items[i].SubItems.Add(products[i].Description);
            }
        }
        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                MessageBox.Show(lvProducts.SelectedItems[0].SubItems[0].Text + ", " + lvProducts.SelectedItems[0].SubItems[1].Text + ", " + lvProducts.SelectedItems[0].SubItems[2].Text);
            }
        }
    }
}