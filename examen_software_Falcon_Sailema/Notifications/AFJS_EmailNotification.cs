

using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema.Notifications;

// SRP: Solo se encarga de enviar notificaciones por correo.
public class AFJS_EmailNotification : AFJS_INotification
{
    public void AFJS_SendNotification(string message)
    {
        Console.WriteLine($"[Correo] Notificación enviada: {message}");
    }
}
