using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations.Films
{
    public class SpecialFilmCategoryConfiguration : IEntityTypeConfiguration<SpecialCategory>
    {
        
        public void Configure(EntityTypeBuilder<SpecialCategory> builder)
        {
            builder.HasKey(x => x.ID);
            
        }
    }
}
