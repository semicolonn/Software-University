﻿namespace _01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable streamFile;

        // If we want to stream a music file, we can't
        // To work it correct, we build interface Istreamable with needed props
        public StreamProgressInfo(IStreamable streamFile)
        {
            this.streamFile = streamFile;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamFile.BytesSent * 100) / this.streamFile.Length;
        }
    }
}