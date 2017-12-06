using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace App1
{

    [Activity(Label = "SoundBoard", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private MediaPlayer mediaPlayer;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            DirectoryInfo di = new DirectoryInfo("//storage//emulated//0//SoundXamarin");
            FileInfo[] fis = di.GetFiles("*.wav");
            mediaPlayer = new MediaPlayer();
            LinearLayout ll_main = FindViewById<LinearLayout>(Resource.Id.ll_main);
            foreach (FileInfo fi in fis)
            {
                Button b = new Button(this.BaseContext);
                b.Text = fi.Name;
                b.Click += delegate
                {
                    lock (mediaPlayer)
                    {
                        mediaPlayer.Reset();
                        mediaPlayer.SetDataSource(fi.FullName);
                        mediaPlayer.Prepare();
                        mediaPlayer.Start();
                    }
                };
                ll_main.AddView(b);
            }
        }
    }
}







