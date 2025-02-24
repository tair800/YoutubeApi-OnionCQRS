using FluentValidation;

namespace YoutubeApi.Application.Features.Auth.Command.RefreshToken
{
    public class RefresTokenCommandValidator : AbstractValidator<RefresTokenCommandRequest>
    {
        public RefresTokenCommandValidator()
        {
            RuleFor(x => x.AccessToken).NotEmpty();
            RuleFor(x => x.RefreshToken).NotEmpty();
        }
    }
}
