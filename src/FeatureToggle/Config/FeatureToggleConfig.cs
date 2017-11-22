using FeatureToggle.Interfaces;
using System.Configuration;

namespace FeatureToggle.Config
{
    public class FeatureToggleConfig : IFeatureToggleConfig
    {
        public bool IsEnhancedWriterEnabled
        {
            get
            {
                var settingString = ConfigurationManager.AppSettings["EnableEnhancedWriterFeatureToggle"];
                bool enableToggle = false;
                return bool.TryParse(settingString, out enableToggle) && enableToggle;
            }
        }
    }
}
