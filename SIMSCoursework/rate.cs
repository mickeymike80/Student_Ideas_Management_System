namespace SIMSCoursework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rate")]
    public partial class rate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idea_Id { get; set; }

        public int user_Id { get; set; }

        public bool voted_Thumb { get; set; }

        public virtual idea idea { get; set; }

        public virtual user user { get; set; }
    }
}
