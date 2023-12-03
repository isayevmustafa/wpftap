﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TapAzImtahan.Model
{

    public static class StaticID
    {
        public static int SID { get; set; } = 0;
    }
    public class Product : INotifyPropertyChanged
    {
        public Product() { }
        public Product(string? name, float price, string? description, string? category, string? imageUri)
        {
            Name = name;
            Price= price;
            Description = description;
            Category = category;
            ImageUri = imageUri;
        }
        public Product(float price,string? description, string? imageUri)
        {
            ImageUri = imageUri;
            Price = price;
        }
        

        

        public int Id { get; set; } = ++StaticID.SID;
        public string? Name { get; set; }
        public float Price { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? ImageUri { get; set; } = null;
        public Image? Image { get; set; } = null;
        public Image[]? Images { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
