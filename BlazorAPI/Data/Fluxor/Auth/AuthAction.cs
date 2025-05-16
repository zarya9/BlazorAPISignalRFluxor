namespace BlazorAPI.Data.Fluxor.Auth
{
    public record SetJwtTokenAction(string Token, string Role);
    public record ClearJwtTokenAction;
    public record LoadAuthStateAction();

    public record NavigationAction(string Url);

    public record LoginSuccessAction(string Token, string Role);
    public record LogoutAction();
}