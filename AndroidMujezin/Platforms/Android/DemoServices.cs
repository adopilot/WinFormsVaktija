using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;

namespace AndroidMujezin
{
    [Service(ForegroundServiceType = Android.Content.PM.ForegroundService.TypeDataSync)]
    public class DemoServices : Service, IServicesTest
    {
        public const int SERVICE_NOTIFICATION_ID = 100;
        public const string SERVICE_CHANNEL_ID = "DemoServicesChannel";

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            if (intent.Action == "START_SERVICE")
            {

                //Activity activity = MainActivity.ActivityCurrent;

                // Minimize the app
                //activity.MoveTaskToBack(true);

                // Register the notification
                RegisterNotification();
            }
            else if (intent.Action == "STOP_SERVICE")
            {
                StopForeground(true);
                StopSelfResult(startId);
            }
            return StartCommandResult.NotSticky;
        }

        public void Start()
        {
            Intent startService = new Intent(MainActivity.ActivityCurrent, typeof(DemoServices));
            startService.SetAction("START_SERVICE");
            MainActivity.ActivityCurrent.StartService(startService);
        }

        public void Stop()
        {
            Intent stopIntent = new Intent(MainActivity.ActivityCurrent, this.Class);
            stopIntent.SetAction("STOP_SERVICE");
            MainActivity.ActivityCurrent.StartService(stopIntent);
        }

        private void RegisterNotification()
        {
            NotificationChannel channel = new NotificationChannel("MujezinChannel", "Mujezin ", NotificationImportance.Max);
            NotificationManager manager = (NotificationManager)MainActivity.ActivityCurrent.GetSystemService(Context.NotificationService);
            manager.CreateNotificationChannel(channel);

            // Create the intent that will launch the main activity when the notification is clicked
            Intent intent = new Intent(MainActivity.ActivityCurrent, typeof(MainActivity));
            intent.SetFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
            PendingIntent pendingIntent = PendingIntent.GetActivity(MainActivity.ActivityCurrent, 0, intent, PendingIntentFlags.Immutable);

            // Build the notification with the pending intent
            Notification notification = new Notification.Builder(this, "MujezinChannel")
                .SetContentTitle("Mujezin je spreman")
                .SetSmallIcon(Resource.Drawable.dotnet_bot)
                .SetOngoing(true)
                .SetContentIntent(pendingIntent) // Set the pending intent to launch the main activity
                .Build();
            
            StartForeground(100, notification);
        }

        /*
        private Intent BuildIntentToShowMainActivity()
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.SetAction(Intent.ActionMain);
            intent.AddCategory(Intent.CategoryLauncher);
            intent.AddFlags(ActivityFlags.NewTask);
            intent.AddFlags(ActivityFlags.ClearTask);
            PendingIntent pendingIntent = PendingIntent.GetActivity(this, 0, intent, PendingIntentFlags.Immutable);
            return intent;
        }
        */
    }
}
