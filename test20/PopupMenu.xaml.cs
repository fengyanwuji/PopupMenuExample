using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test20
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupMenu : PopupPage
    {
        private List<ToolbarItemModel> MenuItems { get; set; }
        public PopupMenu(List<ToolbarItemModel> data)
        {
            InitializeComponent();
            MenuItems = data;
        }

        public class ToolbarItemModel
        {
            //public string Icon { get; set; }

            public string MenuText { get; set; }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SecondaryToolbarListView.ItemsSource = MenuItems;
            SecondaryToolbarListView.HeightRequest = MenuItems.Count * 37;
        }

        protected override void OnAppearingAnimationBegin()
        {
            base.OnAppearingAnimationBegin();
            //CloseImage.TranslationY = -10;
            //MainLayout.RaiseChild(CloseImage);
        }


        protected override bool OnBackgroundClicked()
        {
            CloseAllPopup();

            return false;
        }

        private async void CloseAllPopup()
        {
            await PopupNavigation.Instance.PopAllAsync();
        }

        async void SecondaryToolbarListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("提醒", "功能正在测试中...", "确定");
        }
    }
}
