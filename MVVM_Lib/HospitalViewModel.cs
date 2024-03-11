
using DataLayerLib;

namespace MVVM_Lib
{
    public class HospitalViewModel : ObservableObject
    {
        public HospitalDBContext? DB { get; set; }
        public HospitalViewModel Init(HospitalDBContext newDB)
        {
            DB = newDB;
            Patients = DB.Patients.ToList();
            Examinations = DB.Examinations.ToList();

            VMDoctors = DB.Doctors.Select(x => new DoctorViewModel { DoctorID = x.DoctorID, Firstname = x.Firstname, Lastname = x.Lastname, GPTDoctor =! x.Firstname.StartsWith("Z"),DoctorLink = new Uri("http://www.lusthouse.at/")}).ToList();
            return this;
        }
        private List<Patient> patients;

        public List<Patient> Patients
        {
            get { return patients; }
            set
            {
                patients = value;
                RaisePropertyCHangedEvent(nameof(patients));
            }
        }

        private List<DoctorViewModel> _VMDoctors;

        public List<DoctorViewModel> VMDoctors
        {
            get { return _VMDoctors; }
            set
            {
                _VMDoctors = value;
                RaisePropertyCHangedEvent(nameof(VMDoctors));
            }
        }


        private Patient? selectedPatient;

        public Patient? SelectedPatient
        {
            get { return selectedPatient; }
            set
            {
                selectedPatient = value;
                RaisePropertyCHangedEvent(nameof(selectedPatient));
            }
        }

        private List<Examination> examinations;

        public List<Examination> Examinations
        {
            get { return examinations; }
            set
            {
                examinations = value;
                RaisePropertyCHangedEvent(nameof(examinations));
            }
        }



    }

}
