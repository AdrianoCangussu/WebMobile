namespace TrabAspNet.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrabAspNet.Models.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrabAspNet.Models.Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Tarefas.AddOrUpdate(
                  p => p.Titulo,
                  new Tarefas { Titulo = "Minha tarefa n� 1", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 2", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 3", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 4", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 5", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 6", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 7", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 8", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 9", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 10", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" },
                  new Tarefas { Titulo = "Minha tarefa n� 11", Concluido = false, DataLimite = DateTime.Now, Username = "adriano@dias.com.br", Descricao = "Descri��o das minhas tarefas agendadas" }
                );
            
        }
    }
}
