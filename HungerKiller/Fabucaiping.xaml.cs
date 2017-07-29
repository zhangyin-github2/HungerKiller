﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Fabucaiping : Page
    {
        public Fabucaiping()
        {
            this.InitializeComponent();
        }

       

        private void RouCheckBox_Click(object sender, RoutedEventArgs e)
        {
            
            
                string selectedToppingsText = string.Empty;
                CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
                foreach (CheckBox c in checkboxes)
                {
                    if (c.IsChecked == true)
                    {
                        if (selectedToppingsText.Length > 1)
                        {
                            selectedToppingsText += ", ";
                        }
                        selectedToppingsText += c.Content;
                    }
                }
            ShowTextBlock.Text = selectedToppingsText;
            
        }

        private void TianCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void SuanCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void LiangCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void ReCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void XianCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void LaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void MiShiCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void MianShiCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void SuShiCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private async  void TianjiaTupianButton_Click(object sender, RoutedEventArgs e)
        {
            var srcImage1 = new BitmapImage();
            FileOpenPicker openPicker = new FileOpenPicker();
            //选择视图模式  
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            //openPicker.ViewMode = PickerViewMode.List;  
            //初始位置  
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            //添加文件类型  
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");


            Windows.Storage.StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read))
                {
                    await srcImage1.SetSourceAsync(stream);
                    FabucaipingImage.Source = srcImage1;
                }
            }
        }

        private async  void FabuButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("你确定发布，请检查是否编辑完整", "发布提示");

            dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
            dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));

            //设置默认按钮，不设置的话默认的确认按钮是第一个按钮
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

            //获取返回值
            var result = await dialog.ShowAsync();
        }
    }
}
