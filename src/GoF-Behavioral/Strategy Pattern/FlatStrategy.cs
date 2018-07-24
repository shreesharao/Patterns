namespace Strategy_Pattern
{
    /// <summary>
    /// Strategy for flat objects, such as letters.
    /// 
    /// Uses envelope and stamp.
    /// </summary>
    class FlatStrategy : IPackagingStrategy
    {
        public void Pack(IPackage package)
        {
            package.PackagingMaterials.Add(PackagingMaterials.Envelope);
            package.PackagingMaterials.Add(PackagingMaterials.Stamp);
        }
    }
}
