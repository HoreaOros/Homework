﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calendar
{
    /// <summary>Class member: Ledger;
    /// Clasa creata pt popularea clasei Ledger cu persoane si evenimente. 
    /// </summary>
    class LedgerPopulator
    {
        private Ledger ledger;
        public LedgerPopulator(Ledger ledger)
        {
            this.ledger = ledger;
        }

        public void populate(List<Person> persons, List<CalendarEvent> events)
        {
            foreach(Person person in persons)
            {
                List<CalendarEvent> personEvents = GetPersonEvents(person, events);

                //Console.WriteLine("Adding " + personEvents.Count() + " For " + person.GetName());
                Calendar calendar = new Calendar(person, personEvents);
                ledger.AddCalendar(calendar);
            }
        }

        private List<CalendarEvent> GetPersonEvents(Person person, List<CalendarEvent> events)
        {
            List<CalendarEvent> personEvents = new List<CalendarEvent>();
            foreach(CalendarEvent ce in events)
            {
                if(ce.GetPersonId().Equals(person.GetId()))
                {
                    personEvents.Add(ce);
                }
            }

            return personEvents;
        }
    }
}
