namespace EFcoreExercise1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        public string? Name { get; set; }

        /// <summary>
        /// 稱號
        /// </summary>
        public string? Designation { get; set; }

        /// <summary>
        /// 導航屬性
        /// </summary>
        public Department? Department { get; set; }
    }
}
