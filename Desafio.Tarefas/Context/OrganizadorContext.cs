using Desafio.Tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Tarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) { }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}