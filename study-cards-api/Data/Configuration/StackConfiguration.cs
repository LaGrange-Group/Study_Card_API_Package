using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using study_cards_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace study_cards_api.Data.Configuration
{
    public class StackConfiguration : IEntityTypeConfiguration<Stack>
    {
        public void Configure(EntityTypeBuilder<Stack> builder)
        {
            builder.HasData(
                new Stack
                {
                    Id = 1,
                    Title = "React"
                },
                new Stack
                {
                    Id = 2,
                    Title = "C#"
                },
                new Stack
                {
                    Id = 3,
                    Title = "Flutter"
                });
        }
    }
}
