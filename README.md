# ExtendedTextBox-WPF

ExtendedTextBox provides extended design for WPF TextBox.
## Overview

![Files](./Files/MainWindow (Nothing selected).png)
![Files](./Files/MainWindow (Selected).png)
![Files](./Files/MainWindow (Expression).png)

### Preparation

Add XAML namespace.

Add ResourceDictionary to App.xaml.

```xml
<Application.Resources>
  <ResourceDictionary Source="pack://application:,,,/TextBox.Style;component/Styles/BaseDictionary.xaml"/>
</Application.Resources>
```
Add component namespace to use custom textbox

```xml
xmlns:Components="clr-namespace:TextBoxStyle.Components;assembly=TextBox.Style"
```

## Usage

```xml
<Components:TextBoxExtended Text="{Binding YourText, UpdateSourceTrigger=PropertyChanged}"
                            Style="{DynamicResource TextBoxExtended.Style}"
                            Image="{DynamicResource YourGeometryImage}"
                            PlaceHolder="It is hint"
                            Header="It is Header"/>
```

## License

[MIT License](Licence)
