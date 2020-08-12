using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    /// <summary>
    /// 文字列カウンタのモデル
    /// </summary>
    public class StringLengthCounterModel
    {
        public ReactivePropertySlim<string> Text1 { get; set; } = new ReactivePropertySlim<string>();

        public ReadOnlyReactivePropertySlim<string> Text2 { get; set; }

        public StringLengthCounterModel()
        {
            this.Text2 =
                Text1
                .Select(x => string.IsNullOrEmpty(x) ? "0文字" : x.Length + "文字")
                .ToReadOnlyReactivePropertySlim();
        }
    }
}
