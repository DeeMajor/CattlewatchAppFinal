using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CattleMobile.Services
{
    public class ApiServices
    {
        public async Task RegisterAsync(string email, string password, string confirmPassword)
        {
            var clinet = new HttpClient();
        }
    }
}
