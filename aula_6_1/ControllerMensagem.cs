using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_6_1
{
    class ControllerMensagem
    {
       public  Imensagem msg;
        public ControllerMensagem(Imensagem mensagem)
        {
            msg = mensagem;
        }
        public void realizarEnvio()
        {
            msg.Enviar();
        }
    }
}
