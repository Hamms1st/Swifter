   M S B A M L   `   `   `  ����C  ?Swifter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Swifter1Swifter1  5   	       Swifter1.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Swifter1     5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ 	CanResize=�5	   	    � AllowsTransparency$
 True��5
   	   
������  � WindowStartupLocation$ CenterScreen=�5   
    � Title$ 
MainWindow��5   	   $	��560��6   $	��940��6)   .��5      �� ���#CCCCCC �� CornerRadius$ 10��6"   ���#CCCCCC._�5      �  � RowDefinitions 5   
   �� 5      -   5        $��20 �5   U   6c   �� 5      $	��478 �6   6+   �� 5      $��50 �6   6*   .+�5   
   � $��Right=�6   $��0��6-    � ColumnDefinitions 5      �� 5      $
��25px �6#   63   �� 5      $
��25px �6#   63   .+�5      �� -   5         ��Name$ cross��5      $��1��68   $��x��6I   $��15(�6U   ���#121D55$��SemiBold"�6x   $-��'/Fonts/Montserrat-VariableFont_wght.ttf)�6�   ��5      �� 5       	 �� 
TargetType"	 ��6&   .R�5!      �� $��ButtonBorder��6!   $ 2��65   ._�5"      �� $��Center=�6/   $��Center=�6L   6i   5#      
 �� Triggers
 5$      P� 5%       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5&   &   ��  �� Property �@�Cursor �� Value$
 Hand��6?   5'   #   P� 5)       � ��$
 True��6;   . �5*   "   ��  �� 
TargetName$ ButtonBorder��6)    � ��
 �����6Y   5+      5-      5/      �� 50      -   5        $	 min��50      $��0��69   $��-��6I   $��18(�6U   ���#121D55$-��'/Fonts/Montserrat-VariableFont_wght.ttf)�6x   $��SemiBold"�6�   ��51      �� 52      "	 ��6&   .R�53      �� $��ButtonBorder��6!   $ 2��65   ���#cccccc._�54      �� $��Center=�6/   $��Center=�6L   6i   55      
 56      P� 57       �@J�IsMouseOver$
 True��6=   . �58   "   ��  �@�Cursor$
 Hand��6;   59      P� 5;       � ��$
 True��6;   . �5<   "   �� $ ButtonBorder��6)    � ��
 �����6Y   5=      5?      5A      5C      � 5D      -   5         �Name$ MyContainer��5D      $��1��6(   .+�5E       � -   5          �Name$ Main2��5E        � NavigationUIVisibility$ Hidden=�6(   5F      �� 5G      -   5         ��Name$ Below��5G   0   $��Bottom=�6   $��2��6?   $y�	Collapsed=�6L   $	��250��6c   ���#5F6790$ 8��6�   $	��3pxq�6�   $��1q�6�    J� Effect 5H      3  -System.Windows.Media.Effects.DropShadowEffect  5I         Color$ Black��6'      
BlurRadius$ 8Q�65      ShadowDepth$ 2Q�6D      	Direction$ 90Q�6T      Opacity$	 0.4Q�6c   ._�5L      � $��Bottom=�6   $��2��62    5M      �� 5N      $��* �6'   63   �� 5O      $��* �6'   63   �� 5P      $��* �6'   63   .+�5R      �� -   5        $��0��5R      ��5S      �� 5T      "	 ��6.   .R�5U   "   �� $��ButtonBorder��6)   $ 8��6=   ._�5V   &   �� $��/images/Short.png��6,   $��3q�6G   5W   #   
 5X   "   P� 5Y   &    � ��$
 True��6C   . �5[   *   �� $ ButtonBorder��61    � �� �#72799E6a   5\   '   5^      5`      �� 5a      -   5        $��1��5a      ��5b      �� 5c      "	 ��6.   .R�5d   "   �� $��ButtonBorder��6)   $ 8��6=   ._�5e   &   �� $��/images/Auto.png��6,   $��3q�6F   5f   #   
 5g   "   P� 5h   &    � ��$
 True��6C   . �5j   *   �� $ ButtonBorder��61    � �� �#72799E6a   5k   '   5m      5o      �� 5p      $��2��6   ��5q      �� 5r      "	 ��6.   .R�5s   "   �� $��ButtonBorder��6)   $ 8��6=   ._�5t   &   �� $��/images/Wifi.png��6,   $��3q�6F   5u   #   
 5v   "   P� 5w   &    � ��$
 True��6C   . �5y   *   �� $ ButtonBorder��61    � �� �#72799E6a   5z   '   5|      5~      5      5�      5�      5�      5�      