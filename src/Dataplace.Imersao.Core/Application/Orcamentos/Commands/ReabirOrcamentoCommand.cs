using Dataplace.Core.Domain.Commands;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Commands
{
    public class ReabirOrcamentoCommand : Command
    {
        public int NumOcamento { get; set; }
    }
}