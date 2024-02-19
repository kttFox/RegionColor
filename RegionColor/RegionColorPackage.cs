﻿global using System;

global using Community.VisualStudio.Toolkit;

global using Microsoft.VisualStudio.Shell;

global using Task = System.Threading.Tasks.Task;

using System.Runtime.InteropServices;
using System.Threading;

namespace RegionColor {
	[PackageRegistration( UseManagedResourcesOnly = true, AllowsBackgroundLoading = true )]
	[InstalledProductRegistration( Vsix.Name, Vsix.Description, Vsix.Version )]
	[ProvideMenuResource( "Menus.ctmenu", 1 )]
	[Guid( PackageGuids.RegionColorString )]
	public sealed class RegionColorPackage : ToolkitPackage {
		protected override async Task InitializeAsync( CancellationToken cancellationToken, IProgress<ServiceProgressData> progress ) {
			await JoinableTaskFactory.SwitchToMainThreadAsync( cancellationToken );
		}
	}
}