using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task2
{
    public class CameraRental
    {
        public bool IsFreeCamera { get; private set; } = true;
        public void TakePhotoSession(int photosCount)
        {
            if (!IsFreeCamera)
                throw new Exception("Фотоапарат вже зайнятий");

            if (photosCount <= 0)
                throw new ArgumentException("Кількість фотографій має бути більша за 0!");

            IsFreeCamera = false;
            try
            {
                Console.WriteLine("Фотосесія почалась");
                for (int i = 1; i <= photosCount; i++)
                {
                    Console.WriteLine($"Кількість фото: {i}");
                }
                Console.WriteLine("Фотосесія завершилась");
            }
            finally
            {
                IsFreeCamera = true;
            }
        }
    }
}
