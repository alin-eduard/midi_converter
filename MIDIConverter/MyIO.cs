using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDIConverter
{
	public static class MyIO
	{
		public static MidiFile ReadMidiFile(string path)
		{
			return new MidiFile(path);
		}
		public static void SaveJsone(string path, string jsone)
		{
			BinaryWriter bw = new BinaryWriter(File.Create(path));
			bw.Write(jsone);
			bw.Dispose();
		}
	}
}
