

using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema.Notifications;

// SRP y OCP: Misma lógica que las demás notificaciones.
// Cada canal es independiente y extensible.
public class AFJS_WhatsAppNotification : AFJS_INotification
{
    public void AFJS_SendNotification(string message)
    {
        Console.WriteLine($"[WhatsApp] Notificación enviada: {message}");
    }
}
