using System;

namespace Lab4
{
    public class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;

        public string FirstName
        {
            get { return firstName; }


            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    firstName = value;
                }
                else
                {
                    firstName = "INVALID";
                }
            }
        }
        public string MiddleName
        {
            get { return middleName; }


            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    middleName = value;
                }
                else
                {
                    middleName = "INVALID";
                }
            }
        }
        public string LastName
        {
            get { return lastName; }


            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    lastName = value;
                }
                else
                {
                    lastName = "INVALID";
                }
            }
        }
        public string Street1
        {
            get
            {
                return street1;
            }

            set
            {
                street1 = value;
            }
        }
        public string Street2
        {
            get
            {
                return street2;
            }

            set
            {
                street2 = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
        public string Zip
        {
            get
            {
                return zip;
            }

            set
            {
                if(ValidationLibrary.IsMinimumAmount(value.Length,5))
                {
                    zip = value;
                }
                else
                {
                    zip = "INVALID";
                }
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                if (ValidationLibrary.IsMinimumAmount(value.Length, 10))
                {
                    phone = value;
                }
                else
                {
                    phone = "INVALID";
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (ValidationLibrary.IsValidEmail(value))
                {
                    email = value;
                }
                else
                {
                    email = "INVALID";
                }
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Person person1 = new Person();

                Console.Write("Please Enter First Name: ");
                person1.FirstName = Console.ReadLine();

                Console.Write("Please Enter Middle Name: ");
                person1.MiddleName = Console.ReadLine();

                Console.Write("Please Enter Last Name: ");
                person1.LastName = Console.ReadLine();

                Console.Write("Please Enter Street Address 1: ");
                person1.Street1 = Console.ReadLine();

                Console.Write("Please Enter Street Address 2 (if none, leave blank): ");
                person1.Street2 = Console.ReadLine();

                Console.Write("Please Enter City: ");
                person1.City = Console.ReadLine();

                Console.Write("Please Enter State: ");
                person1.State = Console.ReadLine();

                Console.Write("Please Enter Zip Code: ");
                person1.Zip = Console.ReadLine();

                Console.Write("Please Enter Phone Number: ");
                person1.Phone = Console.ReadLine();

                Console.Write("Please Enter Email Address: ");
                person1.Email = Console.ReadLine();


                // Output
                Console.WriteLine("\nPerson Information Stored Successfully!: ---\n");
                Console.WriteLine($"Name: {person1.FirstName} {person1.MiddleName} {person1.LastName}");
                Console.WriteLine($"Address: {person1.Street1}, {person1.Street2}");
                Console.WriteLine($"{person1.City}, {person1.State} {person1.Zip}");
                Console.WriteLine($"Phone: {person1.Phone}");
                Console.WriteLine($"Email: {person1.Email}");

                Console.ReadLine();
            }
        }
    }
}
