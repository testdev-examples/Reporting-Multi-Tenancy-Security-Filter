using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryFilterServiceApp.Data {
    public class Report {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public byte[] ReportLayout { get; set; }
        public string DisplayName { get; set; }
        public Student Student { get; set; }
    }
}
