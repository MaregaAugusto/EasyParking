//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("EasyParking.Views.Login.IniciarSesion.xaml", "Views/Login/IniciarSesion.xaml", typeof(global::EasyParking.Views.Login.IniciarSesion))]

namespace EasyParking.Views.Login {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Login\\IniciarSesion.xaml")]
    public partial class IniciarSesion : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::EasyParking.Components.NavBar navBar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::EasyParking.Custom.CustomEntry entryEmail;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::EasyParking.Custom.CustomEntry entryContraseña;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::EasyParking.Custom.CustomButton btnIniciarSesion;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ActivityIndicator activityIndicator;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(IniciarSesion));
            navBar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::EasyParking.Components.NavBar>(this, "navBar");
            entryEmail = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::EasyParking.Custom.CustomEntry>(this, "entryEmail");
            entryContraseña = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::EasyParking.Custom.CustomEntry>(this, "entryContraseña");
            btnIniciarSesion = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::EasyParking.Custom.CustomButton>(this, "btnIniciarSesion");
            activityIndicator = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ActivityIndicator>(this, "activityIndicator");
        }
    }
}
