using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApi.Model
{
	public class Member
	{
		public ObjectId Id { get; set; }
		private int _policynumber { get; set; }

		private int _cardnumber { get; set; }

		public Member(int Policynumber, int Cardnumber)
		{
			_policynumber = Policynumber;
			_cardnumber = Cardnumber;

		}
	}
}
