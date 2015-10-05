using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Abp.Application.Features
{
    /// <summary>
    /// Base class for feature settings
    /// </summary>
    [Table("AbpFeatures")]
    public abstract class FeatureSetting : CreationAuditedEntity<long>
    {
        /// <summary>
        /// Maximum length of the <see cref="Name"/> field.
        /// </summary>
        public const int MaxNameLength = 128;

        /// <summary>
        /// Maximum length of the <see cref="Value"/> property.
        /// </summary>
        public const int MaxValueLength = 2000;

        /// <summary>
        /// Feature name.
        /// </summary>
        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Value.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [MaxLength(MaxValueLength)]
        public virtual string Value { get; set; }

        protected FeatureSetting()
        {
            
        }

        protected FeatureSetting(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}