using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkdownTableEditor.Extensions
{
	public static class controls
	{
		public static void ctrl_a( this IEnumerable<TextBox> txts, bool on = true )
		{
			foreach ( var txt in txts )
			{
				txt.ctrl_a( on );
			}
		}
		public static void ctrl_a( this TextBox txt, bool on = true )
		{
			if ( on )
			{
				txt.KeyDown += CtrlA;
			}
			else
			{
				txt.KeyDown -= CtrlA;
			}
		}
		private static void CtrlA( object sender, KeyEventArgs args )
		{
			TextBox txt = sender as TextBox;

			if ( args.Control && args.KeyCode == Keys.A )
			{
				txt.SelectAll();
			}
		}


		#region IEnumerable<Control>
		public static IEnumerable<Control> children( this Form form )
		{
			foreach ( Control control in form.Controls )
			{
				var each = Each( control );
				foreach ( var c in each )
				{
					yield return c;
				}
			}
		}
		public static IEnumerable<Control> children( this Control parent )
		{
			return Each( parent );
		}
		private static IEnumerable<Control> Each( Control current )
		{
			foreach ( Control c in current.Controls )
			{
				yield return c;

				if ( c.HasChildren )
				{
					var each = Each( c );
					foreach ( Control x in each )
					{
						yield return x;
					}
				}
			}
		}
		#endregion
	}
}
