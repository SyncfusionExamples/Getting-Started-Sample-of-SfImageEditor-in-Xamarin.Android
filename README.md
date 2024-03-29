# Getting Started Sample of SfImageEditor in Xamarin.Android

This repository contains sample to get started with the [Syncfusion Xamarin.Android Image Editor](https://help.syncfusion.com/xamarin-android/sfimageeditor/getting-started) control. The image editor control for Xamarin.Android is a very handy tool, Which is used to edit an image by annotating with free hand drawing paths, text, and built-in shapes. It also allows to crop and flip an image.

## Syncfusion controls

This project used the following Syncfusion control(s):
* [SfImageEditor](https://www.syncfusion.com/xamarin-android-ui-controls/image-editor)

## Requirements to run the sample

* [Visual Studio](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)

Refer to the following link for more details - [System Requirements](https://help.syncfusion.com/xamarin-android/system-requirements)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*
   
2. Register your license key in the MainActivity.cs file as demonstrated in the following code.

		protected override void OnCreate(Bundle savedInstanceState)
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
		}
		
	Refer to this [link](https://help.syncfusion.com/xamarin-android/licensing/overview) for more details.
	
3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
