
using System.ComponentModel.DataAnnotations;

namespace ConferenceDTO
{
    public class Speaker
    {
        public int Id { get; set; }
        /// <summary>
        /// The name of the speaker
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        /// <summary>
        /// Biographical information regarding the speaker
        /// </summary>
        [StringLength(4000)]
        public string Bio { get; set; }
        /// <summary>
        /// Where you can learn more about the speaker
        /// </summary>
        
        [StringLength(1000)]
        public virtual string Website { get; set; }

    }
}
