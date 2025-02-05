﻿using System;
using System.Threading;

namespace RandomBoxes
{
    class Program
    {
        private static int _width = 50;
        private static int _height = 20;

        static void Main(string[] args)
        {
            var shapes = CreateShapes();
            var n = 20;
            while (n-- > 0)
            {
                Show(shapes);
                foreach (var shape in shapes)
                {
                    shape.Move();
                }
                Thread.Sleep(400);
            }
        }

        private static Shape[] CreateShapes()
        {
            var random = new Random();
            var shapes = new Shape[5];
            for (var i = 0; i < shapes.Length; i++)
            {
	            int pickShape = random.Next(0, 3);
                if (pickShape == 0) shapes[i] = new Rectangle(random, _width, _height);
                else if (pickShape == 1) shapes[i] = new Triangle(random, _height);
                else if (pickShape == 2) shapes[i] = new Text(10, 5, random);
            }
            return shapes;
        }

        private static void Show(Shape[] shapes)
        {
            Console.Clear();
            for (var row = 0; row < _height; row++)
            {
                for (var col = 0; col < _width; col++)
                {
                    var hasFoundCharacterToPrint = false;
                    foreach (var shape in shapes)
                    {
                        var character = shape.GetCharacter(row, col);
                        if (character != null)
                        {
                            Console.Write(character);
                            hasFoundCharacterToPrint = true;
                            break;
                        }
                    }
                    if (!hasFoundCharacterToPrint) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
