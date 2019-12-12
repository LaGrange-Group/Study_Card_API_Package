using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using study_cards_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace study_cards_api.Data.Configuration
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasData(
                new Card
                {
                    Id = 1,
                    Word = "state",
                    Definition = "JS object that holds values for a component",
                    StackId = 1
                },
                new Card
                {
                    Id = 2,
                    Word = "props",
                    Definition = "A way to pass data into components on initialization",
                    StackId = 1

                },
                new Card
                {
                    Id = 3,
                    Word = "component",
                    Definition = "Reusable building blocks for UI using JSX",
                    StackId = 1
                },
                new Card
                {
                    Id = 4,
                    Word = "variable",
                    Definition = "Named space in memory",
                    StackId = 2
                },
                new Card
                {
                    Id = 5,
                    Word = "class",
                    Definition = "Template for an object that consists of member variables, constructor, methods",
                    StackId = 2
                },
                new Card
                {
                    Id = 6,
                    Word = "object",
                    Definition = "Instance of a class",
                    StackId = 2
                },
                new Card
                {
                    Id = 7,
                    Word = "widget",
                    Definition = "Reusable component in Flutter",
                    StackId = 3
                });
        }
    }
}
