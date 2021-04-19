using System;
using Raylib_cs;

namespace RaylibBase
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "Raylib base");

      Raylib.SetTargetFPS(60);
      Raylib.SetExitKey(0); // Disable ESC key exit

      while (!Raylib.WindowShouldClose())
      {
        // Logic

        // Drawing
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.GRAY);
        Raylib.EndDrawing();
      }
    }
  }
}
