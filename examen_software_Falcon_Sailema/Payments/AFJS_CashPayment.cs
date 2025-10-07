

using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema.Payments;

public class AFJS_CashPayment : AFJS_IPaymentMethod
{
    public void AFJS_ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Efectivo] Pago recibido por ${amount}");
    }
}
