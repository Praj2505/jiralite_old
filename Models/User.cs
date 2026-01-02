using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks;
namespace jiralite.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string UserName { get; set; }
        [ForeignKey(nameof(ID))]
        public UserCredential CredentialID { get; set; }
        [ForeignKey(nameof(ID))]
        public UserType UserType { get; set; }


    }
}
