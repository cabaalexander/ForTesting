using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JwtDotNet
{
    class Program
    {
        private const string secretKey = "027f3987b98d33c125dbc3938612c20977073507f5ed180b9208ee6f7e70427b";

        static void Main(string[] args)
        {
            var tokenCreated = CreateJwtToken("Fulano", 42);
            var tokenVerified = VerifyToken(tokenCreated);

//            Console.WriteLine(string.Format("Token Created ▼\n\n\t:: {0} ::\n\n\t:: {1} ::\n\n\t:: {2} ::", tokenCreated.Split('.')));
            Console.WriteLine(string.Format("Token Created ▼\n\n\t{0}", tokenCreated)); //no split
            Console.WriteLine(string.Format("\n\nVerified Token ▼\n\n\t{0}\n\n", tokenVerified));

            try
            {
                var payload = JWT.JsonWebToken.DecodeToObject(tokenCreated, secretKey) as Dictionary<string, object>;
                Console.WriteLine(string.Format("Deserialized Token Created ▼\n\n\tName: \t\t\t{0}\n\tLast Name: \t\t{1}\n" +
                "\tExpiration Date: \t{2}\n\tIs Admin: \t\t{3}\n\n", payload["name"], payload["lastName"], payload["exp"], payload["userIsAdmin"]));
            }
            catch (Exception e)
            {
                Console.WriteLine("Deserialized Token Created ▼\n\n{0}\n\n", e);
            }
        }

        private static string CreateJwtToken(string name, int expSecs = 0)
        {
            if (expSecs == 0)
                expSecs = 60*10;
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var now = Math.Round((DateTime.UtcNow - unixEpoch).TotalSeconds + expSecs);
            var payload = new Dictionary<string, object>()
                {
                    { "name", name },
                    { "lastName", "FulanoLastName" },
                    { "userIsAdmin", true},
                    { "exp", now}
                };
            var token = JWT.JsonWebToken.Encode(payload, secretKey, JWT.JwtHashAlgorithm.HS256);

            return token;
        }

        private static string VerifyToken(string token)
        {
            try
            {
                var jsonPayload = JWT.JsonWebToken.Decode(token, secretKey);
                return jsonPayload;
            }
            catch (Exception e)
            {
                return string.Format("Invalid token!\n\n{0}\n\n", e);
            }
        }
    }
}
