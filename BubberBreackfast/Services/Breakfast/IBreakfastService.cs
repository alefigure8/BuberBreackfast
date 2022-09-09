namespace BubberBreackfast.Services.Breakfast;
using BubberBreackfast.Models;

public interface IBreakfastService {
    void CreateBreakfast(Breakfast breakfast);

    Breakfast GetBreakfast(Guid id);
}

