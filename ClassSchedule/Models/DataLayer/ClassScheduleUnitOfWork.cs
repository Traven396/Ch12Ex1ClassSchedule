namespace ClassSchedule.Models
{
    public class ClassScheduleUnitOfWork : IClassScheduleUnitOfWork
    {
        private ClassScheduleContext ctx;
        public ClassScheduleUnitOfWork(ClassScheduleContext context)
        {
            this.ctx = context;
        }

        public Repository<Class> classes => new Repository<Class>(ctx);

        public Repository<Teacher> teachers => new Repository<Teacher>(ctx);
        public Repository<Day> days => new Repository<Day>(ctx);

        public void Save()
        {
            ctx.SaveChanges();
        }
    }
}
