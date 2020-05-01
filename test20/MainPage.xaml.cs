using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using static test20.PopupMenu;

namespace test20
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private PopupMenu _popupMenu;

        public MainPage()
        {
            InitializeComponent();
            
            var items = new List<ToolbarItemModel>
            {
                new ToolbarItemModel { MenuText = "\ue801 发起群聊"},
                new ToolbarItemModel { MenuText = "\ue606 注册审核"},
                new ToolbarItemModel { MenuText = "\ue655 网络地址"},
                new ToolbarItemModel { MenuText = "\ue602 显示密码"}
            };

            _popupMenu = new PopupMenu(items);
        }

        #region Overrides

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //this.ToolbarItems.Clear();
            //foreach (var toolBarItem in GetToolBarItems().ToList())
            //{
            //    this.ToolbarItems.Add(toolBarItem);
            //}
        }

        #endregion


        //private IList<ToolbarItem> GetToolBarItems()
        //{
        //    var list = new List<ToolbarItem>();
        //    list.Add(new ToolbarItem("第一","", () =>
        //    {
        //        Device.BeginInvokeOnMainThread(() =>
        //        {
        //            DisplayAlert("提示", "抱歉,功能稍后开放...", "取消");
        //        });
        //    }, ToolbarItemOrder.Primary, 0));
        //    list.Add(new ToolbarItem("第二","", () =>
        //    {
        //        Device.BeginInvokeOnMainThread(async () =>
        //        {
        //            await PopupNavigation.Instance.PushAsync( _popupMenu);
        //        });
        //    }, ToolbarItemOrder.Primary, 1));

        //    return list;
        //}

        async void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(_popupMenu);
        }
    }
}
