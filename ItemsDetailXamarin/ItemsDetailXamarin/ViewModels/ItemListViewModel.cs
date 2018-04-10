﻿using System;
using System.Collections.ObjectModel;
using RandomListXamarin.Model;
using System.Threading.Tasks;
using ItemsDetailXamarin.Helpers;
using Xamarin.Forms.Internals;
using Xamarin.Forms;

namespace RandomListXamarin.ViewModels
{
    public class ItemListViewModel : BaseViewModel
    {
        public ObservableCollection<Post> Posts { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemListViewModel()
        {
            this.Posts = new ObservableCollection<Post>();
        }

        public async Task UpdatePostsAsync()
        {
            var newPosts = await JsonPlaceholderHelper.GetPostsAsync();
            this.Posts.Clear();
            newPosts.ForEach((post) => this.Posts.Add(post));
        }

    }
}
