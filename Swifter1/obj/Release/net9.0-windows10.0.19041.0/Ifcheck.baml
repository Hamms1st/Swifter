   M S B A M L   `   `   `  ���� C  ?Swifter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Swifter1Swifter1      Swifter1.Ifcheck   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:Swifter1       N� Title$  Ifcheck��.���� 
������� �� CornerRadius$ 10�����#CCCCCC._���  �� Orientation$ Vertical=�$��Center=�.+��� $��If the Condition is True��$��10q�$��25(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����#121D55$��Light"��� $	��365��$��Hidden=�$��Disabled=� �� PanningMode$ VerticalOnly=�$
��True��$��0,5,0,5q�$��0q�.���� $ Vertical=�$��Center=�.+��� $��10q�$	��200��$ Vertical=�.+��� $��If WiFi is On/Off ?��$��1q�$��20(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����#121D55$��Light"��� $ 
Horizontal=�.+��� -    ��Name$
 Ifon��$��On�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)�����  �� 
TargetType" ��.R���  ��Name$ ButtonBorder��$��90��$��5q�$��30�����#121D55$ 15�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��	   
BlurRadius$	 8Q�
   ShadowDepth$
 2Q�   	Direction$	 270Q�   Opacity$	 0.4Q�._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  �� Property �@�Cursor �� Value$
 Hand����  �� 
TargetName$ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -   $
 Ifof��$��On�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��5q�$��30�����#121D55$ 15��   $ Black��$	 8Q�$
 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� $��10q�$	��200��$ Vertical=�.+��� $��If Bluetooth is On/Off ?��$��1q�$��20(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����#121D55$��Light"��� $ 
Horizontal=�.+��� -   $ IfBlon��$��On�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��5q�$��30�����#121D55$ 15��   $ Black��$	 8Q�$
 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -   $ Ifblof��$	��Off�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��5q�$��30�����#121D55$ 15��   $ Black��$	 8Q�$
 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� $	��200��$��10q�$ Vertical=�.+��� $��If Battery is  ?��$��1q�$��20(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����#121D55$��Light"��� $ 
Horizontal=�.+��� -   $ IfChon��$��Check�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��5q�$��30�����#121D55$ 15��   $ Black��$	 8Q�$
 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� $��10q�$��Center=�$��1��$ 10��$��2q����#8A8A8A���#7c7c7c$��35��$��90��._��� -    ��Name$ 	checkstat��$;��5pack://application:,,,/Swifter1;component/Fonts/#Jost)����#121D55$��0��
������ $��0q�$��13(�$��4q�$��50�� �� TextAlignment$ Center=�$��Center=��� $	��200��$��10q�$ Vertical=�.+��� $��If Dark Mode is On/Off ?��$��1q�$��20(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����#121D55$��Light"��� $ 
Horizontal=�.+��� -   $ IfNgon��$��On�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��5q�$��30�����#121D55$ 15��   $ Black��$	 8Q�$
 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -   $ IfNgof��$	��Off�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��5q�$��30�����#121D55$ 15��   $ Black��$	 8Q�$
 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� $	��200��$��10q�$ Vertical=�.+��� $"��If Airplane Mode is On/Off ?��$��1q�$��20(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����#121D55$��Light"��� $ 
Horizontal=�.+��� -	   $ IfAron��$��On�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��5q�$��30�����#121D55$ 15��   $ Black��$	 8Q�$
 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98�� -
   $ IfArof��$��On�����#FFFFFF$��
ExtraLight"�$��17(�$U��Opack://application:,,,/Swifter1;component/Fonts/Jost-VariableFont_wght.ttf#Jost)����� " ��.R��� $ ButtonBorder��$��90��$��5q�$��30�����#121D55$ 15��   $ Black��$	 8Q�$
 2Q�$	 270Q�$	 0.4Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � �� �#545C86P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#5D6B98