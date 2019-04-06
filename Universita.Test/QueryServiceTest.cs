using Microsoft.EntityFrameworkCore;
using Servuniv.Data;
using System;
using Universita.Services;
using Xunit;

namespace Universita.Test
{
    public class QueryServiceTest
    {
        private IQueryService queryService = new QueryService(new ServunivContext(new DbContextOptionsBuilder<ServunivContext>()
                                .UseSqlServer("Server =.; Database = servuniv; Trusted_Connection = True; MultipleActiveResultSets = true")
                                .Options));
        [Fact]
        public void GetEstudianteCarreraPlanTest()
        {
            var all = queryService.GetEstudianteCarreraPlan();
            Assert.NotEmpty(all);
        }

        [Fact]
        public void GetEstudianteCarreraPlanByIdTest()
        {
            Assert.NotNull(queryService.GetEstudianteCarreraPlanById("20162022"));
        }

        [Fact]
        public void GetEstudianteActividadesTest()
        {
            var all = queryService.GetEstudianteActividades();
            Assert.NotEmpty(all);
        }

        [Fact]
        public void GetEstudianteActividadesByIdTest()
        {
            Assert.NotNull(queryService.GetEstudianteActividadesById("20162022"));
        }

        [Fact]
        public void GetEstudianteDirTelTest()
        {
            var all = queryService.GetEstudianteDirTel();
            Assert.NotEmpty(all);
        }

        [Fact]
        public void GetEstudianteDirTelByIdTest()
        {
            Assert.NotNull(queryService.GetEstudianteDirTelById("20162022"));
        }

        [Fact]
        public void GetProfesoresPorTipoTest()
        {
            var all = queryService.GetProfesoresPorTipo();
            Assert.NotEmpty(all);
        }

        [Fact]
        public void GetProfesoresPorTipoByIdTest()
        {
            Assert.NotNull(queryService.GetProfesoresPorTipoById(1));
        }

        [Fact]
        public void GetMedioDePagoTest()
        {
            var all = queryService.GetMedioDePago();
            Assert.NotEmpty(all);
        }

        [Fact]
        public void GetMedioDePagoByIdTest()
        {
            Assert.NotNull(queryService.GetMedioDePagoById(1));
        }

    }
}
