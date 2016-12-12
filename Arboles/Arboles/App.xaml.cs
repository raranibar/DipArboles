using Prism.Unity;
using Arboles.Views;

namespace Arboles
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("RootNavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {            
            Container.RegisterTypeForNavigation<RootNavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();                        
            Container.RegisterTypeForNavigation<ListaArbolPage>();            
            Container.RegisterTypeForNavigation<RegistraArbolPage>();
        }
    }
}
