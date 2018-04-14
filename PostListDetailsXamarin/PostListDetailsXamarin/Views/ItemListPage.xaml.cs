﻿using Xamarin.Forms;
using RandomListXamarin.ViewModels;
using PostListDetailsXamarin.Views;
using RandomListXamarin.Model;

namespace ItemsDetailXamarin.Views
{
    public partial class ItemListPage : ContentPage
    {
        ItemListViewModel itemListViewModel;

        public ItemListPage()
        {
            InitializeComponent();
            itemListViewModel = new ItemListViewModel();
            BindingContext = itemListViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await itemListViewModel.UpdatePostsAsync();
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new PostDetail(e.SelectedItem as Post));
        }
    }
}
