using BTG.Aplicacao.Contratos;
using Flunt.Notifications;

namespace BTG.Aplicacao.Comandos;

public abstract class Comando : Notifiable<Notification>, IComando
{
    protected Comando() { }
}

public abstract class Comando<TResultado> : Notifiable<Notification>, IComando<TResultado>
{
    protected Comando() : base() { }
}