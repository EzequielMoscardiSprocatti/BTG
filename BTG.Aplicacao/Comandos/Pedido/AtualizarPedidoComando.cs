﻿using BTG.Aplicacao.Dtos;
using BTG.Aplicacao.Respostas;
using BTG.Dominio.Entidades;
using Flunt.Notifications;
using Flunt.Validations;
using MediatR;

namespace BTG.Aplicacao.Comandos.Pedido;

public class AtualizarPedidoComando : Comando<Guid>
{
    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="codigoPedido"></param>
    /// <param name="codigoCliente"></param>
    /// <param name="produtos"></param>
    public AtualizarPedidoComando(Guid id, int codigoPedido, int codigoCliente, List<Produto> produtos)
    {
        AddNotifications(new Contract<Notification>()
           .Requires()
           .IsGreaterThan(codigoPedido, 0, "CodigoPedido", "O código do pedido deve ser maior que zero.")
           .IsGreaterThan(codigoCliente, 0, "CodigoCliente", "O código do cliente deve ser maior que zero.")
           .IsGreaterThan(produtos.Count, 0, "Produtos", "O pedido deve conter pelo menos um produto."));

        if (IsValid)
        {
            Id = id;
            CodigoPedido = codigoPedido;
            CodigoCliente = codigoCliente;
            Produtos = produtos;
        }
    }

    /// <summary>
    /// Id Pedido
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Código Pedido
    /// </summary>
    public int CodigoPedido { get; private set; }

    /// <summary>
    /// Código Cliente
    /// </summary>
    public int CodigoCliente { get; private set; }

    /// <summary>
    /// Lista de Produtos no Pedido
    /// </summary>
    public IReadOnlyList<Produto> Produtos { get; }

    /// <summary>
    /// Criar comando
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Resposta<Guid>> CriarComandoAsync(IMediator mediator, Guid id, AtualizarPedidoRequest request, CancellationToken cancellationToken)
    {
        var produtos = request.Itens.Select(item => new Produto(item.Id, item.Nome, item.Quantidade, item.Preco)).ToList();
        var comando = new AtualizarPedidoComando(id, request.CodigoPedido, request.CodigoCliente, produtos);
        return await mediator.Send(comando, cancellationToken);
    }
}
