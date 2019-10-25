ToggleButton togglebutton = FindViewById<ToggleButton> (Resource.Id.togglebutton); 
togglebutton.Click += (o, e) => { 
   if (togglebutton.Checked) 
      Toast.MakeText(this, "Torch is ON", ToastLength.Short).Show (); 
   else 
      Toast.MakeText(this, "Torch is OFF", 
      ToastLength.Short).Show(); 
}; 
