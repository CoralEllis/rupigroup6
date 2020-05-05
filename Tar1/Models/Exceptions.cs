using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tar1.Models.DAL;

namespace Tar1.Models
{
    public class Exceptions
    {
        string index;
        int user;
        int unit;
        string shiftType;
        DateTime shiftDate;

        public string Index { get => index; set => index = value; }
        public int User { get => user; set => user = value; }
        public int Unit { get => unit; set => unit = value; }
        public string ShiftType { get => shiftType; set => shiftType = value; }
        public DateTime ShiftDate { get => shiftDate; set => shiftDate = value; }

        public Exceptions() { }
        public Exceptions(string _index, int _user, int _unit, string _type, DateTime date)
        {
            Index = _index;
            User = _user;
            Unit = _unit;
            ShiftType = _type;
            ShiftDate = date;
        }

        public void InsertExceptions(List<Exceptions> ExcptArr)
        {
            DBservices dbs = new DBservices();
            dbs.InsertExceptionsList(ExcptArr);
        }
    }

}