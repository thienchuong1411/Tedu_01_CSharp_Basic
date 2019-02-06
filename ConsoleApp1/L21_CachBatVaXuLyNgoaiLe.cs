using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_L21_CachBatVaXuLyNgoaiLe
{
    class TryCatch01
    {
        public void NhapLieu()
        {
            Console.WriteLine("Please enter number 1:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Please enter number 2:");
            string input2 = Console.ReadLine();

            //int number1 = int.Parse(input1);
            //int number2 = int.Parse(input2);
            //int number3 = number1 / number2;
            //Console.WriteLine("Result of {0} / {1} = {2}", number1, number2, number3);

            // Sẽ xảy ra 2 lỗi với tình huống trên: thứ 1: khách hàng ko nhập số mà nhập chuỗi hay ký tự đặc biệt.
            // Thứ 2: ở number2 khách hàng nhập số 0, sẽ xảy ra lỗi zero , vì vậy sau khi có string input, ta phải ktra dữ liệu như sau

            int number1 = 0;
            try
            {
                number1 = int.Parse(input1);
            }
            // catch chính xác lỗi sai format dùng FormatException
            catch(FormatException formatEx)
            {
                // In thông tin lỗi từ hệ thống
                Console.WriteLine(formatEx.Message);

                // thông báo lỗi cho khách hàng
                Console.WriteLine("Invalid format");
            }
            // Bắt lỗi tổng quát, nếu mình chưa xác định mà có nguy cơ lỗi dùng Exception
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Has an error, please try again.");
            }
            finally
            {
                Console.WriteLine("Finally: ta có thể làm thêm bất kì j ở phần cuối cùng này");
            }

            int number2 = 0;
            try
            {
                number2 = int.Parse(input2);
            }
            catch(FormatException formatEx)
            {
                // In thông tin lỗi từ hệ thống
                Console.WriteLine(formatEx.Message);

                // thông báo lỗi cho khách hàng
                Console.WriteLine("Invalid format");
            }

            try
            {
                int number3 = number1 / number2;
                Console.WriteLine("Result of {0} / {1} = {2}", number1, number2, number3);
            }
            catch (DivideByZeroException dbzex)
            {
                // In thông tin lỗi từ hệ thống
                Console.WriteLine(dbzex.Message);

                // thông báo lỗi cho khách hàng
                Console.WriteLine("Divied number cannot is zero");
            }

            
        }
    }
}
