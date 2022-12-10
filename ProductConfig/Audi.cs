using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConfig.resources.Font
{
    internal class Audi
    {
        //interni, volante, colore carrozzeria, cerchi
        String interni, volante, colo_car, cerchi;
        Boolean telo;


        Audi(String interni, String volante, String colo_car, String cerchi, Boolean telo)
        {
            this.interni = interni;
            this.volante = volante;
            this.colo_car = colo_car;
            this.cerchi=cerchi;
        }

    }
}
