using System.Collections.Generic;
using System.Linq;
using Task_3_working_Excel_document.DocumentData;

namespace Task_3_working_Excel_document
{
    internal class ChangingContactPerson
    {
        public Customers Changing(List<Customers> customers, string contactPerson, string nameOrganization)
        {
            Customers customer = customers.FirstOrDefault(c => c.NameOrganization == nameOrganization);
            customer.ContactPerson = contactPerson;
            return customer;
        }

    }
}
