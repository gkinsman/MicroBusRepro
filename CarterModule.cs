using Carter;
using Enexure.MicroBus;

public class HomeModule : CarterModule
{
    private IMicroBus _bus;

    public HomeModule(IMicroBus bus)
    {
        _bus = bus;

        Get("/", async (req, res, routeData) =>
            await _bus.PublishAsync(new TestEventA()));
    }
}