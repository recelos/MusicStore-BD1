using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public static class ControllerFactory
    {
        public static CreateUserController CreateCreateUserController()
        {
            return new CreateUserController();
        }

        public static LoginController CreateLoginController()
        {
            return new LoginController();
        }

        public static UserController CreateUserController()
        {
            return new UserController();
        }

    }
}
