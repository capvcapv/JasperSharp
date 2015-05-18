# JasperSharp
Libreria para el uso JasperStarter desde .NET

##Requisitos 

-JasperStarter
-.NET Framework 4 


##Modo de uso 

```sh
JasperSharp.JasperSharp jasper = new JasperSharp.JasperSharp();
jasper.rutaBinarios = "Ruta donde se encuentran los binarios de JasperStarter";
jasper.reporte = "Ruta de reporte con extension .jasper";
jasper.formato_salida = "view";
jasper.host = "host";
jasper.tipo ="tipo";
jasper.user = "user";
jasper.clave = "clave";
jasper.bd ="bd";
jasper.db_driver ="db_driver";
jasper.db_url = "db_url";

Console.WriteLine( jasper.generaReporte());
```

