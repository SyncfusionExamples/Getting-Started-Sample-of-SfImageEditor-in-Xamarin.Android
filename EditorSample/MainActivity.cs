using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Syncfusion.SfImageEditor.Android;

namespace EditorSample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SfImageEditor editor = new SfImageEditor(this);
            editor.Bitmap = BitmapFactory.DecodeResource(Resources, Resource.Drawable.Image);
            SetContentView(editor);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}