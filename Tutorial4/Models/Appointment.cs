namespace Tutorial4.Models;

public class Appointment
{
    public DateTime Date { get; set; }
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
}