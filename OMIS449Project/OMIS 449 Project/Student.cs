using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMIS_449_Project
{
    //Student class, varible and property for each column in CSV
    class Student
    {
        private string _FirstName;
        private string _LastName;
        private int _ZID;
        private int _SeatNum;
        private int _Absenses;

        public Student()
        {
            _FirstName = "";
            _LastName = "";
            _ZID = 0;
            _SeatNum = 0;
            _Absenses = 0;
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public int ZID
        {
            get { return _ZID; }
            set { _ZID = value; }
        }

        public int SeatNum
        {
            get { return _SeatNum; }
            set { _SeatNum = value; }
        }

        public int Absenses
        {
            get { return _Absenses; }
            set { _Absenses = value; }
        }
    }
}
