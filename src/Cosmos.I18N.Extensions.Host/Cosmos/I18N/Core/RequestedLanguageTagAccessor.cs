#if !NETSTANDARD2_1

using Microsoft.AspNetCore.Http;

namespace Cosmos.I18N.Core {
    /// <summary>
    /// Current request language tag accessor
    /// </summary>
    public class RequestedLanguageTagAccessor : IRequestedLanguageTagAccessor {
        private readonly HttpContext _httpContext;

        /// <summary>
        /// Create a new instance of <see cref="RequestedLanguageTagAccessor"/>.
        /// </summary>
        /// <param name="accessor"></param>
        public RequestedLanguageTagAccessor(IHttpContextAccessor accessor) {
            _httpContext = accessor?.HttpContext;
        }

        /// <inheritdoc />
        public string Get() {
            return _httpContext is null ? string.Empty : _httpContext.Request.Cookies["langTag"];
        }

        /// <inheritdoc />
        public bool HasContext => _httpContext != null;
    }
}

#endif