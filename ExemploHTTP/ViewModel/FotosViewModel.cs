using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ExemploHTTP.ViewModel
{
    internal partial class FotosViewModel: ObservableObject
    {
        [ObservableProperty]
        private int _Id;

        [ObservableProperty]
        private string _Title;

        [ObservableProperty]
        private string _Url;

        [ObservableProperty]
        private string _description;

        [ObservableProperty]
        private string _AlbumId;

        [ObservableProperty]
        private string _UserId;

        [ObservableProperty]
        private string _ThumbnailUrl;


    }
}
