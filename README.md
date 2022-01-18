<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/356264012/21.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T991355)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Synchronous Theme Preload With Splashscreen

This technique works the best when you display the Splashscreen Manager on the application startup. In this case, theme preload loads a control's theme resources while Splashcreen is displayed. 

## Perfromance
Theme preload slows down application startup but speeds up startup of subsequent windows that use preloaded theme resources. 

## Example
To use synchronous theme preload, use the .Wait() method with the **PreloadThemeResourceAsync**.

Refer to the following documentation topic for more information on theme preload: [Documentation](https://docs.devexpress.com/WPF/400287/common-concepts/performance-improvement?#preload-themes)
