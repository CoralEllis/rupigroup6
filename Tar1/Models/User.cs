using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tar1.Models.DAL;

namespace Tar1.Models
{
    public class User
    {
        string userid;
        string password;
        string firstname;
        string lastname;
        DateTime birthdate;
        string telephone;
        string role;
        bool unitmanager;
        bool bigmanager;
        int unitid;
        double monthlyHours;
        double monthlyExtraHours;
        int numOfPref;
        int trainingLevelId;
        bool isactive;

        public string Userid { get => userid; set => userid = value; }
        public string Password { get => password; set => password = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Role { get => role; set => role = value; }
        public bool Unitmanager { get => unitmanager; set => unitmanager = value; }
        public bool Bigmanager { get => bigmanager; set => bigmanager = value; }
        public int Unitid { get => unitid; set => unitid = value; }
        public double MonthlyHours { get => monthlyHours; set => monthlyHours = value; }
        public double MonthlyExtraHours { get => monthlyExtraHours; set => monthlyExtraHours = value; }
        public int NumOfPref { get => numOfPref; set => numOfPref = value; }
        public int TrainingLevelId { get => trainingLevelId; set => trainingLevelId = value; }
        public bool Isactive { get => isactive; set => isactive = value; }

        public User() { }
        public User(string id, string pass,string first, string last, DateTime bdate, string tel, string _role, bool um, bool bm, int Uid,double monthhour,double exmonthhour, int numofP, int _trainingLevelId, bool _isactive)
        {
            Userid = id;
            Password = pass;
            Firstname = first;
            Lastname = last;
            Birthdate = bdate;
            Telephone = tel;
            Role = _role;
            Unitmanager = um;
            Bigmanager = bm;
            Unitid = Uid;
            MonthlyHours = monthhour;
            MonthlyExtraHours = exmonthhour;
            NumOfPref = numofP;
            TrainingLevelId = _trainingLevelId;
            Isactive = _isactive;
        }
        public void InsertUser()
        {
            DBservices dbs = new DBservices();
            dbs.InsertUser(this);
        }

        public List<User> GetUsers()
        {

            DBservices dbs = new DBservices();
            List<User> U = dbs.GetUser();
            return U;
        }

        public List<User> GetUnitUsers(int id)
        {
            DBservices dbs = new DBservices();
            return dbs.GetUnitUser(id);
        }

        public List<User> getGuides(int id)
        {
            DBservices dbs = new DBservices();
            return dbs.getListGiudesUsers(id);
        }


        public void updateUser(string id)
        {
            DBservices dbs = new DBservices();
            dbs.UpdateUserDet(this, id);// id of guide
        }

        public List<User> getManager()
        {
            DBservices dbs = new DBservices();
            return dbs.getListManager();
        }
        public void updateManager()
        {
            DBservices dbs = new DBservices();
            dbs.UpdateManagerDet(this);
        }
    }
}