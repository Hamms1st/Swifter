   M S B A M L   `   `   `  ����C  ?Swifter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Swifter1Swifter1  5          Swifter1.Ifcheck   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Swifter1     5        N� Title$  Ifcheck��5	      .��5
      �� 
������� �� CornerRadius$ 10��6#   ���#CCCCCC._�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   .+�5      �� $��If the Condition is True��6   $��10q�6:   $��25(�6F   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6U   ���#121D55$��Light"�6�   6�   �� 5      $	��365��6   $��Hidden=�5      $��Disabled=�5       �� PanningMode$ VerticalOnly=�5      $
��True��5      $��0,5,0,5q�5      $��0q�5      .��5      �� $ Vertical=�6   $��Center=�60   .+�5      �� $��10q�6!   $	��200��6-   $ Vertical=�69   .+�5      �� $��If WiFi is On/Off ?��6%   $��1q�6@   $��20(�6K   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6[   ���#121D55$��Light"�6�   6�   �� 5      $ 
Horizontal=�6%   .+�5      �� -   5         ��Name$
 Ifon��5   %   $��On��63   ���#FFFFFF$��
ExtraLight"�6U   $��17(�6m   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6{   ��5   "   �� 5   &    �� 
TargetType" ��66   .R�5   *   ��  ��Name$ ButtonBorder��61   $��90��6G   $��5q�6R   $��30��6]   ���#121D55$ 15��6~    J� Effect 5   .   3  -System.Windows.Media.Effects.DropShadowEffect  5   2      Color$ Black��6C   	   
BlurRadius$	 8Q�6Q   
   ShadowDepth$
 2Q�6`      	Direction$	 270Q�6p      Opacity$	 0.4Q�6�   ._�5    .   �� $��Center=�6?   $��Center=�6\   5!   +    �� Triggers 5"   *   P� 5#   .    P� Property �@J�IsMouseOver P� Value$
 True��6M   . �5$   2   ��  �� Property �@�Cursor �� Value$
 Hand��6K   �� 5%   2    �� 
TargetName$ ButtonBorder��69    � �� �#545C866i   5&   /   P� 5(   .    � ��$
 True��6K   . �5)   2   �� $ ButtonBorder��69    � �� �#5D6B986i   5*   /   5,   '   5.      �� 5/      -   5        $
 Ifof��5/   %   $��On��6K   ���#FFFFFF$��
ExtraLight"�6m   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��50   "   �� 51   &   " ��66   .R�52   *   �� $ ButtonBorder��61   $��90��6G   $��5q�6R   $��30��6]   ���#121D55$ 15��6~    53   .     54   2   $ Black��6C   $	 8Q�6Q   $
 2Q�6`   $	 270Q�6p   $	 0.4Q�6�   ._�56   .   �� $��Center=�6?   $��Center=�6\   57   +    58   *   P� 59   .    �@J�IsMouseOver$
 True��6M   . �5:   2   ��  �@�Cursor$
 Hand��6K   �� 5;   2   $ ButtonBorder��69    � �� �#545C866i   5<   /   P� 5>   .    � ��$
 True��6K   . �5?   2   �� $ ButtonBorder��69    � �� �#5D6B986i   5@   /   5B   '   5D      5E      5G      �� 5I      $��10q�6!   $	��200��6-   $ Vertical=�69   .+�5J      �� $��If Bluetooth is On/Off ?��6%   $��1q�6F   $��20(�6Q   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6a   ���#121D55$��Light"�6�   6�   �� 5K      $ 
Horizontal=�6%   .+�5L      �� -   5        $ IfBlon��5L   %   $��On��6J   ���#FFFFFF$��
ExtraLight"�6l   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5M   "   �� 5N   &   " ��66   .R�5O   *   �� $ ButtonBorder��61   $��90��6G   $��5q�6R   $��30��6]   ���#121D55$ 15��6~    5P   .     5Q   2   $ Black��6C   $	 8Q�6Q   $
 2Q�6`   $	 270Q�6p   $	 0.4Q�6�   ._�5S   .   �� $��Center=�6?   $��Center=�6\   5T   +    5U   *   P� 5V   .    �@J�IsMouseOver$
 True��6M   . �5W   2   ��  �@�Cursor$
 Hand��6K   �� 5X   2   $ ButtonBorder��69    � �� �#545C866i   5Y   /   P� 5[   .    � ��$
 True��6K   . �5\   2   �� $ ButtonBorder��69    � �� �#5D6B986i   5]   /   5_   '   5a      �� 5b      -   5        $ Ifblof��5b   %   $	��Off��66   ���#FFFFFF$��
