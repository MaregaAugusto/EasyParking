//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("EasyParking.Views.MisVehiculos.PopupMisVehiculos.xaml", "Views/MisVehiculos/PopupMisVehiculos.xaml", typeof(global::EasyParking.Views.MisVehiculos.PopupMisVehiculos))]

namespace EasyParking.Views.MisVehiculos {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\MisVehiculos\\PopupMisVehiculos.xaml")]
    public partial class PopupMisVehiculos : global::Rg.Plugins.Popup.Pages.PopupPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.ListView.XForms.SfListView lwlistado;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::EasyParking.Custom.CustomButton btnCancelar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(PopupMisVehiculos));
            lwlistado = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.ListView.XForms.SfListView>(this, "lwlistado");
            btnCancelar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::EasyParking.Custom.CustomButton>(this, "btnCancelar");
        }
    }
}
