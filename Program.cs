namespace SocialConnect
{
    class Program
    {
        static void Main(string[] args)
        {
        Menu:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n      UNG DUNG MANG XA HOI SOCIALCONNECT\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     _______________MENU________________");
            Console.WriteLine("     |                                 |");
            Console.WriteLine("     |      1. Dang Nhap               |");
            Console.WriteLine("     |      2. Dang Ky                 |");
            Console.WriteLine("     |      3. Thoat                   |");
            Console.WriteLine("     |_________________________________|");
            Console.Write("\nMoi nhap lua chon: ");

            int chon;
            Console.ForegroundColor = ConsoleColor.Blue;
            int.TryParse(Console.ReadLine(), out chon);
            Console.ForegroundColor = ConsoleColor.White;
            switch (chon)
            {
                //Neu chon Dang Nhap
                case 1:
                    MainMenu();
                    goto Menu;
                //Neu chon Dang Ky
                case 2:
                    //XuatThongTin();
                    goto Menu;
                //Neu chon Thoat
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ban co muon thoat khong?");
                    Console.WriteLine("1. Co");
                    Console.WriteLine("2. Khong");
                Check2:
                    Console.Write("Ban chon: ");
                    int chon3;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    int.TryParse(Console.ReadLine(), out chon3);
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (chon3)
                    {
                        //Neu chon co -> Thoat chuong trinh
                        case 1:
                            break;
                        //Neu chon khong -> Ve Menu
                        case 2:
                            goto Menu;
                        //Nhap khong hop le
                        default:
                            Check(1);
                            goto Check2;
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Tam biet va hen gap lai!");
                    break;
                //Nhap khong hop le
                default:
                    Check(1);
                    goto Menu;
            }
        }

        //Ham bao Loi lua chon
        static void Check(int chon)
        {
            switch (chon)
            {
                //Neu la loi nhap
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nLua chon khong hop le. Moi nhap lai!");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Bam Enter de tiep tuc... ");
                    Console.ForegroundColor = ConsoleColor.White;
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    break;
                //Neu la loi chuoi rong
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Khong duoc de trong. Moi nhap lai!", Console.ForegroundColor);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                //Neu danh sach rong
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Danh sach trong!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                //Neu khong tim thay doi tuong
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Khong tim thay!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                //Loi xoa doi tuong
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Doi tuong khong ton tai hoac da bi xoa!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        // Menu Chinh
        static void MainMenu()
        {
            int chon;
            Console.Clear();
            Console.WriteLine("\n________________MENU CHINH________________");
            Console.WriteLine("|                                          |");
            Console.WriteLine("|               Chon chuc nang             |");
            Console.WriteLine("|                                          |");
            Console.WriteLine("|         1. Tim Kiem Nguoi Dung           |");
            Console.WriteLine("|         2. Xem Tat Ca Thong Bao          |");
            Console.WriteLine("|         3. Doi Mat Khau                  |");
            Console.WriteLine("|         4. Quan Ly Trang Ca Nhan         |");
            Console.WriteLine("|         5. Xem Danh Sach Nguoi Dung      |");
            Console.WriteLine("|__________________________________________|");
            Console.Write("\nBan chon: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int.TryParse(Console.ReadLine(), out chon);
            Console.ForegroundColor = ConsoleColor.White;

            switch (chon)
            {
                //Neu la Khach hang Viet Nam
                case 1:
                    Console.Clear();
                    TimKiemNguoiDung();
                    break;
                //Neu la Khach hang nuoc ngoai
                case 2:
                    Console.Clear();
                    
                    break;
                //Quay lai Menu
                case 3:
                    break;
                //Nhap khong hop le
                default:
                    Check(1);
                    MainMenu();
                    break;
            }
        }

        //Ham Search
        static void TimKiemNguoiDung()
        {
            Console.Clear();
            int chon;
            string nguoiDung;
            Console.WriteLine("\n_____________TIM KIEM NGUOI DUNG_____________");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|            1. Nhap Ten Nguoi Dung          |");
            Console.WriteLine("|            2. Quay lai Menu                |");
            Console.WriteLine("|____________________________________________|");
            Console.Write("\nBan chon: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int.TryParse(Console.ReadLine(), out chon);
            Console.ForegroundColor = ConsoleColor.White;
            switch (chon)
            {
                case 1:
                TimKiem:
                    Console.Write("\nNhap nguoi dung can tim: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    nguoiDung = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    if (nguoiDung == "")
                    {
                        Check(2);
                        goto TimKiem;
                    }
                    XuatNguoiDung(nguoiDung);
                    Console.WriteLine("\nBan co muon tiep tuc tim kiem?");
                    Console.WriteLine("1. Co");
                    Console.WriteLine("2. Khong");
                Check1:
                    Console.Write("Ban chon: ");
                    int chon1;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    int.TryParse(Console.ReadLine(), out chon1);
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (chon1)
                    {
                        //Chon co -> Ve tab Tim kiem
                        case 1:
                            Console.Clear();
                            TimKiemNguoiDung();
                            break;
                        //Chon khong -> Ve Menu
                        case 2:
                            break;
                        //Nhap khong hop le
                        default:
                            Check(1);
                            goto Check1;
                    }
                    break;
                //Quay lai Menu
                case 2:
                    break;
                //Nhap khong hop le
                default:
                    Check(1);
                    TimKiemNguoiDung();
                    break;
            }
        }
    }
}