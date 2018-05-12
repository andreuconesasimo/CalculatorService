using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCalculadora
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Suma(int num1, int num2);
        [OperationContract]
        int Resta(int num1, int num2);
        [OperationContract]
        int Multiplicacion(int num1, int num2);
        [OperationContract]
        int Division(int num1, int num2);
    }
}
