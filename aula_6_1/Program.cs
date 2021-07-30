using System;

namespace aula_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerMensagem controllerMensagem = new ControllerMensagem(new Sms());
            controllerMensagem.realizarEnvio();

        }
    }
}
