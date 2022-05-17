using System.IO;

namespace MIDIConverter
{
	public static class IOSystem
	{
		public static MidiFile ReadMidiFile(string path)
		{
			return new MidiFile(path);
		}

		public static void SaveJson(string path, string jsone)
		{
			BinaryWriter bw = new BinaryWriter(File.Create(path));
			bw.Write(jsone);
			bw.Dispose();
		}
	}
}
