   M S B A M L   `   `   `  ����P  LLoadingSpinnerControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControlLoadingSpinnerControl  5      rMclr-namespace:LoadingSpinnerControl.Converters;assembly=LoadingSpinnerControl LoadingSpinnerControl.Converters  5      C ?Swifter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Swifter1Swifter1 5         Swifter1.ActionIN   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      WmaterialBclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControl     5      mmaterialexentensionMclr-namespace:LoadingSpinnerControl.Converters;assembly=LoadingSpinnerControl     5      (localclr-namespace:Swifter1     5        N� Title$  ActionIN��5      .��5      �� 
������� �� CornerRadius$ 10��6#   ���#CCCCCC._�5   
   � .+�5      �� .+�5      �� $��Setup your Actions��6   $��Center=�66   $��5q�6S   $��25(�6^   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6m   ���#121D55$��Light"�6�   6�   �� 5      $ ��Add Steps/Conditions/Loops��6   $��Center=�6>   $��14(�6[   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6j   ���#121D55$��Light"�6�   6�   �� 5      -   5         �� PanningMode$ HorizontalOnly=�5       J� IsManipulationEnabled$
 True��6<   $��0q�6�   $��Disabled=�6�   $��Hidden=�6�   $
��True��6�   .��5      � .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ Step1��5   !   ���#FFFFFF$��
ExtraLight"�6Z   $��17(�6r   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   .��5      �� $ 
Horizontal=�6)   .+�5   "   �� $
��Step��6,   $��2q�68   $��Center=�6C   ���#FFFFFF$��
ExtraLight"�6t   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   6�   �� 5   "   $��/images/plus.png��6(   $��2q�6B   $��Center=�6M   $��15��6h   $��15��6s   6�   5      ��5      �� 5   "    �� 
TargetType" ��62   .R�5    &   ��  ��Name$ ButtonBorder��6-   $��90��6C   $��20q�6N   $��30��6Z   ���#121D55$ 15��6{    J� Effect 5!   *   3  -System.Windows.Media.Effects.DropShadowEffect  5"   .   	   Color$	 Black��6?   
   
BlurRadius$
 8Q�6M      ShadowDepth$ 2Q�6\      	Direction$	 270Q�6l      Opacity$	 0.4Q�6|   ._�5%   *   �� $��Center=�6;   $��Center=�6X   5&   '    �� Triggers 5(   &   P� 5)   *    P� Property �@J�IsMouseOver P� Value$
 True��6I   . �5*   .   ��  �� Property �@�Cursor �� Value$
 Hand��6G   �� 5+   .    �� 
TargetName$ ButtonBorder��65    � �� �#545C866e   5,   +   P� 5.   *    � ��$
 True��6G   . �5/   .   �� $ ButtonBorder��65    � �� �#5D6B986e   50   +   52   #   54      �� 55      -   5        $ If��55   !   $��If {_ / _} ��6?   ���#FFFFFF$��
ExtraLight"�6j   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��56      �� 57   "   " ��62   .R�58   &   �� $ ButtonBorder��6-   $��90��6C   $��20q�6N   $��30��6Z   ���#121D55$ 15��6{    59   *     5:   .   $	 Black��6?   $
 8Q�6M   $ 2Q�6\   $	 270Q�6l   $	 0.4Q�6|   ._�5<   *   �� $��Center=�6;   $��Center=�6X   5=   '    5>   &   P� 5?   *    �@J�IsMouseOver$
 True��6I   . �5@   .   ��  �@�Cursor$
 Hand��6G   �� 5A   .   $ ButtonBorder��65    � �� �#545C866e   5B   +   P� 5D   *    � ��$
 True��6G   . �5E   .   �� $ ButtonBorder��65    � �� �#5D6B986e   5F   +   5H   #   5J      �� 5M      -   5        $ Endif��5M   !   $��End_If ��6D   ���#FFFFFF$��
ExtraLight"�6l   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5N      �� 5O   "   " ��62   .R�5P   &   �� $ ButtonBorder��6-   $��90��6D   $��20q�6O   $��30��6[   ���#121D55$ 15��6|    5Q   *     5R   .   $	 Black��6?   $
 8Q�6M   $ 2Q�6\   $	 270Q�6l   $	 0.4Q�6|   ._�5T   *   �� $��Center=�6;   $��Center=�6X   5U   '    5V   &   P� 5W   *    �@J�IsMouseOver$
 True��6I   . �5X   .   ��  �@�Cursor$
 Hand��6G   �� 5Y   .   $ ButtonBorder��65    � �� �#545C866e   5Z   +   P� 5\   *    � ��$
 True��6G   . �5]   .   �� $ ButtonBorder��65    � �� �#5D6B986e   5^   +   5`   #   5b      �� 5d      -   5        $
 Else��5d   !   $��Else{_ / _} ��6C   ���#FFFFFF$��
