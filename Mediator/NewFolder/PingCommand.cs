using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.NewFolder
{
    public class PingCommand : IRequest<PongResponse>
    {

    }
}
