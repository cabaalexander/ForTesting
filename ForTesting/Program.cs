using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using SoapAPIClient;
using Newtonsoft.Json.Serialization;

namespace ForTesting
{
    class Program
    {
        #region Props
        private const string _emailRE = @"^[\w]+@(?:live|outlook|hotmail|gmail|yahoo)\.com|es$";
        #endregion

        static void Main(string[] args)
        {
            #region Deserializing
//            var parent = new Parent();
//            parent.FirstName = "Padre First Name";
//            parent.LastName = "Padre Last Name";
//            parent.Age = 30;
//            
//            var child = new Child();
//            child.FirstName = "Child First Name";
//            child.LastName = "Child Last Name";
//            child.Age = 23;
//            child.Games = "LoL";
//            child.SocialNetwork = "Fb";
//            child.Music = "Metal";
//
//            var parentJson = JsonConvert.SerializeObject(parent);
//
//            var newChild = JsonConvert.DeserializeObject<Child>(parentJson);
//
//            Console.WriteLine("::Put a BreakPoint Here and Debug::"); //This line is for Debugging purpose
            #endregion

            #region Cast(ing)
//            var parent = new Parent();
//            parent.FirstName = "Padre First Name";
//            parent.LastName = "Padre Last Name";
//            parent.Age = 30;
//
//            var child = new Child();
//            child.FirstName = "Child First Name";
//            child.LastName = "Child Last Name";
//            child.Age = 23;
//            child.Games = "LoL";
//            child.SocialNetwork = "Fb";
//            child.Music = "Metal";
//
//            Child casted = (Child) parent;
//
//            Console.WriteLine("Something...");
//            Console.WriteLine("==>>" + casted.FirstName + "<<==");
            #endregion

            #region Dictionary Example
            //Dictionary<string, int> myDict = new Dictionary<string, int>()
            //{
            //    { "one", 1 },
            //    { "two", 2 },
            //    { "three", 3 },
            //    { "four", 4 }
            //};
            //myDict.Add("five", 5);

            //Console.Write(myDict.Values);
            #endregion

            #region Regular Expression - Validation
            //Regex email_RE = new Regex(@"^[a-zA-Z]+@[a-zA-Z]+\.[a-zA-Z]+$");
            //Regex date_RE = new Regex(@"^(0?[1-9]|1[0-2])(/|-)(19|2[0-1])\d{2}$");

            //var result_Email = email_RE.Match("A@A.A");
            //var result_Date = date_RE.IsMatch("12/2015");

            //if (result_Email.Success)
            //{
            //    Console.WriteLine(result_Email);
            //}
            //else
            //{
            //    Console.WriteLine("Email Fail");
            //}

            //if (result_Date)
            //{
            //    Console.WriteLine(result_Date);
            //}
            //else
            //{
            //    Console.WriteLine("Date Fail");
            //}
            #endregion

            #region Regular Expression - Parsing
            //Regex RE_elements = new Regex(@"<element>(.+)</element>");

            //string htmlForm = "<body>\n" +
            //                       "\t<element>[1, 2, 3, 4]</element>\n" +
            //                       "\t<element>2</element>\n" +
            //                       "\t<element>3</element>\n" +
            //                  "</body>";

            //var result = RE_elements.Matches(htmlForm);

            //foreach (Match matched in result)
            //{
            //    Console.WriteLine(matched.Groups[1]);
            //}
            #endregion

            #region API - Soap
            //ConsumingGeoAPIService client = new ConsumingGeoAPIService("190.166.41.152");

            //Console.WriteLine("IP: \t\t{0}\nCountry Name: \t{1}\nCountry Code: \t{2}",
            //                    client.IP, client.CountryName, client.CountryCode);
            #endregion

            #region Random
            //Console.Clear();
            //var body = String.Format("Contact information: \n\nName:  ".Replace("\n", "<br />"));
            //Console.WriteLine(body);
            #endregion

            #region String Split
            //string needToSplit = "n-alexander-de-la-cruz-caba#10762";
            //string[] splitted = needToSplit.Split('#');

            //foreach (string item in splitted)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.Write("Just the second Element(the ID): {0}", splitted[1]);
            #endregion

            #region Random
            //string asdf = "";

            //if (!String.IsNullOrEmpty(asdf))
            //{
            //    Console.WriteLine("Not Empty");
            //}
            //else
            //{
            //    Console.WriteLine("Empty");
            //}
            #endregion

            #region Generics
//            var result = MyGenericMethod<int>(5);
//
//            Console.WriteLine("Value:\t{0}\nType:\t{1}", result, result.GetType());

//            var list = new MyIntList<double>();
//            list.Add(1.4);
//            list.Add(2);
//            list.Add(3);
//
//            list.Show();
//            var perro = new Dog();
//            perro.Speak<int>(23);
            #endregion

            #region Reflection

            #region First Part
//            var assembly = Assembly.GetExecutingAssembly();
//            Console.WriteLine(assembly.FullName);
//            Console.WriteLine();
//            
//            var types = assembly.GetTypes();
//            foreach (var type in types)
//            {
//                Console.WriteLine("> Type: {0}\t> Base Type:\t{1}", type, type.BaseType);
//
//                var props = type.GetProperties();
//                foreach (var prop in props)
//                {
//                    Console.WriteLine("\t* Property:\t{0},   \t* Property Type:\t{1}", prop.Name, prop.PropertyType);
//                }
//
//                var fields = type.GetFields();
//                foreach (var field in fields)
//                {
//                    Console.WriteLine("\t* Field:   \t{0},    \t* Field Type:   \t{1}", field.Name, field.FieldType);
//                }
//
//                var methods = type.GetMethods();
//                foreach (var method in methods)
//                {
//                    Console.WriteLine("\t* Method:  \t{0},   \t* Return Type:  \t{1}", method.Name, method.ReturnType);
//                }
//            }
//            Console.WriteLine();
//
//            var sample = new Sample{ Name = "John", Age = 25 };
//
//            var sampleType = typeof (Sample);
//            var nameProperty = sampleType.GetProperty("Name");
//
//            var myMethod = sampleType.GetMethod("MyMethod");
//
//
//            nameProperty.SetValue(sample, "Now Not John"); //changing the name of the property
//
//            Console.WriteLine("Name: " + sampleType.Name);
//
//            Console.WriteLine("Property: " + nameProperty.GetValue(sample));
//            myMethod.Invoke(sample, null);
            #endregion //first part end

            #region Second Part
//            var assembly = Assembly.GetExecutingAssembly();
//
//            var types = assembly.GetTypes().Where(x => x.GetCustomAttributes<MyClassAttribute>().Any());
//
//            foreach (var type in types)
//            {
//                Console.WriteLine(type.Name);
//
//                var methods = type.GetMethods().Where(x => x.GetCustomAttributes<MyMethodAttribute>().Any());
//
//                foreach (var method in methods)
//                {
//                    Console.WriteLine(method.Name);
//                }
//            }
            #endregion //second part end

            #endregion //reflection end

            #region Testing OleDB Connection for FoxPro
//            VisualFoxProConnection vfcon = new VisualFoxProConnection();
//            Console.Write(vfcon.selectProyecto());
            #endregion

            #region Directory IO Test
//            Console.WriteLine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()));
            #endregion

            #region Email(ing)
//            var source = GetValidSource();
//            var password = GetPassword();
//            var destination = GetValidDestination();
//                if (destination == "exit") return;
//            const string subject = "Important :: Subject";
//            var body = string.Format("Hello, {0}<br />This is someting.<br /><br />Bye.", destination);
//
//            try
//            {
//                var message = new MailMessage();
//                message.From = new MailAddress(source);
//                message.To.Add(destination);
//                message.Subject = subject;
//                message.Body = body;
//                message.IsBodyHtml = true;
//
//                var sourceSmtpService = Regex.Match(source, @"@(.+)\.").Value;
//                sourceSmtpService = ValidSmtpService(sourceSmtpService);
//
//                var client = new SmtpClient
//                {
//                    Host = string.Format("smtp.{0}.com", sourceSmtpService),
//                    EnableSsl = true,
//                    Port = 587,
//                    Credentials = new NetworkCredential(source, password)
//                };
//                client.Send(message);
//            }
//            catch (SmtpException e)
//            {
//                Console.WriteLine(e);
//            }
//            finally
//            {
//                Console.Clear();
//                Console.WriteLine("Email Sent to {0}.", destination);
//            }
            #endregion

            #region NamedValues
            //no implementation
            #endregion

            #region ... Readkey ...
            //This is for pause the console at the end of the functionality
            Console.ReadKey();
            #endregion
        }

