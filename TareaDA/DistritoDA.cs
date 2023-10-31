using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaBE;
using TareaEF;

namespace TareaDA
{
    public class DistritoDA
    {
        private readonly dbTareaAADEntities context;
        public DistritoDA()
        {
            context = new dbTareaAADEntities();
        }

        public List<DistritoBE> ListarDistritos()
        {
            var Lista = new List<DistritoBE>();
            foreach (Distrito dis in context.Distritoes)
            {
                DistritoBE distrito = new DistritoBE();
                distrito.id_distrito = dis.id_distrito;
                distrito.nombre_distrito = dis.nombre_distrito;
                Lista.Add(distrito);
            }
            return Lista;
        }
    }
}
