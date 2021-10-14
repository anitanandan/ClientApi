using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApi.Repository
{
	public class ApiDbContext: DbContext
	{
		public ApiDbContext(DbContextOptions<ApiDbContext> dbContext) : base(dbContext)
		{

		}
	}
}
