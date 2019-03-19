using System.Collections.ObjectModel;
using System.Windows.Input;
using FilmsXamarin.Model;
using Xamarin.Forms;

namespace FilmsXamarin.ViewModel
{
    public class TaskViewModel : BaseViewModel
    {
        private ObservableCollection<TaskModel> _criterionList;
        private string _criterion;
        private double _sliderValue;

        public ICommand AddCommand { get; private set; }

        public TaskViewModel()
        {
            CriterionList = new ObservableCollection<TaskModel>
            {
               new TaskModel { Criterion = "Внешний вид", SliderValue = 4.2 },
               new TaskModel { Criterion = "Полезность", SliderValue = 2.5 },
               new TaskModel { Criterion = "Интересность", SliderValue = 1.7 }
            };

            AddCommand = new Command(AddCriterion);
        }

        public ObservableCollection<TaskModel> CriterionList
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

        private void AddCriterion()
        {
            CriterionList.Add(new TaskModel { Criterion = _criterion, SliderValue = _sliderValue});                
        }

       
    }
}
