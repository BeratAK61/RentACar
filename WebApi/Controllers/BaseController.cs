using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator? _mediator;

        //Yani daha önce mediator enjekte edilmişse onu döndür edilmemişse de set ediyor
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();


    }
}

// protected = sadece inherit edenler kullansın
// aynı zamanda protected olduğu için büyük harf ile başlıyor