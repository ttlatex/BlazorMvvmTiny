using BlazorApp1.Models;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.ViewModels
{
    /// <summary>
    /// 文字列カウンタのビューモデル
    /// </summary>
    public class StringLengthCounterViewModel
    {
        public ReactivePropertySlim<string> Text1 { get; set; } = new ReactivePropertySlim<string>();

        public ReadOnlyReactivePropertySlim<string> Text2 { get; set; }

        public StringLengthCounterViewModel(StringLengthCounterModel model)
        {
            this.Text1 = model.Text1;
            this.Text2 = model.Text2;
        }
    }
}
