   M S B A M L   `   `   `  ����D  @Sms.Forms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Sms.Forms.ConvertersSms.Forms.Converters  5      5clr-namespace:Sms.Forms.HelpersSms.Forms.Helpers  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0894    .Sms.Forms.Converters.ByteArrayToImageConverter   ByteArrayToImageConverter  	TextStyle  �� 
TargetType �� Property �� Value  TextStyleDesctiption �� BasedOn  WrappingPanel K� IsItemsHost  BooksCatalogTemplate 	�Name 	� 	GroupName �� 
TargetType ��Name	 �� Padding
 �� Path �� Mode �� Triggers P� Property P� Value �� 
TargetName  BookInfoExtended �Name � RowDefinitions � ColumnDefinitions �� 	Converter)   #Sms.Forms.Helpers.NavigationService   Text  BookInfo � Cursor  ShowList �� Padding  ShowShortList 	 orderByName �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName   	Direction 
 BooksListControlTemplate �� Orientation d� 	IsChecked ��Name �� Source P� 
SourceName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      1
converters"clr-namespace:Sms.Forms.Converters  5      +helpersclr-namespace:Sms.Forms.Helpers  5      DsortCol8clr-namespace:System.ComponentModel;assembly=WindowsBase  5      %w  &	        &	      &	 �     7  &	     &	 t    &	 �    7   7  7  7  7  &	     7   7  7  7  &	 �    &	 �    &		 1    &	
 �    7  7  7  7 	 7  7     5      6+   �� 5	      "  ��6   .�5
   
   ��  � ��$ 3q�6#   �� 5   
    � ��$ WrapWithOverflow=�6)   5      �� 5      "  ��6)   8   .�5   
   ��  � ��$ 3,3,50,3q�6#   �� 5   
    � ��$ WrapWithOverflow=�6)   5      �� 5      .R�5   
   � #��z��6   #��z��65   $��LeftToRight=�6W    . 6s   5      �� 5      .R�5   
   	� $ SelectableCatalog��6/   $ BooksCatalog��6   ��5      �� 5      " 	�6"   .R�5      �� $ 	tbTabName��6;   $	 10q�6    $��16(�6-   �� 5      �6   �� $
 CatalogName�$ OneWay=� (�� 6R   �6V   �� $
 Books.Count�$ OneTime=�)5       5       P� 5!       �@d�	IsChecked$
 TrueY�67   . �5"      �� $ 	tbTabName��6%    � ��
 ����6R   5#      P� 5$       �@d�	IsChecked$ FalseY�67   . �5%      �� $ 	tbTabName��6%    � ��
 �����6R   5&      5(      5*      5+      �� 5.      .R�5/   
   	� $ rbBooksExtended��6K   $��5q�6   $ BooksExtended��6"   $	��500��6<   ��50      �� 51      " 	�6"   .R�52      � $ rootGrid��6   #��z��6-    53      �� 54      �� 55      $
��Auto �6,   �� 56       58      �� 59      $
��Auto �6/   �� 5:      �� 5;      .+�5=      � $��3��6   $��3q�60   .+�5>      �� $��25��6$   $��45��6/   ��6;   �� *	BookImage+8   5?      �� 5@      8�� $��1��6^   ��6G   �� *Title+6^   �� 5A      8�� $��2��6_   ��6G   �� *Author+6_   �� 5B      8�� $��1��6o   $��1��6|   $��2��6�   ��6R   �� *Description+6�   �� 5C      8�� $��2��6�   $��2��6�   $��1��6�   $
��Left=�6�   ��6G   �� *Url+ 6\   �� *Url+6�   5D       5E      P� 5F       �@d�	IsChecked$
 TrueY�67   . �5G      �� $ rootGrid��6%    � ��
 ����6Q   5H      P� 5I       �@d�	IsChecked$ FalseY�67   . �5J      �� $ rootGrid��6%    � ��
 �����6Q   5K      5M      5O      5P      �� 5S      .R�5T   
   	� $��5q�6   $ Books��6"   ��5U      �� 5V      " 	�6"   .R�5W      � $ rootGrid��6    5X      �� 5Y      $
��Auto �6,   �� 5Z      $
��Auto �6,   �� 5[      $
��Auto �6,    5]      �� 5^      $
��Auto �6/   �� 5_      .+�5a      � $��2��6   $��3q�60   $	��Top=�6;   .+�5b      �� $��25��6$   $��45��6/   ��6;   �� *	BookImage+8   5c      �� 5d      8�� $��1��6^   ��6G   �� *Title+6^   �� 5e      8�� $��2��6_   $��1��6o   ��6G   �� *Author+6o   �� 5f      8�� $��Скачать��6G   $
 Hand��6V   
����  �$��	Underline{�6v   $��3��6�   $��Center=�6�   5g       5h      P� 5i       �@d�	IsChecked$
 TrueY�67   . �5j      �� $ rootGrid��6%    � ��
 ����6Q   5k      P� 5l       �@d�	IsChecked$ FalseY�67   . �5m      �� $ rootGrid��6%    � ��
 �����6Q   5n      5p      5r      5s      �� 5v      " 	�6'   .R�5w   
   �� $��1q�6   
���   �$��5q�69   $ 5q�6D   #��z��6P   ._�5x      �� $��Список��6   5y      5z      �� 5}      " 	�6,   .R�5~   
   �� $��1q�6   
���   �$��5q�69   $ 5q�6D   #��z��6P   ._�5      �� $��Витрина��6   5�      5�      �� 5�       6/   �� *SelectedItemCatalog.Books+ 5�   
     5�      $ Title��6&   $ 	Ascending=�6;   5�      �� 5�      .R�5�   
   �  5�      �� 5�      $
��Auto �6    �� 5�      .+�5�      �� $��Right=�6   $ 
Horizontal=�65   .+�5�      �� $ ��представление��6   $��0,0,25,0q�61   $��Center=�6C   	� 5�      $ asList��6   $
 TrueY�6.   $ ViewMode��6?   8��  
���   �6y   	� 5�      $ asShortList��6   $ ViewMode��63   8�� 6H   5�      �� 5�      $��1��6   .��5�      �� $ ListPresenter��6   8�� ��6a   �� 8  5�      5�       5�   
   P� 5�      $ asList��6    �@d�	IsChecked$
 TrueY�6?   . �5�      �� $ ListPresenter��6   8   � ��6L   �� 5�      $ asList��6    � ��
 �����6C   �� 5�      $ asShortList��6    � ��
 �����6H   5�      P� 5�      $ asShortList��6    �@d�	IsChecked$
 TrueY�6D   . �5�      �� $ ListPresenter��6   8   � ��6L   �� 5�      $ asShortList��6    � ��
 �����6H   �� 5�      $ asList��6    � ��
 �����6C   5�      5�      5�      