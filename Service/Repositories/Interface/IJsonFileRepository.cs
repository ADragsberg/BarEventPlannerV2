namespace BarEventPlannerV2.Service.Repositories.Interface
{//Taget fra Per Laursens Github
    public interface IJsonFileRepository<T> where T : class
    {
        string JsonFileRelative { get; set; }
        string DataRoot { get; set; }

        void SaveToJsonFile(IEnumerable<T> list);
        IEnumerable<T> GetFromJsonFile();
    }
}
