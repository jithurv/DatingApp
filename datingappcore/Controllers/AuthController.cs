using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using datingappcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace datingappcore.Controllers {
    [Route ("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase {

        [HttpPost]
        public ActionResult<AuthResponse> Login (authlogin login) {
            var returnValue = new AuthResponse ();
            if (login.Username == "bob" && login.Password == "12345") {
                returnValue.Token = EnryptString ("SUCCESS123");
                return returnValue;
            }
            return null;
        }
        private string DecryptString (string encrString) {
            byte[] b;
            string decrypted;
            try {
                b = Convert.FromBase64String (encrString);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString (b);
            } catch (FormatException fe) {
                decrypted = "";
            }
            return decrypted;
        }

        private string EnryptString (string strEncrypted) {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes (strEncrypted);
            string encrypted = Convert.ToBase64String (b);
            return encrypted;
        }
    }
}