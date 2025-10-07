

using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema.Payments;

public class AFJS_TransferPayment : AFJS_IPaymentMethod
{
    public void AFJS_ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Transferencia] Pago procesado por ${amount}");
    }
}
