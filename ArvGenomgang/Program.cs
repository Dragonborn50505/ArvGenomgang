

NPC ncp1 = new NPC();

//ncp1.currentBehaviour

Student Student1 = new Student();


Console.WriteLine($"Name: {Student1.Name}, Age: {Student1.Age} & School: {Student1.School}");
Console.ReadLine();

MovingObjekt movingObjekt1 = new MovingObjekt();
Student1.movingObjekt = new Car();
Student1.picupItem = new Crystal();
Console.WriteLine($"Stuedents veichle: {Student1.movingObjekt}, Students Item: {Student1.picupItem}");
Console.WriteLine($"{Student1.picupItem}s rarity {Student1.picupItem.Rarity}");
Console.ReadLine();
