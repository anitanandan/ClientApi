using ClientApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApi.Repository
{
	public interface ISearchRecords
	{
		Task<IEnumerable<MemberDetails>> SearchMemberData(string policyno, string membercard);
	}
}