        #region Auxiliar Methods - Email(ing)
        private static string ValidSmtpService(string service)
        {
            var smtpServers = new Dictionary<string, string>()
            {
                {"live", "live"},
                {"outlook", "live"},
                {"hotmail", "live"},
                {"gmail", "gmail"},
                {"yahoo", "mail.yahoo"}
            };
            string result;
            smtpServers.TryGetValue(service.Substring(1, service.Length - 2), out result);

            return result;
        }

        private static string GetValidDestination()
        {
            bool emailValid = false;
            var destination = string.Empty;
            do
            {
                Console.Write("Destination Email: ");
                destination = Console.ReadLine();
                Console.Clear();

                emailValid = Regex.Match(destination, _emailRE).Success;

                if (destination.ToLower() == "exit") return "exit";
            } while (!emailValid);

            Console.WriteLine("Please Wait...");
            return destination;
        }

        public static string GetValidSource()
        {
            var source = string.Empty;
            var emailValid = false;

            do
            {
                Console.Clear();
                Console.Write("Source Email: ");
                source = Console.ReadLine();

                emailValid = Regex.Match(source, _emailRE).Success;
            } while (!emailValid);
            return source;
        }

        public static string GetPassword()
        {
            Console.Write("Password: ");
            var result = Console.ReadLine();
            Console.Clear();
            return result;
        }
        #endregion

