using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoapi.Models
{    
/// <summary>
/// 
/// </summary>
    public class Todo
    {        
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }        

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
        
        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        /// <value>
        /// The created date time.
        /// </value>
        public DateTime CreatedDateTime { get; set; }
        
        /// <summary>
        /// Gets or sets the modified date time.
        /// </summary>
        /// <value>
        /// The modified date time.
        /// </value>
        public DateTime  ModifiedDateTime { get; set; }
        
        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        public User CreatedBy { get; set; }

    }
}
