using Tutorial4.Models;

namespace Tutorial4.Validators;

public class AppointmentValidator
{
    public static IEnumerable<string> Validate(Appointment appointment)
    {
        if (appointment.Price < 0)
        {
            yield return "Appointments price has to be greater or equal to 0";
        }

        var errors = AnimalValidator.Validate(appointment.Animal).ToList();

        if (errors.Any())
        {
            foreach (var error in errors)
            {
                yield return error;
            }
        }

        if (appointment.Description.Length == 0)
        {
            yield return "Appointments description cannot be blank";
        }
    }
}