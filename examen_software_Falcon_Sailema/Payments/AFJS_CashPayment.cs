

using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema.Payments;

// SRP: Clase con única responsabilidad (procesar pagos en efectivo)
// OCP: Se puede agregar sin modificar las clases existentes.
public class AFJS_CashPayment : AFJS_IPaymentMethod
{
    public void AFJS_ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Efectivo] Pago recibido por ${amount}");
    }
}
