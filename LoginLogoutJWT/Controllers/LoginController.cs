using LoginLogoutJWT.DatabaseContext;
using LoginLogoutJWT.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginLogoutJWT.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserDbContext _dbb;
        public LoginController(UserDbContext db)
        {
            _dbb = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //[Route("Login")]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        [HttpPost]
        [Route("Login")]
        public Users Login(LoginModel loginInfo)
        {
            if (loginInfo == null)
            {
               // return BadRequest(string.Empty);
            }
            //var result = Customers.Where(temp => temp.Location == "New York").ToList();
            List<Users> temp = _dbb.Users.ToList();
            var user = temp.FirstOrDefault(temp => temp.Email == loginInfo.Email && temp.Password== loginInfo.Password);
           // var pass = temp.First(temp => temp.Password == loginInfo.Password);
            if (user!= null)
            {
                return user ;
            }
            
            Users u=new Users();
            return u;
        }


    }
}
