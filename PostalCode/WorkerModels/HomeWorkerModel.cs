using PostalCode.DAOModels;
using PostalCode.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostalCode.WorkerModels
{
    public class HomeWorkerModel : IHomeWorkerModel
    {
        // DAOの取り込み
        private IHomeDAOModel DAO;
        public HomeWorkerModel() { DAO = new HomeDAOModel(); }
        public HomeWorkerModel(IHomeDAOModel dao) { DAO = dao; }

        // 初期表示処理
        public HomeView InitView()
        {
            HomeView result = new HomeView();
            return result;
        }

        // ダミーボタン処理
        public HomeView GetDummy(HomeView view)
        {
            HomeView result = this.InitView();
            result.InfoMessage = "ボタンクリック";
            return result;
        }
    }
}