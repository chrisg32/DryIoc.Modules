using System;

namespace DryIoc.Modules
{
    public interface IModule
    {
        void RegisterTypes(IRegistrator container);
    }
}
