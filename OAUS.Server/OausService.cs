using System;
using System.Collections.Generic;
using System.Text;
using Innov.Core;

namespace Innov.Server
{
    internal class InnovService : MarshalByRefObject, IInnovService
    {
        private UpdateConfiguration fileConfig;
        public InnovService(UpdateConfiguration _fileConfig)
        {
            this.fileConfig = _fileConfig;
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public int GetLatestVersion()
        {
            return this.fileConfig.ClientVersion;
        }
    }
}
