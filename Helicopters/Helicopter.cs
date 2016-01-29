using System.Collections.Generic;
using HelicopterOfTest.Helicopters.Controllers;
using HelicopterOfTest.Helicopters.Web.Views;
using HelicopterOfTest.Helicopters.Web.Views.LoginAndSignup;

namespace HelicopterOfTest.Helicopters
{
    public class Helicopter
    {
        protected Dictionary<ControllerTypes.ControllerType, IController> ControllerHolder = new Dictionary<ControllerTypes.ControllerType, IController>();
        protected Dictionary<ViewTypes.ViewType, IView> ViewHolder = new Dictionary<ViewTypes.ViewType, IView>();

        public IController GetController(ControllerTypes.ControllerType controllerType)
        {
            return (IController) ControllerHolder[controllerType];
        }

        public void AddController(ControllerTypes.ControllerType ctrlType, Controller ctrler)
        {
            ctrler.Simulator = this;
            ControllerHolder.Add(ctrlType, ctrler);
        }

        public ISignupController GetSignupController()
        {
            return (ISignupController) GetController(ControllerTypes.ControllerType.Signup);
        }

        public IView GetView(ViewTypes.ViewType viewType)
        {
            return ViewHolder[viewType] as IView;
        }

        public void AddView(ViewTypes.ViewType viewType, View view)
        {
            view.Simulator = this;
            ViewHolder.Add(viewType, view);
        }

        public ISignupView GetSignupView()
        {
            return (ISignupView) GetView(ViewTypes.ViewType.Signup);
        }

    }
}
