// <auto-generated />
namespace Microsoft.AspNetCore.Diagnostics.HealthChecks
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Diagnostics.HealthChecks.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.
        /// </summary>
        internal static string UnableToFindServices
        {
            get => GetString("UnableToFindServices");
        }

        /// <summary>
        /// Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.
        /// </summary>
        internal static string FormatUnableToFindServices(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnableToFindServices"), p0, p1, p2);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
