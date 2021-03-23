using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MP_EF_HeberAndrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }



    public class Diet : CustomTreatment
    {
        public Diet(string dietName, string dietType, int dietSelect, int dietDaysProgram)
        {
            DietName = dietName;
            DietType = dietType;
            DietSelect = dietSelect;
            DietDaysProgram = dietDaysProgram;
        }
        public int Id { get; set; }
    }



    public class Diet1 : CustomTreatment
    {
        public Diet1(string dietName, string dietType, int dietSelect, int dietDaysProgram)
        {
            DietName = dietName;
            DietType = dietType;
            DietSelect = dietSelect;
            DietDaysProgram = dietDaysProgram;
        }
        public int Id { get; set; }
    }



    public class CustomTreatment
    {
        public string DietName { get; set; }
        public string DietType { get; set; }
        public int DietSelect { get; set; }
        public int DietDaysProgram { get; set; }
    }



    class CustomTreatmentContext : DbContext
    {
        public DbSet<Diet> Diets { get; set; }
        public DbSet<Diet1> Diets1 { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //s5d011\sqlexpres
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = CustomTreatment; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}


