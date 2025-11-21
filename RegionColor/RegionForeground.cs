using System.ComponentModel.Composition;
using System.Windows.Media;

using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace RegionColor {
	// https://github.com/sodza/gt-code/
	
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
}