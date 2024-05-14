using System;
using System.Threading.Channels;

namespace Iterator
{
    public class CarRadio : IChannelCollection
    {
        private List<Channel> channels;

        public CarRadio()
        {
            this.channels = new List<Channel>();
        }

        public void AddChannel(Channel c)
        {
            channels.Add(c);
        }

        public IChannelIterator CreateIterator() //the iterator connection part
        {
            // ChannelIteratorNormal iterator = new ChannelIteratorNormal(channels);
             ChannelIteratorShuffle shuffle = new ChannelIteratorShuffle(channels);
            return shuffle;
        }

        public void RemoveChannel(Channel c)
        {
            channels.Remove(c);
        }
    }
}

