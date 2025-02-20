﻿using System.ComponentModel;
using System.Runtime.CompilerServices;



/*
 * Copyright (c) 2021 All Rights Reserved.
 * Description：HeaderedItemViewModel
 * Author： Chance_写代码的厨子
 * Create Time：2021-08-13 09:58:14
 */
namespace CookPopularControl.Communal.ViewModel
{
    /// <summary>
    /// Helper class to create view models, particularly for tool/MDI windows.
    /// </summary>
    internal class HeaderedItemViewModel : INotifyPropertyChanged
    {
        private bool _isSelected;
        private object _header;
        private object _content;

        public HeaderedItemViewModel()
        {
        }

        public HeaderedItemViewModel(object header, object content, bool isSelected = false)
        {
            _header = header;
            _content = content;
            _isSelected = isSelected;
        }

        public object Header
        {
            get { return _header; }
            set
            {
                if (_header == value) return;
                _header = value;
                OnPropertyChanged();
            }
        }

        public object Content
        {
            get { return _content; }
            set
            {
                if (_content == value) return;
                _content = value;
                OnPropertyChanged();
            }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (_isSelected == value) return;
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
