using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.EL
{
    class HospitalDTO
    {
        private int Id;
        private String name;
        private String birth;
        private String address;
        private String medicalHistory;
        private String secondExamine;

        public HospitalDTO() {}
        public HospitalDTO(int Id, String name, String birth, String address, String medicalHistory, String secondExamine)
        {
            this.Id = Id;
            this.name = name;
            this.birth = birth;
            this.address = address;
            this.medicalHistory = medicalHistory;
            this.secondExamine = secondExamine;
        }
        public int ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
        public String Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public String Birth
        {
            get { return this.birth; }
            set { this.birth = value; }
        }
        public String Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public String MedicalHistory
        {
            get { return this.medicalHistory; }
            set { this.medicalHistory = value; }
        }
        public String SecondExamine
        {
            get { return this.secondExamine; }
            set { this.secondExamine = value; }
        }
    }
}
