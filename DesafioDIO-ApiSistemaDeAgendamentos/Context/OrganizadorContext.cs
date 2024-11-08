using Microsoft.EntityFrameworkCore;
using DIOSistemaDeAgendamentoApi.Models;

namespace DIOSistemaDeAgendamentoApi.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}