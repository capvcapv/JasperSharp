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
        public string parametros { get; set; }

        public string generaReporte()
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

            if (parametros != "" && parametros!=null)
            {
                cmd.Append(" -P ");
                cmd.Append(parametros);
            }

            return ExecuteCommand(cmd.ToString());

            
        }

        private string ExecuteCommand(string _Command)
        {
          
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + _Command);
           
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            
            procStartInfo.CreateNoWindow = true;
            
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            proc.WaitForExit();
           
            string result = proc.StandardOutput.ReadToEnd();

            return result;
        }

    }
}
