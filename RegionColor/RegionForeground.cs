using System.ComponentModel.Composition;
using System.Windows.Media;

using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace RegionColor {
	// https://github.com/sodza/gt-code/tree/08976827faf27835fc0f59cddb6fd53f90dc42c7/region-extension
	
	public static class TypeExports {
		[Export( typeof( ClassificationTypeDefinition ) )]
		[Name( "region-foreground" )]
		public static ClassificationTypeDefinition OrdinaryClassificationType;
	}

	[Export( typeof( EditorFormatDefinition ) )]
	[ClassificationType( ClassificationTypeNames = "region-foreground" )]
	[Name( "region-foreground" )]
	[UserVisible( true )]
	[Order( After = Priority.High )]
	public sealed class RegionForeground: ClassificationFormatDefinition {
		public RegionForeground() {
			DisplayName = "Region Foreground";
			ForegroundColor = Colors.Gray;
		}
	}

	#region Name
	#endregion
}