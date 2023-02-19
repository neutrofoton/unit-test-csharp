using System;
namespace NeutroLab.BusinessLogic
{
	public class Name
	{
		public string MakeFullName(string firstName, string lastName)
		{
			return $"{firstName} {lastName}";
		}
	}
}

