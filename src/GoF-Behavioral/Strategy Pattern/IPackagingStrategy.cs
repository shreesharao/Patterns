namespace Strategy_Pattern
{
    /// <summary>
    /// Strategy interface used to pack all packages.
    /// </summary>
    interface IPackagingStrategy
    {
        void Pack(IPackage package);
    }
}
