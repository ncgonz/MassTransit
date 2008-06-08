namespace HeavyLoad.Correlated
{
    using System;
    using MassTransit.ServiceBus;

    [Serializable]
    internal class SimpleRequestMessage : 
        CorrelatedBy<Guid>
    {
        private Guid _id;

        public SimpleRequestMessage()
        {
        }

        public SimpleRequestMessage(Guid id)
        {
            _id = id;
        }

        public Guid CorrelationId
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}