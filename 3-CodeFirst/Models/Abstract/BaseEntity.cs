using System;
namespace _3_CodeFirst.Models.Abstract
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }

        public DateTime CreateDate { get; set; }

    }
}

