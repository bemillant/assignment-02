namespace Assignment2;
public class Extensions
{
    public Extensions()
    {
    }

    public bool isSecure(Uri url)
    {
        if (url.Scheme == Uri.UriSchemeHttps)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public int wordCount(String str)
    {
        return str.Split(new char[] { ' ', ',', '.', '?', '!', ';', ':', '/' }, StringSplitOptions.RemoveEmptyEntries).Length;




    }

}
