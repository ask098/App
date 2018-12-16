using System;

namespace app.entities
{
    public class Academy
    {
        public int Id {get;set;}
        public string Email {get;set;}
        public int Nit {get;set;}
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }

        public string Addres { get; set; }
        public datetime CreationDate { get; set; }

        public bool ForceChangePassword { get; set; }
        public string LastPassword { get; set; }
        public string BankAccount { get; set; }
        public string OwnerFirstName { get; set; }

        public string OwnerSecondName { get; set; }

        public string OwnerFirstSurname { get; set; }

        public string OwnerSecondSurname { get; set; }
        public string OwnerTypeId { get; set; }

        public string OwnerId { get; set; }

        public string Desc { get; set; }

        public datetime LastActivationDate { get; set; }

        public string Department { get; set; }

        public string City { get; set; }

        public string LocationLong { get; set; }

        public string LocationLat { get; set; }



         
        
    }
}
