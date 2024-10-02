using ProvaH_um.Models;
using static ProvaH_um.Services.ChurrasRepository;

namespace ProvaH_um.Services
{
    public class ChurrasRepository : IChurrasRepository
    {
        private static List<Churras> listaChurras = [];

        public void CriarChurras(Churras churras)
        {
            listaChurras.Add(churras);
        }

        public List<Churras> ListarChurras()
        {
            return listaChurras;
        }
    }   
    
}
