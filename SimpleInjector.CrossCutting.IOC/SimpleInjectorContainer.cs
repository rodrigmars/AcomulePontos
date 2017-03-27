namespace SimpleInjector.CrossCutting.IOC
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            container.Register<IClienteService, ClienteService>();

            container.Verify();

            return container; 
        }
    }
}
