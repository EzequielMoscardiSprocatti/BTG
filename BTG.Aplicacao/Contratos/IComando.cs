using BTG.Aplicacao.Respostas;
using MediatR;

namespace BTG.Aplicacao.Contratos;

public interface IComando : IRequest<bool> { }

public interface IComando<TResultado> : IRequest<Resposta<TResultado>> { }