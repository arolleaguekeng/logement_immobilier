
using LogementImobilier.BO;
using LogementImobilier.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BLL
{
    public class UserManager
    {
        
        public UserRepository repository;
        public UserManager()
        {
            repository = new UserRepository();
        }
        public void  CreateUser(User user)
        {
            repository.Add(user);
            repository.Save();
        }
        public void AddUser(User user)
        {
           repository.Add(user);
            repository.Save();

        }
        public void EditUser(User user , User newUser)
        {
            repository.Set(user, newUser);
        }
        
        public User LoginUser(string email , string password)
        {
            return repository.Login(email,password);
        }

        public void DeleteUser(User user)
        {
            repository.Delete(user);
        }

        public List<User> GetAllUsers()
        {
            return repository.GetAll();
        }
        public  string Md5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x5"));
            }
            return stringBuilder.ToString();
        }

        public void SaveUser()
        {
            repository.Save();
        }
    }
}
