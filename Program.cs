using System;

namespace custom_colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero ();
            fxs.MainColor = "Midnight Blue";
            
            Tesla modelS = new Tesla ();
            modelS.MainColor = "Ron Burgundy";
            
            Cessna mx410 = new Cessna ();
            mx410.MainColor = "White Knight";

            Ram hemi = new Ram ();
            hemi.MainColor = "Silver Bullet";

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();

            hemi.Drive();
            hemi.Turn("left");
            hemi.Stop();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();  
        }
    }
}
