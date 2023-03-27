using rw_df;

//  Settings



// Objects

Player player = new(3,4);
Enemy enemy = new(4,5);
Wall wall = new(4,4);
Game.objects[0] = player;
Game.objects[1] = enemy;

// Game menu while
Menu.Build();
Map.Build();
// Game while
while (Game.running) {

    Thread.Sleep(Game.FPMS); // 60 FPS counter
    Console.Clear(); // Screen update
    ++Game.step;

    // information
    if (Game.debug_info)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Информация для разработчика");
        Console.WriteLine($"Шаг: {Game.step}");
        Console.WriteLine($"Координаты игрока: {player.x}x {player.y}y");
        Console.WriteLine($"Координаты врага: {enemy.x}x {enemy.y}y");
        Console.WriteLine($"Размер карты: {Map.map1.Length}, размер карты 2: {Map.map2.Length}");
        Console.WriteLine($"Высота карты: {Map.y}, ширина карты: {Map.x}");
        Console.ResetColor();
    }
    
    // Rendering
    Map.Render();

    Map.map2[player.x, player.y] = ".";
    Map.map2[enemy.x, enemy.y] = ".";

    // Movement
    Console.Write("\nЧтобы передвигаться используйте WASD: ");
    
   
    
    player.Move();
    Console.Write("Есть нажатие!");
  

    //player.Collision(wall.x, wall.y);
    if (Game.step % 15 == 0) enemy.MoveTo(player.x, player.y);

    // Map writing
    Map.map2[enemy.x, enemy.y] = enemy.art;
    Map.map2[player.x, player.y] = player.art;
    
}
Console.WriteLine("Нажмите Any-key...");
Console.ReadKey();