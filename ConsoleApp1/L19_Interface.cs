namespace NS_L19_Interface
{
    // Khai báo 1 interface IProduct có method tính tổng tiền. Chú ý là khai báo tổng quát, ko có detail cách tính
    // Thường thì người dev sẽ implement các method này và bắt đầu code
    interface IProduct
    {
        double GetTotal(double price, int quantity);
    }

    // khởi tạo class Product kế thừa interface IProduct
    class Product : IProduct
    {
        public double GetTotal(double price, int quantity)
        {
            return price * quantity;
        }
    }
}
