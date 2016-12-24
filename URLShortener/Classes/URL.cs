using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace URLShortener.Classes
{
    public class UploadedUrl
    {
        /// <summary>
        /// The original url to redirect to
        /// </summary>
        [Required]
        public string Url { get; set; }

        /// <summary>
        /// Randomly generated shortened url
        /// </summary>
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ShortenedUrl { get; set; }

        /// <summary>
        /// Amount of times url has been clicked
        /// </summary>
        public int Clicks { get; set; } = 0;

        /// <summary>
        /// Upload date of the shortened url
        /// </summary>
        public DateTime UploadDate { get; set; } = DateTime.Now;

    }
}
