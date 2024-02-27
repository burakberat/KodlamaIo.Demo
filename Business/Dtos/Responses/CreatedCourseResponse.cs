namespace Business.Dtos.Responses
{
    public class CreatedCourseResponse
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
