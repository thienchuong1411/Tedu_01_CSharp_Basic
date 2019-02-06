using System;

namespace NS_L17_Polimorphism
{
    /// <summary>
    /// StaticPolimorphism
    /// </summary>
    class Person
    {
        public void Say()
        {
            Console.WriteLine("No name");
        }

        public void Say(string name)
        {
            Console.WriteLine("My name is " + name);
        }
    }

    /// <summary>
    /// DynamicPolimorphism
    /// </summary>
    
    /// class cha
    class Shape
    {
        protected int _width;
        protected int _height;

        // hàm khởi tạo, hay constructor
        // protected : thì chỉ những class kế thừa mới sử dụng đc
        protected Shape(int width, int height)
        {
            _width = width;
            _height = height;
        }

        // khai báo virtual để các class con khác có thể ghi đè lên method này
        //nếu để protected thì ko sử dụng đc trong main, nên khai báo public. các class kế thừa phải giống từ khóa này
        public virtual int GetArea()
        {
            Console.WriteLine("This is parent method");
            return 0;
        }
    }

    // Class Rectangle (hình chữ nhật) kế thùa từ class Shape
    class Rectangle : Shape
    {
        // Constructor kế thừa từ class Shape dùng từ khóa base
        public Rectangle(int width, int height) : base(width, height)
        {

        }

        // viết mới 1 method tính diện tích cho class Rectangle
        public override int GetArea()
        {
            Console.WriteLine("Rectangle area:");
            return _width * _height;    // sử dụng đc property của class cha Shape
        }
    }

    // class con Triangle kế thừa class cha Shape
    class Triangle : Shape
    {
        // viết hàm khởi tạo constructor kế thừa hàm khởi tạo của class Shape, nếu ko có hàm này thì báo lỗi ở class
        public Triangle(int a, int b) : base(a, b)
        {

        }

        public override int GetArea()
        {
            Console.WriteLine("Triangle area:");
            return (_width * _height) / 2;
        }
    }

    // viết Class Caller để gọi lớp cha Shape, và thực tế trên Main khởi tạo class này ta có thể truyền vào class con là Recangle và Triangle
    class Caller
    {
        public int GetArea(Shape shape)
        {
            // biến area kiểu int, nhận giá trị khi gọi method GetArea.
            // Nếu truyền vào là shapr thì area = 0 (default virtual của class Shape) nhưng nếu truyển vào là obj của Triangle
            int area = shape.GetArea();
            return area;
        }
    }
}
