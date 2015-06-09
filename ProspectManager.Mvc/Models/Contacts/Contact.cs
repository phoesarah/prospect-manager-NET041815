using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProspectManager.Mvc.Models.Contacts
{
    public class Contact
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        [EmailAddress]
        public string Email { get; set; }

<<<<<<< HEAD
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
=======
        [DisplayName("Birthdate")]
>>>>>>> 09a537b3fb9da8f9f7252d91f4d5be06d39a5105
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string ReturnDateForDisplay
        {
            get { return this.BirthDate.ToString(); }
        }
    }
}
