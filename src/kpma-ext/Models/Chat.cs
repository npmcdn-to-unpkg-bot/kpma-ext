﻿using kpma_ext.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kpma_ext.Models
{
	[Table("Chat", Schema = "mess")]
	public class Chat: ILogModel
    {
		[Key]
		public int Id { get; set; }
		public int MetaObjectId { get; set; }
		public int ObjectId { get; set; }
		public int AuthorId { get; set; }
		public int DepartmentId { get; set; }
		public string MessageText { get; set; }

		[MaxLength(100)]
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		[MaxLength(100)]
		public string LastUpdatedBy { get; set; }
		public DateTime LastUpdatedDate { get; set; }

		[ForeignKey("MetaObjectId")]
		public MetaObject MetaObject { get; set; }
		[ForeignKey("DepartmentId")]
		public Department Department { get; set; }
		[ForeignKey("AuthorId")]
		public User Author { get; set; }
	}
}
