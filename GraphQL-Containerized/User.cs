namespace GraphQL_Containerized
{
    /// <summary>
    /// The User class describes a user managed within Turnstile.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User()
        {
            this.Properties = new List<Property>();
            this.UserGroupIds = new List<string>();
        }

        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The user id from the external system.
        /// </summary>
        public string ExternalUserId { get; set; }

        /// <summary>
        /// The users first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The users last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The users email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The home organization's id.
        /// </summary>
        public string HomeOrganizationId { get; set; }

        /// <summary>
        /// A list of user group id's the user belongs to.
        /// </summary>
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// Gets or sets the date on which the user last logged in.
        /// </summary>
        public DateTime LastLoggedIn { get; set; }

        /// <summary>
        /// Gets or sets the date on which the product was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the date on which the product was last modified.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// Gets or sets a collection of properties defined for the product.
        /// </summary>
        public List<Property> Properties { get; set; }
    }
}
