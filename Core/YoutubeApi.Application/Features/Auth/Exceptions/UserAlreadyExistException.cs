using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistException : BaseException
    {
        public UserAlreadyExistException() : base("User already exist") { }
    }

    public class EmailAdressShouldBeValidException : BaseException
    {
        public EmailAdressShouldBeValidException() : base("Email adress is not valid") { }
    }

}
