   M S B A M L   `   `   `  ����H  DTaskAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TaskAssistantTaskAssistant  5   	   J FDBTaskAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:DBTaskAssistant;assembly=DBTaskAssistantDBTaskAssistant 5   	       TaskAssistant.AddTask   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TaskAssistant     5   	   Evm6clr-namespace:DBTaskAssistant;assembly=DBTaskAssistant     5   	     � Title$  Add Task��5	   	   $	��450��6   $	��800��6'   $	��450��5
   	   $	��450��6   $	��800��6)   $	��800��68    � DataContext 5        DBTaskAssistant.AddVM  5   
    � 	Resources 5         ComboBoxToggleButton �� 
TargetType � ColumnDefinitions ��Name �� CornerRadius F�Name  ComboBoxTextBox �� 
TargetType	 �� Property
 �� Value �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation �� Triggers P� Property P� Value �� 
TargetName P� 
SourceName �� Triggers  �� Padding  Text  TimeText! �� BasedOn" ��Name# ��Name
$ � Tag% �� Padding& �� TextAlignment' �� TextAlignment( ]� 
Conditions) �� Property* �� Value  RoundedGrad+ �� 
StartPoint, �� EndPoint- � Color. � Offset��%v  &	        &	     '�� w    7   '�� ;	    &	 W    &	 J    7  '�� �    &	 [    �� 5   
   " d�67   .R�5      �  5      �� 5      �� 5      $��20 �6'   .+�5      �� $ Border��5      $��2��5      $ 5��5      ���#6bcdfd
�������$��1q�5      �� 5      $��0��5      $ 0��5      $��1q�5      
����������	#FF97A0A5$��0,0,1,0q�5"      F� 5#      $ Arrow��5$      $��1��5%      
�������$��Center=�5'      $��Center=�5(      =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	5)      5+      5:      �� 5<   
   " ��62   .R�5=      �� $ PART_ContentHost��6   $|�False��6/   #��z��6A   5>      �� 5@   
   " ��6*   .�5A      �� 	 �@J�SnapsToDevicePixels$

 true��64   �� 5B      	 �@�OverridesDefaultStyle$

 true��66   �� 5C      	 � ��$

 true��6>   �� 5D      	 � ��$
 50��6&   �� 5E      	 � ��$
 40��6'   �� 5F      	 � ��
 �#699cfc6+   �� 5G      	 � ��$
 20(�6)   �� 5H      	 � ��
 5I      �� 5J      " ��6&   .R�5K      � .+�5L      d� $��ToggleButton��5M      8��  $��2��5O      $|�false��5P      $ Press=�5R       5Q      �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+5S      �� 5T      $��ContentSite��6/   $ False��6B   #��z 6\   #��z 5U      #��z��5V      $��3,3,23,3q�5W      $��Center=�5X      $
��Left=�5Y      � 5Z      $��Popup��5[      $��Bottom=�5\      #��z 5]      $
 True��5^      $|�False��5_      $��Slide=�5`      .��5b   "   � $��DropDown��6'   $
 True��5c      #��z 5d      #��z 5e      .+�5f   &   �� $ DropDownBorder��5g   !   
�������$��1q�5j   !   
�������5k   !   �� 5l   &   $��4,6,4,6q�63   $
 True��6D   .��5m   *   �� $
 True��65   $ 	Contained=�6H   5n   '   5o   #   5p      5q       5r      P� 5s       �@��HasItems$ false��6:   . �5t   "   �� $ DropDownBorder��6)   	 � ��$
 95��6Z   5u      P� 5v       �@��
