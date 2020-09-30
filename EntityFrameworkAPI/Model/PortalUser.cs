using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkAPI.Model
{
    public class PortalUser
    {

        public PortalUser()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "username is obligatory")]
        public string Username { get; set; } = default!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "firtsName is obligatory")]
        [RegularExpression("^[a-zA-Z-α-ωΑ-Ω.-]+\\s?[a-zA-Z-α-ωΑ-Ω.]+?$",
            ErrorMessage = "first name must have only characters, numbers not allowed")]
        [StringLength(32, MinimumLength = 2)]
        public string FirstName { get; set; } = default;

        [Required(AllowEmptyStrings = false, ErrorMessage = "last name is obligatory")]
        [RegularExpression("^[a-zA-Z-α-ωΑ-Ω.-]+\\s?[a-zA-Z-α-ωΑ-Ω.]+?$",
            ErrorMessage = "last name must have only characters, numbers not allowed")]
        [StringLength(32, MinimumLength = 2)]
        public string LastName { get; set; } = default!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "email is obligatory")]
        [StringLength(150, MinimumLength = 2)]
        [EmailAddress(ErrorMessage = "The email address is no valid")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "country is obligatory")]
        public string Country { get; set; } = default!;

        [Required(ErrorMessage = "address is obligatory")]
        public string Address { set; get; } = default!;

        [Required(ErrorMessage = "postal code is obligatory")]
        public string PostalCode { set; get; } = default!;

#nullable enable
        public string? TelCountryCode { set; get; }

        public string? Telephone { get; set; }

        [Required(ErrorMessage = "mobileCountryCode is obligatory")]
        public string MobileCountryCode { get; set; } = default!;

        [Required(ErrorMessage = "mobile is obligatory")]
        public string Mobile { get; set; } = default!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "identificationNum is obligatory")]
        [StringLength(50, MinimumLength = 2)]
        public string IdentificationNum { get; set; } = default!;

        [Required(ErrorMessage = "identificationNum is obligatory")]
        public string IdentificationNumType { get; set; } = default!;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "yyyy-mm-dd")]
        [Required(ErrorMessage = "identificationNumExpiration is obligatory")]
        public DateTime IdentificationNumExpiration { get; set; }

        [Required(ErrorMessage = "organizationId is obligatory")]
        public long OrganizationId { get; set; }
    }
}
