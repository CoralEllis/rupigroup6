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
        string name;

        public string Index { get => index; set => index = value; }
        public int User { get => user; set => user = value; }
        public int Unit { get => unit; set => unit = value; }
        public string ShiftType { get => shiftType; set => shiftType = value; }
        public DateTime ShiftDate { get => shiftDate; set => shiftDate = value; }
        public string Name { get => name; set => name = value; }

        public Exceptions() { }
        public Exceptions(string _index, int _user, int _unit, string _type, DateTime date,string _name)
        {
            Index = _index;
            User = _user;
            Unit = _unit;
            ShiftType = _type;
            ShiftDate = date;
            Name = _name;
        }

        public void InsertExceptions(List<Exceptions> ExcptArr)
        {
            DBservices dbs = new DBservices();
            dbs.InsertExceptionsList(ExcptArr);
        }

        public List<Exceptions> GetSpecialExcep(DateTime start, DateTime end,int unitid)
        {

            DBservices dbs = new DBservices();
         return  dbs.GetSpecialExcep(start,end,unitid);

        }

            public List<Exceptions> GetExceptionsNum(DateTime start, DateTime end, int unitid)
        {

            DBservices dbs = new DBservices();
            return dbs.GetExceptionsNum(start, end, unitid);
        }


    }

}