using System;
using System.Collections.Generic;
namespace examen_software_Falcon_Sailema.Interfaces;

public interface AFJS_INotification
{
    // ISP (Interface Segregation Principle)
    // Interfaz dedicada exclusivamente a las notificaciones.
    // Esto evita acoplar funcionalidades que no correspondan a la clase.
    void AFJS_SendNotification(string message);
}
