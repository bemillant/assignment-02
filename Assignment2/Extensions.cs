namespace Assignment2;
public static class Extensions
{
    public static bool isSecure(this Uri url)
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

    public static int wordCount(this string str) => str.Split(new char[] { ' ', ',', '.', '?', '!', ';', ':', '/' }, StringSplitOptions.RemoveEmptyEntries).Length;

}
