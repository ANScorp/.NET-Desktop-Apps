   M S B A M L   `   `   `  ����F  BFileChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FileCheckerFileChecker  5   	       FileChecker.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FileChecker     5   	     � Title$  FileChecker��5   	   $	��350��6   $	��525��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��242* �6   �� 5      $
��255* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $	��29* �6   �� 5      $��30 �6   �� 5      $	��77* �6   �� 5      $	��29* �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ 
rtbMissing��5      $��3��6*   $��2��67   $ �� HorizontalScrollBarVisibility$
 Auto=�6G   " �� VerticalScrollBarVisibility$
 Auto=�6l   5      �� 5   
   -   5        $ rtbCodes��5      $��1��6(   $��3��68   $
 Auto=�6E   $
 Auto=�6j   5      �� 5   
   -   5         ��Name$ btnFolderToCheck��5      $9��3Выбор каталока для проверки��6+   $��1��6Q   $��1��6a   $��2��6n   �� 5   
   -   5         ��Name$ label��5      $'��!Коды для проверки:��6   $��1��6<   $
��Left=�6L   $��2��6g   $	��Top=�6t   �� 5    
   -   5        $ label1��5       $��Отсутствуют:��6    $��2��67   $
��Left=�6G   $��2��6b   $	��Top=�6o   �� 5!   
   -   5        $ btnStart��5!      $��Проверить��6#   $��1��67   $��4��6G   $��2��6T   5"      5#      