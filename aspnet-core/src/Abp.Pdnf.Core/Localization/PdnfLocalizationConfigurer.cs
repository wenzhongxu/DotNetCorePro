using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Abp.Pdnf.Localization
{
    public static class PdnfLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PdnfConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PdnfLocalizationConfigurer).GetAssembly(),
                        "Abp.Pdnf.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
