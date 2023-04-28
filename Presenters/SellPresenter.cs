using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class SellPresenter
    {
        private ISellView view;
        private ISellModelRepository repository;
        private BindingSource sellBindingSource;
        private IEnumerable<SellModel> sellModelList;

        public SellPresenter(ISellView view, ISellModelRepository repository)
        {
            this.sellBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchSell;
            this.view.AddNewEvent += AddNewSell;
            this.view.EditEvent += LoadSelectSellToEdit;
            this.view.DeleteEvent += DeleteSelectedSell;
            this.view.SaveEvent += SaveSell;
            this.view.CancelEvent += CancelAction;

            this.view.SetSellListBildingSource(sellBindingSource);

            loadAllSellList();

            this.view.Show();
        }

        private void SaveSell(object? sender, EventArgs e)
        {
            var sell = new SellModel();
            sell.Id = Convert.ToInt32(view.Sell_Id);
            sell.CustomerId = Convert.ToInt32(view.Sell_CustomerId);
            sell.Total = Convert.ToInt32(view.Sell_Total);
            sell.PayMode = view.Sell_PayMode;
            sell.Observation = view.Sell_Observation;

            try
            {
                new Common.ModelDataValidation().Validate(sell);
                if (view.IsEdit)
                {
                    repository.Edit(sell);
                    view.Message = "Sell edited successfuly";
                }
                else
                {
                    repository.Add(sell);
                    view.Message = "Sell added successfuly";
                }
                view.IsSuccesful = true;
                loadAllSellList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.Sell_Id = "0";
            view.Sell_CustomerId = "";
            view.Sell_Total = "";
            view.Sell_PayMode = "";
            view.Sell_Observation = "";
        }

        private void DeleteSelectedSell(object? sender, EventArgs e)
        {
            try
            {
                var sell = (SellModel)sellBindingSource.Current;

                repository.Delete(sell.Id);
                view.IsSuccesful = true;
                view.Message = "Sell deleted successfully";
                loadAllSellList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could ot delete sell";
            }
        }

        private void LoadSelectSellToEdit(object? sender, EventArgs e)
        {
            var sell = (SellModel)sellBindingSource.Current;
            view.Sell_Id = sell.Id.ToString();
            view.Sell_CustomerId = sell.CustomerId.ToString();
            view.Sell_Total = sell.Total.ToString();
            view.Sell_PayMode = sell.PayMode;
            view.Sell_Observation = sell.Observation;

            view.IsEdit = true;
        }

        private void AddNewSell(object? sender, EventArgs e)
        {
               view.IsEdit = false;
        }

        private void SearchSell(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                sellModelList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                sellModelList = repository.GetAll();
            }
            sellBindingSource.DataSource = sellModelList; ;
        }

        private void loadAllSellList()
        {
            sellModelList = repository.GetAll();
            sellBindingSource.DataSource = sellModelList;

        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

    }
}
