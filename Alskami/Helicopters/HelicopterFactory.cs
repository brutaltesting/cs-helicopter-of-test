using HelicopterOfTestProject.Alskami.Helicopters.Controllers;
using HelicopterOfTestProject.Alskami.Helicopters.Controllers.Signup;
using HelicopterOfTestProject.Alskami.Helicopters.Web.Views;
using HelicopterOfTestProject.Alskami.Helicopters.Web.Views.LoginAndSignup;

namespace HelicopterOfTestProject.Alskami.Helicopters
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