ExtraLight"�6p   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5e      �� 5f   "   " ��62   .R�5g   &   �� $ ButtonBorder��6-   $��90��6D   $��20q�6O   $��30��6[   ���#121D55$ 15��6|    5h   *     5i   .   $	 Black��6?   $
 8Q�6M   $ 2Q�6\   $	 270Q�6l   $	 0.4Q�6|   ._�5k   *   �� $��Center=�6;   $��Center=�6X   5l   '    5m   &   P� 5n   *    �@J�IsMouseOver$
 True��6I   . �5o   .   ��  �@�Cursor$
 Hand��6G   �� 5p   .   $ ButtonBorder��65    � �� �#545C866e   5q   +   P� 5s   *    � ��$
 True��6G   . �5t   .   �� $ ButtonBorder��65    � �� �#5D6B986e   5u   +   5w   #   5y      �� 5{      -   5        $ Elseend��5{   !   $��End_Else��6I   ���#FFFFFF$��
ExtraLight"�6r   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5|      �� 5}   "   " ��62   .R�5~   &   �� $ ButtonBorder��6-   $	��100��6D   $��20q�6P   $��30��6\   ���#121D55$ 15��6}    5   *     5�   .   $	 Black��6?   $
 8Q�6M   $ 2Q�6\   $	 270Q�6l   $	 0.4Q�6|   ._�5�   *   �� $��Center=�6;   $��Center=�6X   5�   '    5�   &   P� 5�   *    �@J�IsMouseOver$
 True��6I   . �5�   .   ��  �@�Cursor$
 Hand��6G   �� 5�   .   $ ButtonBorder��65    � �� �#545C866e   5�   +   P� 5�   *    � ��$
 True��6G   . �5�   .   �� $ ButtonBorder��65    � �� �#5D6B986e   5�   +   5�   #   5�      �� 5�      -   5        $
 Loop��5�   !   ���#FFFFFF$��
