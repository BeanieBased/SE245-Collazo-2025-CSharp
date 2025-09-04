using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace MidTerm
{ 
    class Person
    {
        private string fname;
        private string mname;
        private string lname;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;
        public string feedbackClass;

        public Person()
        {
            fname = "";
            mname = "";
            lname = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            zip = "";
            phone = "";
            email = "";
            feedbackClass = "";
        }

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                if(!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    fname = "First Name is Required";
                    feedbackClass += fname;
                } else
                {
                    fname = value;
                    feedbackClass += value;
                }
            }
        }

        public string Mname
        {
            get
            {
                return mname;
            }
            set
            {
                if (!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    mname = "\nMiddle Name/Initial Invalid";
                    feedbackClass += mname;
                }
                else
                {
                    mname = value;
                    feedbackClass += "\n" + value;
                }
            }
         }

        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                if (!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    lname = "\nLast Name Invalid";
                    feedbackClass += lname;
                }
                else
                {
                    lname = value;
                    feedbackClass += "\n" + value;
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
                if (!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    street1 = "\nStreet 1 Name Invalid";
                    feedbackClass += street1;
                }
                else
                {
                    street1 = value;
                }
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
                feedbackClass += "\n" + value;
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
                if (!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    city = "\nCity is Required";
                    feedbackClass += city;
                }
                else
                {
                    city = value;
                    feedbackClass += "\n" + value;
                }
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
                if (!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    state = "\nState is Required";
                    feedbackClass += state;
                }
                else
                {
                    state = value;
                    feedbackClass += "\n" + value;
                }
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
                if (!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    zip = "\nZIP Code is Required";
                    feedbackClass += zip;
                }
                else
                {
                    zip = value;
                    feedbackClass += "\n" + value;
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
                if (!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    phone = "\nPhone Number is Required";
                    feedbackClass += phone;
                }
                else
                {
                    phone = value;
                    feedbackClass += "\n" + value;
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
                if (!(ValidationLibrary.IsValidEmail(value)) || value == null)
                {
                    email = "\nINVALID EMAIL";
                    feedbackClass += email;                    
                }
                else
                {
                    email = value;
                    feedbackClass += "\n" + value;
                }
            }
        }
    }
}