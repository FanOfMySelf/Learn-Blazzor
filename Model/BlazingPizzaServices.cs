namespace BlazingPizza.Model;

public class PizzaService
{
public async Task<List<Pizza>> GetPizzasAsync()
{
    List<Pizza> pizzas = new List<Pizza>();

    try
    {
        // Some code that populates the pizzas list
        // ...

        return pizzas; // return the list of pizzas
    }
    catch (Exception ex)
    {
        // log the exception or handle it in some way
        // ...

        throw; // throw the exception to be handled elsewhere
    }

    // If an exception is not caught and returned above, we need to have a return statement here
    return pizzas;
}

}