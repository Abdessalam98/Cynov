using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class Main
    {
        private static CynovContext db = new CynovContext();
        private static string passwordSaved;
        private static List<User> users = new List<User>();
        private static bool hasSession = false;
        private static bool adminSession = false;
        private static int currentUserId = 0;

        public void Start()
        {
            while (true)
            {
                switch (Menu())
                {
                    case 1: SignUp(); break;
                    case 2: SignIn(); break;
                    case 3: Exit(); break;
                }
            }
        }

        static int Menu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Welcome to Cynov !\nMake a choice\n1-Sign up" +
                    "\n2-Sign in\n3-Exit");
                Int32.TryParse(Console.ReadLine(), out choice);
            } while (choice <= 0 || choice > 5);
            return choice;
        }

        static void SignUp()
        {
            User u = new User();

            while (true)
            {
                try
                {
                    Console.WriteLine("Sign Up\n=================");

                    if (u.Username == null)
                    {
                        Console.WriteLine("Username ?");
                        u.Username = Console.ReadLine();
                    }

                    if (u.Email == null)
                    {
                        Console.WriteLine("Email ?");
                        u.Email = Console.ReadLine();
                    }

                    if (u.Password == null)
                    {
                        Console.WriteLine("Password ?");
                        u.Password = Utils.EncodePassword(Console.ReadLine());
                    }
                    break;
                }
                catch (DataException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            db.Users.Add(u);
            db.SaveChanges();
        }

        static void SignIn()
        {
            Console.WriteLine("Sign In\n=================\nEmail ?");
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
            Console.WriteLine("Search ?\n==========================");
            string searchKey = Console.ReadLine();

            ListShowTimes(db.Showtimes.Include("Film").Include("Auditorium").
                Where(s => s.Film.Name.Contains(searchKey) || s.Film.Producer.Contains(searchKey) || s.Film.Director.Contains(searchKey)));

        }

        static void Exit()
        {
            Environment.Exit(0);
        }

        static void GetCreditentials(User u)
        {
            Console.WriteLine("Password ?");
            string inputPass = Console.ReadLine();

            passwordSaved = u.Password;

            if (Utils.DecodePassword(passwordSaved, inputPass))
            {
                hasSession = true;
                currentUserId = u.Id;
                Console.WriteLine(((u.IsAdmin) ? "Admin User" : "Basic User"));
                switch (u.IsAdmin)
                {
                    case true:
                        adminSession = true;
                        Console.WriteLine("You can now add films and showtimes");
                        while (true)
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
                        Console.WriteLine("Make a choice");
                        while (true)
                        {
                            Console.WriteLine("1-Register to a showtime\n2-Search\n" +
                                "3-View my history\n4-Return to menu");
                            int choice;
                            Int32.TryParse(Console.ReadLine(), out choice);

                            switch (choice)
                            {
                                case 1:
                                    RegisterToShowTime();
                                    break;
                                case 2:
                                    Search();
                                    break;
                                case 3:
                                    ViewUserHistory();
                                    break;
                                case 4:
                                    return;
                            }
                        }
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
            Showtime s = new Showtime();

            while(true)
            {
                string finishTimeFinal = "";
                string startTimeFinal = "";
                try
                {
                    Console.WriteLine("Select a film from the list below");
                    ListFilms();
                    int filmChoice;
                    Int32.TryParse(Console.ReadLine(), out filmChoice);


                    s.Film = db.Films.Where(f => f.Id == filmChoice).FirstOrDefault();

                    Console.WriteLine("Then select an auditorium from the list below");
                    ListAuditoriums();

                    int auditoriumChoice;
                    Int32.TryParse(Console.ReadLine(), out auditoriumChoice);

                    s.Auditorium = db.Auditoriums.Where(a => a.Id == auditoriumChoice).FirstOrDefault();

                    Console.WriteLine("Start time (ex: 15/10/2018 - 16:00) ?");
                    string startTime = Console.ReadLine();

                    if (startTime == null || startTime.Length == 0 || s.Start == DateTime.MinValue)
                    {
                        throw new DataException("Incorrect start date format, Retry");
                    }
                    else
                    {
                        startTimeFinal = startTime;
                        s.Start = Utils.StringToDateTime(startTimeFinal);
                     }

                    Console.WriteLine("Finish time (ex: 15/10/2018 - 18:00)?");
                    string finishTime = Console.ReadLine();

                    if (finishTime != null || finishTime.Length > 0 || s.Finish == DateTime.MinValue)
                    {
                        throw new DataException("Incorrect date format, Retry");
                    }
                    else
                    {
                        finishTimeFinal = finishTime;
                        s.Finish = Utils.StringToDateTime(finishTimeFinal);
                    }

                    Console.WriteLine("Is it 3D (y/n) ?");
                    string threeDChoice = Console.ReadLine();
                    Boolean tChoice = threeDChoice == "y" ? true : false;

                    s.ThreeDimensional = tChoice;

                    Console.WriteLine("Is it on Original Version (y/n) ?");
                    string oVChoice = Console.ReadLine();
                    Boolean oChoice = oVChoice == "y" ? true : false;

                    s.OriginalVersion = oChoice;

                    break;
                }catch(DataException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            db.Showtimes.Add(s);
            db.SaveChanges();
            Console.WriteLine("Show added !");
        }

        static void RegisterToShowTime()
        {
            Console.WriteLine("Select a show from the list below");
            ListShowTimes();
            int showChoice;
            Int32.TryParse(Console.ReadLine(), out showChoice);

            User cUser = db.Users.Where(u => u.Id == currentUserId).
                FirstOrDefault();

            Showtime cShowtime = db.Showtimes.Where(s => s.Id == showChoice).
                FirstOrDefault();

            cUser.Showtimes.Add(cShowtime);

            Order o = PrintReceiptTicket(cShowtime);
            cUser.Orders.Add(o);


            PrintTicket(cUser, o);

            if (cShowtime.Auditorium.CurrentCapacity > 0)
            {
                cShowtime.Auditorium.CurrentCapacity -= 1;
            }
            else
            {
                cShowtime.Auditorium.CurrentCapacity = 0;
            }


            db.SaveChanges();

            Console.WriteLine("Show registered for your account !");
        }

        static void ViewUserHistory()
        {
            Console.WriteLine("My orders:\n============================");

            foreach (Order o in db.Orders.Include("User").Where(o=> o.User.Id == currentUserId)) {
                Console.WriteLine(o.OrderId);
            } ;
        }

        static void ListFilms()
        {
            Console.WriteLine("List films (id, name, director, producer, year, type)" +
                "\n========================================================");
            foreach (Film f in db.Films)
            {
                Console.WriteLine($"#{f.Id} - {f.Name} - {f.Director} - " +
                    $"{f.Producer} - {f.ReleaseDate.Year} - {f.Type}");
            }
        }

        static void ListAuditoriums()
        {

            Console.WriteLine("List auditoriums (id, name, capacity)" +
                "\n=========================================");
            foreach (Auditorium a in db.Auditoriums)
            {
                Console.WriteLine($"#{a.Id} - {a.Name} - {a.Capacity}");
            }
        }

        static void ListShowTimes(IEnumerable<Showtime> showtimes = null)
        {
            if (showtimes == null)
            {
                showtimes = db.Showtimes.Include("Film").Include("Auditorium");
            }

            Console.WriteLine("List showtimes (id, film's name, start, finish, 3D, OV, Remaining places)" +
                "\n====================================================================================");
            foreach (Showtime s in showtimes)
            {
                if (s.Start <= DateTime.Now)
                {
                    Console.WriteLine($"#{s.Id} - {s.Film.Name} - {s.Start} - {s.Finish} - " +
                        $"{(s.ThreeDimensional ? "Yes" : "No")} - {(s.OriginalVersion ? "Yes" : "No")} " +
                        $"{(s.Auditorium.CurrentCapacity > 0 ? s.Auditorium.CurrentCapacity.ToString() : "0")}");
                }
                else
                {
                    Console.WriteLine("No showtime");
                }
            }

        }

        static void CreateAuditoriums()
        {
            Auditorium a1 = new Auditorium
            {
                Name = "A1",
                Capacity = 30,
                CurrentCapacity = 30
            };

            Auditorium a2 = new Auditorium
            {
                Name = "A2",
                Capacity = 30,
                CurrentCapacity = 30
            };
            Auditorium b1 = new Auditorium
            {
                Name = "B1",
                Capacity = 50,
                CurrentCapacity = 50
            };
            Auditorium b2 = new Auditorium
            {
                Name = "B2",
                Capacity = 50,
                CurrentCapacity = 50
            };
            Auditorium b3 = new Auditorium
            {
                Name = "B3",
                Capacity = 50,
                CurrentCapacity = 50
            };
            
            db.Auditoriums.Add(a1);
            db.Auditoriums.Add(a2);
            db.Auditoriums.Add(b1);
            db.Auditoriums.Add(b2);
            db.Auditoriums.Add(b3);

            db.SaveChanges();
        }

        
        static Order PrintReceiptTicket(Showtime showTime)
        {
            Order order = new Order
            {
                Showtime = showTime
            };

            db.Orders.Add(order);

            return order;
        }

        static void PrintTicket(User u, Order o)
        {
            string c = DateTime.Now + "\n" + o.OrderId + "\n" + u.Username;
            FileManager.Instance.WriteToFile(DateTime.Now.ToString("yyyyMMdd-HHmmss") + "-" + o.OrderId + u.Username.ToLower(), c);
        }

    }

}
