[assembly: Module("FusionDemoOrderingTypes")]
[assembly: DataLoaderModule("FusionDemoOrderingDataLoader")]
[assembly:
    DataLoaderDefaults(
        AccessModifier = DataLoaderAccessModifier.PublicInterface,
        ServiceScope = DataLoaderServiceScope.DataLoaderScope
    )]