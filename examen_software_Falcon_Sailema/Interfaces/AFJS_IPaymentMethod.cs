

namespace examen_software_Falcon_Sailema.Interfaces;

public interface AFJS_IPaymentMethod
{
    // ISP (Interface Segregation Principle)
    // Se define una interfaz específica solo para métodos de pago,
    // evitando depender de métodos que no se usan.
    void AFJS_ProcessPayment(decimal amount);
}
