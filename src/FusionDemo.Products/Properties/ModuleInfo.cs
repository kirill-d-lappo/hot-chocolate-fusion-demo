[assembly: Module("FusionDemoProductsTypes")]
[assembly: DataLoaderModule("FusionDemoProductsDataLoader")]
[assembly:
    DataLoaderDefaults(
        AccessModifier = DataLoaderAccessModifier.PublicInterface,
        ServiceScope = DataLoaderServiceScope.DataLoaderScope
    )]