using Android.App;
using Android.Widget;
using Android.OS;

namespace FirstAndroidApplication1
{
    // The Activity attribute applies to the class (MainActivity). The
    // Label appears on the application's title bar. The MainLauncher=true
    // causes the activity to operate as the startup activity.
    [Activity(Label = "Cunningham", MainLauncher = true,
        Icon = "@drawable/icon")]

    // Activities derive from the Activity class.
    public class MainActivity : Activity
    {

        // The OnCreate event fires when the activity is created by
        // Android. 
        protected override void OnCreate(Bundle bundle)
        {
            // First call the base class method and pass the bundle to it.
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource.
            // this must be done before trying to reference any of the 
            // widgets.
            SetContentView(Resource.Layout.Main);
            TextView txt = (TextView)FindViewById(Resource.Id.txtDateOutput);
            txt.Text = System.DateTime.Now.ToString();

            Button btnRecArea =
                (Button)FindViewById(Resource.Id.btnRecArea);
            btnRecArea.Click += btnRecArea_Click;
            Button btnCubeArea =
                (Button)FindViewById(Resource.Id.btnCubeArea);
            btnCubeArea.Click += btnCubeArea_Click;
        }

        void btnRecArea_Click(object sender, System.EventArgs args)
        {
            // Get the widget references.
            EditText etLengthIn = (EditText)FindViewById(Resource.Id.etLengthIn);
            EditText etWidthIn = (EditText)FindViewById(Resource.Id.etWidthIn);
            TextView txtRecAreaOut =
           (TextView)FindViewById(Resource.Id.txtRecAreaOut);
            double lengthConverted;
            try
            {
                lengthConverted = System.Convert.ToDouble(etLengthIn.Text);
            }

            catch (System.Exception)
            {
                lengthConverted = 0;
            }
            finally
            {
                //
            }
            double widthConverted;
            widthConverted = System.Convert.ToDouble(etWidthIn.Text);
            try
            {
                widthConverted = System.Convert.ToDouble(etWidthIn.Text);
            }

            catch (System.Exception)
            {
                widthConverted = 0;
            }
            finally
            {
                //
            }
            txtRecAreaOut.Text = (lengthConverted* widthConverted).ToString("F2");
        }




        

    
        void btnCubeArea_Click(object sender, System.EventArgs args)
        {
            // Get the widget references.
            EditText etLengthIn = (EditText)FindViewById(Resource.Id.etLengthIn);
            EditText etWidthIn = (EditText)FindViewById(Resource.Id.etWidthIn);
            EditText etHeightIn = (EditText)FindViewById(Resource.Id.etHeightIn);
            TextView txtCubeOut =
           (TextView)FindViewById(Resource.Id.txtCubeOut);
            double lengthConverted;            
            try
            {
                lengthConverted = System.Convert.ToDouble(etLengthIn.Text);
            }
            catch
            {
                lengthConverted = 0;
            }
            finally
            {
                //
            }
            double widthConverted;
            widthConverted = System.Convert.ToDouble(etWidthIn.Text);
            try
            {
                widthConverted = System.Convert.ToDouble(etWidthIn.Text);
            }

            catch (System.Exception)
            {
                widthConverted = 0;
            }
            finally
            {
                //
            }
            double heightConverted;
            
            try
            {
                heightConverted = System.Convert.ToDouble(etHeightIn.Text);
            }
            catch
            {
                heightConverted = 0;
            }
            finally
            {
                //
            }

            txtCubeOut.Text = (lengthConverted * widthConverted * heightConverted).ToString("F2");
        }
    }
}
    

// 120

