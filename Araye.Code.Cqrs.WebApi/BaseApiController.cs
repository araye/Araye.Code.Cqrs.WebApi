using Araye.Code.Core.Security.Extensions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Araye.Code.Cqrs.WebApi
{
    [ApiController]
    [Route("[controller]/[action]")]
    public abstract class BaseApiController : Controller
    {
        private IMediator _mediator;

        private string _currentUserId;

        protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());

        protected string CurrentLoggedInUserId => _currentUserId ?? (_currentUserId = HttpContext.User?.GetUserId());

    }
}
