namespace PizzaMart.Shared;

public class Order
{
    public int OrderId { get; set; }
    public string? UserId { get; set; }

    public DateTime CreatedTime { get; set; }

    public Address DeliveryAddress { get; set; } = new Address();
    // Set by server during POST
    public LatLong? DeliveryLocation { get; set; }
}