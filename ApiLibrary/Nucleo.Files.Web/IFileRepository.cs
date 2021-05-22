namespace Nucleo.Files.Web
{
    public interface IFileRepository
    {
        dynamic Upload();
        dynamic DownLoad(int type,string dir,string name);
        dynamic Delete(int type, string dir, string name,string format);
    }
}
