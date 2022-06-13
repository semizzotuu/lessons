namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {

                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });

            LoadProducts();
            MessageBox.Show("Added!");


        }
        public void SearchProducts(string ket)
        {
            //var result= _productDal.GetAll().Where(x=>x.Name.ToLower().Contains(ket.ToLower())).ToList();
            var result = _productDal.GeyByName(ket);//burada ise direkt olarak database e sorgu gönderiyoruz.
            dgwProducts.DataSource = result;
            
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void dgwProducts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
            });
            LoadProducts();
            MessageBox.Show("Deleted!");

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.GetById(2);
        }
    }
}
