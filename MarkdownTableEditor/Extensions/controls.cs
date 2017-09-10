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
	}
}
