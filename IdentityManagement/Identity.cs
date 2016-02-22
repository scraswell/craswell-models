using System;

namespace Craswell.Models.IdentityManagement
{
    /// <summary>
    /// Models an identity.
    /// </summary>
    public class Identity : DataModel
    {
        /// <summary>
        /// Gets or sets the title for the identity.
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// Gets or sets the URI of the resource associated with the identity.
        /// </summary>
        public virtual string AssociatedResource { get; set; }

        /// <summary>
        /// Gets or sets the username for the identity.
        /// </summary>
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets the password for the identity.
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets or sets the description for the identity.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Gets or sets the notes of the identity.
        /// </summary>
        public virtual string Notes { get; set; }
    }
}
