using BTG.Aplicacao.Respostas;
using MediatR;

namespace BTG.Aplicacao.Contratos;

public interface IQuery<TResultado> : IRequest<Resposta<IEnumerable<TResultado>>>
{
    Paginacao Paginacao { get; }

    string Ordenacao { get; }

    IEnumerable<string> Campos { get; }
}

public interface IQuery<TEntidade, TResultado> : IQuery<TResultado> { }