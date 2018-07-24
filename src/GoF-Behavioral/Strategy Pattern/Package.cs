using System.Collections.Generic;

namespace Strategy_Pattern
{
    class Package : IPackage
    {
        public string PackageContent { get; set; }
        public List<PackagingMaterials> PackagingMaterials { get; set; }

        public Package(string packageContent)
        {
            PackagingMaterials = new List<PackagingMaterials>();
            PackageContent = packageContent;
        }

        /// <summary>
        /// Outputs package Content and comma-delimited list of packing materials.
        /// </summary>
        /// <returns>Formatted string.</returns>
        public override string ToString()
        {
            return $"'{PackageContent}' packaged using {string.Join(",", PackagingMaterials)}";
        }
    }
}
