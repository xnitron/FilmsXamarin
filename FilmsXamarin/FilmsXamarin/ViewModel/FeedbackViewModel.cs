using System.Collections.ObjectModel;
using System.Windows.Input;
using FilmsXamarin.Model;
using Xamarin.Forms;

namespace FilmsXamarin.ViewModel
{
    public class FeedbackViewModel : BaseViewModel
    {
        private ObservableCollection<FeedbackModel> _criterionList;
        private string _criterion;
        private double _sliderValue;
        private Page _page;

        public ICommand AddCommand { get; private set; }

        public FeedbackViewModel(Page page)
        {
            _page = page;

            CriterionList = new ObservableCollection<FeedbackModel>
            {
               new FeedbackModel { Criterion = "Внешний вид", SliderValue = 4.2 },
               new FeedbackModel { Criterion = "Полезность", SliderValue = 2.5 },
               new FeedbackModel { Criterion = "Интересность", SliderValue = 1.7 }
            };

            AddCommand = new Command(AddCriterion);
        }

        private void AddCriterion()
        {
            if (string.IsNullOrWhiteSpace(_criterion))
            {
                _page.DisplayAlert("Error", "String can not be empty", "Ok");   
            }
            else
            {
                CriterionList.Add(new FeedbackModel { Criterion = _criterion, SliderValue = _sliderValue });                
            } 
        }

        public ObservableCollection<FeedbackModel> CriterionList
        {
            get
            {
                return _criterionList;
            }
            set
            {
                if (value != _criterionList)
                {
                    _criterionList = value;

                    NotifyPropertyChanged();
                }
            }
        }

        public string Criterion
        {
            get
            {
                return  _criterion;
            }
            set
            {
                if (value != _criterion)
                {
                    _criterion = value;

                    NotifyPropertyChanged();
                }
            }
        }

        public double SliderValue
        {
            get
            {
                return _sliderValue;
            }
            set
            {
                if (value != _sliderValue)
                {
                    _sliderValue = value;

                    NotifyPropertyChanged();
                }
            }
        }
    }
}
