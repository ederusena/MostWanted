using MostWasted.Models;
using MostWasted.Repository.Context;
using System.Linq;

namespace MostWasted.Repository
{
    public class ProcuradoRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public ProcuradoRepository(DataBaseContext ctx)
        {
            dataBaseContext = ctx;
        }

        public IList<ProcuradoModel> Listar()
        {
            var lista = new List<ProcuradoModel>();
            lista = dataBaseContext.Procurado.ToList<ProcuradoModel>();
            return lista;
        }

        public ProcuradoModel Consultar(int id)
        {
            var procurado = dataBaseContext.Procurado.Find(id);
            return procurado;
        }

        public IList<ProcuradoModel> PorNome(string nome)
        {
            var lista = new List<ProcuradoModel>();
            lista = dataBaseContext.Procurado.Where(c => c.NomeProcurado.Contains(nome)).ToList<ProcuradoModel>();
            return lista;
        }

        public IList<ProcuradoModel> PorNacionalidade(string pais)
        {
            var lista = new List<ProcuradoModel>();
            lista = dataBaseContext.Procurado.Where(c => c.Nacionalidade.Contains(pais)).ToList<ProcuradoModel>();
            return lista;
        }


        public IList<ProcuradoModel> PorAgencia(string agencia)
        {
            var lista = new List<ProcuradoModel>();
            lista = dataBaseContext.Procurado.Where(c => c.NomeAgencia.Contains(agencia)).ToList<ProcuradoModel>();
            return lista;
        }


        public IList<ProcuradoModel> PorRecompensaCrescente( )
        {
            var lista = new List<ProcuradoModel>();
            lista = dataBaseContext.Procurado.OrderBy(c => c.Recompensa).ToList<ProcuradoModel>();
            return lista;
        }

        public IList<ProcuradoModel> PorRecompensaDecrescente()
        {
            var lista = new List<ProcuradoModel>();
            lista = dataBaseContext.Procurado.OrderByDescending(c => c.Recompensa).ToList<ProcuradoModel>();
            return lista;
        }

        public void Inserir(ProcuradoModel procurado)
        {
            dataBaseContext.Procurado.Add(procurado);
            dataBaseContext.SaveChanges();
        }

        public void Update(ProcuradoModel procurado)
        {
            dataBaseContext.Procurado.Update(procurado);
            dataBaseContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var procurado = new ProcuradoModel { ProcuradoId = id };

            dataBaseContext.Procurado.Remove(procurado);
            dataBaseContext.SaveChanges();
        }
    }
}