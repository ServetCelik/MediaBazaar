using DatabaseLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ContractAdmin
    {
        List<Contract> contracts = new List<Contract>();
        List<ContractDTO> contractDTOs = new List<ContractDTO>();
        ContractDatabase contractDB = new ContractDatabase();
   

        public void AddContract(Contract contract)
        {
           
            contracts.Add(contract);

            contractDB.AddContractToDB(contract.UserName, contract.StartDate, contract.EndDate, contract.Position, contract.Department);
            
        }
        public List<Contract> ReturnEmployeeContractHistory(string userName)
        {
            List <Contract> contractHistory = new List<Contract>();
            for (int i = 0; i < contracts.Count; i++)
            {
                if (contracts[i].UserName == userName)
                {
                    contractHistory.Add(contracts[i]);
                }
            }
            return contractHistory;
        }

        public void EditContractDetails(int contractId,string userName, string startDate, string endDate, string position, string department)
        {
            for (int i = 0; i < contracts.Count; i++)
            {
                if (contracts[i].ContractId == contractId)
                {
                    contracts[i].StartDate = startDate;
                    contracts[i].EndDate = endDate;
                    contracts[i].Position = position;
                    contracts[i].Department = department;
                    
                }
            }

            contractDB.EditContractInDB(contractId,userName, startDate, endDate, position, department);
        }
         public int GetContractId(string userName, string startDate, string endDate, string position, string department)
        {
            int contractId = 0;
            for (int i = 0; i < contracts.Count; i++)
            {
                if (contracts[i].UserName == userName && contracts[i].StartDate == startDate && contracts[i].EndDate == endDate && contracts[i].Position == position && contracts[i].Department == department)
                {
                    contractId = contracts[i].ContractId;
                }
            }
            return contractId;
        }
        public Contract MapperContractObject(ContractDTO contractDTO)
        {
            Contract contract = new Contract(contractDTO.ContractId,contractDTO.UserName, contractDTO.StartDate, contractDTO.EndDate, contractDTO.Position, contractDTO.Department);
            return contract;
        }

        // adds employee dtos list to employees list
        public void MapperContractList(List<ContractDTO> contractdTOs)
        {
            contracts.Clear();
            foreach (var item in contractdTOs)
            {
                contracts.Add(MapperContractObject(item));
            }
        }

        // update employees list in database and local memory using the dtos list.
        public void UpdateContractsLists()
        {
            contractDB.GetAllContractsFromDB(contractDTOs);
            MapperContractList(contractDTOs);
        }

        public int GetTimesContractRenewed(string userName)
        {
           return ReturnEmployeeContractHistory(userName).Count;
        }

        public DateTime GetLatestEndDateBeforePermanentContract( string userName)
        {

            List<Contract> tempConttractHistory = ReturnEmployeeContractHistory(userName);

            DateTime firstStartDate;
            DateTime latestEndDateBeforePermanentContract = DateTime.MinValue;
            for (int i = 0; i < tempConttractHistory.Count; i++)
            {
                firstStartDate = DateTime.ParseExact(tempConttractHistory[0].EndDate, "dd/MM/yyyy", null);
                latestEndDateBeforePermanentContract = firstStartDate.AddYears(2);

            }


            return latestEndDateBeforePermanentContract;

        }
        public bool CheckIfContractCanBeRenewed(string startDate, string endDate, string userName )
        {
            DateTime contractStartDate = DateTime.ParseExact(startDate, "dd/MM/yyyy", null);
            DateTime contractEndDate = DateTime.ParseExact(endDate, "dd/MM/yyyy", null);
            DateTime latestDateBeforePermanentContract = GetLatestEndDateBeforePermanentContract(userName);
            int contractTimesRenewed = GetTimesContractRenewed(userName);
          

            if (contractTimesRenewed < 3 && contractEndDate <= latestDateBeforePermanentContract)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool CheckIfTempContractDurationIsValid(string startDate, string endDate, string userName)
        {
            DateTime contractStartDate = DateTime.ParseExact(startDate, "dd/MM/yyyy", null);
            DateTime contractEndDate = DateTime.ParseExact(endDate, "dd/MM/yyyy", null);
            DateTime latestDateBeforePermanentContract = GetLatestEndDateBeforePermanentContract(userName);

            if (contractEndDate <= latestDateBeforePermanentContract)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool CheckIfFisrtContractDurationIsValid(string startDate, string endDate)
        {
            DateTime contractStartDate = DateTime.ParseExact(startDate, "dd/MM/yyyy", null);
            DateTime contractEndDate = DateTime.ParseExact(endDate, "dd/MM/yyyy", null);
            DateTime latestDateBeforePermanentContract = contractStartDate.AddYears(2);

            if (contractEndDate == null || contractEndDate <= latestDateBeforePermanentContract)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public DateTime GetLatestEndDateOfFistContractBeforePermanentContract(string startDate)
        {
            DateTime contractStartDate = DateTime.ParseExact(startDate, "dd/MM/yyyy", null);
            DateTime latestDateBeforePermanentContract = contractStartDate.AddYears(2);
            return latestDateBeforePermanentContract;
        }
        public Contract FindCurrentContract(string userName, string startDate, string endDate, string position)
        {
            Contract currentContract = null;
            for (int i = 0; i < ReturnEmployeeContractHistory(userName).Count; i++)
            {
                if (ReturnEmployeeContractHistory(userName)[i].StartDate == startDate && ReturnEmployeeContractHistory(userName)[i].EndDate == endDate && ReturnEmployeeContractHistory(userName)[i].Position == position)
                {
                    currentContract= ReturnEmployeeContractHistory(userName)[i];
                }
            }
            return currentContract;
        }

    }
}
