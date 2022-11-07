public class Tool : PicupItem
{

    public Tool()
    {
        Random generator = new();
        ItemName = "Tool";
        Rarity = generator.Next(1, 8);


    }

}