
using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema.Payments;

public class AFJS_CreditCardPayment : AFJS_IPaymentMethod
{
    public void AFJS_ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Tarjeta de Crédito] Pago procesado por ${amount}");
    }

}