IsGrouping$
 true��6<   . �5w   "   �� 	 � ��$
 false��6R   5x      P� 5y      $ Popup��6&    �@�AllowsTransparency$
 true��6]   . �5z   "   �� $ DropDownBorder��6)   	 �@��CornerRadius$
 0��6]   �� 5{   "   $ DropDownBorder��6)   	 � ��$
 0,2,0,0q�6W   5|      5~      5�       5�      5�      �� 5�   
   " ��6.   .�5�      �� 	 �@J�SnapsToDevicePixels$

 true��64   �� 5�      	 � ��
 �#8ab4fa6+   �� 5�      	 � ��$
 18(�6)   �� 5�      	 �@�OverridesDefaultStyle$

 true��66   �� 5�      	 � ��
 5�      �� 5�      " ��6&   .R�5�      �� $��Border��6!   $  2q�5�      $
 true��5�      ._�5�      �� 5�       5�      P� 5�       �@��IsHighlighted$
 true��6?   . �5�   "   �� $ Border��6)   	 � ��

 �  ��6S   5�      5�      5�      5�      �� 5�   
   " ��6   .�5�      �� 	 � ��$
 0 50 0 0q�6'   �� 5�      	 � ��

 �����6+   �� 5�      	 �@��TextAlignment$
 Center=�6.   �� 5�      	 � ��$	
 Top=�62   �� 5�      	 � ��$
 15(�6)   5�      �� 5�   
   " ��6   8!   .�5�      �� 	 � ��$
 50��6&   5�      �� 5�   
   " ��6   .�5�      �� 	 � ��
 �#8ab4fa6+   �� 5�      	 �@��	MaxLength$
 30��6*   �� 5�      	 � ��$
 20(�6)   �� 5�      	 � ��

 �����6+   �� 5�      	 � ��$
 0q�60   �� 5�      	 � ��

 ���� 6,   �� 5�      	 � ��$
 5q�6'   �� 5�      	 � ��$

 20 5q�6(   �� 5�      	 � ��
 5�      �� 5�      " ��6&   .R�5�      �� #��z��5�      #��z��5�      #��z��5�      $ 20��5�      ._�5�      � .+�5�   "   �� $" PART_ContentHost��5�   %   $��0q�5�   %   $��Center=�5�   %   �� 5�   "   $# DefText��5�   %   #��z$ 5�   %   #% z��5�   %   $��Center=�5�   %   
������ #��z��5�   %   
�������$ False��5�   %   #' z& 5�   %   $y�	Collapsed=�5�   %   5�      5�       5�      ]� 5�      ( 5�   "   �� 5�   &   ) � ��$*  ��6@   ./�5�   "   �� $ DefText��6)   	 � y�$
 Visible=�6T   5�      5�      5�      5�      �� 5�   
   " ��6   .�5�      �� 	 � ��$
 0q�60   �� 5�      	 � ��

 �����6+   �� 5�      	 � ��$
 40(�6)   �� 5�      	 � ��$	
 250��6&   �� 5�      	 � ��$
 10q�6'   �� 5�      	 � ��
 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ BackBord��6%   $ 30��67   $��2q�6I   
���������5�   "   �� 5�   &   $	+ 0,0&�6:   $	, 0,1&�6K   .��5�   *   � $- #699cfc��67   $. 0Q�6G   � 5�   *   $- #6bcdfd��67   $. 1Q�6G   5�   '   5�      �� 5�      $��Center=�6/   $��Center=�6J   5�       5�      ]� 5�      ( 5�   "   �� 5�   &   ) �@J�IsMouseOver$
* true��6G   ./�5�   "   �� $ BackBord��6)   	 � ��
 5�   &   �� 5�   *   $	+ 0,0&�6>   $	, 0,1&�6O   .��5�   .   � $- #8fb6ff��6;   $. 0Q�6K   � 5�   .   $- #91dbff��6;   $. 1Q�6K   5�   +   5�   #   5�      ]� 5�      ( 5�   "   �� 5�   &   ) � ��$
* true��6E   ./�5�   "   �� $ BackBord��6)   	 � ��
 5�   &   �� 5�   *   $	+ 0,0&�6>   $	, 0,1&�6O   .��5   .   � $- #bdd4ff��6;   $. 0Q�6K   � 5  .   $- #bfeaff��6;   $. 1Q�6K   5  +   5  #   5     5     5	     5
     5     .��5     � ��5  
   �� 5     / �� ImageSource$ / Images\BackgroundLogin.jpg��6   0 j� Stretch$0 UniformToFill=�6B   .+�5  
   �� $��0��6   1 J� Opacity$
1 0.65Q�6   ��5     �� 5     $	+ 0,0&�6&   $	, 1,0&�67   .��5     � $- #676cfb��6#   $. 0Q�63   � 5     $- #6bcdfd��6#   $. 1Q�63   5     5     �� 5  
   .+�5     �� -   5        2 ��Name$
2 Node��5     $
$ Node��5     $��25(�5     ���#699cfc$��30 30q�5     $
��10 5q�5     3 �� 	MaxLength$3 50��5      � 5!     $
��60 0q�6    5"     �� 5#     $��* �6'   �� 5$     $��* �6'   �� 5%     $��* �6'   .+�5'     &   System.Windows.Controls.Calendar  -   5        4  Name$4 Calend��5'     $��0��5(     
�������5   IsTodayHighlighted$
5 True��5+     $��10q�5,     6   SelectedDate6 5*     �� *date+5,     �� 5.     $��1��6   7 �� Orientation$7 
Horizontal=�5/     $��Center=�50     .+�51     �� .+�52     �� $
��Hour��6$   #��[ 60   �� 53     -   5        8 ��Name$8 HourBox��53  #   ��54     �� *hours+9 �� SelectedValue9 55     �� *
currHour+56     �� 57     .+�58     �� $��Minute��6$   #��[ 62   �� 59     -   5        $8 	MinuteBox��59  #   ��5:     �� *	minutes+9 5;     �� *
currMinute+5<     5=     �� 5>     $��3��6   .+�5?     �� $��Пріорітет��6    #��[ 61   �� 5@     -   5        $8 PriorityBox��5@     ��5A     �� *
priorities+9 5B     �� *
priority+5C     5F     A� 5G     : A� Columns$: 2��6   $��Bottom=�6&   $��10 20q�6A   .+�5H     �� -   5        $��Скасувати��5H     #��[ 5I     6>   �� 5J     -   5        $��Зберегти��5J     #��[ 5K     6>   5L     5M     5N     5O     