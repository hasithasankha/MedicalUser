using MedicalUser.Data;
using MedicalUser.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalUser.Data 
{
    public class DrugService
    {

        private readonly AppDbContext _Context;
   
        public DrugService(AppDbContext Context)
        {
            _Context = Context;
        }

        //Get All Drugs
        public List<Drug> GetDrugList()
        {
            var drugList = _Context.Drug.ToList();
            return drugList;
        }

        //Add New Drugs
        public void AddDrugDetails(Drug model)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    _Context.Drug.Add(model);
                    _Context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }


            }

        }

        //Get ID by Drugs
        public Drug GetDrugById(int drugID)
        {
            var data = _Context.Drug.Where(a => a.DrugId == drugID).FirstOrDefault();

            if (data != null)
            {
                return data;
            }
            return new Drug();
        }

        //Update Details
        public void UpdateDrug(Drug model)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    var drug = _Context.Drug.FirstOrDefault(a => a.DrugId == model.DrugId);
                    if (drug != null)
                    {
                        drug.Trde_Name = model.Trde_Name;
                        drug.Generic_Name = model.Generic_Name;
                        drug.Note = model.Note;
                        _Context.Drug.Update(drug);
                        _Context.SaveChanges();
                        transaction.Commit();
                    }

                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }


            }




        }

//Delete Drug
        
        public void DeleteDrug(int drugID)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    var data = _Context.Drug.FirstOrDefault(a => a.DrugId == drugID);
                    if (data != null)
                    {
                        _Context.Drug.Remove(data);
                        _Context.SaveChanges();
                        transaction.Commit();
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

}
