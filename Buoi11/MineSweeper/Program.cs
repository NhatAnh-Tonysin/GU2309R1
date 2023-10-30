using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Map gốc
            Console.WriteLine("Create New Map");
            Console.Write("Enter map size: ");
            int s = int.Parse(Console.ReadLine());

            string[,] map = new string[s, s]; //Biến mảng map gốc
            string dot = ".";
            string star = "*";

            Console.Write("Map: ");
            for (int row = 0; row < s; row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < s; column++)
                {
                    map[row, column] = dot;
                    Console.Write(map[row, column] + "   ");
                }
            }

            int mineN = s * 3 / 5; //Biến số lượng mine được phép cài vào map

            Console.Write("\nSet {0} mines at: \n", mineN);

            for (int nhap = 1; nhap <= mineN; nhap++)
            {
                Console.Write("row: ");
                int r = int.Parse(Console.ReadLine());  //Nhập địa chỉ dòng theo vùng nhìn
                Console.Write("column: ");
                int c = int.Parse(Console.ReadLine());  //Nhập địa chỉ cột theo vùng nhìn

                map[r - 1, c - 1] = star;                   //r-1,c-1 để trỏ về địa chỉ thực của mảng
                Console.WriteLine();
            }

            Console.WriteLine();

            //In mảng sau khi đã set mine
            Console.Write("Map: ");
            for (int row = 0; row < s; row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < s; column++)
                    Console.Write(map[row, column] + "   ");
            }

            Console.WriteLine();
            #endregion Map gốc

            /* Đổi lại tên biến cho dễ quan sát
             * xOrdinate => x: Biến cột của phần tử được dò
             * yOrdinate => y: Biến dòng của phần tử được dò
             * NEIGHBOURS_ORDINATE => NB:Biến mảng của các ô xung quanh ô hiện tại
             * xOrdinateOfNeighbour => xOfNB
             */

            int MAP_HEIGHT = map.GetLength(0);  //Biến số lượng phần tử chiều dọc(số lượng hàng)
            int MAP_WIDTH = map.GetLength(1);   //Biến số lượng phần tử chiều ngang(số lượng cột/ số lượng phần tử của mỗi hàng)

            string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH]; //Biến mảng map kết quả, lấy số lượng phần tử dòng ,cột của mảng "map"

            /*  Vòng lặp dưới sẽ dò tìm từng phần tử trong mảng map và in ra kết quả là mảng mapReport
             *  mỗi phần tử sẽ đc được dò ngay tại vị trí đó trước, nếu có dấu "*" sẽ in ra dấu "*", nếu không sẽ dò 8 ô vị trí xung quanh của ô phần tử đó nếu dò thấy có ô có "*" sẽ đếm số lượng và in ra số lượng "*" xuất hiện
             */

            #region Dò tìm "*" trong từng phần tử
            for (int y = 0; y < MAP_HEIGHT; y++)
            {
                for (int x = 0; x < MAP_WIDTH; x++)
                {
                    String curentCell = map[y, x];  //Biến phần tử được dò

                    if (curentCell.Equals("*"))     //Nếu thấy "*" ở vt hiện tại trong mảng "map" thì in ra kết quả ở vt đó trên mảng "mapReport"
                        mapReport[y, x] = "*";

                    else
                    {
                        int[,] NB = { { y - 1, x - 1 }, { y - 1, x }, { y - 1, x + 1 }, { y, x - 1 }, { y, x + 1 }, { y + 1, x - 1 }, { y + 1, x }, { y + 1, x + 1 }, }; //Biến mảng tập hợp các phần tử xung quanh phần tử được dò(8 ô xung quanh)

                        int minesAround = 0; // Biến đếm số lượng mìn/ dấu "*"

                        for (int i = 0; i < NB.GetLength(0); i++)
                        {
                            int xOfNB = NB[i, 1]; // Biến vị trí cột của phần tử xung quanh được dò
                            int yOfNB = NB[i, 0]; // Biến vị trí hàng của phần tử xung quanh được dò

                            bool isOutOfMapNeighbour = xOfNB < 0 || xOfNB == MAP_WIDTH || yOfNB < 0 || yOfNB == MAP_HEIGHT; //Nếu phần tử được dò có vị trí nằm ngoài phạm vi số lượng phần tử của mảng "map" thì sẽ tiếp tục lệnh ở dưới để đếm số lượng mìn/"*"
                            if (isOutOfMapNeighbour) continue;

                            bool isMineOwnerNeighbour = map[yOfNB, xOfNB].Equals("*");
                            if (isMineOwnerNeighbour) minesAround++;
                        }

                        mapReport[y, x] = minesAround.ToString();   //Lấy số lượng mìn/"*" gán cho vị trí phần tử được dò tại thời điểm đó
                    }
                }
            }
            #endregion Dò tìm "*" trong từng phần tử

            #region In ra map kết quả sau khi dò từ map gốc
            Console.WriteLine("\n\nMap Result: ");
            for (int y = 0; y < MAP_HEIGHT; y++)
            {
                Console.WriteLine("\n");
                for (int x = 0; x < MAP_WIDTH; x++)
                {
                    String currentCellReport = mapReport[y, x];
                    Console.Write(currentCellReport + "   ");
                }
            }
            #endregion In ra map kết quả sau khi dò từ map gốc



            Console.ReadKey();
        }
    }
}
