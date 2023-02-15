﻿using System;
using German.Core.Interfaces;
namespace German.Core.Entities
{
	public class Course : IAuditableEntity
	{
		public Course()
		{
		}

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CourseUrl { get; set; }

    }
}

