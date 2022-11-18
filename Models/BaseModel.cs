using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTools.ADO.Models
{
    public class BaseModel
    {
        /// <summary>
        /// represents the id of contact entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// represents the Created date of entity
        /// </summary>
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// represents the Updated date of entity
        /// </summary>
        public DateTime UpdateOn { get; set; }
    }
}
