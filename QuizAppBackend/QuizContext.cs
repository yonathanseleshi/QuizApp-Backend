using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizAppBackend.Models;

namespace QuizAppBackend
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {}

        public DbSet<Question> Questions { get; set; }

        public DbSet<QuizAppBackend.Models.Quiz> Quiz { get; set; }

    }
}
