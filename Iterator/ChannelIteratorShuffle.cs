using System;
namespace Iterator
{
	public class ChannelIteratorShuffle : IChannelIterator
    {
        private List<Channel> channels;
        private int currentPosition = 0;

        public ChannelIteratorShuffle(List<Channel> channels) //constru
        {
            this.channels = channels;
            this.Shuffle();
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = channels.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Channel value = channels[k];
                channels[k] = channels[n];
                channels[n] = value;
            }
        }
        public bool HasNext()
        {
            if (currentPosition < channels.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Channel Next()
        {
            return channels[currentPosition++];
        }
    }
}

