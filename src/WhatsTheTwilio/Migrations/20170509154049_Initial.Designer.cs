using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WhatsTheTwilio.Models;

namespace WhatsTheTwilio.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20170509154049_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WhatsTheTwilio.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("WhatsTheTwilio.Models.Message", b =>
                {
                    b.Property<string>("To");

                    b.Property<string>("Body");

                    b.Property<string>("From");

                    b.Property<string>("Status");

                    b.HasKey("To");

                    b.ToTable("Messages");
                });
        }
    }
}
