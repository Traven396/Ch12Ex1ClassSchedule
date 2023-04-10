namespace ClassSchedule.Models
{
    public interface IClassScheduleUnitOfWork
    {
        Repository<Class> classes { get; }
        Repository<Teacher> teachers { get; }
        Repository<Day> days { get; }
        void Save();
    }
}