ExtraLight"�6n   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5c   "   �� 5d   &   " ��66   .R�5e   *   �� $ ButtonBorder��61   $��90��6G   $��5q�6R   $��30��6]   ���#121D55$ 15��6~    5f   .     5g   2   $ Black��6C   $	 8Q�6Q   $
 2Q�6`   $	 270Q�6p   $	 0.4Q�6�   ._�5i   .   �� $��Center=�6?   $��Center=�6\   5j   +    5k   *   P� 5l   .    �@J�IsMouseOver$
 True��6M   . �5m   2   ��  �@�Cursor$
 Hand��6K   �� 5n   2   $ ButtonBorder��69    � �� �#545C866i   5o   /   P� 5q   .    � ��$
 True��6K   . �5r   2   �� $ ButtonBorder��69    � �� �#5D6B986i   5s   /   5u   '   5w      5x      5z      �� 5|      $	��200��6!   $��10q�6-   $ Vertical=�69   .+�5}      �� $��If Battery is  ?��6%   $��1q�6>   $��20(�6I   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6Y   ���#121D55$��Light"�6�   6�   �� 5~      $ 
Horizontal=�6%   .+�5      �� -   5        $ IfChon��5   %   $��Check��6J   ���#FFFFFF$��
ExtraLight"�6o   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5�   "   �� 5�   &   " ��66   .R�5�   *   �� $ ButtonBorder��61   $��90��6G   $��5q�6R   $��30��6]   ���#121D55$ 15��6~    5�   .     5�   2   $ Black��6C   $	 8Q�6Q   $
 2Q�6`   $	 270Q�6p   $	 0.4Q�6�   ._�5�   .   �� $��Center=�6?   $��Center=�6\   5�   +    5�   *   P� 5�   .    �@J�IsMouseOver$
 True��6M   . �5�   2   ��  �@�Cursor$
 Hand��6K   �� 5�   2   $ ButtonBorder��69    � �� �#545C866i   5�   /   P� 5�   .    � ��$
 True��6K   . �5�   2   �� $ ButtonBorder��69    � �� �#5D6B986i   5�   /   5�   '   5�      �� 5�      $��10q�6%   $��Center=�62   $��1��6M   $ 10��6]   $��2q�6o   ���#8A8A8A���#7c7c7c$��35��6�   $��90��6�   ._�5�   "   �� -   5         ��Name$ 	checkstat��5�   *   $;��5pack://application:,,,/Swifter1;component/Fonts/#Jost)�6>   ���#121D55$��0��6�   
