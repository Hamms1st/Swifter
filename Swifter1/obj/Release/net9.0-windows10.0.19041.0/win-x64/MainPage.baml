   M S B A M L   `   `   `  ���� C  ?Swifter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Swifter1Swifter1      Swifter1.MainPage   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:Swifter1       N� Title$  MainPage��.���� ���#CCCCCC �� CornerRadius$ 10�����#CCCCCC._�� $��5q�$	��478�� � RowDefinitions �� $��50 ��� .+��� $��0��$��1q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��   
BlurRadius$ 8Q�   ShadowDepth$ 2Q�   	Direction$	 270Q�   Opacity$	 0.4Q�._�� 	 � ColumnDefinitions	 �� $	��145 ��� $	��420 ��� .+��� $��5q�$
��Left=�$��Bottom=�$��0��$;��5pack://application:,,,/Swifter1;component/Fonts/#Jost)����#121D55$��Light"�$��	Shortcuts��$��34(��� $y�Hidden=�$
��Left=�$��Center=�$��1��$ 10��$��0q�
�������$��25��$	��200��._�� 	 �� $��* ��� $��28 �.+��� $��23��$��Right=�$��1��$��2,0,4,1q����� 
 �� 
TargetType"
 ��.R��� $��ButtonBorder��$ 8�����#FFFFFF._��� $��/images/search.png��$��2q� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  �� Property �@�Cursor �� Value$
 Hand���� $;��5pack://application:,,,/Swifter1;component/Fonts/#Jost)����#121D55$��0��
������ $��0q�$��13(�$��4q�$��Center=�� $��1��	 �� $	��250 ��� .+��� $��Hidden=�$��1��$��0q�$��0,5,0,5q�$��Center=�.���� $��Center=�.+��� -    ��Name$ empico��$y�Hidden=�$��/images/empty.png��$	��280��$
��Auto���� -    ��Name$ NoShortcutsText��$.��(You haven’t created any shortcuts yet.��$��27(�$��SemiBold"�
�������$��Center=�$;��5pack://application:,,,/Swifter1;component/Fonts/#Jost)�$��10q�$y�Hidden=�� -    �Name$ ShortcutsContainer��$��Center=�� $��0�� �� �� .+��� -   $��0��$��80��$��25q����� "
 ��.R��� $��ButtonBorder��$ 14�����#5F6790._�� .+��� $��28q�$��Create��$
��Left=�$��Center=�$��30(�$;��5pack://application:,,,/Swifter1;component/Fonts/#Jost)����#ffffff$��Light"��� $��/images/Edit.png��$��Right=�$��15q� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand����  �� 
TargetName$ ButtonBorder�� � ��$ 1q��� $ ButtonBorder�� � ��
 ������� $��1��$��80��$��25q����� "
 ��.R��� $��ButtonBorder��$ 14�����#5F6790._�� .+��� $��28q�$��Import��$
��Left=�$��Center=�$��30(�$;��5pack://application:,,,/Swifter1;component/Fonts/#Jost)����#ffffff$��Light"��� $��/images/import.png��$��Right=�$��55��$��3,5,5,15q�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$
 Hand���� $ ButtonBorder�� � ��$ 1q��� $ ButtonBorder�� � ��
 �����