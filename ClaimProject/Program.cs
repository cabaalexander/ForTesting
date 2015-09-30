using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClaimProject
{
    class Program
    {
        static void Main(string[] args)
        {
//            Setup();
////            CheckCompatibility();
//            CheckNewClaimsUsage();
        }

        private static void Setup()
        {
            var claimCollection = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "Andras"),
                new Claim(ClaimTypes.Country, "Sweden"),
                new Claim(ClaimTypes.Gender, "M"),
                new Claim(ClaimTypes.Surname, "Nemes"),
                new Claim(ClaimTypes.Email, "hello@me.com"),
                new Claim(ClaimTypes.Role, "IT"),
                new Claim("ASDF", "1234")
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claimCollection, "My e-commerce website", ClaimTypes.Email, ClaimTypes.Role);

            Console.WriteLine(claimsIdentity.IsAuthenticated);

            ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
            Thread.CurrentPrincipal = principal;
        }

        private static void CheckCompatibility()
        {
            IPrincipal currentPrincipal = Thread.CurrentPrincipal;
            Console.WriteLine(currentPrincipal.Identity.Name);
            Console.WriteLine(currentPrincipal.IsInRole("IT"));
        }

        private static void CheckNewClaimsUsage()
        {
            ClaimsPrincipal currentClaimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;
            Claim nameClaim = currentClaimsPrincipal.FindFirst(ClaimTypes.Name);
            var identities = currentClaimsPrincipal.FindAll(ClaimTypes.Name);
            foreach (var item in identities)
            {
                Console.WriteLine(item);
            }
//            Console.WriteLine(nameClaim);
        }
    }
}
