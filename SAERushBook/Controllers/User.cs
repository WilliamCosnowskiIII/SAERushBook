using System;
using Microsoft.AspNetCore.Mvc;

namespace SAERushBook.Controllers
{
	public class User : Controller
	{
		private string username;
		private string password;
		private string email;

		public User(string username, string password, string email)
		{

			this.username = username;
			this.password = password;
			this.email = email;

		}

        public string getEmail()
        {
			return this.email;
        }

        public string getPassword()
        {
			return this.password;
        }

        public string getUsername() { return this.username;  }


	}
}

