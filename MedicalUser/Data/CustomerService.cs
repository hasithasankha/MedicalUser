using MedicalUser.Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MedicalUser.Data
{
    public class CustomerService
    {
        private readonly AppDbContext _Context;

        public CustomerService(AppDbContext Context)
        {
            _Context = Context;
        }

        //Get All Customer
        public List<Customer> GetCustomersList()
        {
            var customerList = _Context.Customer.ToList();
            return customerList;
        }


        //Add New Customer
        public void AddCustomerDetails(Customer model)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    _Context.Customer.Add(model);
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


        // Get Customer By ID
        public Customer GetCustomerById(int customerId)
        {
            var data = _Context.Customer.Where(a => a.CusId == customerId).FirstOrDefault();

            if (data != null)
            {
                return data;
            }
            return new Customer();
        }


        //Update Customer Details
        public void UpdateCustomer(Customer model)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    var customer = _Context.Customer.FirstOrDefault(a => a.CusId == model.CusId);
                    if (customer != null)
                    {
                        customer.Name = model.Name;
                        customer.Email = model.Email;
                        customer.Address = model.Address;
                        _Context.Customer.Update(customer);
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
        public void DeleteCustomer(int customerId)
        {
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    var data = _Context.Customer.FirstOrDefault(a => a.CusId == customerId);
                    if (data != null)
                    {
                        _Context.Customer.Remove(data);
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