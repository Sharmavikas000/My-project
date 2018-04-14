using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;


namespace Settings
{
    public class ControllerFactory : DefaultControllerFactory
    {

        //private Type _defaultControllerType;
        //public ControllerFactory(Type defaultControllerType)
        //{
        //    _defaultControllerType = defaultControllerType;
        //}

        //protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        //{
        //    try
        //    {
        //        return (IController)ObjectFactory.GetInstance(controllerType);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //    //return base.GetControllerInstance(requestContext, controllerType);
        //}
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            try
            {
                return (IController)ObjectFactory.GetInstance(controllerType);
            }
            catch   
            {
                throw new HttpException(404, "Not found exception");
                
            }
        }

    }
}
