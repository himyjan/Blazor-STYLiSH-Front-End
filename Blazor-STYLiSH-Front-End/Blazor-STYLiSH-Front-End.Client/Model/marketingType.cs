namespace STYLiSH.Model
{
  public class CarouselDetails
  {
    public int id { get; set; }
    public int product_id { get; set; }
    public string? picture { get; set; }
    public string? story { get; set; }
  }

  public class MarketingCampaigns
  {
    public CarouselDetails[]? data { get; set; }
  }
}