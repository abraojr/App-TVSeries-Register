using System;

namespace app_Series_Register
{
    class Program
    {
        static TVShowRepository repository = new TVShowRepository();
        static void Main(string[] args)
        {
            string userOption = GetUserOptions();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSeries();
                        break;
                    case "3":
                        UpdateSeries();
                        break;
                    case "4":
                        DeleteSeries();
                        break;
                    case "5":
                        ViewSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOption = GetUserOptions();
            }

            Console.WriteLine("Thank you for using our services.");
            Console.ReadLine();
        }

        private static void ListSeries()
        {
            Console.WriteLine("List Series");

            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("No Tv shows registered.");
                return;
            }
            foreach (var tvShow in list)
            {
                var deleted = tvShow.getDeleted();

                Console.WriteLine("#ID {0}: - {1} {2}", tvShow.getId(), tvShow.getTitle(), (deleted ? "*Deleted*" : ""));
            }
        }

        private static void InsertSeries()
        {
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }
            Console.Write("Enter the genre from the options above: ");
            int inputGenre = int.Parse(Console.ReadLine());

            Console.Write("Enter the Tv Show Title: ");
            string inputTitle = Console.ReadLine();

            Console.Write("Enter the release year of the Tv Show: ");
            int inputYear = int.Parse(Console.ReadLine());

            Console.Write("Enter the Tv Show Description: ");
            string inputDescription = Console.ReadLine();

            TVShow newTvShow = new TVShow(id: repository.nextId(), genre: (Genre)inputGenre, title: inputTitle, year: inputYear, description: inputDescription);

            repository.Insert(newTvShow);
        }

        private static void UpdateSeries()
        {
            Console.Write("Enter the Tv Show ID: ");
            int tvShowIndex = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }
            Console.Write("Enter the genre from the options above: ");
            int inputGenre = int.Parse(Console.ReadLine());

            Console.Write("Enter the Tv Show Title: ");
            string inputTitle = Console.ReadLine();

            Console.Write("Enter the release year of the Tv Show: ");
            int inputYear = int.Parse(Console.ReadLine());

            Console.Write("Enter the Tv Show Description: ");
            string inputDescription = Console.ReadLine();

            TVShow updateTvShow = new TVShow(id: tvShowIndex, genre: (Genre)inputGenre, title: inputTitle, year: inputYear, description: inputDescription);

            repository.Update(tvShowIndex, updateTvShow);
        }

        private static void DeleteSeries()
        {
            Console.Write("Enter the Tv Show ID: ");
            int tvShowIndex = int.Parse(Console.ReadLine());

            repository.Delete(tvShowIndex);
        }

        private static void ViewSeries()
        {
            Console.Write("Enter the Tv Show ID: ");
            int tvShowIndex = int.Parse(Console.ReadLine());

            var tvShow = repository.GetById(tvShowIndex);
            Console.WriteLine(tvShow);
        }

        private static string GetUserOptions()
        {
            Console.WriteLine();
            Console.WriteLine("TV Shows at your disposal!!");
            Console.WriteLine("Enter the desired option:");

            Console.WriteLine("1- List TV Shows");
            Console.WriteLine("2- Insert a new TV Show");
            Console.WriteLine("3- Update TV Show");
            Console.WriteLine("4- Delete TV Show");
            Console.WriteLine("5- View TV Show");
            Console.WriteLine("C- Clear Screen");
            Console.WriteLine("X - Exit");

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}
