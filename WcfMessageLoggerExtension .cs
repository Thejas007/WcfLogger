using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
    public class WcfMessageLoggerExtension : BehaviorExtensionElement
    {
        #region Overrides of BehaviorExtensionElement

        /// <summary>
        /// Creates a behavior extension based on the current configuration settings.
        /// </summary>
        /// <returns>
        /// The behavior extension.
        /// </returns>
        protected override object CreateBehavior()
        {
            return new WcfMessageLogger();
        }

        /// <summary>
        /// Gets the type of behavior.
        /// </summary>
        /// <returns>
        /// The type of behavior.
        /// </returns>
        public override Type BehaviorType
        {
            get { return typeof (WcfMessageLogger); }
        }

        #endregion
    }
}
