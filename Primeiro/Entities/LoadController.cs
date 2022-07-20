using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Entities
{
    abstract class LoadController
    {
        public abstract void Rodar();        
    }


    class LoaderAction
    {
        public string Title { get; set; }
        public string Controller { get; set; } = "";

        public LoaderAction(string title, string controller)
        {
            Title = title;
            Controller = controller;
        }

        public object CreateInstance()
        {
            // scan for the class type            
            var type = Type.GetType(Controller);

            if (type == null)
                throw new InvalidOperationException("Type not found");

            return Activator.CreateInstance(type);
        }
    }
}
