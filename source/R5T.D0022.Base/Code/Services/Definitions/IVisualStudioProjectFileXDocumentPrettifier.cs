using System;
using System.Threading.Tasks;

using R5T.T0004;
using R5T.T0064;


namespace R5T.D0022
{
    /// <summary>
    /// Prettifies the XElement structure of a Visual Studio project file <see cref="ProjectXElement"/>.
    /// 1) Ensures all root [Project] element children are sandwiched by XText nodes containing blank lines.
    /// 2) Ensures there are no empty [ItemGroup] elements ([ItemGroup] elements without children).
    /// </summary>
    /// <remarks>
    /// Note that adding ANY XText nodes causes the XmlWriter to stop auto-indenting. This is insanely obnoxious, but means that if you take responsibility for prettifying the XElement, you have to take FULL resposibility for prettifying the XElement.
    /// </remarks>
    [ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileXDocumentPrettifier : IServiceDefinition
    {
        Task Prettify(VisualStudioProjectFileXDocument visualStudioProjectFileXDocument);
    }
}
