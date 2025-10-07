
using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema.Payments;
// SRP (Single Responsibility Principle)
// Esta clase solo se encarga de procesar pagos con tarjeta de crédito.
// No maneja notificaciones ni lógica de negocio adicional
public class AFJS_CreditCardPayment : AFJS_IPaymentMethod
{
    // LSP (Liskov Substitution Principle)
    // Cualquier clase que implemente IPaymentMethod_SAIL puede sustituir a otra
    // sin alterar el comportamiento del sistema.
    public void AFJS_ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Tarjeta de Crédito] Pago procesado por ${amount}");
    }

}
