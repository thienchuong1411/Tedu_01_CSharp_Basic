using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_L22_RegularExpression
{
    /*
     * Regular Expression hay RE là 1 ngôn ngữ cực mạnh dùng mô tả văn bản cũng như thao tác trên văn bản. Một RE thường đc ứng dụng lên một chuỗi, nghĩa là lên 1 nhóm ký tự
     * RE gồm 2 phần: 
     * 01./ literal (trực kiện) : 
     * 02./ metacharacters (siêu ký tự):
     *  \d : ký tự chữ số tương đương [0-9]
     *  \D : ký tự ko phải chữ số
     *  \s : ký tự khoảng trắng tương đương [ \f\n\r\t\v]
     *  \S : ký tự ko phải khoảng trắng tương đương [ \f\n\r\t\v]
     *  \w : ký tự word (gồm chữ cái và chữ số, dấu gạch dưới) tương đương [a-zA-Z_0-9]
     *  \W : ký tự ko phải ký tự word tương đương [^a-zA-Z_0-9]
     *  ^  : bắt đầu 1 chuỗi hay 1 dòng
     *  $  : kết thúc 1 chuỗi hay 1 dòng
     *  \A : bắt đầu 1 chuỗi
     *  \z : kết thúc 1 chuỗi
     *  
     *  -- Các siêu ký tự thường dùng (quan trọng)
     *  |       : ký tự ngăn cách so trùng tương đương or (lưu ý cái này nếu muốn kết hợp nhiều điều kiện)
     *  [abc]   : khớp với 1 ký tự nằm trong nhóm a hay b hay c
     *  [a-z]   : so sánh trùng với 1 ký tự nằm trong phạm vi từ a-z, dùng dấu - làm dấu ngăn cách
     *  [^abc]  : sẽ ko so trùng với 1 ký tự nằm trong nhóm. Ví dụ ko so trùng với a hay b hay c
     *  ()      : xác định 1 group (biểu thức con) xem như nó là 1 yếu tố đơn lẻ trong pattern. Ví dụ ( ( a (b) ) c ) sẽ khớp vói b, ab hay abc
     *  ?       : khớp với đứng trước từ 0 hay 1 lần. Ví dụ A?B sẽ khớp với B hay AB
     *  *       : khớp với từ 0 lần trở lên. Ví dụ A*B sẽ khớp với B, AB, AAB, AAAB hay ...
     *  +       : khớp với đứng trước từ 1 lần trở lên. Ví dụ A+B sẽ khớp với AB, AAB ...
     *  {n}     : n là con số, khớp đúng với n ký tự đứng trước nó. Ví dụ A{2} khớp đúng với 2 chữ A là AA
     *  {n,}    : khớp đúng với n ký tự trở lên đứng trước nó. Ví dụ A{2,} khớp với AA, AAA, AAAA ...
     *  {m,n}   : khớp đúng với từ m->n ký tự đứng trước nó. Ví dụ A{2,4} khớp với AA, AAA hay AAAA
     *  
     *  -- Các lớp để thao tác với Regular Expression trong .NET
     *  Name space: System.Text.RegularExpression , chủ yếu là việc với 1,2,3,4,6
     *      1. Regex
     *      2. Match
     *      3. MatchCollection
     *      4. Group
     *      5. GroupCollection
     *      6. Cature
     *      7. CatureCollection
     */
}
