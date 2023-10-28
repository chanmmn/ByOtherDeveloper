using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISecurity.Models
{
    public class UserRepository : IDisposable
    {
        // SECURITY_DBEntities it is your context class
        UserEntities context = new UserEntities();
        //This method is used to check and validate the user credentials
        public User ValidateUser(string username, string password)
        {
            return context.Users.FirstOrDefault(user =>
            user.Name.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.Password == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}