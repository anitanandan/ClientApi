using ClientApi.Model;
using ClientApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SearchController : ControllerBase
	{
		//dependancy Injection
		private readonly ISearchRecords _searchrec;
	
		public SearchController( ISearchRecords searchrecord)
		{
			
			_searchrec = searchrecord;
		}

		
		[HttpGet]
		public async Task<ActionResult> SearchData(string policyno,string membercard)
		{
			try
			{
				if (string.IsNullOrEmpty(policyno))
				{
					return NotFound("Please enter the policy no");
				}
				var dblist= await _searchrec.SearchMemberData(policyno, membercard);
				if (dblist == null)
				{
					return NotFound();
				}
				return Ok(dblist);

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { 
				
			}
}
	}
}
