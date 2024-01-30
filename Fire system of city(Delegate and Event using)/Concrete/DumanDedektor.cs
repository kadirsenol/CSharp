﻿using Fire_system_of_city_Delegate_and_Event_using_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_system_of_city_Delegate_and_Event_using_.Concrete
{
    public class DumanDedektor : IDumanDedektor
    {
        public event FireHandler AlarmCaldi;   
        public string marka { get; set; }

        public void DumanAlgila(object dumancikaran)
        {
            if (dumancikaran is Sigara)
            {
                Console.WriteLine("Dedektör sigara alarmı devreye girdi.");
                AlarmCaldi(dumancikaran);
            }
            else if (dumancikaran is Kablo)
            {
                Console.WriteLine("Dedektör yangın alarmı devreye girdi ve otomatik olarak itfaiyeye bildirim geçildi.");
                AlarmCaldi(dumancikaran);
            }
        }
    }
}
