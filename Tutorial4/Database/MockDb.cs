using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public List<Appointment> Appointments { get; set; } = new List<Appointment>();

    public MockDb()
    {
        Animals.Add(new Animal { Id = 1, FirstName = "Fluffy1", Category = "Cat1", Weight = 5, FurColor = "White" });
        Animals.Add(new Animal { Id = 2, FirstName = "Fluffy2", Category = "Cat2", Weight = 5, FurColor = "White" });
        Animals.Add(new Animal { Id = 3, FirstName = "Fluffy3", Category = "Cat3", Weight = 5, FurColor = "White" });
        Animals.Add(new Animal { Id = 4, FirstName = "Fluffy4", Category = "Cat4", Weight = 5, FurColor = "White" });
        Animals.Add(new Animal { Id = 5, FirstName = "Fluffy5", Category = "Cat5", Weight = 5, FurColor = "White" });


        Appointments.Add(new Appointment
        {
            Date = DateTime.Today,
            Animal = Animals[0],
            Description = "Appointment 1 description",
            Price = 50
        });

        Appointments.Add(new Appointment
        {
            Date = DateTime.Today.AddDays(1),
            Animal = Animals[1],
            Description = "Appointment 2 description",
            Price = 50
        });
        
        Appointments.Add(new Appointment
        {
            Date = DateTime.Today.AddDays(2),
            Animal = Animals[3],
            Description = "Appointment 3 description",
            Price = 50
        });
        
        Appointments.Add(new Appointment
        {
            Date = DateTime.Today.AddDays(3),
            Animal = Animals[2],
            Description = "Appointment 4 description",
            Price = 50
        });
        
        Appointments.Add(new Appointment
        {
            Date = DateTime.Today.AddDays(4),
            Animal = Animals[0],
            Description = "Appointment 5 description",
            Price = 50
        });
        

    }
}