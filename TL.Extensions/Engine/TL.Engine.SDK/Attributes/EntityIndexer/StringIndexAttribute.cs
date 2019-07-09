using System;

namespace TL.Engine.SDK.Attributes.EntityIndexer
{
    /// <summary>
    /// Аттрибут полнотекстового индекса поля.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class StringIndexAttribute : Attribute
    {
    }
}
