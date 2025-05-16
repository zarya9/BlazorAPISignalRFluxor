using Fluxor;

namespace BlazorAPI.Data.Fluxor.Auth
{
    public static class AuthReducers
    {
        [ReducerMethod]
        public static AuthState OnSetJwtToken(AuthState state, SetJwtTokenAction action)
        {
            return state with
            {
                JwtToken = action.Token,
                IsAuthenticated = true,
                Role = action.Role
            };
        }

        [ReducerMethod]
        public static AuthState OnClearJwtToken(AuthState state, ClearJwtTokenAction action)
        {
            return new AuthState();
        }
    }
}