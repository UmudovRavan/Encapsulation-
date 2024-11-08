using Encapsulation.Tapsiriq_1;
using Encapsulation.Tapsiriq_2;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1


            Car car1 = new Car(1, "Mercedes", 320, 1);
            Car car2 = new Car(2, "BMW", 300, 2);
            Car car3 = new Car(3,"Aston-Martin",360,3);

            Galerry galerry = new Galerry();

            galerry.AddCar(car1);
                
            galerry.AddCar(car2);
            galerry.AddCar(car3);


            Console.WriteLine("Movcud masinlar:");

            foreach(var car in galerry.Cars)
            {
                Console.WriteLine($"ID: {car.Id} , Name: {car.Name} , Speed: {car.Speed} , CarCode: {car.CarCode}.");
            }

            Console.WriteLine("Axdardiginiz ID'e aid masin: ");

            Car wantedCarId = galerry.FindCarById(2);
            if (wantedCarId != null )
            {
                Console.WriteLine($"ID: {wantedCarId.Id} , Name: {wantedCarId.Name} , Speed: {wantedCarId.Speed} , CarCode: {wantedCarId.CarCode}.");
            }
            else
            {
                Console.WriteLine("Bu ID'e aid masin yoxdur.");
            }

            Console.WriteLine("Axdardiginiz CarCode uygun masinlar:");

            Car wantedCarCode = galerry.FindCarByCarCode("ME1001");
            if (wantedCarCode != null)
            {
                Console.WriteLine($"Axdardiginiz masinin ID:{wantedCarCode.Id}, Name: {wantedCarCode.Name} , Speed: {wantedCarCode.Speed} , CarCode: {wantedCarCode.CarCode},");
            }
            else
            {
                Console.WriteLine("Bu CarCode'e aid masin yoxdur.");
            }

            Console.WriteLine("Axdardiginiz suret intervalina aid masin: ");

            List<Car> speedInterval = galerry.FindCarsBySpeedInterval(300, 350);
            if (speedInterval.Count > 0)
            {
                Console.WriteLine("100-300 suret intervalinda olan masinlar: ");
                foreach (var car in speedInterval)
                {
                    Console.WriteLine($"ID: {car.Id} , Name: {car.Name} , Speed: {car.Speed} , CarCode: {car.CarCode}.");
                }
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz intervalda surete malik  masin yoxdur.");
            }
            #endregion

            #region Task 2
            Console.WriteLine("==================================TASK2===============================================================================");

            Book book1 = new Book(1, "Harry Potter", 26, "Fantazya");
            Book book2 = new Book(2, " Qara Qənbər ", 7, "Psychology");
            Book book3 = new Book(3, "Yarımçıq şəkil", 10, "Fiction");


            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            Console.WriteLine("Movcud kitablar: ");
            foreach (var book in library.books)
            {
                Console.WriteLine(book.Name);
            }

            Console.WriteLine("Axdardiginiz ID'e aid kitablar:");

            Book wantedBookId = library.GetBookById(3);
            if (wantedBookId != null)
            {
                Console.WriteLine(wantedBookId.Name);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz ID'li kitab yoxdur.");
            }
            Console.WriteLine("Axdardiginiz ad'a aid kitablar:");

            //Book wantedBookName = library.GetBookByName("Harry");
            //if (wantedBookName != null)
            //{
            //    Console.WriteLine(wantedBookName.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz ID'li kitab yoxdur.");
            //}

            Book[] wantedBooksName = library.GetBooksByName("qara");
            foreach (var book in wantedBooksName)
            {
                Console.WriteLine(book.Name);
            }

            Console.WriteLine("Axdariginiz janra uygun kitablar:");

            Book[] wantedGenre = library.GetFilteredBook("fiction");
            foreach (var book in wantedBooksName)
            {
                Console.WriteLine(book.Name);
            }


            Console.WriteLine("Axdardiginiz qiymet araliginda olan kitablar:");
           
            List<Book> maxMinPrice = library.GetFilteredBook(10, 20);

            if(maxMinPrice.Count > 0)
            {
                foreach (var book in maxMinPrice)
                {
                    Console.WriteLine(book.Name);
                }
            }
            else
            {
                Console.WriteLine("Bu qiymet araliginda qiymet yoxdur.");
            }

            #endregion

        }
    }
}
