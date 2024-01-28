using System;
using MongoDB.Bson;

namespace PracticeExamples
{
	public class UserData
	{
		public ObjectId _id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}

