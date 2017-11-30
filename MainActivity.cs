using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;
using System.Collections.Generic;
using System.Threading;

namespace App1
{
    [Activity(Label = "SoundBoard", MainLauncher = true)]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            addbutton();

        }
        MediaPlayer mediaPlayer;

        public void sound(string sounds)
        {

            
          
           

            switch (sounds)
            {

                case "lick lick my balls":
                    mediaPlayer = MediaPlayer.Create(this, Resource.Raw.lick_my_balls);
                    mediaPlayer.Start();
                         break;

                case "aids":
                    mediaPlayer = MediaPlayer.Create(this, Resource.Raw.test);
                    mediaPlayer.Start();
                      break;

                case "retarded":
                    mediaPlayer = MediaPlayer.Create(this, Resource.Raw.test2);
                    mediaPlayer.Start();
                    
                    break;
                case "dupdup":
                    mediaPlayer = MediaPlayer.Create(this, Resource.Raw.test3);
                    mediaPlayer.Start();
                    
                    break;
                case "tiny rick":
                    mediaPlayer = MediaPlayer.Create(this, Resource.Raw.rick);
                    mediaPlayer.Start();
                    
                    break;
                case "goodjob":
                    mediaPlayer = MediaPlayer.Create(this, Resource.Raw.Good_Job);
                    mediaPlayer.Start();
                    
                    break;
                case "aaaw bitch":
                    mediaPlayer = MediaPlayer.Create(this, Resource.Raw.Awww_Bitch);
                    mediaPlayer.Start();
                   
                    break;
                case "Ryan":
                    mediaPlayer = MediaPlayer.Create(this, Resource.Raw.Ryan);
                    mediaPlayer.Start();
                   break;

                default:
                 
                    break;
            }
            

        }

        public void addbutton()

        {
            

            

            List<string> buttonlist = new List<string>
            {
                "lick lick my balls",
                "aids",
                "retarded",
                "dupdup",
                "tiny rick",
                "goodjob",
                "aaaw bitch",
                "Ryan",

            };
          
            foreach (string button in buttonlist)
            {
                LinearLayout parentLayoutView = FindViewById<LinearLayout>(Resource.Id.LinearLayoutMain);
                var aButton = new Button(this);
                aButton.Click += (sender, e) =>
                 { sound(button); };
               
                aButton.Text = button;
                parentLayoutView.AddView(aButton);


            }
    





        }
    }
}
