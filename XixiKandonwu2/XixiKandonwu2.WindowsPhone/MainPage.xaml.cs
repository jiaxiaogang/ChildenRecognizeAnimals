using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace XixiKandonwu2
{
    /// <summary>
    /// 可独立使用或用于导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DonWu donwu = null;
        public bool b = true;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。
        /// 此参数通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.New)
            {
                List<DonWu> list = new List<DonWu>();
                list.Add(new DonWu { Name = "狗", ImgPath = "ms-appx:///images/gou.jpg", Jiao = "ms-appx:///Musics/gou.mp3", JiaoName = "ms-appx:///MusicName/gou.mp3" });
                list.Add(new DonWu { Name = "猫", ImgPath = "ms-appx:///images/mao.jpg", Jiao = "ms-appx:///Musics/mao.mp3", JiaoName = "ms-appx:///MusicName/mao.mp3" });
                list.Add(new DonWu { Name = "豹", ImgPath = "ms-appx:///images/bao.jpg", Jiao = "ms-appx:///Musics/bao.mp3", JiaoName = "ms-appx:///MusicName/bao.mp3" });
                list.Add(new DonWu { Name = "虎", ImgPath = "ms-appx:///images/hu.jpg", Jiao = "ms-appx:///Musics/hu.mp3", JiaoName = "ms-appx:///MusicName/hu.mp3" });
                list.Add(new DonWu { Name = "鸡", ImgPath = "ms-appx:///images/ji.jpg", Jiao = "ms-appx:///Musics/ji.mp3", JiaoName = "ms-appx:///MusicName/ji.mp3" });
                list.Add(new DonWu { Name = "马", ImgPath = "ms-appx:///images/ma.jpg", Jiao = "ms-appx:///Musics/ma.mp3", JiaoName = "ms-appx:///MusicName/ma.mp3" });
                list.Add(new DonWu { Name = "鸟", ImgPath = "ms-appx:///images/niao.jpg", Jiao = "ms-appx:///Musics/niao.mp3", JiaoName = "ms-appx:///MusicName/niao.mp3" });
                list.Add(new DonWu { Name = "牛", ImgPath = "ms-appx:///images/niu.jpg", Jiao = "ms-appx:///Musics/niu.mp3", JiaoName = "ms-appx:///MusicName/niu.mp3" });
                list.Add(new DonWu { Name = "狮", ImgPath = "ms-appx:///images/si.jpg", Jiao = "ms-appx:///Musics/si.mp3", JiaoName = "ms-appx:///MusicName/si.mp3" });
                list.Add(new DonWu { Name = "兔", ImgPath = "ms-appx:///images/tu.jpg", Jiao = "ms-appx:///Musics/tu.mp3", JiaoName = "ms-appx:///MusicName/tu.mp3" });
                list.Add(new DonWu { Name = "象", ImgPath = "ms-appx:///images/xian.jpg", Jiao = "ms-appx:///Musics/xian.mp3", JiaoName = "ms-appx:///MusicName/xian.mp3" });
                list.Add(new DonWu { Name = "鸭", ImgPath = "ms-appx:///images/ya.jpg", Jiao = "ms-appx:///Musics/ya.mp3", JiaoName = "ms-appx:///MusicName/ya.mp3" });
                list.Add(new DonWu { Name = "羊", ImgPath = "ms-appx:///images/yan.jpg", Jiao = "ms-appx:///Musics/yan.mp3", JiaoName = "ms-appx:///MusicName/yan.mp3" });
                list.Add(new DonWu { Name = "鹰", ImgPath = "ms-appx:///images/yin.jpg", Jiao = "ms-appx:///Musics/yin.mp3", JiaoName = "ms-appx:///MusicName/yin.mp3" });
                list.Add(new DonWu { Name = "鱼", ImgPath = "ms-appx:///images/yu.jpg", Jiao = "ms-appx:///Musics/yu.mp3", JiaoName = "ms-appx:///MusicName/yu.mp3" });
                list.Add(new DonWu { Name = "猪", ImgPath = "ms-appx:///images/zu.jpg", Jiao = "ms-appx:///Musics/zu.mp3", JiaoName = "ms-appx:///MusicName/zu.mp3" });
                list.Add(new DonWu { Name = "熊", ImgPath = "ms-appx:///images/xion.jpg", Jiao = "ms-appx:///Musics/xion.mp3", JiaoName = "ms-appx:///MusicName/xion.mp3" });
                fv1.ItemsSource = list;
                //donwu = fv1.SelectedItem as DonWu;
                fv1.Tapped += fv1_Tapped;
            }
        }
        void fv1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            donwu = fv1.SelectedItem as DonWu;
            if (b)
            {
                mediaJiao.DataContext = donwu;
                mediaJiao.Play();
            }
            if(!b)
            {
                mediaName.DataContext = donwu;
                mediaName.Play();
            }
        }

        private void btnJiaoJiao_Click(object sender, RoutedEventArgs e)
        {
            b = true;
        }

        private void btnJiaoName_Click(object sender, RoutedEventArgs e)
        {
            b = false;
        }

        private void fv1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mediaJiao.Stop();
            mediaName.Stop();
        }
    }
}
