using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HospitalManagement.DAL;
using HospitalManagement.EL;

namespace HospitalManagement.BLL
{
    class HospitalBLO
    {
        public DataTable loadAllData()
        {
            return new HospitalDAO().loadAll();

        }
        public bool Add(HospitalDTO hos)
        {
            if (hos.Name.Equals("") || hos.Birth.Equals("") || hos.Address.Equals("") || hos.MedicalHistory.Equals("") || hos.SecondExamine.Equals(""))
                return false;
            bool result = new HospitalDAO().Insert(hos);
            return result;

        }
        //public bool DeleteData(HospitalDTO hos)
        //{
        //    if (hos.Name.Equals("") || hos.Birth.Equals("") || hos.Address.Equals("") || hos.MedicalHistory.Equals("") || hos.SecondExamine.Equals(""))
        //        return false;
        //    bool result = new HospitalDAO().Delete(hos);
        //    return result;

        //}
        public List<HospitalDTO> find(String name)
        {

            return new HospitalDAO().findName(name);

        }
        public bool update(HospitalDTO hos)
        {
            if (hos.Name.Equals("") || hos.Birth.Equals("") || hos.Address.Equals("") || hos.MedicalHistory.Equals("") || hos.SecondExamine.Equals(""))
                return false;
            bool result = new HospitalDAO().Update(hos);
            return result;
        }

    }
}
