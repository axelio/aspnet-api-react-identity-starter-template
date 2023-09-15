This template is an ASP.NET API (.NET 7), ASP.NET Identity with cookies authentication, and it includes a React project. It is based on the `ASP.NET Core with React.JS` (option without authentication) template available in [Visual Studio SPA templates](https://learn.microsoft.com/en-us/aspnet/core/client-side/spa/intro?view=aspnetcore-7.0), but with the following additions:

-   Entity Framework.
-   ASP.NET Identity, along with scaffolded ASP.NET Identity UI pages and Razor Pages support.
-   Configuration of cookies with `SameSite Strict` and `HttpOnly` attributes.
-   `Auth` controller (optional). 
-   `LoginMenu.js` component in React (optional).

**Note:**
Another Visual Studio template is available [here](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-7.0), which supports authentication through Duende Identity Server for implementing OpenID Connect.