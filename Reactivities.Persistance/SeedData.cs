using Reactivities.Domain;

namespace Reactivities.Persistance;

public class SeedData
{
    public static List<Activity> Activities()
    {
        return new List<Activity>
            {
                new Activity
                {
                    Id = Guid.Parse("727fcebe-800f-4b0b-bffc-c53b215f3e9b"),
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Activity
                {
                    Id = Guid.Parse("3f91340d-6214-4200-9312-21cd60654fd2"),
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Activity
                {
                    Id = Guid.Parse("945fd28d-abdb-48cd-8c39-dc0192578bc8"),
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                new Activity
                {
                    Id = Guid.Parse("b6974c66-23cb-4980-84ef-197f7eb9776f"),
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                },
                new Activity
                {
                    Id = Guid.Parse("440b8ad0-5b40-4805-a7b2-52d04d670beb"),
                    Title = "Future Activity 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                },
                new Activity
                {
                    Id = Guid.Parse("74c44b38-57a1-4f40-ae59-ae1d1597f64f"),
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                },
                new Activity
                {
                    Id = Guid.Parse("0a70036a-e2fe-4fcb-9fba-a6af8cb0dc54"),
                    Title = "Future Activity 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                },
                new Activity
                {
                    Id = Guid.Parse("7668de5d-2fed-421f-b553-7d69c5715998"),
                    Title = "Future Activity 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },
                new Activity
                {
                    Id = Guid.Parse("9018b4b6-4347-4f33-a3ac-8fbc2b89f1ce"),
                    Title = "Future Activity 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Activity 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Activity
                {
                    Id = Guid.Parse("dd07fe2e-7e2e-4dd7-9fae-9faad6f96815"),
                    Title = "Future Activity 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                }
            };
    }
}