ExtraLight"�6Y   $��17(�6q   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6   .��5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $
��Loop��6,   $��2q�68   $��Center=�6C   ���#FFFFFF$��
ExtraLight"�6t   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   6�   �� 5�   "   $��/images/refresh.png��6(   $��2q�6E   $��Center=�6P   $��15��6k   $��15��6v   6�   5�      ��5�      �� 5�   "   " ��62   .R�5�   &   �� $ ButtonBorder��6-   $��90��6C   $��20q�6N   $��30��6Z   ���#121D55$ 15��6{    5�   *     5�   .   $	 Black��6?   $
 8Q�6M   $ 2Q�6\   $	 270Q�6l   $	 0.4Q�6|   ._�5�   *   �� $��Center=�6;   $��Center=�6X   5�   '    5�   &   P� 5�   *    �@J�IsMouseOver$
 True��6I   . �5�   .   ��  �@�Cursor$
 Hand��6G   �� 5�   .   $ ButtonBorder��65    � �� �#545C866e   5�   +   P� 5�   *    � ��$
 True��6G   . �5�   .   �� $ ButtonBorder��65    � �� �#5D6B986e   5�   +   5�   #   5�      �� 5�      -   5        $ EndLoop��5�   !   ���#FFFFFF$��
ExtraLight"�6^   $��17(�6v   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   .��5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $��Loop_End��6,   $��2q�6<   $��Center=�6G   ���#FFFFFF$��
ExtraLight"�6x   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   6�   �� 5�   "   $��/images/refresh.png��6(   $��2q�6E   $��Center=�6P   $��15��6k   $��15��6v   6�   5�      ��5�      �� 5�   "   " ��62   .R�5�   &   �� $ ButtonBorder��6-   $	��110��6C   $��20q�6O   $��30��6[   ���#121D55$ 15��6|    5�   *     5�   .   $	 Black��6?   $
 8Q�6M   $ 2Q�6\   $	 270Q�6l   $	 0.4Q�6|   ._�5�   *   �� $��Center=�6;   $��Center=�6X   5�   '    5�   &   P� 5�   *    �@J�IsMouseOver$
 True��6I   . �5�   .   ��  �@�Cursor$
 Hand��6G   �� 5�   .   $ ButtonBorder��65    � �� �#545C866e   5�   +   P� 5�   *    � ��$
 True��6G   . �5�   .   �� $ ButtonBorder��65    � �� �#5D6B986e   5�   +   5�   #   5�      �� 5�      -	   5        $	 Del��5�   !   ���#FFFFFF$��
ExtraLight"�6V   $��17(�6n   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6|   .��5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $��Delay��6,   $��2q�69   $��Center=�6D   ���#FFFFFF$��
ExtraLight"�6u   $��17(�6�   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   6�   �� 5�   "   $��/images/clock.png��6(   $��2q�6C   $��Center=�6N   $��15��6i   $��15��6t   6�   5�      ��5�      �� 5�   "   " ��62   .R�5�   &   �� $ ButtonBorder��6-   $��90��6C   $��20q�6N   $��30��6Z   ���#121D55$ 15��6{    5�   *     5�   .   $	 Black��6?   $
 8Q�6M   $ 2Q�6\   $	 270Q�6l   $	 0.4Q�6|   ._�5�   *   �� $��Center=�6;   $��Center=�6X   5�   '    5�   &   P� 5�   *    �@J�IsMouseOver$
 True��6I   . �5�   .   ��  �@�Cursor$
 Hand��6G   �� 5�   .   $ ButtonBorder��65    � �� �#545C866e   5�   +   P� 5�   *    � ��$
 True��6G   . �5�   .   �� $ ButtonBorder��65    � �� �#5D6B986e   5�   +   5�   #   5�      5�      5�      5�      �� 5�      $	��200��6    $��Hidden=�60   $��0q�6U   $��0,5,0,5q�6j   $��Center=�6{   .��5�      � -
   5         �Name$ StepsCOntainer��5�   W    � Orientation$ Vertical=�6!   $��Center=�69   5�      5�      �� 5�      -   5        $ Confirm��5�      $��Confirm��6*   ���#FFFFFF$��
ExtraLight"�6S   $��17(�6k   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6y   ��5�      �� 5�      " ��6*   .R�5�      �� $ ButtonBorder1��6%   $��5q�6<   $	��185��6G   $��40��6S   ���#121D55$ 15��6t    5�   "     5�   &   $	 Black��67   $
 8Q�6E   $ 2Q�6T   $ 90Q�6d   $	 0.4Q�6s   ._�5�   "   �� $��Center=�63   $��Center=�6P   5�       5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  �@�Cursor$
 Hand��6?   �� 5�   &   $ ButtonBorder1��6-    � �� �#545C866^   5�   #   5     5     �� 5     -   5         ��Name$
 DOne��5     $y�Hidden=�6*   $`��ZYour Shortcut has been Created Successfully!
Please wait while we restart your Application��5     $��Center=�5     $��14(�6)   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�5     ���#121D55$��Light"�5	  !   *   $LoadingSpinnerControl.LoadingSpinner  5
     -   5          Name$
 spin��5
  *      	IsLoading$ False��68   $��1��6J      Diameter$ 30Q�6W      	Thickness$	 1.4Q�6e      Color �#121D55$
��25pxq�6�   6�   5     5     5     5     