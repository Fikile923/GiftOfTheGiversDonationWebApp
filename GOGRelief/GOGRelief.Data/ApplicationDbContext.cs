using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GOGRelief.Data.Models;
namespace GOGRelief.Data { public class ApplicationDbContext : IdentityDbContext { public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {} public DbSet<Incident> Incidents { get; set; } public DbSet<Donation> Donations { get; set; } } }