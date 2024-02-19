using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;

using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Operations;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace RegionColor {
	[Export( typeof( IViewTaggerProvider ) )]
	[ContentType( "any" )]
	[TagType( typeof( ClassificationTag ) )]
	public sealed class RegionTaggerProvider: IViewTaggerProvider {
		[Import]
		public IClassificationTypeRegistryService Registry;

		[Import]
		internal ITextSearchService TextSearchService { get; set; }

		public ITagger<T> CreateTagger<T>( ITextView textView, ITextBuffer buffer ) where T: ITag {
			if( buffer != textView.TextBuffer ) {
				return null;
			}

			IClassificationType classificationType = Registry.GetClassificationType( "region-foreground" );
			return new RegionTagger( textView, TextSearchService, classificationType ) as ITagger<T>;
		}
	}

}