        #region Auxiliar Methods - Generics
        public static T MyGenericMethod<T>(T value)
        {
            return value;
        }
        #endregion
    }

    #region Auxiliar Clases - Deserializing/Cast(ing)
    public class Parent
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Age { get; set; }
    }

    public class Child : Parent
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Age { get; set; }
        public virtual string Games { get; set; }
        public virtual string SocialNetwork { get; set; }
        public virtual string Music { get; set; }
    }
    #endregion

    #region Auxiliar Clases - Generics
    public class MyIntList<T>
    {
        private T[] myInts;
        private int count;

        public MyIntList()
        {
            myInts = new T[5];
            count = 0;
        }

        public void Add(T value)
        {
            if (count >= 5)
            {
                return;
            }
            myInts[count] = value;
            count++;
        }

        public void Show()
        {
            foreach (var myInt in myInts)
            {
                Console.WriteLine(myInt);
            }
        }
    }

    public static class AnimalExtensions
    {
        public static string get_name(this Animal animal)
        {
            return animal.Name;
        }

        public static string get_name(this string animal)
        {
            return "sutff";
        }

    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Dog : Animal
    {
        public string Owner { get; set; }
        public string Type { get; set; }

        public void Speak<T>(T value)
        {
            Console.WriteLine((value as Dog).Owner);
        }
    }
    #endregion

    #region Auxiliar Clases - Reflection
    [MyClass]
    public class Sample
    {
        public string Name { get; set; }
        public int Age;

        [MyMethod]
        public void MyMethod()
        {
            Console.WriteLine("Hello From MyMethod");
        }

        public void NoAttributeMethod() { }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MyClassAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Method)]
    public class MyMethodAttribute : Attribute { }
    #endregion
}