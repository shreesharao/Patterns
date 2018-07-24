namespace Strategy_Pattern
{
    /// <summary>
    /// Client that routes all packages to the passed packaging strategy.
    /// </summary>
    class Packager
    {
        readonly IPackagingStrategy _packagingStrategy;

        public Packager(IPackagingStrategy packagingStrategy)
        {
            _packagingStrategy = packagingStrategy;
        }

        public void Pack(IPackage package)
        {
            _packagingStrategy.Pack(package);
        }
    }
}
