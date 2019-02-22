

using System.Threading.Tasks;
using Enexure.MicroBus;

class TestEventA : IEvent { }
class TestEventHandler : IEventHandler<TestEventA>
{
    public Task Handle(TestEventA @event)
    {
        throw new System.NotImplementedException();
    }
}
