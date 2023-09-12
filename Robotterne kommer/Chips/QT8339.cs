using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotterne_kommer.Chips
{
    internal class QT8339
    {
        //here I declare the different variables I'm gonna use in this class
        public bool _small { get; set; }
        public string _microchip { get; set; }
        public bool _wifi { get; set; }


        //here starts the contructors
        public QT8339(string _microchip)
        {
            _microchip = "You can sweep the floor\r\n";
        }
        public QT8339(string _microchip, bool small) : this(_microchip)
        {
            if (_small == false)
            {
                _microchip += "As well as change tyres\r\n";
            }
        }
        //"this(_microchip) means that the constructor "looks into" the string called _microchip
        public QT8339(string _microchip, bool _small, bool _wifi) : this(_microchip)
        {
            if (_wifi)
            {
                _microchip += "You have a WiFi module\r\n";
            }
            else
            {
                _microchip += "You don't have a WiFi module\r\n";
            }
        }
    }
}
