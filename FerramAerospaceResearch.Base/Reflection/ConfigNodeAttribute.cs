using System;

namespace FerramAerospaceResearch.Reflection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ConfigNodeAttribute : Attribute
    {
        /// <summary>
        ///     Whether there can be multiple nodes of this, should only be used if IsRoot is true
        /// </summary>
        public readonly bool AllowMultiple;

        /// <summary>
        ///     Whether this node should be saved
        /// </summary>
        public readonly bool ShouldSave;

        /// <summary>
        ///     Node name
        /// </summary>
        public readonly string Id;

        /// <summary>
        ///     Whether this node is root in config files
        /// </summary>
        public readonly bool IsRoot;

        /// <summary>
        ///     If not null attaches this config node as a child to Parent
        /// </summary>
        public readonly Type Parent;

        public ConfigNodeAttribute(string id, bool isRoot = false, bool allowMultiple = false, bool shouldSave = true, Type parent = null)
        {
            Id = id;
            IsRoot = isRoot;
            AllowMultiple = allowMultiple;
            ShouldSave = shouldSave;
            Parent = parent;
        }
    }
}
