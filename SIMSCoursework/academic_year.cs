namespace SIMSCoursework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class academic_year
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public academic_year()
        {
            ideas = new HashSet<idea>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int academicYear_Id { get; set; }

        [StringLength(9)]
        public string academicYear_Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? startDate_AcademicYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime? endDate_AcademicYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime? closureDate_Ideas { get; set; }

        [Column(TypeName = "date")]
        public DateTime? closureDate_Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<idea> ideas { get; set; }
    }
}
