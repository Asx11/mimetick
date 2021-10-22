﻿using Mimetick.Core;
using Mimetick.Module.Ssh.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Mimetick.Module.Ssh
{
    public class SshModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();

            regionManager.RegisterViewWithRegion<SshModuleItemView>(RegionNames.ModuleRegion);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}