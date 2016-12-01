using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Domain;
using DomainModel;
using DomainModel.Models;

namespace Services
{
   public class StationLocal
    {
        public IUnitOfWork u;

        public  StationLocal(IUnitOfWork uu)
        {

            u = uu;

        }
        public StationLocal()
        {
            u = Scope.Resolve<IUnitOfWork>();


        }
        public static ILifetimeScope Scope;
        public static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        public bool logAdmin(string emailText, string passwordText)
        {
            User uz;
            emailText = emailText.ToLower();
            passwordText = GetStringSha256Hash(passwordText);
            {
                
                uz=u.UsersRepository.Find(
                        p => p.Email == emailText && p.PassWord == passwordText && p.PhoneNo == "admin")
                    .FirstOrDefault();
            }
            return uz!= null;
        }
    }
}
