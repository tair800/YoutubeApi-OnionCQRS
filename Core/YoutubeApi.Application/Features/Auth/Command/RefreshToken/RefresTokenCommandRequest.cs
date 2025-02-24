using MediatR;

namespace YoutubeApi.Application.Features.Auth.Command.RefreshToken
{
    public class RefresTokenCommandRequest : IRequest<RefresTokenCommandResponse>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
