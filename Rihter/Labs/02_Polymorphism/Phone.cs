namespace Rihter.Labs._02_Polymorphism;

public class Phone
{
    // Віртуальний метод: дозволяє нащадкам "вписатися" в логіку
    public virtual void Call() => Console.WriteLine("Phone: Здійснюю звичайний дзвінок...");

    // Невіртуальний метод: нащадки можуть його тільки 'сховати'
    public void SendSms() => Console.WriteLine("Phone: Надсилаю стандартне SMS...");
}