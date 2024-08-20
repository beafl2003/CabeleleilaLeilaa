using CabeleleilaLeila.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabeleleilaLeilaa.Extensions
{
    public static class FormExtensions
    { 
    
        public static void NotifyError(this Form form)
        {

            form.NotifyError(Result.Factory.False());
        }

        public static void NotifyError(this Form form, Result result)
        {
            if(result.Success)
                return;

            var message = result.Messages.Any()
                ? "Foram encontradas inconsistências: " + Environment.NewLine + string.Join(Environment.NewLine, result.Messages):
                "Algumas inconsistências foram encontradas. Verifique se houve alguma falha e tente novamente. ";

            string caption = "Aviso";
            DialogResult resultado;
            resultado = MessageBox.Show(message, caption);
        }



    }
}
