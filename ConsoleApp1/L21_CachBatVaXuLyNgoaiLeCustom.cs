using System;

namespace NP_L21_CachBatVaXuLyNgoaiLe
{
    // Tạo 1 class bắt lỗi tuổi kế thừa từ class Exception
    // chú ý: class Exception là lớn nhất, tất cả các class Exception khác kế thừa từ nó
    class InvalidAgeException : Exception
    {
        // khi ta kế thừa nó, ta bắt buộc phải kế thừa 1 constructor của nó
        // Đưa chuột vào từ khóa Exception ở trên, chọn Generate Constructor ....
        public InvalidAgeException(string message) : base(message)
        {
        }

        // Ta có thể viết 1 constructor thứ 2, kế thừa từ constructor của Exception lấy ra được thông tin innerException
        public InvalidAgeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
