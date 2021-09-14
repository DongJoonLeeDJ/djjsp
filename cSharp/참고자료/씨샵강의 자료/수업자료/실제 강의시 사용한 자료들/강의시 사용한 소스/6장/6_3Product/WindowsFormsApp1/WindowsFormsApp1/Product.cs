namespace WindowsFormsApp1
{
    class Product
    {
        public static int mCounter = 0;
        public int mId;
        public string mName;
        public int mPrice;

        public Product(string name, int price)
        {
            mCounter = mCounter + 1;
            mId = mCounter;
            mName = name;
            mPrice = price;
        }
    }
}