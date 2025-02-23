using MediatR;
using System.ComponentModel;

namespace YoutubeApi.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        [DefaultValue("tahir@mail.ru")]
        public string Email { get; set; }
        [DefaultValue("12345@Tt")]
        public string Password { get; set; }
    }
}
