using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApi.Model
{
	public class MemberDetails
	{
		[BsonId]
		public ObjectId _Id { get; set; }

		public int id { get; set; }
		public string firstName { get; set; }

		public string lastName { get; set; }
		public string memberCardNumber { get; set; }
		public string policyNumber { get; set; }
		public string dataOfBirth { get; set; }

	}
}