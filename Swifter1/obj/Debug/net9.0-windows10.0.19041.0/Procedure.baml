   M S B A M L   `   `   `  ����C  ?Swifter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Swifter1Swifter1  5          Swifter1.Procedure   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Swifter1     5        N� Title$  	Procedure��5	      .��5
      �� 
������� �� CornerRadius$ 10��6#   ���#CCCCCC._�5   
   � .+�5      �� $��Center=�6   .+�5      �� $(��"Pick a Step from the options below��6   $��Center=�6F   $��5q�6c   $��25(�6n   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6}   ���#121D55$��Light"�6�   6  �� 5      -   5         ��Name$	 Sys��5      $��Sytem Functions��6&   ���#FFFFFF$��
ExtraLight"�6U   $��17(�6m   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6{   ��5      �� 5       �� 
TargetType" ��6*   .R�5      ��  ��Name$ ButtonBorder��6%   $	��180��6;   $��20q�6G   $��30��6S   ���#121D55$ 15��6t    J� Effect 5   "   3  -System.Windows.Media.Effects.DropShadowEffect  5   &      Color$ Black��67      
BlurRadius$ 8Q�6E      ShadowDepth$ 2Q�6T   	   	Direction$		 270Q�6d   
   Opacity$	
 0.4Q�6t   ._�5   "   �� $��Center=�63   $��Center=�6P   5       �� Triggers 5      P� 5   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5   &   ��  �� Property �@�Cursor �� Value$
 Hand��6?   �� 5   &    �� 
TargetName$ ButtonBorder��6-    � �� �#545C866]   5   #   P� 5   "    � ��$
 True��6?   . �5   &   �� $ ButtonBorder��6-    � �� �#5D6B986]   5    #   5"      5$      �� 5&      -   5        $	 Key��5&      $��
Keystrokes��68   ���#FFFFFF$��
ExtraLight"�6b   $��17(�6z   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5'      �� 5(      " ��6*   .R�5)      �� $ ButtonBorder��6%   $	��180��6;   $��20q�6G   $��30��6S   ���#121D55$ 15��6t    5*   "     5+   &   $ Black��67   $ 8Q�6E   $ 2Q�6T   $		 270Q�6d   $	
 0.4Q�6t   ._�5-   "   �� $��Center=�63   $��Center=�6P   5.       5/      P� 50   "    �@J�IsMouseOver$
 True��6A   . �51   &   ��  �@�Cursor$
 Hand��6?   �� 52   &   $ ButtonBorder��6-    � �� �#545C866]   53   #   P� 55   "    � ��$
 True��6?   . �56   &   �� $ ButtonBorder��6-    � �� �#5D6B986]   57   #   59      5;      �� 5=      -   5        $	 txt��5=      $��
Paste Text��68   ���#FFFFFF$��
ExtraLight"�6b   $��17(�6z   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6�   ��5>      �� 5?      " ��6*   .R�5@      �� $ ButtonBorder��6%   $	��180��6;   $��20q�6G   $��30��6S   ���#121D55$ 15��6t    5A   "     5B   &   $ Black��67   $ 8Q�6E   $ 2Q�6T   $		 270Q�6d   $	
 0.4Q�6t   ._�5D   "   �� $��Center=�63   $��Center=�6P   5E       5F      P� 5G   "    �@J�IsMouseOver$
 True��6A   . �5H   &   ��  �@�Cursor$
 Hand��6?   �� 5I   &   $ ButtonBorder��6-    � �� �#545C866]   5J   #   P� 5L   "    � ��$
 True��6?   . �5M   &   �� $ ButtonBorder��6-    � �� �#5D6B986]   5N   #   5P      5R      �� 5T      -   5        $	 App��5T      $��Open Application��6&   ���#FFFFFF$��
ExtraLight"�6V   $��17(�6n   $U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�6|   ��5U      �� 5V      " ��6*   .R�5W      �� $ ButtonBorder��6%   $	��180��6;   $��20q�6G   $��30��6S   ���#121D55$ 15��6t    5X   "     5Y   &   $ Black��67   $ 8Q�6E   $ 2Q�6T   $		 270Q�6d   $	
 0.4Q�6t   ._�5[   "   �� $��Center=�63   $��Center=�6P   5\       5]      P� 5^   "    �@J�IsMouseOver$
 True��6A   . �5_   &   ��  �@�Cursor$
 Hand��6?   �� 5`   &   $ ButtonBorder��6-    � �� �#545C866]   5a   #   P� 5c   "    � ��$
 True��6?   . �5d   &   �� $ ButtonBorder��6-    � �� �#5D6B986]   5e   #   5g      5i      5k      5l      5m      5n      