﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace BlackBoat
{
	[Activity(Label = "Black Boat", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.home);

			// Get our button from the layout resource,
			// and attach an event to it


		}
	}
}

