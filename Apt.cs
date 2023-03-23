using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Part2
{
    public class Apt
    {
        string _AptNumber;
        string _FirstName;
        string _LastName;
        decimal _MonthlyPayment;
        decimal _CurrentBal;
        float _NumOfBedrooms;
        string _AptNotes;
        bool _isOccupied;

       

        public Apt(string name,bool isOccupied = true)
        {
            Random rand = new Random();


            _FirstName = FirstName;
            _AptNumber = rand.Next(100, 1000).ToString();
            _isOccupied = isOccupied;

        }

        //Overloading

        public Apt(string AptNumber, string FirstName)
        {
            _AptNumber = AptNumber;
            _FirstName = FirstName;
            _isOccupied = true;

        }

        //Constructos dont have return types
        
        public Apt(string AptNumber, string FirstName, string LastName, decimal MonthlyPayment, float NumOfBedrooms)

        {
            _AptNumber = AptNumber;
            _FirstName = FirstName;
            _LastName = LastName;
            _MonthlyPayment = MonthlyPayment;
            _NumOfBedrooms = NumOfBedrooms;

        }

        public string AptNumber { get => _AptNumber;  }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public decimal MonthlyPayment { get => _MonthlyPayment; set => _MonthlyPayment = value; }
        public decimal CurrentBal { get => _CurrentBal; set => _CurrentBal = value; }
        public float NumOfBedrooms { get => _NumOfBedrooms; set => _NumOfBedrooms = value; }
        public string AptNotes { get => _AptNotes; set => _AptNotes = value; }
        public bool IsOccupied { get => _isOccupied; set => _isOccupied = value; }


        //override to string, to change what display when you call ToString() on an object
        public override string ToString()
        {
            //If is occupied, display Apt number and First name 
            //else display Apt number and Vacant

            if (IsOccupied) 
            {

                return $"{_AptNumber} - Firstname{_FirstName}";

            }
            else
            {

                return $"{_AptNumber}  - Vacant";
            }
                
           
        }
    }
}
