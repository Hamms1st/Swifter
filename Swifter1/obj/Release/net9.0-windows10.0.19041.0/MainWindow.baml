   M S B A M L   `   `   `  ���� C  ?Swifter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Swifter1Swifter1      Swifter1.MainWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Swifter1       � WindowStyle$
  None=� � 
ResizeMode$ 	CanResize=� � AllowsTransparency$
 True��
������  � WindowStartupLocation$ CenterScreen=� � Title$ 
MainWindow��$	��550��$	��880��.���� ���#CCCCCC �� CornerRadius$ 10�����#CCCCCC._��  � RowDefinitions �� -   $
��20px ��� $	��478 ��� $
��50px �.+�� $��Right=�$��0�� � ColumnDefinitions �� $
��25px ��� $
��25px �.+��� -    ��Name$ cross��$��1��$��x��$��15(����#121D55$��SemiBold"�$-��'/Fonts/Montserrat-VariableFont_wght.ttf)����� 	 �� 
TargetType"	 ��.R��� $��ButtonBorder��$ 2��._��� $��Center=�$��Center=�
 �� Triggers
 P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  �� Property �@�Cursor �� Value$
 Hand��P�  � ��$
 True��. ���  �� 
TargetName$ ButtonBorder�� � ��
 ������� -   $	 min��$��0��$��-��$��18(����#121D55$-��'/Fonts/Montserrat-VariableFont_wght.ttf)�$��SemiBold"����� "	 ��.R��� $��ButtonBorder��$ 2�����#cccccc._��� $��Center=�$��Center=�
 P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand��P�  � ��$
 True��. ��� $ ButtonBorder�� � ��
 ������ -    �Name$ MyContainer��$��1��.+� � -     �Name$ 
MainFrame1��  � NavigationUIVisibility$ Hidden=� � -   $ Main2��$ Hidden=��� -    ��Name$ Below��$��Bottom=�$��2��$y�Hidden=�$	��250�����#5F6790$ 8��$	��3pxq�$��1q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��   
BlurRadius$ 8Q�   ShadowDepth$ 2Q�   	Direction$ 90Q�   Opacity$	 0.4Q�._�� $��Bottom=�$��2�� �� $��* ��� $��* ��� $��* �.+��� -   $��0������ "	 ��.R��� $��ButtonBorder��$ 8��._��� $��/images/Short.png��$��3q�
 P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#72799E�� -	   $��1������ "	 ��.R��� $��ButtonBorder��$ 8��._��� $��/images/Auto.png��$��3q�
 P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#72799E�� $��2������ "	 ��.R��� $��ButtonBorder��$ 8��._��� $��/images/Wifi.png��$��3q�
 P�  � ��$
 True��. ��� $ ButtonBorder�� � �� �#72799E