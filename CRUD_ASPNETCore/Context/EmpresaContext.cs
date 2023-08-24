using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIVTECH2.Models;
using Microsoft.EntityFrameworkCore;

namespace DIVTECH2.Context
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> op) : base(op) { }   

        public DbSet<FornecedorModel> Fornecedores { get; set; }
    }
}