using System.Collections.Generic;
using System.Windows.Input;
using Cirrious.MvvmCross.Commands;
using Cirrious.MvvmCross.ExtensionMethods;
using SixSteps.Core.Interfaces.Speakers;

namespace SixSteps.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private string _key;
        public string Key
        {
            get { return _key; }
            set { _key = value; RaisePropertyChanged(() => this.Key); }
        }

        private List<Speaker> _items;
        public List<Speaker> Items
        {
            get { return _items; }
            set { _items = value; RaisePropertyChanged(() => this.Items); }
        }

        public ICommand FetchItemsCommand
        {
            get
            {
                return new MvxRelayCommand(DoFetchItems);
            }
        }

        private void DoFetchItems()
        {
            var service = this.GetService<ISpeakerService>();
            service.GetSpeakers(this.Key, OnSuccess, OnError);
        }

        private void OnSuccess(List<Speaker> simpleItems)
        {
            Items = simpleItems;
        }

        private void OnError(SpeakerServiceError speakerServiceError)
        {
            ReportError("Sorry - a problem occurred - " + speakerServiceError.ToString());
        }
    }
}
