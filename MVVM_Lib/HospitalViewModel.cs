
using DataLayerLib;

namespace MVVM_Lib
{
    public class HospitalViewModel: ObservableObject
    {
        public HospitalDBContext?  DB{ get; set; }
        public HospitalViewModel Init(HospitalDBContext newDB)
		{
		  DB = newDB;
			Patients = DB.Patients.ToList();
			return this;
		}
		private List<Patient> patients;

		public List<Patient> Patients
		{
			get { return patients; }
			set { patients = value;
				RaisePropertyCHangedEvent(nameof(patients));
			}
		}

		private Patient? selectedPatient;

		public Patient? SelectedPatient
		{
			get { return selectedPatient; }
			set { selectedPatient = value;
            RaisePropertyCHangedEvent(nameof(selectedPatient));
            }
		}


	}

}
