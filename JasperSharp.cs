using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasperSharp
{
    public class JasperSharp
    {
        public string rutaBinarios { get; set; }
        public string reporte { get; set; }
        public string formato_salida {get;set;}

        public string tipo { get; set; }
        public string host { get; set; }
        public string user { get; set; }
        public string clave { get; set; }
        public string bd {get; set;}
        public string db_driver { get; set; }
        public string db_url { get; set; }

        public void generaReporte()
        {
            StringBuilder cmd = new StringBuilder();

            cmd.Append(rutaBinarios);
            cmd.Append(@"\jasperstarter.exe pr ");
            cmd.Append(reporte);
            cmd.Append(" -f ");
            cmd.Append(formato_salida);
            cmd.Append(" -t ");
            cmd.Append(tipo);
            cmd.Append(" -H ");
            cmd.Append(host);
            cmd.Append(" -u ");
            cmd.Append(user);
            cmd.Append(" -p ");
            cmd.Append(clave);
            cmd.Append(" -n ");
            cmd.Append(bd);
            cmd.Append(" --db-driver ");
            cmd.Append(db_driver);
            cmd.Append(" --db-url ");
            cmd.Append(db_url);

            ExecuteCommand(cmd.ToString());

            
        }

        private void ExecuteCommand(string _Command)
        {
            //Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque. 
            //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
            //Para mas informacion consulte la ayuda de la consola con cmd.exe /? 
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + _Command);
            // Indicamos que la salida del proceso se redireccione en un Stream
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = true;
            //Inicializa el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            proc.WaitForExit();
            //Consigue la salida de la Consola(Stream) y devuelve una cadena de texto
            string result = proc.StandardOutput.ReadToEnd();
            //Muestra en pantalla la salida del Comando
            
        }

    }
}
