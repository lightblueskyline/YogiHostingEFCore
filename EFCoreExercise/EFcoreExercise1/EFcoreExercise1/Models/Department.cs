namespace EFcoreExercise1.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        /// <summary>
        /// 導航屬性
        /// </summary>
        public ICollection<Employee>? Employee { get; set; }
    }
}
