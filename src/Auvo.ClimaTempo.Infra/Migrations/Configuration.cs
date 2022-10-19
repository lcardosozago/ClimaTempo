namespace Auvo.ClimaTempo.Infra.Migrations
{
    using Auvo.ClimaTempo.Business.Models.Cidades;
    using Auvo.ClimaTempo.Business.Models.Estados;
    using Auvo.ClimaTempo.Business.Models.PrevisaoClimas;
    using Auvo.ClimaTempo.Infra.Data.Context;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Estados.AddOrUpdate(x => x.Id,
                new Estado() { Id = 1, Nome = "Acre", UF = "AC" },
                new Estado() { Id = 2, Nome = "Mato Grosso", UF = "MT" },
                new Estado() { Id = 3, Nome = "Mato Grosso do Sul", UF = "MS" },
                new Estado() { Id = 4, Nome = "Paraná", UF = "PR" },
                new Estado() { Id = 5, Nome = "Santa Catarina", UF = "SC" },
                new Estado() { Id = 6, Nome = "Rio Grande do Sul", UF = "RS" }
            );

            context.Cidades.AddOrUpdate(x => x.Id,
                new Cidade() { Id = 1, Nome = "Rio Branco", EstadoId = 1 },
                new Cidade() { Id = 2, Nome = "Rondonópolis", EstadoId = 2 },
                new Cidade() { Id = 3, Nome = "Campo Grande", EstadoId = 3 },
                new Cidade() { Id = 4, Nome = "Curitiba", EstadoId = 4 },
                new Cidade() { Id = 5, Nome = "Balneário Camboriú", EstadoId = 5 },
                new Cidade() { Id = 6, Nome = "Gramado", EstadoId = 6 },
                new Cidade() { Id = 7, Nome = "Itajaí", EstadoId = 4 },
                new Cidade() { Id = 8, Nome = "Corumbá", EstadoId = 3 },
                new Cidade() { Id = 9, Nome = "Cuiabá", EstadoId = 2 }
            );

            context.PrevisaoClimas.AddOrUpdate(x => x.Id,
                new PrevisaoClima() { Id = 1, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(1), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 16 },
                new PrevisaoClima() { Id = 2, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(2), Clima = "Tempestuoso", TemperaturaMinima = 8, TemperaturaMaxima = 20 },
                new PrevisaoClima() { Id = 3, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(3), Clima = "Tempestuoso", TemperaturaMinima = 6, TemperaturaMaxima = 18 },
                new PrevisaoClima() { Id = 4, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(4), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 5, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(5), Clima = "Tempestuoso", TemperaturaMinima = 5, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 6, CidadeId = 6, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 1, TemperaturaMaxima = 16 },
                new PrevisaoClima() { Id = 7, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(7), Clima = "Tempestuoso", TemperaturaMinima = 4, TemperaturaMaxima = 16 },
                new PrevisaoClima() { Id = 8, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(1), Clima = "Tempestuoso", TemperaturaMinima = 5, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 9, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(2), Clima = "Tempestuoso", TemperaturaMinima = 1, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 10, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(3), Clima = "Tempestuoso", TemperaturaMinima = 2, TemperaturaMaxima = 18 },
                new PrevisaoClima() { Id = 11, CidadeId = 5, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 5, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 12, CidadeId = 6, DataPrevisao = DateTime.Now.AddDays(5), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 13, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(6), Clima = "Tempestuoso", TemperaturaMinima = 2, TemperaturaMaxima = 13 },
                new PrevisaoClima() { Id = 14, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(7), Clima = "Tempestuoso", TemperaturaMinima = 6, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 15, CidadeId = 7, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 16 },
                new PrevisaoClima() { Id = 16, CidadeId = 8, DataPrevisao = DateTime.Now.AddDays(2), Clima = "Tempestuoso", TemperaturaMinima = 5, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 17, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(3), Clima = "Tempestuoso", TemperaturaMinima = 1, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 18, CidadeId = 9, DataPrevisao = DateTime.Now.AddDays(4), Clima = "Tempestuoso", TemperaturaMinima = 6, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 19, CidadeId = 9, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 7, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 20, CidadeId = 9, DataPrevisao = DateTime.Now.AddDays(6), Clima = "Tempestuoso", TemperaturaMinima = 8, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 21, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(7), Clima = "Tempestuoso", TemperaturaMinima = 9, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 22, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(1), Clima = "Tempestuoso", TemperaturaMinima = 4, TemperaturaMaxima = 18 },
                new PrevisaoClima() { Id = 23, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(2), Clima = "Tempestuoso", TemperaturaMinima = 2, TemperaturaMaxima = 19 },
                new PrevisaoClima() { Id = 24, CidadeId = 6, DataPrevisao = DateTime.Now.AddDays(3), Clima = "Tempestuoso", TemperaturaMinima = 9, TemperaturaMaxima = 16 },
                new PrevisaoClima() { Id = 25, CidadeId = 7, DataPrevisao = DateTime.Now.AddDays(4), Clima = "Tempestuoso", TemperaturaMinima = 1, TemperaturaMaxima = 13 },
                new PrevisaoClima() { Id = 26, CidadeId = 8, DataPrevisao = DateTime.Now.AddDays(5), Clima = "Tempestuoso", TemperaturaMinima = 11, TemperaturaMaxima = 24 },
                new PrevisaoClima() { Id = 27, CidadeId = 3, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 4, TemperaturaMaxima = 12 },
                new PrevisaoClima() { Id = 28, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(7), Clima = "Tempestuoso", TemperaturaMinima = 6, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 29, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(2), Clima = "Tempestuoso", TemperaturaMinima = 1, TemperaturaMaxima = 11 },
                new PrevisaoClima() { Id = 30, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(3), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 31, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(4), Clima = "Tempestuoso", TemperaturaMinima = 2, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 32, CidadeId = 6, DataPrevisao = DateTime.Now.AddDays(5), Clima = "Tempestuoso", TemperaturaMinima = 5, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 33, CidadeId = 7, DataPrevisao = DateTime.Now.AddDays(6), Clima = "Tempestuoso", TemperaturaMinima = 2, TemperaturaMaxima = 12 },
                new PrevisaoClima() { Id = 34, CidadeId = 8, DataPrevisao = DateTime.Now.AddDays(7), Clima = "Tempestuoso", TemperaturaMinima = 6, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 35, CidadeId = 9, DataPrevisao = DateTime.Now.AddDays(1), Clima = "Tempestuoso", TemperaturaMinima = 7, TemperaturaMaxima = 18 },
                new PrevisaoClima() { Id = 36, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(2), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 13 },
                new PrevisaoClima() { Id = 37, CidadeId = 6, DataPrevisao = DateTime.Now.AddDays(3), Clima = "Tempestuoso", TemperaturaMinima = 6, TemperaturaMaxima = 12 },
                new PrevisaoClima() { Id = 38, CidadeId = 7, DataPrevisao = DateTime.Now.AddDays(4), Clima = "Tempestuoso", TemperaturaMinima = 7, TemperaturaMaxima = 13 },
                new PrevisaoClima() { Id = 39, CidadeId = 2, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 8, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 40, CidadeId = 9, DataPrevisao = DateTime.Now.AddDays(6), Clima = "Tempestuoso", TemperaturaMinima = 9, TemperaturaMaxima = 21 },
                new PrevisaoClima() { Id = 41, CidadeId = 4, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 1, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 42, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(1), Clima = "Tempestuoso", TemperaturaMinima = 2, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 43, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(2), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 16 },
                new PrevisaoClima() { Id = 44, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(3), Clima = "Tempestuoso", TemperaturaMinima = 2, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 45, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(4), Clima = "Tempestuoso", TemperaturaMinima = 4, TemperaturaMaxima = 11 },
                new PrevisaoClima() { Id = 46, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(5), Clima = "Tempestuoso", TemperaturaMinima = 5, TemperaturaMaxima = 12 },
                new PrevisaoClima() { Id = 47, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(6), Clima = "Tempestuoso", TemperaturaMinima = 2, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 48, CidadeId = 6, DataPrevisao = DateTime.Now.AddDays(7), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 13 },
                new PrevisaoClima() { Id = 49, CidadeId = 7, DataPrevisao = DateTime.Now.AddDays(1), Clima = "Tempestuoso", TemperaturaMinima = 4, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 50, CidadeId = 8, DataPrevisao = DateTime.Now.AddDays(2), Clima = "Tempestuoso", TemperaturaMinima = 5, TemperaturaMaxima = 12 },
                new PrevisaoClima() { Id = 51, CidadeId = 9, DataPrevisao = DateTime.Now.AddDays(3), Clima = "Tempestuoso", TemperaturaMinima = 7, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 52, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(4), Clima = "Tempestuoso", TemperaturaMinima = 8, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 53, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(5), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 16 },
                new PrevisaoClima() { Id = 54, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(6), Clima = "Tempestuoso", TemperaturaMinima = 4, TemperaturaMaxima = 11 },
                new PrevisaoClima() { Id = 55, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(7), Clima = "Tempestuoso", TemperaturaMinima = 1, TemperaturaMaxima = 12 },
                new PrevisaoClima() { Id = 56, CidadeId = 6, DataPrevisao = DateTime.Now.AddDays(1), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 18 },
                new PrevisaoClima() { Id = 57, CidadeId = 6, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 6, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 58, CidadeId = 7, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 7, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 59, CidadeId = 7, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 8, TemperaturaMaxima = 13 },
                new PrevisaoClima() { Id = 60, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(5), Clima = "Tempestuoso", TemperaturaMinima = 4, TemperaturaMaxima = 12 },
                new PrevisaoClima() { Id = 61, CidadeId = 8, DataPrevisao = DateTime.Now.AddDays(6), Clima = "Tempestuoso", TemperaturaMinima = 5, TemperaturaMaxima = 16 },
                new PrevisaoClima() { Id = 62, CidadeId = 8, DataPrevisao = DateTime.Now, Clima = "Tempestuoso", TemperaturaMinima = 6, TemperaturaMaxima = 18 },
                new PrevisaoClima() { Id = 63, CidadeId = 9, DataPrevisao = DateTime.Now.AddDays(1), Clima = "Tempestuoso", TemperaturaMinima = 2, TemperaturaMaxima = 19 },
                new PrevisaoClima() { Id = 64, CidadeId = 9, DataPrevisao = DateTime.Now.AddDays(2), Clima = "Tempestuoso", TemperaturaMinima = 1, TemperaturaMaxima = 12 },
                new PrevisaoClima() { Id = 65, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(3), Clima = "Tempestuoso", TemperaturaMinima = 3, TemperaturaMaxima = 15 },
                new PrevisaoClima() { Id = 66, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(4), Clima = "Tempestuoso", TemperaturaMinima = 4, TemperaturaMaxima = 14 },
                new PrevisaoClima() { Id = 67, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(5), Clima = "Tempestuoso", TemperaturaMinima = 7, TemperaturaMaxima = 16 },
                new PrevisaoClima() { Id = 68, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(6), Clima = "Tempestuoso", TemperaturaMinima = 8, TemperaturaMaxima = 18 },
                new PrevisaoClima() { Id = 69, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(7), Clima = "Tempestuoso", TemperaturaMinima = 9, TemperaturaMaxima = 17 },
                new PrevisaoClima() { Id = 70, CidadeId = 7, DataPrevisao = DateTime.Now.AddDays(1), Clima = "Tempestuoso", TemperaturaMinima = 1, TemperaturaMaxima = 13 }
            );
        }
    }
}
