﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Capstone
{
    public class SelectMultipleBasePage <T> : ContentPage
    {

        public class WrappedSelection<T> : INotifyPropertyChanged
        {
            public T Item { get; set; }
            bool isSelected = false;
            public bool IsSelected
            {
                get
                {
                    return isSelected;
                }
                set
                {
                    if (isSelected != value)
                    {
                        isSelected = value;
                        PropertyChanged(this, new PropertyChangedEventArgs("IsSelected"));
                        //                      PropertyChanged (this, new PropertyChangedEventArgs (nameof (IsSelected))); // C# 6
                    }
                }
            }
            public event PropertyChangedEventHandler PropertyChanged = delegate { };
        }
        public class WrappedItemSelectionTemplate : ViewCell
        {
            

            public WrappedItemSelectionTemplate() : base()
            {
                Label name = new Label();
                name.SetBinding(Label.TextProperty, new Binding("Item.Name"));
                Switch mainSwitch = new Switch();
                mainSwitch.SetBinding(Switch.IsToggledProperty, new Binding("IsSelected"));
                RelativeLayout layout = new RelativeLayout();
                layout.Children.Add(name,
                    Constraint.Constant(5),
                    Constraint.Constant(5),
                    Constraint.RelativeToParent(p => p.Width - 60),
                    Constraint.RelativeToParent(p => p.Height - 10)
                );
                layout.Children.Add(mainSwitch,
                    Constraint.RelativeToParent(p => p.Width - 55),
                    Constraint.Constant(5),
                    Constraint.Constant(50),
                    Constraint.RelativeToParent(p => p.Height - 10)
                );
                View = layout;
            }
        }
        public List<WrappedSelection<T>> WrappedItems = new List<WrappedSelection<T>>();
        ListView mainList;


        public SelectMultipleBasePage(List<T> items)
        {
            WrappedItems = items.Select(item => new WrappedSelection<T>() { Item = item, IsSelected = false }).ToList();
            mainList = new ListView()
            {
                ItemsSource = WrappedItems,
                ItemTemplate = new DataTemplate(typeof(WrappedItemSelectionTemplate)),
            };

            Button Play = new Button();

            mainList.ItemSelected += (sender, e) => {
                if (e.SelectedItem == null) return;
                var o = (WrappedSelection<T>)e.SelectedItem;
                o.IsSelected = !o.IsSelected;
                ((ListView)sender).SelectedItem = null; //de-select

                if(e.SelectedItem.Equals("Xamarin.com"))
                {
                    DisplayAlert("hey", "ok", "yes");
                }

            };

            


            Content = mainList;
            ToolbarItems.Add(new ToolbarItem("All", null, SelectAll, ToolbarItemOrder.Primary));
            ToolbarItems.Add(new ToolbarItem("None", null, SelectNone, ToolbarItemOrder.Primary));
        }


        void SelectAll()
        {
            foreach (var wi in WrappedItems)
            {
                wi.IsSelected = true;
            }
        }
        void SelectNone()
        {
            foreach (var wi in WrappedItems)
            {
                wi.IsSelected = false;
            }
        }
        public List<T> GetSelection()
        {
            return WrappedItems.Where(item => item.IsSelected).Select(wrappedItem => wrappedItem.Item).ToList();
        }


    }
}
