using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeListApp.Data
{
	public class AppDBContext:DbContext
	{
		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
		{ }
		public DbSet<Employee> Employees { get; set; }
	}
}
