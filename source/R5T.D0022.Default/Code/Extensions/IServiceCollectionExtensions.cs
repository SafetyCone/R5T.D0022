using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0022.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the see <see cref="VisualStudioProjectFileXDocumentPrettifier"/> implementation of <see cref="IVisualStudioProjectFileXDocumentPrettifier"/> as a s<see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioProjectFileXDocumentPrettifier(this IServiceCollection services)
        {
            services.AddSingleton<IVisualStudioProjectFileXDocumentPrettifier, VisualStudioProjectFileXDocumentPrettifier>();

            return services;
        }

        /// <summary>
        /// Adds the see <see cref="VisualStudioProjectFileXDocumentPrettifier"/> implementation of <see cref="IVisualStudioProjectFileXDocumentPrettifier"/> as a s<see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioProjectFileXDocumentPrettifier> AddVisualStudioProjectFileXDocumentPrettifierAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IVisualStudioProjectFileXDocumentPrettifier>(() => services.AddVisualStudioProjectFileXDocumentPrettifier());
            return serviceAction;
        }
    }
}
