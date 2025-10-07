using examen_software_Falcon_Sailema.Interfaces;
using examen_software_Falcon_Sailema.Notifications;
using examen_software_Falcon_Sailema.Payments;

namespace examen_software_Falcon_Sailema
{
    internal class AFJS_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Pagos - Prueba SOLID ===\n");

            // Datos simulados
            decimal amount = 150.75m;
            string user = "Alejandro Sailema";

            decimal amount2 = 2000;
            string user2 = "Jorge Falcon";

            // Inyección de dependencias (Ejemplo: pago con tarjeta + notificación por correo)
            AFJS_IPaymentMethod payment = new AFJS_CreditCardPayment();
            AFJS_INotification notification = new AFJS_EmailNotification();
            AFJS_IPaymentMethod payment2 = new AFJS_TransferPayment();
            AFJS_INotification notification2 = new AFJS_SMSNotification();

            AFJS_PaymentProcessor processor = new AFJS_PaymentProcessor(payment, notification);
            AFJS_PaymentProcessor processor2 = new AFJS_PaymentProcessor(payment2, notification2);


            processor.AFJS_ExecutePayment(amount, user);
            processor2.AFJS_ExecutePayment(amount2, user2);

            Console.WriteLine("\nOperación finalizada correctamente.");
        }
    }
}
