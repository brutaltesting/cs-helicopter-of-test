using HelicopterOfTest.Helicopters.Controllers;
using HelicopterOfTest.Helicopters.Controllers.Signup;
using HelicopterOfTest.Helicopters.Web.Views;
using HelicopterOfTest.Helicopters.Web.Views.LoginAndSignup;

namespace HelicopterOfTest.Helicopters
{
    public class HelicopterFactory
    {
        public static Helicopter GetDefaultHelicopter() { 
            var helicopter = new Helicopter();

            helicopter.AddController(ControllerTypes.ControllerType.Signup, new SignupControllerA());
            helicopter.AddView(ViewTypes.ViewType.Signup, new SignupPage());
            return helicopter;
        }
    }
}
