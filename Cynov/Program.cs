using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class Program
    {
        private static CynovContext db = new CynovContext();
        private static string passwordSaved;
        private static List<User> users = new List<User>();
        private static bool hasSession = false;
        private static bool adminSession = false;

        static void Main(string[] args)
        {
            CreateAuditoriums();
            while (true)
            {
                switch (Menu())
                {
                    case 1: SignUp(); break;
                    case 2: SignIn(); break;
                    case 3: Search(); break;
                    case 4: ListShowTimes(); break;
                    case 5: Exit(); break;
                }
            }
        }

        static int Menu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Welcome to Cynov !\nMake a choice\n1-Sign up" +
                    "\n2-Sign in\n3-Search\n4-List showtimes\n5-Exit");
                Int32.TryParse(Console.ReadLine(), out choice);
            } while (choice <= 0 || choice > 5);
            return choice;
        }

        static void SignUp()
        {
            Console.WriteLine("Sign In\n=================" +
                "\nUsername ?");
            string username = Console.ReadLine();
            Console.WriteLine("Email ?");
            string email = Console.ReadLine();
            Console.WriteLine("Password ?");
            string pass = Console.ReadLine();

            User u = new User
            {
                Username = username,
                Password = Utils.EncodePassword(pass),
                Email = email,
                IsAdmin = true
            };
            db.Users.Add(u);
            db.SaveChanges();
        }

        static void SignIn()
        {
            Console.WriteLine("Email ?");
            string input = Console.ReadLine();

            User resUser = db.Users.Where(u => u.Email == input.Trim().ToLower()).FirstOrDefault();

            if (resUser != null)
            {
                GetCreditentials(resUser);
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

        static void Search()
        {

        }

        static void ListShowTimes()
        {

        }


        static void ChooseShowTime()
        {
            Console.WriteLine("Choose a showtime");
            ListShowTimes();
            int showTimeChoice;
            Int32.TryParse(Console.ReadLine(), out showTimeChoice);
        }

        static void Exit()
        {
            Environment.Exit(0);
        }


        static void GetCreditentials(User u)
        {
            Console.WriteLine("Password ?");
            Console.WriteLine(u.Password);
            string inputPass = Console.ReadLine();


            passwordSaved = u.Password;


            if (Utils.DecodePassword(passwordSaved, inputPass))
            {
                hasSession = true;
                Console.WriteLine(((u.IsAdmin) ? "Admin User" : "Basic User"));


                switch (u.IsAdmin)
                {
                    case true:
                        adminSession = true;
                        Console.WriteLine("You can now add films and showtimes");
                        while(true)
                        {
                            Console.WriteLine("1-Add films\n2-Add showtimes\n3-Return to menu");
                            int choice;
                            Int32.TryParse(Console.ReadLine(), out choice);

                            switch (choice)
                            {
                                case 1:
                                    AddFilms();
                                    break;
                                case 2:
                                    AddShowTimes();
                                    break;
                                case 3:
                                    return;
                            }
                        }
                    case false:
                        Console.WriteLine("You can now pick a showtime from the list");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect creditentials");
            }
        }

        static void AddFilms()
        {
            Console.WriteLine("Add film\n=================");
            Console.WriteLine("Film's name ?");
            string filmName = Console.ReadLine();
            Console.WriteLine("Director's name ?");
            string directorName = Console.ReadLine();
            Console.WriteLine("Producer's name ?");
            string producerName = Console.ReadLine();
            Console.WriteLine("What's its type ?\n1-Feature film\n2-Short film\n3-Serie");
            int filmTypeChoice;
            Int32.TryParse(Console.ReadLine(), out filmTypeChoice);
            FilmType filmType = new FilmType();
            switch (filmTypeChoice)
            {
                case 1:
                    filmType = FilmType.FeatureFilm;
                    break;
                case 2:
                    filmType = FilmType.ShortFilm;
                    break;
                case 3:
                    filmType = FilmType.Serie;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Film's gender ?");
            string filmGender = Console.ReadLine();
            Console.WriteLine("Release Date ?");
            DateTime releaseDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("fr-FR"));



            Film f = new Film
            {
                Name = filmName,
                Director = directorName,
                Producer = producerName,
                Gender = filmGender,
                Type = filmType,
                ReleaseDate = releaseDate
            };
            db.Films.Add(f);
            db.SaveChanges();
            Console.WriteLine("Film added !");
        }


        static void AddShowTimes()
        {
        }


        static void CreateAuditoriums()
        {
            Auditorium a = new Auditorium
            {
                Name = "B3",
                Capacity = 50
            };


            db.Auditoriums.Add(a);
            db.SaveChanges();
        }
    }
}