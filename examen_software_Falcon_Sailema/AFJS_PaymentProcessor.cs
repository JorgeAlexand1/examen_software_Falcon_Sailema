
using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema;

// DIP (Dependency Inversion Principle)
// Esta clase depende de las abstracciones (interfaces)
// y no de las implementaciones concretas.
public class AFJS_PaymentProcessor
{
    private readonly AFJS_IPaymentMethod _paymentMethod;
    private readonly AFJS_INotification _notification;

    // DIP: Inyección de dependencias mediante el constructor.
    // No se instancia ninguna clase directamente aquí.
    public AFJS_PaymentProcessor(AFJS_IPaymentMethod paymentMethod, AFJS_INotification notification)
    {
        _paymentMethod = paymentMethod;
        _notification = notification;
    }

    // SRP: Solo se encarga de coordinar el flujo del pago.
    public void AFJS_ExecutePayment(decimal amount, string user)
    {
        _paymentMethod.AFJS_ProcessPayment(amount);
        _notification.AFJS_SendNotification($"Usuario: {user} realizó un pago de ${amount} correctamente.");
        Console.WriteLine("--------------------------------------");
    }
}
