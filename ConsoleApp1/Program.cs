
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NP_L21_CachBatVaXuLyNgoaiLe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson17_Polimorphism();
            //Lesson19_Interface();
            //Lesson20_NameSpace();
            //lesson21_CachBatVaXuLyNgoaiLe();
            //lesson21_lesson21_CachBatVaXuLyNgoaiLeCustom();
            lesson22_RegularExpression();
        }

        public static void lesson22_RegularExpression()
        {
            // -- Bài 1: tìm trong chuỗi các ký tự số và in ra
            string original = "akjsdjlkj3lkr4jlsadkfjsl935i8s;dlfkslk3";

            // tìm các số trong dãy, dấu + để tìm sự xuất hiện của 1 2 hay nhiều số
            Match match = Regex.Match(original, "[0-9]+");

            // dùng while, matche.Group[0].Value và match.NextMatch() để lấy ra các giá trị
            while(match.Groups[0].Value != "")
            {
                Console.WriteLine(match.Groups[0].Value);
                match = match.NextMatch();
            }

            // -- Bài 2: tìm và in ra giá trị và vị trí của value cần tìm
            string original2 = "swfd strg sogd gmwo sdsd";
            // So chuỗi tìm chuỗi có có s ở đầu và d ở cuối
            // thêm dấu @ để thêm các ký tự đặc biệt trong C#. Trong python thì thêm chữ N , search lại
            MatchCollection matchs = Regex.Matches(original2, @"s\w+d");

            // for each loop lấy ra giá trị và vị trí của nó
            foreach(Match match2 in matchs)
            {
                foreach(Capture capture in match2.Captures)
                {
                    Console.WriteLine("Value: {0} and Index (hay vị trí bắt đầu thứ): {1}", capture.Value, capture.Index);
                }
            }

            // Bài 3: kiểm tra trả về đúng sai khi so khớp
            string s1 = "Tedu - Technology Education";
            Console.WriteLine(Regex.IsMatch(s1, "\\W"));  // tìm xem chuỗi s1 có chứa các ký tự ko phải là ký tự word ko?

            string s2 = "0937.89.48.38";
            string s3 = "0937894838";
            Console.WriteLine(Regex.IsMatch(s2, "\\D"));  // tìm xem chuỗi s2 có chứa các ký tự ko phải là ký tự số ko?
            Console.WriteLine(Regex.IsMatch(s3, "\\D"));

            Console.ReadKey();
        }

        public static void lesson21_lesson21_CachBatVaXuLyNgoaiLeCustom()
        {
            Console.WriteLine("Please enter your age:");
            string input = Console.ReadLine();

            try
            {
                byte age = byte.Parse(input);

                // ktra tuổi nhập vào có nhỏ hơn 18 ko? nếu có thì đẩy tới ngoại lệ custom bên dưới , truyền vào message theo constructor dựng sẳn
                if(age < 18)
                {
                    throw new InvalidAgeException("You didn't enought age.");
                }

                Console.WriteLine("Your age is {0}", age);
            }
            catch(FormatException formatEx)
            {
                Console.WriteLine("You have to type a number.");
                Console.WriteLine(formatEx.Message);
            }
            catch(InvalidAgeException iex)
            {
                Console.WriteLine(iex.InnerException);  // sử dụng constructor thứ 2, có thông tin innerException
                Console.WriteLine(iex.Message);
            }

            Console.ReadKey();
        }

        public static void lesson21_CachBatVaXuLyNgoaiLe()
        {
            NP_L21_CachBatVaXuLyNgoaiLe.TryCatch01 tc = new NP_L21_CachBatVaXuLyNgoaiLe.TryCatch01();

            tc.NhapLieu();

            Console.ReadKey();
        }

        public static void Lesson20_NameSpace()
        {
            NP_L20_First.A aFirst = new NP_L20_First.A();
            NP_L20_Second.A aSecond = new NP_L20_Second.A();

            aFirst.Display();
            aSecond.Display();

            NP_L20_Parent.NP_L20_Children.A aNested = new NP_L20_Parent.NP_L20_Children.A();
            aNested.Display();

            Console.ReadKey();
        }

        public static void Lesson19_Interface()
        {
            // khởi tạo obj product
            NS_L19_Interface.Product product19 = new NS_L19_Interface.Product();

            // gọi method GetTotal() và truyền vào giá với số lượng để tính tổng tiền
            double total = product19.GetTotal(50000, 10);
            Console.WriteLine("Tổng tiền: {0}", total);
            Console.ReadKey();
        }

        public static void Lesson17_Polimorphism()
        {
            // --- lesson 17, tính đa hình, StaticPolimorphism
            NS_L17_Polimorphism.Person person17 = new NS_L17_Polimorphism.Person();
            person17.Say();
            person17.Say("chuongnt");

            // --- lesson 17, tính đa hình, DynamicPolimorphism

            // khởi tạo class Rectangle, Triangle và truyền vào width, height
            NS_L17_Polimorphism.Rectangle rec = new NS_L17_Polimorphism.Rectangle(10, 20);
            NS_L17_Polimorphism.Triangle tri = new NS_L17_Polimorphism.Triangle(30, 40);

            // khởi tạo class Caller, gọi method của GetArea (tính diện tích) từ ob caller nhưng truyền vào obj rec và tri ở trên
            NS_L17_Polimorphism.Caller caller = new NS_L17_Polimorphism.Caller();
            int recArea = caller.GetArea(rec);
            Console.WriteLine(recArea);

            int triArea = caller.GetArea(tri);
            Console.WriteLine(triArea);

            Console.ReadKey();
        }
    }
}
