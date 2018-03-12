namespace SIMSCoursework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class idea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public idea()
        {
            comments = new HashSet<comment>();
            documents = new HashSet<document>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idea_Id { get; set; }

        public int category_Id { get; set; }

        public int academicYear_Id { get; set; }

        [Display(Name = "Posted by")]
        public int submitted_By { get; set; }

        [StringLength(250)]
        [Display(Name = "Title")]
        public string idea_Title { get; set; }

        [StringLength(1000)]
        [Display(Name = "Body")]
        public string idea_Body { get; set; }

        [Display(Name = "Views")]
        public int view_Count { get; set; }

        public bool isPosted_Anonymous { get; set; }

        [StringLength(10)]
        [Display(Name = "Status")]
        public string status { get; set; }

        public bool isEnabled { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Time of post")]
        public DateTime timestamp { get; set; }

        public virtual academic_year academic_year { get; set; }

        public virtual category category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<document> documents { get; set; }

        public virtual rate rate { get; set; }
    }
}
