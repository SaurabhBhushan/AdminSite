﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AdminSite.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class RatnoTechEntities : DbContext
{
    public RatnoTechEntities()
        : base("name=RatnoTechEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<adminCredential> adminCredentials { get; set; }
    public virtual DbSet<Registration> Registrations { get; set; }
}
