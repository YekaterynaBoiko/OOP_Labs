namespace Lab28_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            CameraRental cameraRental = new CameraRental();
            try
            {
                cameraRental.TakePhotoSession(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Фотоапарат доступний? {cameraRental.IsFreeCamera}");
        }
    }
}
