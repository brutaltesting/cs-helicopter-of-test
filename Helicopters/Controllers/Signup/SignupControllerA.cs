using System;

namespace HelicopterOfTest.Helicopters.Controllers.Signup
{
    public class SignupControllerA : Controller, ISignupController
    {

        public void Signup(string username, string password)
        {
            Console.WriteLine("This is where the Signup should be implemented");
            Console.WriteLine("Signing up (controller) {0} with password {1}", username, password);
            Simulator.GetSignupView().Signup(username, password);
        }
    }
}

