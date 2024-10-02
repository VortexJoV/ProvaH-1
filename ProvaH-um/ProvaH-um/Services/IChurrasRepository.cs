using ProvaH_um.Models;

namespace ProvaH_um.Services
{
        public interface IChurrasRepository
        {
            void CriarChurras(Churras churras);
            List<Churras> ListarChurras();
        }
}
