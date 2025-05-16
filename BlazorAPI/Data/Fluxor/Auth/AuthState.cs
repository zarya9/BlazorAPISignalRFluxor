using Fluxor;

namespace BlazorAPI.Data.Fluxor.Auth
{
    [FeatureState(CreateInitialStateMethodName = nameof(CreateInitialState))]
    public record AuthState
    {
        public string JwtToken { get; init; }
        public bool IsAuthenticated { get; init; }
        public string Role { get; init; }

        public static AuthState CreateInitialState()
        {
            return new AuthState
            {
                JwtToken = null,
                IsAuthenticated = false,
                Role = null
            };
        }
    }
}