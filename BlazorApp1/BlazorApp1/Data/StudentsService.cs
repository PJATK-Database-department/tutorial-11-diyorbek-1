namespace BlazorApp1.Data;

public class StudentsService
{
    private static readonly Student[] Students =
    {
        new()
        {
            Id = 1,
            Avatar = "https://picsum.photos/id/237/200/200",
            Birthdate = DateTime.Parse("05/02/2003"),
            Studies = "Computer Science",
            FirstName = "Ola",
            LastName = "Ratynska"
        },
        new()
        {
            Id = 2,
            Avatar = "https://picsum.photos/id/37/200/200",
            Birthdate = DateTime.Parse("10/31/2000"),
            Studies = "New Media Art",
            FirstName = "Vika",
            LastName = "Marshall"
        },
        new()
        {
            Id = 3,
            Avatar = "https://picsum.photos/id/137/200/200",
            Birthdate = DateTime.Parse("11/23/1998"),
            Studies = "Management",
            FirstName = "Jim",
            LastName = "White"
        },
        new()
        {
            Id = 4,
            Avatar = "https://picsum.photos/id/231/200/200",
            Birthdate = DateTime.Now,
            Studies = "New Media Art",
            FirstName = "Clay",
            LastName = "Cleichmann"
        },
        new()
        {
            Id = 5,
            Avatar = "https://picsum.photos/id/227/200/200",
            Birthdate = DateTime.Parse("01/03/1699"),
            Studies = "Computer Science",
            FirstName = "Richard",
            LastName = "Kruspe"
        }
    };

    public Task<Student[]> GetStudentsAsync()
    {
        return Task.FromResult(Students);
    }

    public Task<Student?> GetStudentsByIdAsync(int studentId)
    {
        return Task.FromResult(Students.FirstOrDefault(s => s.Id == studentId));
    }
}