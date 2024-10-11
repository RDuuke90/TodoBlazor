namespace TodoApi.Dtos
{
 /**
    "userId": 1,
    "id": 1,
    "title": "delectus aut autem",
    "completed": false
 */
    public class TodoDto {
        public int userId {get; set;}
        public int id {get; set;}
        public string title {get; set;}
        public bool completed {get; set;}
    }
}