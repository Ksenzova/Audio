using NAudio.Wave;
using System;

using NAudio.Wave;
using NAudio.Lame;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
	public class Convertor
	{
		public int Rate { get; private set; }
		public int Bits { get; private set; }
		public int Chanels { get; private set; }

		public Convertor(int rate, int bits, int chanels)
		{
			Rate = rate;
			Bits = bits;
			Chanels = chanels;
		}

		public void ConvertToMp3(string fileName)
		{
			using (var reader = new WaveFileReader(fileName))
			{
				var newFormat = new Mp3(Rate, Bits, Chanels);
				using (var conversionStream = new WaveFormatConversionStream(newFormat, reader))
				{
					WaveFileWriter.CreateWaveFile("output.wav", conversionStream);
				}
			}
		}

		public void ConvertToFlac()
		{
			using (var reader = new WaveFileReader(fileName))
			{
				var newFormat = new WaveFormat(rate * 1000, bit, channels);
				using (var conversionStream = new WaveFormatConversionStream(newFormat, reader))
				{
					WaveFileWriter.CreateWaveFile("output.wav", conversionStream);
				}
			}
		}

		public void ConvertToWav()
		{
			using (var reader = new WaveFileReader(fileName))
			{
				var newFormat = new WaveFormat(rate * 1000, bit, channels);
				using (var conversionStream = new WaveFormatConversionStream(newFormat, reader))
				{
					WaveFileWriter.CreateWaveFile("output.wav", conversionStream);
				}
			}
		}
	}
}
