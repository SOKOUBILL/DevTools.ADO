using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTools.ADO.Models
{
    public class Comment : BaseModel
    {

        /// <summary>
        /// represents the id of the contact concernend by this comment
        /// </summary>
        public int Contact_Id { get; set; }

        /// <summary>
        /// represents the content of comment
        /// </summary>
        public string Content { get; set; }

        
    }
}
