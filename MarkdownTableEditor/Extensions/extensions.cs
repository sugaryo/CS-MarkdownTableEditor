using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownTableEditor.Extensions
{
	public static class extensions
	{
		public static bool isEmpty( this string s )
		{
			return string.IsNullOrEmpty( s );
		}
		public static bool notEmpty( this string s )
		{
			return !s.isEmpty();
		}

		public static bool isSpace( this string s )
		{
			return string.IsNullOrWhiteSpace( s );
		}
		public static bool notSpace( this string s )
		{
			return !s.isSpace();
		}


		public static string join( this IEnumerable<string> strings, string joinner )
		{
			StringBuilder sb = new StringBuilder();

			string add = "";

			foreach ( var s in strings )
			{
				sb.Append( add );
				sb.Append( s );
				add = joinner;
			}

			return sb.ToString();
		}

		public static string arounds( this IEnumerable<string> strings, string with )
		{
			StringBuilder sb = new StringBuilder();

			string add = "";

			foreach ( var s in strings )
			{
				add = with;
				sb.Append( add );
				sb.Append( s );
			}
			sb.Append( add );

			return sb.ToString();
		}

		public static IEnumerable<string> repeat( this string s, int n )
		{
			for ( int i = 0; i < n; i++ )
			{
				yield return s;
			}
		}


		public static IEnumerable<DataRow> asRows( this DataTable dt )
		{
			foreach ( DataRow row in dt.Rows )
			{
				yield return row;
			}
		}

		public static IEnumerable<object> asColumns( this DataRow row )
		{
			foreach ( DataColumn col in row.Table.Columns )
			{
				yield return row[col];
			}
		}


		private const StringSplitOptions DEFAULT_SPLIT_OPTION = StringSplitOptions.RemoveEmptyEntries;

		public static string[] split( this string s, params string[] by )
		{
			return s.Split( by, DEFAULT_SPLIT_OPTION );
		}
		public static string[] split( this string s, StringSplitOptions option = DEFAULT_SPLIT_OPTION, params string[] by )
		{
			return s.Split( by, option );
		}

		public static string[] lines( this string s, StringSplitOptions option = DEFAULT_SPLIT_OPTION )
		{
			return s.split( option, Environment.NewLine );
		}



		public static Font resize( this Font f, float size )
		{
			return new Font( f.FontFamily, size );
		}
	}
}
