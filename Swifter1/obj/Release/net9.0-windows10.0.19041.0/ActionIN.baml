   M S B A M L   `   `   `  ���� C  ?Swifter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Swifter1Swifter1      Swifter1.ActionIN   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:Swifter1       N� Title$  ActionIN��.���� 
������� �� CornerRadius$ 10�����#CCCCCC._�� .+��� .+��� $��Setup your Actions��$��Center=�$��5q�$��25(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����#121D55$��Light"��� $ ��Add Steps/Conditions/Loops��$��Center=�$��14(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����#121D55$��Light"��� -    �� PanningMode$ HorizontalOnly=� J� IsManipulationEnabled$
 True��$��0q�$��Disabled=�$��Hidden=�$
��True��.����  �� Orientation$ 
Horizontal=�.+��� -    ��Name$ Step1�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�.���� $ 
Horizontal=�.+��� $
��Step��$��2q�$��Center=����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)��� $��/images/plus.png��$��2q�$��Center=�$��15��$��15������  �� 
TargetType" ��.R���  ��Name$ ButtonBorder��$��90��$��20q�$��30�����#121D55$ 15�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  	   Color$	 Black��
   
BlurRadius$
 8Q�   ShadowDepth$ 2Q�   	Direction$	 270Q�   Opacity$	 0.4Q�._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  �� Property �@�Cursor �� Value$
 Hand����  �� 
TargetName$ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -   $ If��$��If {_ / _} �����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��20q�$��30�����#121D55$ 15��   $	 Black��$
 8Q�$ 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -   $
 Else��$��Else{_ / _} �����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��20q�$��30�����#121D55$ 15��   $	 Black��$
 8Q�$ 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -   $ Endif��$��End_If �����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��20q�$��30�����#121D55$ 15��   $	 Black��$
 8Q�$ 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -   $
 Loop�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�.���� $ 
Horizontal=�.+��� $
��Loop��$��2q�$��Center=����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)��� $��/images/refresh.png��$��2q�$��Center=�$��15��$��15������ " ��.R��� $ ButtonBorder��$��90��$��20q�$��30�����#121D55$ 15��   $	 Black��$
 8Q�$ 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -   $ EndLoop�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�.���� $ 
Horizontal=�.+��� $��Loop_End��$��2q�$��Center=����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)��� $��/images/refresh.png��$��2q�$��Center=�$��15��$��15������ " ��.R��� $ ButtonBorder��$	��110��$��20q�$��30�����#121D55$ 15��   $	 Black��$
 8Q�$ 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -   $	 Del�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�.���� $ 
Horizontal=�.+��� $��Delay��$��2q�$��Center=����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)��� $��/images/clock.png��$��2q�$��Center=�$��15��$��15������ " ��.R��� $ ButtonBorder��$��90��$��20q�$��30�����#121D55$ 15��   $	 Black��$
 8Q�$ 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� $��Hidden=�$��1��$��0q�$��0,5,0,5q�$��Center=�.���� $��Center=�$ Vertical=�.+�� -	    �Name$ StepsCOntainer��$��Center=