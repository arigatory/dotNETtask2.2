using System;


namespace dotNETtask2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "***** Демонстрация полиморфизма *****";
            Body3D[] body3Ds = new Body3D[]
            {
                new Parallelepiped(1,2,3),
                new Sphere(2),
                new Tetrahedron(5),
                new Parallelepiped(2,4,8),
                new Parallelepiped(2,2,3),
                new Sphere(),
                new Tetrahedron(1),
                new Parallelepiped(2,4,1)
            };

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Вывод элементов массива 3D тел: ");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < body3Ds.Length; i++)
            {
                Console.WriteLine($"{body3Ds[i].PetName} с объемом {body3Ds[i].Volume():0.##} и площадью поверхности {body3Ds[i].SurfaceArea():0.##}");
            }

            Console.ReadLine();
        }
    }
}
