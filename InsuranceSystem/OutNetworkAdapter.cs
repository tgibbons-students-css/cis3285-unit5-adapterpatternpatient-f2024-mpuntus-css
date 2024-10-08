namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        OutNetworkPatient patient;
        public OutNetworkAdapter(string newName, int newPolicyNumber)
        {
            patient = new OutNetworkPatient(newName, newPolicyNumber);
        }

        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            return (patient.CoveragePercent(ProcedureCost) * ProcedureCost);
        }

        public string getPatientName()
        {
            return patient.getPatientName();
        }

        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }

        public bool IsCovered(string patientName, string policyNumber)
        {

            //return true;
            string covered = patient.IsCovered(patientName, policyNumber); 

            if(covered.Equals("yes"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
