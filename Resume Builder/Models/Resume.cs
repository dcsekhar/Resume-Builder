using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Resume_Builder.Models
{
    public class Resume
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        [MaxLength(250)]
        public string Extension { get; set; }
        public byte[] Content { get; set; }
        public string MIMEType { get; set; }
    }

    public class ResumeDb : DbContext
    {
        public DbSet<Resume> Resumes { get; set; }
    }
}