������ $��0q�6�   $��13(�6�   $��4q�6�   $��50��6�    �� TextAlignment$ Center=�6�   $��Center=�6  5�      5�      5�      �� 5�      $	��200��6!   $��10q�6-   $ Vertical=�69   .+�5�      �� $��If Dark Mode is On/Off ?��6%   $��1q�6E   $��20(�6P   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6`   ���#121D55$��Light"�6�   6�   �� 5�      $ 
Horizontal=�6%   .+�5�      �� -   5        $ IfNgon��5�   %   $��On��6J   ���#FFFFFF$��
ExtraLight"�6l   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5�   "   �� 5�   &   " ��66   .R�5�   *   �� $ ButtonBorder��61   $��90��6G   $��5q�6R   $��30��6]   ���#121D55$ 15��6~    5�   .     5�   2   $ Black��6C   $	 8Q�6Q   $
 2Q�6`   $	 270Q�6p   $	 0.4Q�6�   ._�5�   .   �� $��Center=�6?   $��Center=�6\   5�   +    5�   *   P� 5�   .    �@J�IsMouseOver$
 True��6M   . �5�   2   ��  �@�Cursor$
 Hand��6K   �� 5�   2   $ ButtonBorder��69    � �� �#545C866i   5�   /   P� 5�   .    � ��$
 True��6K   . �5�   2   �� $ ButtonBorder��69    � �� �#5D6B986i   5�   /   5�   '   5�      �� 5�      -   5        $ IfNgof��5�   %   $	��Off��6K   ���#FFFFFF$��
ExtraLight"�6n   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5�   "   �� 5�   &   " ��66   .R�5�   *   �� $ ButtonBorder��61   $��90��6G   $��5q�6R   $��30��6]   ���#121D55$ 15��6~    5�   .     5�   2   $ Black��6C   $	 8Q�6Q   $
 2Q�6`   $	 270Q�6p   $	 0.4Q�6�   ._�5�   .   �� $��Center=�6?   $��Center=�6\   5�   +    5�   *   P� 5�   .    �@J�IsMouseOver$
 True��6M   . �5�   2   ��  �@�Cursor$
 Hand��6K   �� 5�   2   $ ButtonBorder��69    � �� �#545C866i   5�   /   P� 5�   .    � ��$
 True��6K   . �5�   2   �� $ ButtonBorder��69    � �� �#5D6B986i   5�   /   5�   '   5�      5�      5�      �� 5�      $	��200��6!   $��10q�6-   $ Vertical=�69   .+�5�      �� $"��If Airplane Mode is On/Off ?��6%   $��1q�6I   $��20(�6T   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6d   ���#121D55$��Light"�6�   6�   �� 5�      $ 
Horizontal=�6%   .+�5�      �� -	   5        $ IfAron��5�   %   $��On��6J   ���#FFFFFF$��
ExtraLight"�6l   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5�   "   �� 5�   &   " ��66   .R�5�   *   �� $ ButtonBorder��61   $��90��6G   $��5q�6R   $��30��6]   ���#121D55$ 15��6~    5�   .     5�   2   $ Black��6C   $	 8Q�6Q   $
 2Q�6`   $	 270Q�6p   $	 0.4Q�6�   ._�5�   .   �� $��Center=�6?   $��Center=�6\   5�   +    5�   *   P� 5�   .    �@J�IsMouseOver$
 True��6M   . �5�   2   ��  �@�Cursor$
 Hand��6K   �� 5�   2   $ ButtonBorder��69    � �� �#545C866i   5�   /   P� 5�   .    � ��$
 True��6K   . �5�   2   �� $ ButtonBorder��69    � �� �#5D6B986i   5�   /   5�   '   5�      �� 5�      -
   5        $ IfArof��5�   %   $��On��6K   ���#FFFFFF$��
ExtraLight"�6m   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5�   "   �� 5�   &   " ��66   .R�5�   *   �� $ ButtonBorder��61   $��90��6G   $��5q�6R   $��30��6]   ���#121D55$ 15��6~    5�   .     5�   2   $ Black��6C   $	 8Q�6Q   $
 2Q�6`   $	 270Q�6p   $	 0.4Q�6�   ._�5�   .   �� $��Center=�6?   $��Center=�6\   5�   +    5�   *   P� 5�   .    �@J�IsMouseOver$
 True��6M   . �5�   2   ��  �@�Cursor$
 Hand��6K   �� 5�   2   $ ButtonBorder��69    � �� �#545C866i   5�   /   P� 5�   .    � ��$
 True��6K   . �5�   2   �� $ ButtonBorder��69    � �� �#5D6B986i   5�   /   5�   '   5     5     5     5     5     5     5	     5
     