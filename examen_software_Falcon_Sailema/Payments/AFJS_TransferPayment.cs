

using examen_software_Falcon_Sailema.Interfaces;

namespace examen_software_Falcon_Sailema.Payments;

public class AFJS_TransferPayment : AFJS_IPaymentMethod
{
    // SRP: Solo maneja pagos por transferencia bancaria.
    // OCP: Extiende el sistema agregando una nueva forma de pago
    // sin modificar código ya existente.
    public void AFJS_ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Transferencia] Pago procesado por ${amount}");
    }
}
