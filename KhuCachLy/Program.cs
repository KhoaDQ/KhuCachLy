using System;
using System.Collections.Generic;

namespace KhuCachLy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Thông tin khu cách ly ở thời điểm hiện tại
            // Danh sach Cac khu cach ly
            List<Zone> zones = new List<Zone>();

            // Tao khu cach ly
            Zone zone1 = new Zone("A",2);

            zones.Add(zone1);

            // Tao phong
            Room room1 = new Room(1, 4);
            Room room2 = new Room(2, 2);

            zone1.ListRoom.Add(room1);
            zone1.ListRoom.Add(room2);

            // Tao thong tin nguoi o
            Person person1 = new Person(51, (float)1.62);
            Person person2 = new Person(60, (float)1.50);
            Person person3 = new Person(40, (float)1.68);

            room1.ListPerson.Add(person1);
            room1.ListPerson.Add(person2);
            room1.ListPerson.Add(person3);
            
            Person person4 = new Person(55, (float)1.65);
            Person person5 = new Person(70, (float)1.70);

            room2.ListPerson.Add(person4);
            room2.ListPerson.Add(person5);
            
            #endregion
            
            #region Thông tin menu
            List<Food> menu = new List<Food>(7);

            Food food1 = new Food(1, 10000, 1000, 800, 600, 500); menu.Add(food1);
            Food food2 = new Food(1, 4000, 200, 150, 550, 390); menu.Add(food2);
            Food food3 = new Food(1, 2000, 50, 50, 380, 200); menu.Add(food3);
            Food food4 = new Food(1, 5000, 600, 600, 600, 270); menu.Add(food4);
            Food food5 = new Food(1, 9000, 350, 250, 40, 50); menu.Add(food5);
            Food food6 = new Food(1, 4000, 120, 440, 530, 430); menu.Add(food6);
            Food food7 = new Food(1, 3000, 800, 600, 500, 300); menu.Add(food7);

            #endregion

            #region Chọn thức ăn và xuất tổng chi phí
            person1.foods.Add(menu[0]);
            person2.foods.Add(menu[3]);
            person3.foods.Add(menu[5]);
            person4.foods.Add(menu[2]);
            person5.foods.Add(menu[3]);

            float totalFee = 0;

            foreach (Room room in zone1.ListRoom)
            {
                foreach (Person person in room.ListPerson)
                {
                    totalFee = totalFee + person.FoodFee();
                }    
            }

            Console.WriteLine(totalFee);

            #endregion

            #region Xuất thể trạng của từng người

            foreach (Room room in zone1.ListRoom)
            {
                foreach (Person person in room.ListPerson)
                {
                    Console.WriteLine(person.ToString());
                }
            }

            #endregion

            #region Có bao nhiêu người chọn khẩu phần ăn đúng thể trạng

            Console.WriteLine("\n Tình trạng chọn thức ăn của mỗi người: ");
            foreach (Room room in zone1.ListRoom)
            {
                foreach (Person person in room.ListPerson)
                {
                    if (person.Evaluate()) Console.WriteLine("Đúng");
                    else Console.WriteLine("Không đúng");
                }
            }

            #endregion
        }
    }
}
