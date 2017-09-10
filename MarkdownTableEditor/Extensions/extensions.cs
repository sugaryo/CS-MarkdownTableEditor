using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownTableEditor.Extensions
{
	public static class extensions
	{
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
	}
}
