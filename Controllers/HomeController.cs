using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Jaime San Diego", StudentId = "S001", StudentAge = "55" , StudentHobby = "Basketball"},
            new StudentInfoModel { Name = "Jervy San Diego", StudentId = "S002", StudentAge = "14", StudentHobby = "Chess" },
            new StudentInfoModel { Name = "Josephine San Diego", StudentId = "S003", StudentAge = "50" , StudentHobby = "Cooking"},
            new StudentInfoModel { Name = "Jamie San Diego", StudentId = "S004", StudentAge = "20" , StudentHobby = "Painting"}
        };

        return View(studentInfoArray);
    }
}
