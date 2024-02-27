using PizzaMart.Helper;

namespace PizzaMart.Shared;

public class OrderWithStatus
{
    public static readonly TimeSpan PreparationDuration = TimeSpan.FromSeconds(10);
    public static readonly TimeSpan DeliveryDuration = TimeSpan.FromMinutes(1); // Unrealistic, but more interesting to watch
    // Set from DB
    public Order Order { get; set; } = null!;

    // Set from Order
    public string StatusText { get; set; } = null!;

    public bool IsDelivered => StatusText == "Delivered";

    public List<Maker> MapMarkers { get; set; } = null!;

}