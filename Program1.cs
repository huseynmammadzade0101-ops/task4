namespace lesson4_;


// 1 ci tapsirig
// class WebSite
// {
//     public string? site_Name;
//     public string? Site_Path { get; set; }
//     public string? Site_Description { get; set; }
//     private string? site_Ip;

//     public WebSite()
//     {
//     }
//     public WebSite(string? site_Name, string? site_Path, string? site_Description, string? site_Ip)
//     {
//         Site_Name = site_Name;
//         Site_Path = site_Path;
//         Site_Description = site_Description;
//         Site_Ip = site_Ip;
//     }

//     public string? Site_Name
//     {
//         get { return site_Name; }
//         set
//         {
//             if (value.Length >= 3)
//                 Site_Name = value;
//             else
//                 throw new Exception("Wrong name input!!!");
//         }

//     }
//     public string? Site_Ip
//     {
//         get { return site_Ip; }
//         set
//         {
//             if (value != null && value.Length > 6)
//             {
//                 site_Ip = value;
//             }

//             else
//                 throw new Exception("Wrong IP address!!!");
//         }

//     }
//     public void Input()
//     {
//         Console.Write("Site name: ");
//         Site_Name = Console.ReadLine();

//         Console.Write("Site path: ");
//         Site_Path = Console.ReadLine();

//         Console.Write("Site description: ");
//         Site_Description = Console.ReadLine();

//         Console.Write("Site IP: ");
//         Site_Ip = Console.ReadLine();

//     }

//     public void Show()
//     {
//         Console.WriteLine($"site name: {this.site_Name}");
//         Console.WriteLine($"site path: {this.Site_Path}");
//         Console.WriteLine($"site description: {this.Site_Description}");
//         Console.WriteLine($"site IP: {this.Site_Ip}");
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             WebSite website = new WebSite();
//             website.Input();
//             website.Show();
//         }
//     }

// }











// 2 ci tapsrig
// class Magazine
// {
//     private string? magazine_Name;
//     private int foundation_Year;
//     private string? magazine_Information;
//     private string? phone_Number;
//     private string? email;

//     public Magazine()
//     {
//     }

//     public Magazine(string? magazine_Name, int foundation_Year, string? magazine_Information, string? phone_Number, string? email)
//     {
//         Magazine_Name = magazine_Name;
//         Foundation_Year = foundation_Year;
//         Magazine_Information = magazine_Information;
//         Phone_Number = phone_Number;
//         Email = email;
//     }

//     public string? Magazine_Name
//     {
//         get { return magazine_Name; }
//         set
//         {
//             if (value.Length >= 3)
//                 magazine_Name = value;
//             else
//                 throw new Exception("Wrong magazine name!!!");
//         }
//     }

//     public int Foundation_Year
//     {
//         get { return foundation_Year; }
//         set
//         {
//             if (value > 0)
//                 foundation_Year = value;
//             else
//                 throw new Exception("Wrong foundation year!!!");
//         }
//     }

//     public string? Magazine_Information
//     {
//         get { return magazine_Information; }
//         set
//         {
//             if (value.Length >= 5)
//                 magazine_Information = value;
//             else
//                 throw new Exception("Wrong magazine information!!!");
//         }
//     }

//     public string? Phone_Number
//     {
//         get { return phone_Number; }
//         set
//         {
//             if (value.Length >= 7)
//                 phone_Number = value;
//             else
//                 throw new Exception("Wrong phone number!!!");
//         }
//     }

//     public string? Email
//     {
//         get { return email; }
//         set
//         {
//             if (value.Contains("@"))
//                 email = value;
//             else
//                 throw new Exception("Wrong email address!!!");
//         }
//     }

//     public void Input()
//     {
//         Console.Write("Magazine name: ");
//         Magazine_Name = Console.ReadLine();

//         Console.Write("Foundation year: ");
//         Foundation_Year = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Magazine information: ");
//         Magazine_Information = Console.ReadLine();

//         Console.Write("Phone number: ");
//         Phone_Number = Console.ReadLine();

//         Console.Write("Email: ");
//         Email = Console.ReadLine();
//     }

//     public void Show()
//     {
//         Console.WriteLine($"Magazine name: {this.magazine_Name}");
//         Console.WriteLine($"Foundation year: {this.foundation_Year}");
//         Console.WriteLine($"Magazine information: {this.magazine_Information}");
//         Console.WriteLine($"Phone number: {this.phone_Number}");
//         Console.WriteLine($"Email: {this.email}");
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Magazine magazine = new Magazine();
//             magazine.Input();
//             magazine.Show();
//         }
//     }
// }