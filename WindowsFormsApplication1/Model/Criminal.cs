using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    [Serializable]
    public class Criminal
    {
        private int _index;
        private string _name = string.Empty;
        private string _surname = string.Empty;
        private string _nickname = string.Empty;
        private string _height;
        private string _bornDate;
        private string _colorEye = string.Empty;
        private string _colorHair = string.Empty;
        private string _lastBusy = string.Empty;
        private string _nowAdress = string.Empty;
        private string _cityzenship = string.Empty;
        private string _features = string.Empty;
        private string _group = string.Empty;

        public Criminal(string Name, string Surname, string BornDate, string Nickname, string LastBusy,
            string Height, string ColorEye, string ColorHair, string NowAdress, string Cityzenship, string Features, string Group)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.BornDate = BornDate;
            this.Nickname = Nickname;
            this.LastBusy = LastBusy;
            this.Height = Height;
            this.ColorEye = ColorEye;
            this.ColorHair = ColorHair;
            this.NowAdress = NowAdress;
            this.Cityzenship = Cityzenship;
            this.Features = Features;
            this.Group = Group;
        }

        public Criminal()
        {

        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
        public string Group
        {
            get { return _group; }
            set
            {
                if (value == string.Empty)
                    _group = "Неизвестна";
                else
                    _group = value;
            }
        }
        public string Cityzenship
        {
            get { return _cityzenship; }
            set
            {
                if (value == string.Empty)
                    _cityzenship = "Неизвестно";
                else
                    _cityzenship = value;
            }
        }
        public string Features
        {
            get { return _features; }
            set
            {
                if (value == string.Empty)
                    _features = "Неизвестны";
                else
                    _features = value;
            }
        }
        public string NowAdress
        {
            get { return _nowAdress; }
            set
            {
                if (value == string.Empty)
                    _nowAdress = "Неизвестен";
                else
                    _nowAdress = value;
            }
        }

        public string LastBusy
        {
            get { return _lastBusy; }
            set
            {
                if (value == string.Empty)
                    _lastBusy = "Неизвестно";
                else
                    _lastBusy = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == string.Empty)
                {
                    _name = "Неизвестно";
                }
                else
                {
                    Regex regex = new Regex("[^0-9]");
                    if (regex.Match(value).Success)
                        _name = value;
                    else
                    {
                        throw new ArgumentException("Неверно введено поле имени");
                    }
                }

            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == string.Empty)
                {
                    _surname = "Неизвестна";
                }
                else
                {
                    Regex regex = new Regex("[^0-9]");
                    if (regex.Match(value).Success)
                        _surname = value;
                    else
                    {
                        throw new ArgumentException("Неверно введено поле фамилии");
                    }
                }
            }
        }

        public string Nickname
        {
            get { return _nickname; }
            set
            {
                if (value == string.Empty)
                {
                    _nickname = "Неизвестна";
                }
                else
                {
                    Regex regex = new Regex("[^0-9]");
                    if (regex.Match(value).Success)
                        _nickname = value;
                    else
                    {
                        throw new ArgumentException("Неверно введено поле клички");
                    }
                }
            }
        }

        public string Height
        {
            get { return _height; }
            set
            {
                if (value == string.Empty)
                {
                    _height = "Неизвестен";
                }
                else
                {
                    Regex regex = new Regex("[0-9]{3}");
                    if (regex.Match(value).Success)
                        _height = value;
                    else
                    {
                        throw new ArgumentException("Неверно введено поле возраста");
                    }
                }
            }
        }
        public string BornDate
        {
            get { return _bornDate; }
            set
            {
                if (value == string.Empty)
                    _bornDate = "Неизвестна";
                else
                    _bornDate = value;
            }
        }

        public string ColorEye
        {
            get { return _colorEye; }
            set
            {
                if (value == string.Empty)
                {
                    _colorEye = "Неизвестен";
                }
                else
                {
                    Regex regex = new Regex("[^0-9]");
                    if (regex.Match(value).Success)
                        _colorEye = value;
                    else
                    {
                        throw new ArgumentException("Неверно введено поле цвета глаз");
                    }
                }
            }
        }

        public string ColorHair
        {
            get { return _colorHair; }
            set
            {
                if (value == string.Empty)
                {
                    _colorHair = "Неизвестен";
                }
                else
                {
                    Regex regex = new Regex("[^0-9]");
                    if (regex.Match(value).Success)
                        _colorHair = value;
                    else
                    {
                        throw new ArgumentException("Неверно введено поле цвета волос");
                    }
                }
            }
        }


        
    }
}
