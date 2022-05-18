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
			StreamWriter streamWriter = new StreamWriter(File.Create(path));
			streamWriter.Write(jsone);
			streamWriter.Close();
		}
	}
}
