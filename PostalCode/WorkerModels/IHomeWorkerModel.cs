using PostalCode.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostalCode.WorkerModels
{
    public interface IHomeWorkerModel
    {
        HomeView InitView();    // 初期表示処理
        HomeView GetDummy(HomeView view);   // ボタンクリック処理
    }
}