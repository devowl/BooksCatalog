   M S B A M L   `   `   `  ����  	Sms.Forms"    Sms.Forms.Views.BooksCatalog   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� Source�� 5	   
   $$ ..\Resources\SmsResources.xaml?�6   %    .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0,0,0,2q�6   
���   �._�5      � .+�5      �� $��Каталог книг��6   $
��Left=�60   5      5      �� 5   
   -   5         ��Name$ CatalogList��5   e   $��1��6z      WrappingPanel#��[  6�     BooksCatalogTemplate#��[ 6�   ��6   �� *BooksCatalog+ �� SelectedItem 68   �� *SelectedItemCatalog+  5       �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value��%�   '��       �� 5      " ��6    5      P� 5       �@J�IsKeyboardFocusWithin . . �5      �� 	 �@��
IsSelected
 . 6;   5      5      5      5       �� 5!   
   $��2��6     BooksListControlTemplate#��[ 6   5"      5#      