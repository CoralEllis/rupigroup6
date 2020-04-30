using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tar1.Models.DAL;

namespace Tar1.Models
{
    public class Apartment
    {
        int unitId;
        int apartmenttypeId;

        public int UnitId { get => unitId; set => unitId = value; }
        public int ApartmenttypeId { get => apartmenttypeId; set => apartmenttypeId = value; }

        public Apartment() { }
        public Apartment(int _unitId, int _apartmenttypeId)
        {
            UnitId = _unitId;
            ApartmenttypeId = _apartmenttypeId;

        }

        

        

    }
}