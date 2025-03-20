using BTG.Aplicacao.Dtos;
using BTG.Aplicacao.Respostas;
using BTG.Dominio.Entidades;
using Flunt.Notifications;
using Flunt.Validations;
using MediatR;

namespace BTG.Aplicacao.Comandos.Pedido;

public class ExcluirPedidoComando : Comando<Guid>
{
    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="id"></param>
    public ExcluirPedidoComando(Guid id)
    {
        Id = id;
    }

    /// <summary>
    /// Id Pedido
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Criar comando
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Resposta<Guid>> CriarComandoAsync(IMediator mediator, Guid id, CancellationToken cancellationToken)
    {
        var comando = new ExcluirPedidoComando(id);
        return await mediator.Send(comando, cancellationToken);
    }
}
