
public class TaskLogic
    {

        public void StateGroup()
        {

            //Display states in sets of three
            Console.WriteLine("Display states grouped by letter on separate lines");
            Console.WriteLine();
            var newSet = Context.setOfStates.Select((state, index) => new { state, index })
                        .GroupBy(x => x.index / 3)
                        .Select(group => group.Select(x => x.state).ToArray())
                        .ToList();

            foreach (var ste in newSet)
                Console.WriteLine(string.Join(", ", ste));

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");
        }


        public void JoinItem()
        {
            //Arrange/Join Items Of Collections
            Console.WriteLine("Arrange/Join Items Of Collections");
            Console.WriteLine();
            var innerJoin = Context.itemlist.Join(
                             Context.saleslist,
                             s => s.ItemId,
                             x => x.ItemId,
                             (s, x) => new
                             {
                                 ItemId = s.ItemId,
                                 ItemName = s.ItemDes,
                                 ItemQty = x.Qty
                             });

            Console.WriteLine("ItemID\tItemName\tQty");
            Console.WriteLine("--------------------------------------------------------------------------");
        
            foreach (var kvp in innerJoin)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}",kvp.ItemId, kvp.ItemName, kvp.ItemQty);
            }
        }


        public void ArrangeState()
        {
        var keys = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        var set = keys.GroupJoin(Context.stateList, s => s, x => x.First(), (statekey, states) => new { AlphabetSte = statekey, States = states });

        foreach (var key in set)
        {
            if (key.States.Count() > 0)
            {
                Console.WriteLine($"Sets of {key.AlphabetSte} -- {key.States.Count()}");
                Console.WriteLine("-------------------------------------------------------");

                foreach (var ste in key.States)
                {
                    Console.WriteLine(ste);
                }
                Console.WriteLine("-------------------------------------------------------");
            }
        }
    }
}
