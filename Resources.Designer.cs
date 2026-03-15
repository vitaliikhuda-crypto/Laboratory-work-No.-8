namespace dz.Properties {
    using System;
    using System.Resources;

    internal class Resources {

        private static ResourceManager resourceMan;

        internal Resources() {
        }

        internal static ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    resourceMan = new ResourceManager("dz.Properties.Resources", typeof(Resources).Assembly);
                }
                return resourceMan;
            }
        }
    }
}
