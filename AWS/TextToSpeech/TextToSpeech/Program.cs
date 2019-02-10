using System;
using System.IO;
using Amazon.Polly;
using Amazon.Polly.Model;

namespace TextToSpeech
{
    /// <summary>
    /// Class Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var pc = new AmazonPollyClient();

            var sreq = new SynthesizeSpeechRequest
            {
                Text = "Your Sample Text Here",
                OutputFormat = OutputFormat.Mp3,
                VoiceId = VoiceId.Amy,
                SampleRate = "8000",
                TextType = TextType.Text
            };

            var sres = pc.SynthesizeSpeechAsync(sreq);

            using (var fileStream = File.Create(@"c:\Temp\yourfile.mp3"))
            {
                sres.Result.AudioStream.CopyTo(fileStream);
                fileStream.Flush();
                fileStream.Close();
            }

            Console.ReadKey();
        }
    }
}
