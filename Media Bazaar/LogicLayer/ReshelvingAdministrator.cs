using Media_Bazaar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ReshelvingAdministrator
    {
        DatabaseHelper db = new DatabaseHelper();

        public void GetAllReshelvingRequests(List<Reshelving>  reshelvings)
        {
            reshelvings.Clear();

            List<ReshelvingDTO> requestListDTO = db.GetReshelvingRequests();
            foreach (ReshelvingDTO item in requestListDTO)
            {                
                reshelvings.Add(DTOToReshelving(item));
            }            
        }
        public void RespondReshelving(int selectedRequestId, AppStatus status)
        {
            AppStatusDTO statusDTO = (AppStatusDTO)status;
            db.RespondReshelving(selectedRequestId,statusDTO);
        }
        public void ChangeAndAcceptReshelving(int selectedRequestId,int amount, AppStatus status)
        {
            AppStatusDTO statusDTO = (AppStatusDTO)status;
            db.ChangeAndAcceptReshelving(selectedRequestId,amount, statusDTO);
        }

        public void RequestReshelving(string itemname,int amount,string department,string specifications)
        {
            db.RequestReshelving(itemname, amount, department, specifications);
        }
        private Reshelving DTOToReshelving(ReshelvingDTO item)
        {
            AppStatus status = (AppStatus)item.Status;
            Reshelving reshelving = new Reshelving(item.Id, item.ItemName, item.Amount, item.Department, item.Specifications, status);
            return reshelving;
        }
    }
}
