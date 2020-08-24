using System;

namespace RMDesktopUI.Library.Models
{
    public interface ILoggedInUserModel
    {
        DateTime CreatedAt { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        string Token { get; set; }
    }
}