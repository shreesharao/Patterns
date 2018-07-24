namespace Strategy_Pattern
{
    /// <summary>
    /// Strategy for fragile objects, such as glassware.
    /// 
    /// Uses box, foam, and tape.
    /// </summary>
    class FragileStrategy : IPackagingStrategy
    {
        public void Pack(IPackage package)
        {
            package.PackagingMaterials.Add(PackagingMaterials.Box);
            package.PackagingMaterials.Add(PackagingMaterials.Foam);
            package.PackagingMaterials.Add(PackagingMaterials.Tape);
        }
    }
}
