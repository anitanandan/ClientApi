using ClientApi.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApi.Repository
{
	public class SearchRecords : ISearchRecords
	{
		private readonly IConfiguration _configuration;
		private readonly ILogger<SearchRecords> _logger;

        

        public  SearchRecords(IConfiguration configuration, ILogger<SearchRecords> logger)
		{
			_configuration = configuration;
			_logger = logger;
		}
		public  async Task<IEnumerable<MemberDetails>> SearchMemberData(string policyno, string membercard)
		{
			try
			{
				MongoClient dbclient = new MongoClient(_configuration.GetConnectionString("EmployeeApiCon"));

				List<MemberDetails> dblist = new List<MemberDetails>();

				dblist = await dbclient.GetDatabase("sxcustomers").GetCollection<MemberDetails>("customer-details").Find(s => s.policyNumber.Contains(policyno)).ToListAsync();

				if (!string.IsNullOrEmpty(membercard) && !(membercard == "null"))
				{
					var finallist = dblist.Where(s => s.memberCardNumber.Contains(membercard)).ToList();
					if (finallist != null)
						return finallist;
				}
				return dblist;
			}
			catch (Exception ex)
			{
				_logger.Log(LogLevel.Error,ex.Message);

				throw;
			}
			finally
			{ 
			
			}
		}
	}
}
