using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IdentityModel.Tokens;
using System.Security.Claims;

namespace JwtProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var publicAndPrivate = new RSACryptoServiceProvider();
            var keyGenerationResult = GenerateRsaKeys();

            publicAndPrivate.FromXmlString(keyGenerationResult.PublicAndPrivateKey);
            var jwtToken = new JwtSecurityToken(
                issuer: "http:/issuer.com",
                audience: "http:/mysite.com",
                claims: new List<Claim>() { new Claim(ClaimTypes.Name, "Andras Nemes") },
                expires: DateTime.UtcNow.AddHours(5),
                signingCredentials: new SigningCredentials(new RsaSecurityKey(publicAndPrivate), SecurityAlgorithms.RsaSha256Signature, SecurityAlgorithms.Sha1Digest)
            );

            var tokenHandler = new JwtSecurityTokenHandler();
            string tokenString = tokenHandler.WriteToken(jwtToken);

            Console.WriteLine(string.Format("Token:\n\n>>{0}<<\n\n>>{1}<<\n\n>>{2}<<", tokenString.Split('.')));
        }

        private static RsaKeyGenerationResult GenerateRsaKeys()
        {
            var myRSA = new RSACryptoServiceProvider(2048);
            var publicKey = myRSA.ExportParameters(true);
            var result = new RsaKeyGenerationResult();
            result.PublicAndPrivateKey = myRSA.ToXmlString(true);
            result.PublicKeyOnly = myRSA.ToXmlString(false);
            return result;
        }
    }
}
