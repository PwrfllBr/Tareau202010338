using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaBE;
using TareaDA;

namespace TareaBL
{
    public class DistritoBL
    {
        private readonly DistritoDA objDistritoDA;
        public DistritoBL()
        {
            objDistritoDA = new DistritoDA();
        }
        public List<DistritoBE> ListarDistritos()
        {
            try
            {
                return objDistritoDA.ListarDistritos();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
