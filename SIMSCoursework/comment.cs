namespace SIMSCoursework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int comment_Id { get; set; }

        [StringLength(500)]
        public string comment_Body { get; set; }

        public int? idea_Id { get; set; }

        public int? user_Id { get; set; }

        public bool isPosted_Anonymous { get; set; }

        [StringLength(10)]
        public string status { get; set; }

        public bool isEnabled { get; set; }

        [Column(TypeName = "date")]
        public DateTime timestamp { get; set; }

        public virtual idea idea { get; set; }

        public virtual user user { get; set; }
    }
}
