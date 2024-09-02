<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/356264012/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T991355)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Synchronously Preload WPF Themes Within Splashscreen

This example displays the [Splash Screen Manager](https://docs.devexpress.com/WPF/401685/controls-and-libraries/windows-and-utility-controls/splash-screen-manager) on application startup and preloads Data Grid and LayoutControl theme resources while the splash screen is displayed.

Theme preload slows down the application startup but speeds up the startup of subsequent windows that use preloaded theme resources.

## Files to Review

* [App.xaml.cs](./CS/ThemePreloadwithSplashscreen/App.xaml.cs) (VB: [App.xaml.vb](./VB/ThemePreloadwithSplashscreen/App.xaml.vb))
* [ComplexWindow.xaml](./CS/ThemePreloadwithSplashscreen/ComplexWindow.xaml) (VB: [ComplexWindow.xaml](./VB/ThemePreloadwithSplashscreen/ComplexWindow.xaml))

## Documentation

* [Preload Theme Resources](https://docs.devexpress.com/WPF/403439/common-concepts/themes/preload-theme-resources)
* [Splash Screen Manager](https://docs.devexpress.com/WPF/401685/controls-and-libraries/windows-and-utility-controls/splash-screen-manager)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-synchronous-theme-preload-with-splashscreen&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-synchronous-theme-preload-with-splashscreen&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
