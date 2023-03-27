using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class Actor
    {
        private string jobTitle;

        public Actor()
        {
            Console.WriteLine("An actor is created!");
        }

        public Actor(string actorName) : this() //calling default constructor
        {
            ActorName = actorName;
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set { actorName = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string GetOccupation()
        {
            JobTitle = "Actor";

            return JobTitle;
        }

        public string BookActor()
        {
            return BookActor(string.Empty);
        }

        public string BookActor(string theDate)
        {
            string details = "Booking can change if actor starts trouble.";
            string theActor = $"Actor: {ActorName} is booked";

            if (theDate != string.Empty)
            {
                return $" {theActor} on the {theDate} with details: {details}";
            }
            else
            {
                return $" {theActor} with details: {details}";
            }
        }
    }
}
