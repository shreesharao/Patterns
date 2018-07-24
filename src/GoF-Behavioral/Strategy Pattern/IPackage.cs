using System.Collections.Generic;

namespace Strategy_Pattern
{
    /// <summary>
    /// Defines a basic package to be shipped.
    /// 
    /// Contains package content and packing materials used.
    /// </summary>
    interface IPackage
    {
        string PackageContent { get; set; }
        List<PackagingMaterials> PackagingMaterials { get; set; }

        /// <summary>
        /// Outputs package Content and comma-delimited list of packing materials.
        /// </summary>
        /// <returns>Formatted string.</returns>
        string ToString();
    }
}
