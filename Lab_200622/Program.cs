using System;

namespace Lab_200622
{
    class Program
    {
        /// <summary>
        /// Bài 1. Viết chương trình nhập vào điểm 3 môn học: Toán, Lý, Hóa. 
        /// Tính trung bình cộng điểm 3 môn.
        /// Sau đó in ra màn hình loại học sinh (Xuất sắc, Giỏi, Khá, Trung bình, Yếu).
        /// </summary>
        public static void Bai01()
        {
            double toan, ly, hoa;
            do
            {
                Console.Write("- Điểm toán: ");
                toan = Convert.ToDouble(Console.ReadLine());
            } while (toan < 0 || toan > 10);
            do
            {
                Console.Write("- Điểm lý: ");
                ly = Convert.ToDouble(Console.ReadLine());
            } while (ly < 0 || ly > 10);
            do
            {
                Console.Write("- Điểm hoá: ");
                hoa = Convert.ToDouble(Console.ReadLine());
            } while (hoa < 0 || hoa > 10);

            double dtb = (toan + ly + hoa) / 3;
            Console.WriteLine("=> Điểm trung bình: " + dtb);

            string xl = "";
            if (dtb >= 9) xl = "Xuất sắc";
            else if (dtb >= 8) xl = "Giỏi";
            else if (dtb >= 6.5) xl = "Khá";
            else if (dtb >= 5) xl = "Trung bình";
            else xl = "Yếu";
            Console.WriteLine("=> Xếp loại: " + xl);
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 2. Viết chương trình giải phương trình bậc hai.
        /// </summary>
        public static void Bai02()
        {
            Console.Write("- A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("- B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("- C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("=> Phương trình vô số nghiệm");
                    else
                        Console.WriteLine("=> Phương trình số nghiệm");
                }
                else Console.WriteLine("=> Nghiệm x: " + (-1.0 * c / b));
            }
            else
            {
                int d = b * b - 4 * a * c;
                Console.WriteLine("=> Delta = " + d);
                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("=> Nghiệm x1 = " + x1 + "\n=> Nghiệm x2 = " + x2);
                }
                else if (d == 0)
                {
                    double x = -1.0 * b / (2 * a);
                    Console.WriteLine("=> Nghiệm kép x = " + x);
                }
                else
                    Console.WriteLine("=> Phương trình số nghiệm");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 3. Viết chương trình nhập vào một số nguyên dương. 
        /// Cho biết số nguyên vừa nhập là số chẵn hay số lẻ.
        /// </summary>
        public static void Bai03()
        {
            Console.Write("- Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine(n + " là số chẫn");
            else
                Console.WriteLine(n + " là số lẻ");
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 4. Viết chương trình nhập vào hai giờ. Tính và in ra tổng và hiệu của hai giờ đó. 
        /// </summary>
        public static void Bai04()
        {
            Console.Write("- Thời gian thứ 1: ");
            TimeSpan t1 = new TimeSpan(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.Write("- Thời gian thứ 2: ");
            TimeSpan t2 = new TimeSpan(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("=> Tổng: " + (t1 + t2).ToString());
            Console.WriteLine("=> Hiệu: " + (t1 - t2).ToString());
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 5. Viết chương trình cho phép nhập vào các số thực a, b, c.
        /// Kiểm tra xem chúng có lập thành 3 cạnh của một tam giác không.
        /// Nếu có, hãy cho biết tam giác đó là tam giác gì? 
        /// (Xét các trường hợp tam giác cân, đều, vuông, vuông cân và tam giác thường)
        /// </summary>
        public static void Bai05()
        {
            Console.Write("- Nhập a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("- Nhập b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("- Nhập c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("=> 3 cạnh lập thành tam giác");
                if (a == b && b == c)
                    Console.WriteLine("=> Tam giác đều");
                else if (a == b || b == c || c == a)
                    Console.WriteLine("=> Tam giác cân");
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    Console.WriteLine("=> Tam giác vuông");
                else if ((a == b || b == c || c == a) && (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a))
                    Console.WriteLine("=> Tam giác vuông cân");
                else
                    Console.WriteLine("=> Tam giác thường");
            }
            else
                Console.WriteLine("=> 3 cạnh không lập thành tam giác");
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 6. Viết chương trình nhập vào 4 số nguyên dương.
        /// Tìm số lớn nhất trong 4 số nguyên dương đó.
        /// </summary>
        public static void Bai06()
        {
            Console.Write("- Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhập b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhập c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhập d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            Console.WriteLine("=> Tìm số lớn nhất: " + max);
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 7. Viết chương trình tính tiền đi taxi biết số km đã đi. 
        /// Biết rằng: 1km đầu tiên giá 5000 đồng.
        /// Từ km thứ 2 đến km thứ 5 giá trung bình là 4500 đồng/km.
        /// Từ km thứ 6 trở đi, giá trung bình mỗi km là 3500 đồng/km.
        /// Nếu khách hàng đi trên 120 km thì sẽ được giảm 10% trên tổng số tiền tính theo qui định.
        /// </summary>
        public static void Bai07()
        {
            Console.Write("- Số km: ");
            int km = Convert.ToInt32(Console.ReadLine());
            int km1 = km;
            int money = 0;
            if (km > 5)
            {
                money += 3500 * (km - 5);
                km = 5;
            }
            if (km > 1)
            {
                money += 4500 * (km - 1);
                km = 1;
            }
            money += (km > 0) ? 5000 : 0;
            money -= (km1 > 120) ? (money / 10) : 0;
            Console.WriteLine("=> Số tiền: " + money);
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 8. Viết chương trình nhập vào hai số nguyên. Sau đó hiển thị ra màn hình các lựa chọn: 
        /// Thực hiện phép cộng.
        /// Thực hiện phép trừ.
        /// Thực hiện phép nhân.
        /// Thực hiện phép chia.
        /// Người dùng nhập vào các số từ 1 đến 4 để thực hiện lựa chọn của mình.
        /// </summary>
        public static void Bai08()
        {
            Console.Write("- Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhập b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***** Lựa chọn phép tính *****");
            Console.WriteLine("1. Cộng");
            Console.WriteLine("2. Trừ");
            Console.WriteLine("3. Nhân");
            Console.WriteLine("4. Chia");
            Console.Write("Lựa chọn: ");
            int pt = Convert.ToInt32(Console.ReadLine());

            int n = 0;
            switch (pt)
            {
                case 1:
                    n = a + b;
                    break;
                case 2:
                    n = a - b;
                    break;
                case 3:
                    n = a * b;
                    break;
                case 4:
                    n = a / b;
                    break;
            }
            Console.WriteLine("=> Kết quả: " + n);
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 9. Cước phí bưu phẩm trong nước được tính như sau: 
        /// Nếu trọng lượng thư trong khoảng định mức 100gam đầu thì cước phí trung bình cho mỗi gam là 300 đồng.
        /// Nếu trọng lượng thư vượt định mức không quá 30gam thì cước phí trung bình cho mỗi gam vượt định mức là 200 đồng.
        /// Trường hợp trọng lượng thư vượt quá 130g thì tính trung bình 120 đồng cho mỗi gam vượt quá 130gam.
        /// Viết chương trình tính cước phí phải trả khi nhập vào trọng lượng bức thư.
        /// </summary>
        public static void Bai09()
        {
            Console.Write("- Nhập số gam: ");
            int gam = Convert.ToInt32(Console.ReadLine());

            int money = 0;
            if (gam <= 100)
                money = gam * 300;
            else if (100 < gam && gam <= 130)
                money = 100 * 300 + (gam - 100) * 200;
            else
                money = 100 * 300 + 30 * 200 + (gam - 130) * 120;
            Console.WriteLine("=> Số tiền: " + money);
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 10. Viết chương trình cho phép nhập vào một số nguyên dương có 2 chữ số. 
        /// Hãy in ra cách đọc của số nguyên này.
        /// </summary>
        public static void Bai10()
        {
            string[] number = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            Console.Write("- Nhập số có 2 chữ số: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = n / 10, dv = n % 10;

            string read = "";
            if (c == 1) read += "mười ";
            else read += number[c] + " mươi ";

            if (dv == 0) read += "";
            else if (c != 1 && dv == 1) read += "mốt";
            else if (c != 1 && dv == 5) read += "lăm";
            else read += number[dv];
            Console.WriteLine("=> " + n + " đọc là " + read);
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 11. Viết chương trình nhập vào một năm dương lịch và xét xem năm đó có phải là năm nhuận không? 
        /// </summary>
        public static void Bai11()
        {
            Console.Write("- Nhập năm: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 400 == 0 || (n % 4 == 0 && n % 100 != 0))
                Console.WriteLine("=> " + n + " là năm nhuận");
            else
                Console.WriteLine("=> " + n + " không phải là năm nhuận");
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 12. Viết chương trình nhập vào số Kwh tiêu thụ điện. 
        /// Tính tiền điện phải trả biết rằng cách thức tính tiền theo qui định như sau: 
        /// 100 kwh định mức đầu tiên có đơn giá trung bình là 600đ/kwh
        /// Các kwh từ 101 đến 150 có đơn giá là 700đ/kwh
        /// Các kwh từ 151 đến 200 có đơn giá là 900đ/kwh
        /// Các kwh từ 201 trở đi có đơn giá là 1100đ/kwh
        /// </summary>
        public static void Bai12()
        {
            Console.Write("- Nhập số Kwh tiêu thụ điện: ");
            int kwh = Convert.ToInt32(Console.ReadLine());

            int money = 0;
            if (kwh <= 100)
                money = kwh * 600;
            else if (100 < kwh && kwh <= 150)
                money = 100 * 600 + (kwh - 100) * 700;
            else if (150 < kwh && kwh <= 200)
                money = 100 * 600 + 50 * 700 + (kwh - 150) * 900;
            else
                money = 100 * 600 + 50 * 700 + 50 * 900 + (kwh - 200) * 1100;
            Console.WriteLine("=> Số tiền: " + money);
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 13. Viết chương trình nhập vào một số, kiểm tra xem số vừa nhập vào là số âm hay số dương.
        /// </summary>
        public static void Bai13()
        {
            Console.Write("- Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0)
                Console.WriteLine("=> " + n + " là số dương");
            else
                Console.WriteLine("=> " + n + " là số âm");
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 14. Viết chương trình tính tiền thuê phòng biết số ngày thuê và loại phòng với qui định của khách sạn như sau: 
        /// Loại A: 250.000 đ/ngày
        /// Loại B: 200.000 đ/ngày
        /// Loại C: 150.000 đ/ngày
        /// Nếu thuê quá 10 ngày thì % được giảm trên tổng số tiền (được tính theo giá qui định) là 10%.
        /// </summary>
        public static void Bai14()
        {
            Console.WriteLine("***** Loại phòng *****");
            Console.WriteLine("A. Loại A giá 250.000 đ/ngày");
            Console.WriteLine("B. Loại B giá 200.000 đ/ngày");
            Console.WriteLine("C. Loại C giá 150.000 đ/ngày");
            Console.Write("- Nhập lựa chọn: ");
            char r = Convert.ToChar(Console.ReadLine());
            Console.Write("- Số ngày: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int money = 0;
            if (r == 'a') money = 250000 * n;
            if (r == 'b') money = 200000 * n;
            if (r == 'c') money = 150000 * n;
            if (n > 10) money = money * 9 / 10;
            Console.WriteLine("=> Phòng loại " + r + " với " + n + " ngày, thành tiền " + money);
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 15. Viết chương trình cho phép nhập vào tháng và năm. Hãy cho biết tháng đó có bao nhiêu ngày.
        /// </summary>
        public static void Bai15()
        {
            Console.Write("- Nhập tháng: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhập năm: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int d = 0;
            if (m == 2)
            {
                if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
                    d = 29;
                else d = 28;
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
                d = 30;
            else d = 31;

            Console.WriteLine("=> Tháng " + m + " năm có " + d + " ngày");
            Console.ReadKey();
        }

        /// <summary>
        /// Bài 16. Giả sử lương của công nhân được tính theo công thức: 
        /// Tiền lương = (mức lương mỗi ngày * số ngày) + tiền thưởng - tiền phạt.
        /// Biết rằng tiền thưởng bao gồm 2 khoản: 
        /// Tiền thưởng thêm cho mỗi giờ làm việc tăng ca là 10000 đồng.
        /// Tiền thưởng thêm cho mỗi ngày là 15000 đồng kể từ ngày làm việc thứ 25 trở đi nếu số ngày làm việc lớn hơn 24 ngày.
        /// Tiền phạt đối với mỗi ngày đi trễ là 20000 đồng.
        /// Viết chương trình nhập vào mức lương mỗi ngày, số ngày làm việc, số giờ làm việc tăng ca, số ngày đi trễ, tính và in ra tiền lương của công nhân.
        /// </summary>
        public static void Bai16()
        {

        }

        /// <summary>
        /// Bài 17. Viết chương trình cho phép nhập vào một số nguyên dương có 3 chữ số. Hãy in ra cách đọc của số nguyên này.
        /// </summary>
        public static void Bai17()
        {

        }

        /// <summary>
        /// Bài 18. Viết chương trình nhập vào 1 số nguyên dương N. 
        /// Liệt kê ra màn hình tất cả các ước số của số nguyên N.
        /// Ví dụ: N= 12. Các ước số của N là: 1, 2, 3, 4, 6, 12.
        /// </summary>
        public static void Bai18()
        {

        }

        /// <summary>
        /// Bài 19. Viết chương trình nhập vào 1 số nguyên dương N. 
        /// Đếm xem số nguyên N có bao nhiêu ước số.
        /// </summary>
        public static void Bai19()
        {

        }

        /// <summary>
        /// Bài 20. Viết chương trình tìm ước số chung lớn nhất của hai số.
        /// </summary>
        public static void Bai20()
        {

        }

        /// <summary>
        /// Bài 21. Viết chương trình tìm bội số chung nhỏ nhất của hai số. 
        /// </summary>
        public static void Bai21()
        {

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Bai16();
            }
        }
    }
}
