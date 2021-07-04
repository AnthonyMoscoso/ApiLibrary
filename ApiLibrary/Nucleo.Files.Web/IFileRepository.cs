namespace Core.Files.Web
{
    public interface IFileRepository
    {
        dynamic Upload();
        dynamic DownLoad(string type,string dir,string name);
        dynamic Delete(string dir, string name);
    }
}
