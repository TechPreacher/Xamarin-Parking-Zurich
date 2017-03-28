# Xamarin-Parking-Zurich

Xamarin-Parking-Zurich is a Xamarin XAML Forms Sample App that uses a DataTemplateSelector which uses a DataTemplate at runtime per item in a ListView.ItemsSource. All of the project's UI and logic is contained in a portable class library that is shared across all OS heads. The UI code is written in Xamarin XAML Forms.

The app lists parkings in Zurich and their number of currently available parking places. The data is pulled from the RSS feed of the Zurich Parkleitsystem at http://www.pls-zh.ch/plsFeed/rss

This app uses code from the Xamarin Monkey Chat app by James Montemagno (https://github.com/jamesmontemagno/app-monkeychat)

## Project Structure

- **ParkingZH** contains the Portable Class Library with all the Xamarin XAML Forms UI, User Controls and Logic
- **ParkingZH.Droid** contains the Android Xamarin Head/App
- **ParkingZH.iOS** contains the iOS Xamarin Head/App
- **ParkingZH.UWP** contains the Universal Windows Head/App

## Screenshots

Universal Windows App:

![Universal Windows App](https://github.com/TechPreacher/Xamarin-Parking-Zurich/blob/master/images/windowsuniversal-screen.png)

Android App:

![Android App](https://github.com/TechPreacher/Xamarin-Parking-Zurich/blob/master/images/android-screen.png)
