using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Carlos
{
    public class HomeFragment : Android.Support.V4.App.Fragment
    {
        
        public HomeFragment()
        {
            
        }
        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            HomeFragment busrouteFragment = new HomeFragment();

            return busrouteFragment;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.activity_rest, null);
            ListView myList;
            myList = (ListView)root.FindViewById(Resource.Id.ReslistView);
            myList.Adapter = new MyCustomListAdapter(RestData.Rests);
            //Button LoginBtn = (Button)root.FindViewById(Resource.Id.dummybutton_);
            //LoginBtn.Click += LoginBtn_Click;
            return root;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Toast.MakeText(Application.Context, "Got Hit", ToastLength.Short).Show();
        }
    }
}