   M S B A M L   `   `   `  ����H  DTextBox.Style, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TextBoxStyle.ComponentsTextBoxStyle.Components  5      A%clr-namespace:TextBoxStyle.ConvertersTextBoxStyle.Converters  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35  �� MergedDictionaries �� Source=    7TextBoxStyle.Converters.BoolToVisibilityHiddenConverter   BHConverter7   1TextBoxStyle.Converters.BoolToVisibilityConverter  BVConverter  TextBoxExtended.Style �� 
TargetType-   'TextBoxStyle.Components.TextBoxExtended �� Property  TextBox.Static.CaretBrush �� Value  TextBox.Static.Background  TextBox.Static.Border �� 
TargetType ��Name   Header � Cursor	 �� CornerRadius
 � ColumnDefinitions  TextBox.Static.Foreground �� Stretch   Image ��Name ��Name  Button.FlatStyle �� RelativeSource  
CloseImage �� Triggers P� Property P� Value �� 
TargetName �� Triggers  	 TextBox.MouseOver.Foreground 
 TextBox.MouseOver.Border  TextBox.Disabled.Foreground  TextBox.Disabled.Border �� Binding �� Value J� IsHitTestVisible�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    4
Components%clr-namespace:TextBoxStyle.Components  5      4
Converters%clr-namespace:TextBoxStyle.Converters  5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        5      �� 5   
   $ Colors.xaml?�6   �� 5   
   $ ButtonStyle.xaml?�6   %�  &	        &	      &	 &        5
      61     5      6+   �� 5      "  6*   �5   
   �� 5       �@��
CaretBrush# �  6+   �� 5       � ��# �  6+   �� 5       � ��# �  6,   �� 5       � ��$ 1,1,1,1q�60   �� 5       �@�ForceCursor . 6,   �� 5       � �� 5      �� 5      "  6&   .R�5      $� .+�5      �� $ PART_Header��6(   #��z 6=   $ IBeam��6]   �� 5      $��Border��6%   $	 1��63   #��z��5   %   #��z��5   %   #��z��5   %   ._�5   "   � 
 5    &   �� 5!   *   $
��Auto �6;   �� 5"   *   �� 5#   *   $
��Auto �6;   .+�5&   &   F� #���  6+   $ IBeam��6^   $��0��5'   +   $ Uniform=�6?   #��z��6Q   #��z 5(   +   �� 5*   &   $ PART_ContentHost��63   $��1��6M   $��Center=�6]   �� 5,   &   $ 
PART_Clear��6-   $��2��6A   #���  6Q   ��5-   -   �� *Command_TextClear+ �� *TemplatedParent+.��5.   *   F� #���  6/   #��z��6b   $��0��5/   /   $ Uniform=�6C   #���  6U   50   '   51   #   52      53       54      P� 55       � ��$  ��66   . �56   "   �� $ 
PART_Clear��6)    � y�$ Hidden=�6W   57      P� 58       �@ Header$  ��68   . �59   "   �� $ PART_Header��6)    � y�$ 	Collapsed=�6X   5:      5<      5>       5@   
   P� 5A       �@J�IsMouseOver . . �5B      ��  � ��# � 	 6/   �� 5C       � ��# � 
 60   5D      P� 5E       � {� .  . �5F      ��  � ��# �  6/   �� 5G       � ��# �  60   5H      �� 5J       6   �� *IsKeyboardFocused+ �� *Self+	 False6f   .a�5K      ��  � �� 5L      �� 5M      "  6*   .R�5N      $� .+�5P   "   �� $ PART_Header��6,   #��z 6A   $ IBeam��6a   �� 5R   "   $��Border��6)   $	 1��67   #��z��5S   )   #��z��5T   )   #��z��5U   )   ._�5V   &   � 
 5W   *   �� 5X   .   $
��Auto �6?   �� 5Y   .   �� 5Z   .   $
��Auto �6?   .+�5]   *   F� #���  6/   $ IBeam��6b   $��0��5^   /   $ Uniform=�6C   #��z��6U   #��z 5_   /   �� 5a   *   $ 	PART_Hint��64   $��1��6G   #��z��6W   $	��2,0q�5b   4   $��CharacterEllipsis=�6A   $ IBeam��6b   #���  5c   4   
������  .  $��Center=�5d   M   �� 5f   *   $ 
PART_Clear��61   $��2��6E   #���  6U   $
 Hand��6�   ��5g   1   �� *Command_TextClear+ �� *TemplatedParent+.��5h   .   F� #���  63   #��z��6f   $��0��5i   3   $ Uniform=�6G   #���  6Y   5j   +   5k   '   5l   #   5m       5n      P� 5o   "    � ��$  ��6:   . �5p   &   �� $ 	PART_Hint��6-    6T   �� *PlaceHolder+ �� *TemplatedParent+ � ���� 5q   &   $ 
PART_Clear��6-    � y�$ Hidden=�6[   5r   #   P� 5s   "    �@ Header$  ��6<   . �5t   &   �� $ PART_Header��6-    � y�$ 	Collapsed=�6\   5u   #   5w      5y      5z      5|      5�      