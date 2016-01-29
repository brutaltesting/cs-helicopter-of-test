namespace HelicopterOfTest.Helicopters.Controllers
{
    public interface ISignupController : IController
    {
        void Signup(string username, string password);
    }
}
