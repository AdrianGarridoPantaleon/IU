   M S B A M L   `   `   `  ����@  <TESLA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TESLATESLA  5   	       TESLA.Bienvenido   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:TESLA     5   	     � Title$  
Bienvenido��5   	   $	��720��6   $
��1280��6)    � WindowStartupLocation$ CenterScreen=�66    � 	Resources 5	         ButtonStyle15 �� 
TargetType �� Property �� Value �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value��%l  &	        �� 5
   
   " ��6&   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �  5        5   "   CommonStates��. 5   &     
Normal��.	 5   *   �� .��5   .   U� $
 (Shape.StrokeThickness)�6L   $ 
rectangle4��6�   .\�5   2     $ 0��6G   $ 2Q�6S   5   /   U� 5   .   $
 (Rectangle.RadiusX)�6L   $ 
rectangle4��6|   .\�5   2     $ 0��6G   $
 15.6Q�6S   5   /   U� 5   .   $
 (Rectangle.RadiusY)�6L   $ 
rectangle4��6|   .\�5   2     $ 0��6G   $
 15.6Q�6S   5   /   �� 5   .   $,
 &(Shape.Stroke).(SolidColorBrush.Color)�6K   $ 
rectangle4��6�   .g�5   2     $ 0��6F   $ White��6R   5   /   5   +   5    '     5!   &   	MouseOver��.	 5"   *   �� .��5#   .   U� $
 (Rectangle.RadiusX)�6L   $ 
rectangle4��6|   .\�5$   2     $ 0��6G   $
 17.1Q�6S   5%   /   U� 5&   .   $
 (Rectangle.RadiusY)�6L   $ 
rectangle4��6|   .\�5'   2     $ 0��6G   $
 17.1Q�6S   5(   /   U� 5)   .   $
 (Shape.StrokeThickness)�6L   $ 
rectangle4��6�   .\�5*   2     $ 0��6G   $ 4Q�6S   5+   /   5,   +   5-   '     5.   &   Pressed��.	 5/   *   �� .��50   .   U� $
 (Rectangle.RadiusX)�6L   $ 
rectangle4��6|   .\�51   2     $ 0��6G   $
 20.3Q�6S   52   /   U� 53   .   $
 (Rectangle.RadiusY)�6L   $ 
rectangle4��6|   .\�54   2     $ 0��6G   $
 20.3Q�6S   55   /   U� 56   .   $
 (Shape.StrokeThickness)�6L   $ 
rectangle4��6�   .\�57   2     $ 0��6G   $ 4Q�6S   58   /   59   +   5:   '     5;   &   Disabled��62   5<   #   .+�5>      �� $ 
rectangle4��6(   
���   �
���   �6I   �� 5?      #��z��6/   ��. # z 6�   #��z��6�   $��OK��6  5@       5A      P� 5B       �@J�	IsFocused . 6;   P� 5C       �@��IsDefaulted . 6=   P� 5D       �@J�IsMouseOver . 6=   P� 5E       � �� . 6;   P� 5F       � {� .  6;   5H      5J      �� 5K       � �� �	#FFF4F4F46+   �� 5L       � ��$ Goudy Old Style)�6+   �� 5M       � ��$ 20(�6)   5N      5O      .��5P      � $
��1280��6   $	��720��6   .+�5Q   
   �� -   5        $ 
rectangle3��5Q      ���	#FF343434$
��Left=�69   $	��720��6T   $��0.4,0,-486.8,-299.6q�6a   
���   �$	��Top=�6�   $
��1280��6�   �� 5R   
   -   5         ��Name$ button9��5R      $��Button��6"   $
��Left=�63   $
��44.8��6N   $��993.2,607.6,-390,-232q�6\   #���   6{   $	��Top=�6�   $��190.4��6�   
�������6�   �� 5S   
   -   5         ��Name$ 	textBlock��5S      $
��Left=�6'   $��259.2��6B   $��223.501,212.4,-15.501,0q�6Q   $
��Wrap=�6r   $��BIENVENIDO A TESLA��6�   $	��Top=�6�   $
��1072��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�    J� Opacity$
 0.75Q�6�   
�������$��Goudy Old Style)�6  $��80(�6$  z�5T      V� 5U      .~�5V      �� �� 5W      �� 5X      T� 5Y      5Z      5\      5^      5_      