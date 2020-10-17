using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sichem
{
	public class ConversionResult
	{
		public readonly Dictionary<string, StringBuilder> Enums = new Dictionary<string, StringBuilder>();

		public readonly Dictionary<string, StringBuilder> Constants = new Dictionary<string, StringBuilder>();

		public readonly Dictionary<string, StringBuilder> GlobalVariables = new Dictionary<string, StringBuilder>();

		public readonly Dictionary<string, StringBuilder> Structs = new Dictionary<string, StringBuilder>();

		public readonly Dictionary<string, StringBuilder> Methods = new Dictionary<string, StringBuilder>();
	}
}
