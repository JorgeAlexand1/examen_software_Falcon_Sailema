

using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema.Notifications;

// SRP: Solo envía SMS, sin mezclarse con otros canales.
// OCP: Podemos agregar nuevos tipos (como WhatsApp) sin tocar esta clase.
public class AFJS_SMSNotification : AFJS_INotification
{
    public void AFJS_SendNotification(string message)
    {
        Console.WriteLine($"[SMS] Notificación enviada: {message}");
    }
}
