using NewExam_sem3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewExam_sem3.Context
{
    public class NewExamDbContext : DbContext
    {
        DbSet<NewExam> NewExams { get; set; }
    }
}