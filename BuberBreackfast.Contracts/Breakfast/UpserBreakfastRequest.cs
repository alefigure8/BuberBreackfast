namespace BuberBreackfast.Contracts.Breakfast;

    public record UpserBreakfastRequest(
         string Name,
         string Description,
         DateTime StartDateTime,
         DateTime EndDateTime,
         List<string> Savory,
         List<string> Sweet
    );
    
    

    
