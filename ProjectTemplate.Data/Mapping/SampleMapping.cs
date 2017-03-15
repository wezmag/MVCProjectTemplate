using ProjectTemplate.Core.DomainModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProjectTemplate.Data.Mapping
{
    public class SampleMapping : EntityTypeConfiguration<Sample>
    {
        public SampleMapping()
        {
            //資料表名稱
            ToTable("Samples");

            //設定Key值
            HasKey(s => s.Id); 
            //設定ID為Identity
            Property(s => s.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //設定Name不可為NULL，長度100
            Property(s => s.Name).IsRequired().HasMaxLength(100);
            //設定Description可為NULL，長度1024
            Property(s => s.Description).IsOptional().HasMaxLength(1024);
        }
    }
}
