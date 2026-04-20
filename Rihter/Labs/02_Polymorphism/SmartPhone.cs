namespace Rihter.Labs._02_Polymorphism;

public sealed class SmartPhone : Phone
{
    // override: ми офіційно замінюємо поведінку батька
    public override void Call()
    {
        Console.WriteLine("SmartPhone: Використовую 5G та шифрування...");
        base.Call();
    }
    
    // new: ми "ховаємо" батьківський метод, створюючи свою паралельну реальність
    public new void SendSms() => Console.WriteLine("SmartPhone: Надсилаю повідомлення через Telegram...");
}