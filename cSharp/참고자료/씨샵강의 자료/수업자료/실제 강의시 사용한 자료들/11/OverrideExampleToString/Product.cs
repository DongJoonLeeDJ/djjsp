using System.Windows.Forms;

namespace OverrideExampleToString
{
    class Product
    {
        public string mName;
        public int mPrice;

        public Product(string name, int price)
        {
            mName = name;
            mPrice = price;
        }

        //public void printProduct()
        //{
        //    MessageBox.Show($"재품명:{mName}, 가격:{mPrice}");
        //}

        public override string ToString()
        {
            return $"재품명:{mName}, 가격:{mPrice}";
        }
    }
}