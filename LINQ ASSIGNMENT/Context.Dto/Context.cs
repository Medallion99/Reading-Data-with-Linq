// See https://aka.ms/new-console-template for more information
public class Context
{
    public static List<string> stateList = new List<string>()
    {
        "Abia", "Adamawa", "AkwaIbom", "Anambra", "Bauchi", "Bayelsa",
        "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Edo", "Ekiti",
        "Enugu", "Federal Capital", "Gombe", "Imo", "Jigawa", "Kaduna",
        "Kano", "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa",
        "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers", "Sokoto",
        "Taraba", "Yobe", "Zamfara"
    };

    public static List<string> setOfStates = new List<string>()
    {
        "Abia", "Adamawa", "AkwaIbom", "Anambra", "Bauchi", "Bayelsa",
        "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Edo", "Ekiti",
        "Enugu", "Federal Capital", "Gombe", "Imo", "Jigawa", "Kaduna",
        "Kano", "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa",
        "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers", "Sokoto",
        "Taraba", "Yobe", "Zamfara"
    };

    public static List<Item> itemlist = new List<Item>

    {

    new Item { ItemId = 1, ItemDes = "Bag" },

    new Item { ItemId = 2, ItemDes = "Pen" },

    new Item { ItemId = 3, ItemDes = "Book " },

    new Item { ItemId = 4, ItemDes = "Shoe " },

    new Item { ItemId = 5, ItemDes = "Pin " }

    };

    public static List<Sales> saleslist = new List<Sales>
    {

        new Sales { InvNo = 1, ItemId = 3, Qty = 10 },

        new Sales { InvNo = 2, ItemId = 2, Qty = 20 },

        new Sales { InvNo = 3, ItemId = 3, Qty = 500 },

        new Sales { InvNo = 4, ItemId = 4, Qty = 20 },

        new Sales { InvNo = 5, ItemId = 3, Qty = 100 },

        new Sales { InvNo = 6, ItemId = 1, Qty = 50 }
    };

}

