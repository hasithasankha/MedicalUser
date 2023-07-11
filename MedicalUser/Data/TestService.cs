using MedicalUser.Model;
using System.Collections.Generic;
using System.Linq;
using System;
using MedicalUser.Data; 

namespace MedicalUser.Data 
{
    public class TestService
    {


        private readonly AppDbContext _Context;

        public TestService(AppDbContext Context)
        {
            _Context = Context;
        }

        //Get All Test
        public List<Test> GetTestList()
        {
            var testList = _Context.Test.ToList();
            return testList;
        }

        //Add New Test
        public void AddTestDetails(Test model)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    _Context.Test.Add(model);
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

        // Get Test By ID
        public Test GetTestById(int testId)
        {
            var data = _Context.Test.Where(a => a.Id == testId).FirstOrDefault();

            if (data != null)
            {
                return data;
            }
            return new Test();
        }

        //Update Test Details
        public void UpdateTest(Test model)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    var test = _Context.Test.FirstOrDefault(a => a.Id == model.Id);
                    if (test != null)
                    {
                        test.Test_Name = model.Test_Name;
                        test.Test_Description = model.Test_Description;
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


        //Delete Details
        public void DeleteTest(int testId)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    var data = _Context.Test.FirstOrDefault(a => a.Id == testId);
                    if (data != null)
                    {
                        _Context.Test.Remove(data);
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
