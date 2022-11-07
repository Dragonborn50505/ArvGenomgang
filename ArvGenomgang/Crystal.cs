public class Crystal : PicupItem
{

    public Crystal()
    {
        ItemName = "Tool";
        Random generator = new();
        Rarity = generator.Next(8, 20);


       
    }

    
}