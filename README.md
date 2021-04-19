# Synchronous Theme Preload With Splashscreen

This technique works the best when you display the Splashscreen Manager on the application startup. In this case, theme preload loads a control's theme resources while Splashcreen is displayed. 

## Perfromance
Theme preload slows down application startup but speeds up startup of subsequent windows that use preloaded theme resources. 

## Example
To use synchronous theme preload, use the .Wait() method with the **PreloadThemeResourceAsync**.
