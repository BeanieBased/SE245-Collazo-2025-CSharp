using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MidTermCorrectThistime;
using Validation;

namespace MidTerm
{
    class PersonV2 : Person
    {
        private string cellPhone;
        private string instagramURL;

        public PersonV2()
        {
            cellPhone = "";
            instagramURL = "";
        }


        public string CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                if (!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    cellPhone = "Cell Phone is Required";
                }
                else
                {
                    cellPhone = value;
                    feedbackClass += "\n" + value;
                }
            }
        }

        public string InstagramURL
        {
            get
            {
                return instagramURL;
            }
            set
            {
                if (!(ValidationLibrary.IsItFilledIn(value)) || value == null)
                {
                    instagramURL = "\nInstagram URL Invalid";
                }
                else
                {
                    instagramURL = value;
                    feedbackClass += "\n" + value;
                }
            }
        }
    }
}