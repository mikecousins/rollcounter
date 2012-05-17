using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RollCounter
{
    /// <summary>
    /// Our main view model
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Private Members
        private List<int> _rolls;
        private Sum _two;
        private Sum _three;
        private Sum _four;
        private Sum _five;
        private Sum _six;
        private Sum _seven;
        private Sum _eight;
        private Sum _nine;
        private Sum _ten;
        private Sum _eleven;
        private Sum _twelve;
        #endregion

        #region Display Properties
        public int TwoCount
        {
            get
            {
                return _two.Count;
            }
            set
            {
                _two.Count = value;
                NotifyPropertyChanged("TwoCount");
            }
        }

        public float TwoPercentage
        {
            get
            {
                return _two.Percentage;
            }
            set
            {
                _two.Percentage = value;
                NotifyPropertyChanged("TwoPercentage");
            }
        }

        public int ThreeCount
        {
            get
            {
                return _three.Count;
            }
            set
            {
                _three.Count = value;
                NotifyPropertyChanged("ThreeCount");
            }
        }

        public float ThreePercentage
        {
            get
            {
                return _three.Percentage;
            }
            set
            {
                _three.Percentage = value;
                NotifyPropertyChanged("ThreePercentage");
            }
        }

        public int FourCount
        {
            get
            {
                return _four.Count;
            }
            set
            {
                _four.Count = value;
                NotifyPropertyChanged("FourCount");
            }
        }

        public float FourPercentage
        {
            get
            {
                return _four.Percentage;
            }
            set
            {
                _four.Percentage = value;
                NotifyPropertyChanged("FourPercentage");
            }
        }

        public int FiveCount
        {
            get
            {
                return _five.Count;
            }
            set
            {
                _five.Count = value;
                NotifyPropertyChanged("FiveCount");
            }
        }

        public float FivePercentage
        {
            get
            {
                return _five.Percentage;
            }
            set
            {
                _five.Percentage = value;
                NotifyPropertyChanged("FivePercentage");
            }
        }

        public int SixCount
        {
            get
            {
                return _six.Count;
            }
            set
            {
                _six.Count = value;
                NotifyPropertyChanged("SixCount");
            }
        }

        public float SixPercentage
        {
            get
            {
                return _six.Percentage;
            }
            set
            {
                _six.Percentage = value;
                NotifyPropertyChanged("SixPercentage");
            }
        }

        public int SevenCount
        {
            get
            {
                return _seven.Count;
            }
            set
            {
                _seven.Count = value;
                NotifyPropertyChanged("SevenCount");
            }
        }

        public float SevenPercentage
        {
            get
            {
                return _seven.Percentage;
            }
            set
            {
                _seven.Percentage = value;
                NotifyPropertyChanged("SevenPercentage");
            }
        }

        public int EightCount
        {
            get
            {
                return _eight.Count;
            }
            set
            {
                _eight.Count = value;
                NotifyPropertyChanged("EightCount");
            }
        }

        public float EightPercentage
        {
            get
            {
                return _eight.Percentage;
            }
            set
            {
                _eight.Percentage = value;
                NotifyPropertyChanged("EightPercentage");
            }
        }

        public int NineCount
        {
            get
            {
                return _nine.Count;
            }
            set
            {
                _nine.Count = value;
                NotifyPropertyChanged("NineCount");
            }
        }

        public float NinePercentage
        {
            get
            {
                return _nine.Percentage;
            }
            set
            {
                _nine.Percentage = value;
                NotifyPropertyChanged("NinePercentage");
            }
        }

        public int TenCount
        {
            get
            {
                return _ten.Count;
            }
            set
            {
                _ten.Count = value;
                NotifyPropertyChanged("TenCount");
            }
        }

        public float TenPercentage
        {
            get
            {
                return _ten.Percentage;
            }
            set
            {
                _ten.Percentage = value;
                NotifyPropertyChanged("TenPercentage");
            }
        }

        public int ElevenCount
        {
            get
            {
                return _eleven.Count;
            }
            set
            {
                _eleven.Count = value;
                NotifyPropertyChanged("ElevenCount");
            }
        }

        public float ElevenPercentage
        {
            get
            {
                return _eleven.Percentage;
            }
            set
            {
                _eleven.Percentage = value;
                NotifyPropertyChanged("ElevenPercentage");
            }
        }

        public int TwelveCount
        {
            get
            {
                return _twelve.Count;
            }
            set
            {
                _twelve.Count = value;
                NotifyPropertyChanged("TwelveCount");
            }
        }

        public float TwelvePercentage
        {
            get
            {
                return _twelve.Percentage;
            }
            set
            {
                _twelve.Percentage = value;
                NotifyPropertyChanged("TwelvePercentage");
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public MainViewModel()
        {
            _rolls = new List<int>();

            _two = new Sum() { Name = 2 };
            _three = new Sum() { Name = 3 };
            _four = new Sum() { Name = 4 };
            _five = new Sum() { Name = 5 };
            _six = new Sum() { Name = 6 };
            _seven = new Sum() { Name = 7 };
            _eight = new Sum() { Name = 8 };
            _nine = new Sum() { Name = 9 };
            _ten = new Sum() { Name = 10 };
            _eleven = new Sum() { Name = 11 };
            _twelve = new Sum() { Name = 12 };
        }
        #endregion

        /// <summary>
        /// Adds a roll
        /// </summary>
        /// <param name="roll"></param>
        public void AddRoll(int roll)
        {
            // add the roll to our list
            _rolls.Add(roll);

            // add the roll to the correct sum
            switch (roll)
            {
                case 2:
                    TwoCount++;
                    break;
                case 3:
                    ThreeCount++;
                    break;
                case 4:
                    FourCount++;
                    break;
                case 5:
                    FiveCount++;
                    break;
                case 6:
                    SixCount++;
                    break;
                case 7:
                    SevenCount++;
                    break;
                case 8:
                    EightCount++;
                    break;
                case 9:
                    NineCount++;
                    break;
                case 10:
                    TenCount++;
                    break;
                case 11:
                    ElevenCount++;
                    break;
                case 12:
                    TwelveCount++;
                    break;
            }

            // update our percentages
            UpdatePercentages();
        }

        /// <summary>
        /// Removes the last roll
        /// </summary>
        public void UndoRoll()
        {
            // find the last roll
            var lastRoll = _rolls[_rolls.Count - 1];

            // decrement the correct sum
            switch (lastRoll)
            {
                case 2:
                    TwoCount--;
                    break;
                case 3:
                    ThreeCount--;
                    break;
                case 4:
                    FourCount--;
                    break;
                case 5:
                    FiveCount--;
                    break;
                case 6:
                    SixCount--;
                    break;
                case 7:
                    SevenCount--;
                    break;
                case 8:
                    EightCount--;
                    break;
                case 9:
                    NineCount--;
                    break;
                case 10:
                    TenCount--;
                    break;
                case 11:
                    ElevenCount--;
                    break;
                case 12:
                    TwelveCount--;
                    break;
            }

            // remove the last roll
            _rolls.RemoveAt(_rolls.Count - 1);

            // update our percentages
            UpdatePercentages();
        }
        
        /// <summary>
        /// Updates the percentages for each sum
        /// </summary>
        private void UpdatePercentages()
        {
            float totalRolls = _rolls.Count;
            TwoPercentage = TwoCount / totalRolls;
            ThreePercentage = ThreeCount / totalRolls;
            FourPercentage = FourCount / totalRolls;
            FivePercentage = FiveCount / totalRolls;
            SixPercentage = SixCount / totalRolls;
            SevenPercentage = SevenCount / totalRolls;
            EightPercentage = EightCount / totalRolls;
            NinePercentage = NineCount / totalRolls;
            TenPercentage = TenCount / totalRolls;
            ElevenPercentage = ElevenCount / totalRolls;
            TwelvePercentage = TwelveCount / totalRolls;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}