﻿using P01_HospitalDatabase.Data;

namespace P01_HospitalDatabase
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new HospitalDatabaseContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

        }
    }
}
