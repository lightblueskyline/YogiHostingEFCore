using EFcoreExercise1.Models;

namespace EFcoreExercise1.Data
{
    public static class DbInitializer
    {
        #region Entity Framework Core Seed Data
        public static void Initialize(CompanyContext context)
        {
            if (context.Information.Any())
            {
                return;
            }

            var infos = new Information[]
            {
                new Information { Name = "YogiHosting", License = "XXYY", Revenue = 1000, Establshied = Convert.ToDateTime("2014/06/24") },
                new Information{ Name ="Microsoft", License ="XXXX", Revenue = 1000, Establshied = Convert.ToDateTime("2014/07/14") },
                new Information{ Name ="Google", License ="RRRRR", Revenue = 1000, Establshied = Convert.ToDateTime("2019/06/18") },
                new Information{ Name ="Apple", License ="XADFD", Revenue = 1000, Establshied = Convert.ToDateTime("2022/02/02") },
                new Information{ Name ="SpaceX", License ="XXXX", Revenue = 1000, Establshied = Convert.ToDateTime("2030/10/01") }
            };
            context.Information.AddRange(infos);
            context.SaveChanges();
        }
        #endregion
    }
}
