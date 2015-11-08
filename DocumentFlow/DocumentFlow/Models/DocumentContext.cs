using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DocumentFlow.Models
{
    public class DocumentContext: DbContext
    {
        public DbSet<Document> documents;
    }
}