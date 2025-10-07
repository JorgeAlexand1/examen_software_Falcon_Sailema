using examen_software_Falcon_Sailema.Interfaces;
using examen_software_Falcon_Sailema.Notifications;
using examen_software_Falcon_Sailema.Payments;

namespace examen_software_Falcon_Sailema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Pagos - Prueba SOLID ===\n");

            // Datos simulados
            decimal amount = 150.75m;
            string user = "Alejandro Sailema";

            // Inyección de dependencias (Ejemplo: pago con tarjeta + notificación por correo)
            AFJS_IPaymentMethod payment = new AFJS_CreditCardPayment();
            AFJS_INotification notification = new AFJS_EmailNotification();

            AFJS_PaymentProcessor processor = new AFJS_PaymentProcessor(payment, notification);
            processor.AFJS_ExecutePayment(amount);

            Console.WriteLine("\nOperación finalizada correctamente.");
        }
    }
}
