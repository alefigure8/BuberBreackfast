namespace BuberBreackfast.Contracts.Breakfast;

    public record CreateBreakfastRequest(
         string Name,
         string Description,
         DateTime StartDateTime,
         List<string> Savory,
         List<string> Sweet
    );
    
    

    
