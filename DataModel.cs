namespace Craswell.Models
{
    /// <summary>
    /// The base data model
    /// </summary>
    public abstract class DataModel : IDataModel
    {
        /// <summary>
        /// Gets or sets the identifier of the data model.
        /// </summary>
        public virtual uint Id { get; set; }
    }
}
