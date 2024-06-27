using Tutorial4.Models;

namespace Tutorial4.Validators;

public class AnimalValidator
{
    public static IEnumerable<string> Validate(Animal animal)
    {
        if (animal.Id < 0)
        {
            yield return "Animals ID has to be greater or equal to 0";
        }

        if (string.IsNullOrWhiteSpace(animal.FirstName))
        {
            yield return "Animals first name is required";
        }

        if (string.IsNullOrWhiteSpace(animal.Category))
        {
            yield return "Animals category is required";
        }

        if (animal.Weight <= 0)
        {
            yield return "Animals weight must be greater than zero";
        }

        if (string.IsNullOrWhiteSpace(animal.FurColor))
        {
            yield return "Animals ur color is required";
        }
    }
}