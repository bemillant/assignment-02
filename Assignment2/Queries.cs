using System.Linq;

namespace Assignment2;

public class Queries
{
    public static IEnumerable<String> getRowlingNamesSQL(WizardCollection w)
    {
        return from wiz in w
               where wiz.Creator == "J.K. Rowling"
               select wiz.Name;

    }

    public static IEnumerable<String> getRowlingNamesExt(WizardCollection w)
    {
        return w.Where(wiz => wiz.Creator.Equals("J.K. Rowling")).Select(wiz => wiz.Name);
    }



    public static int getFirstSithLordYearSQL(WizardCollection w)
    {
        return (from wiz in w
                where wiz.Name.Contains("Dart")
                select wiz.Year).Min()!.Value;
    }



    public static int getFirstSithLordYearEXT(WizardCollection w)
    {
        return w.Where(wiz => wiz.Name.Contains("Dart")).Select(wiz => wiz.Year).Min()!.Value;
    }


    public static List<Tuple<string, int?>> getListOfWizardsAndYearSQL(WizardCollection w)
    {
        List<Tuple<string, int?>> list = new();

        var grp = from wiz in w
                  where wiz.Medium.Equals("Harry Potter")
                  select new
                  {
                      Name = wiz.Name,
                      Year = wiz.Year
                  };

        list.AddRange(from item in grp
                      let tup = Tuple.Create<string, int?>(item.Name, item.Year)
                      select tup);
        return list;
    }
    public static List<Tuple<string, int?>> getListOfWizardsAndYearEXT(WizardCollection w)
    {
        List<Tuple<string, int?>> list = new();

        var grp = w.Where(wiz => wiz.Medium.Equals("Harry Potter")).Select(wiz => new { Name = wiz.Name, Year = wiz.Year });

        list.AddRange(from item in grp
                      let tup = Tuple.Create<string, int?>(item.Name, item.Year)
                      select tup);
        return list;
    }



    public static object grpAndSortWizSQL(WizardCollection w)
    {
        return from wiz in w
               orderby wiz.Creator descending, wiz.Name
               group wiz.Name by wiz.Creator into wizards
               select wizards;
    }
    public static object grpAndSortWizEXT(WizardCollection w)
    {
        return w.OrderByDescending(wiz => wiz.Creator).ThenBy(wiz => wiz.Name).GroupBy(wiz => wiz.Creator, wiz => wiz.Name);
    }





}
