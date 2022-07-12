using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ContractDTO
    {
        private int contractId;
        private string userName;
        private string startDate;
        private string endDate;
        private string position;
        private string department;

        public int ContractId { get => contractId; set => contractId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string Position { get => position; set => position = value; }
        public string Department { get => department; set => department = value; }
        public ContractDTO(string userName, string startDate, string endDate, string position, string department)
        {
            this.UserName = userName;
            this.StartDate = startDate;
            if (endDate == "")
            {
                this.EndDate = "";
            }
            else
            {
                this.EndDate = endDate;
            }
            this.Position = position;
            this.Department = department;
        }
        public ContractDTO(int contractId, string userName, string startDate, string endDate, string position, string department)
        {
            this.ContractId = contractId;   
            this.UserName = userName;
            this.StartDate = startDate;
            if (endDate == "")
            {
                this.EndDate = "";
            }
            else
            {
                this.EndDate = endDate;
            }
            this.Position = position;
            this.Department = department;
        }
    }
}
