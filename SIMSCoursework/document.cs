namespace SIMSCoursework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int document_Id { get; set; }

        [StringLength(250)]
        public string path { get; set; }

        public int? idea_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime timestamp { get; set; }

        public virtual idea idea { get; set; }
    }
}
