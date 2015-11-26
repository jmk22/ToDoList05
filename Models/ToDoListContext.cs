using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoList05.Models
{
    public partial class ToDoListContext : DbContext
    {
        public ToDoListContext() : base("name=ToDoListContext")
        {

        }
        public virtual DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}