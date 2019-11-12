namespace DryIoc.Modules
{
    public static class Extensions
    {
        public static void RegisterModule<TModule>(this IContainer container) where TModule : IModule
        {
            container.Register<TModule>();
            var module = container.Resolve<TModule>();
            module.RegisterTypes(container);
        }
    }
}
