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
using DinerMaxWebClient.DinerMaxServiceReference;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DinerMaxWebClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
    

    public sealed partial class MainPage : Page
    {
       
    
        DinerMax3000ServiceClient webService = new DinerMax3000ServiceClient();
        public MainPage()
        {
            webService.BypassCertErrorAsync();
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
           
            getCustomers();
        }

        async void byPassCertError()
        {
            try
            {
                await webService.BypassCertErrorAsync();
            }
            catch (Exception ex)
            {
                MessageDialog messageDialog = new MessageDialog(ex.Message);
                await messageDialog.ShowAsync();
            }
        }

        async void getCustomers()
        {
            try
            {
                ProgressBar.IsIndeterminate = true;
                ProgressBar.Visibility = Visibility.Visible;
                GridViewCustomers.ItemsSource = await webService.getCustomersAsync();
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;
            }
            catch (Exception ex)
            {
                MessageDialog messageDialog = new MessageDialog(ex.Message);
                await messageDialog.ShowAsync();
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;
            }
        }
        private void GridViewCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                Customer selectedCustomer = e.AddedItems[0] as Customer;
                TextBoxName.Text = selectedCustomer.Name;
                TextBoxSurname.Text = selectedCustomer.Surname;
                TextBoxCity.Text = selectedCustomer.City;
                TextBoxAge.Text = selectedCustomer.Age.ToString();
                if (selectedCustomer.IsRegularCustomer == true)
                {
                    CheckBoxRegularCustomer.IsChecked = true;
                }
                else
                {
                    CheckBoxRegularCustomer.IsChecked = false;
                }
            }
        }

        async private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProgressBar.IsIndeterminate = true;
                ProgressBar.Visibility = Visibility.Visible;
                Customer newCustomer = new Customer();
                newCustomer.Name = TextBoxName.Text;
                newCustomer.Surname = TextBoxSurname.Text;
                newCustomer.Age = Int32.Parse(TextBoxAge.Text);
                newCustomer.City = TextBoxCity.Text;
                if (CheckBoxRegularCustomer.IsChecked == true)
                {
                    newCustomer.IsRegularCustomer = true;
                }
                else
                {
                    newCustomer.IsRegularCustomer = false;
                }
                bool result = await webService.addNewCustomerAsync(newCustomer);
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;
                if (result == true)
                {
                    MessageDialog messageDialog = new MessageDialog("Customer successfully added.");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    MessageDialog messageDialog = new MessageDialog("Customer couldn't be added.");
                    await messageDialog.ShowAsync();
                }
                getCustomers();
            }
            catch (Exception ex)
            {
                MessageDialog messageDialog = new MessageDialog(ex.Message);
                await messageDialog.ShowAsync();
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;
            }
        }

        async private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (GridViewCustomers.SelectedItem != null)
            {
                try
                {
                    ProgressBar.IsIndeterminate = true;
                    ProgressBar.Visibility = Visibility.Visible;
                    bool result = await webService.deleteCustomerAsync((GridViewCustomers.SelectedItem as Customer).Id);
                    if (result == true)
                    {
                        MessageDialog messageDialog = new MessageDialog("Customer successfully deleted.");
                        await messageDialog.ShowAsync();
                    }
                    else
                    {
                        MessageDialog messageDialog = new MessageDialog("Customer couldn't be deleted.");
                        await messageDialog.ShowAsync();
                    }
                    getCustomers();
                }
                catch (Exception ex)
                {
                    MessageDialog messageDialog = new MessageDialog(ex.Message);
                    await messageDialog.ShowAsync();
                    ProgressBar.Visibility = Visibility.Collapsed;
                    ProgressBar.IsIndeterminate = false;
                }
            }
        }

        async private void ButtonModify_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProgressBar.IsIndeterminate = true;
                ProgressBar.Visibility = Visibility.Visible;
                Customer newCustomer = new Customer();
                newCustomer.Id = (GridViewCustomers.SelectedItem as Customer).Id;
                newCustomer.Name = TextBoxName.Text;
                newCustomer.Surname = TextBoxSurname.Text;
                newCustomer.Age = Int32.Parse(TextBoxAge.Text);
                newCustomer.City = TextBoxCity.Text;
                if (CheckBoxRegularCustomer.IsChecked == true)
                {
                    newCustomer.IsRegularCustomer = true;
                }
                else
                {
                    newCustomer.IsRegularCustomer = false;
                }
                bool result = await webService.modifyCustomerAsync(newCustomer);
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;
                if (result == true)
                {
                    MessageDialog messageDialog = new MessageDialog("Customer successfully modified.");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    MessageDialog messageDialog = new MessageDialog("Customer couldn't be modified.");
                    await messageDialog.ShowAsync();
                }
                getCustomers();
            }
            catch (Exception ex)
            {
                MessageDialog messageDialog = new MessageDialog(ex.Message);
                await messageDialog.ShowAsync();
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;
            }


        }
    }
}
