
namespace DevTools.ADO.Models
{
    public class Contact : BaseModel
    {
        /// <summary>
        /// represents the FirstName of contact
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// represents the LastName of contact
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// represents the City of contact
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// represents the PostalCode of contact
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// represents all messages concerned by this contact
        /// </summary>
        public string PhoneNumber { get; set; }





    }
}
