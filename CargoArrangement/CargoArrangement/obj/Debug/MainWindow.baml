   M S B A M L   `   `   `  ����K  GCargoArrangement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CargoArrangementCargoArrangement  5   	   ?$clr-namespace:CargoArrangement.ToolsCargoArrangement.Tools  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   !    CargoArrangement.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CargoArrangement     5   	   6tools$clr-namespace:CargoArrangement.Tools     5   	   c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5	   	   3System&clr-namespace:System;assembly=mscorlib  5   	   -   5        $��
mainWindow��5   H     � Title$  
MainWindow��6	   $	��600��6   $	��800��6)   
������� � 	Resources 5         btnStyle �� 
TargetType �� Property �� Value  dataFromSortCriteria S� 
MethodName S� 
ObjectType  System.Enum  DefaultDataTemplate  ColorDataTemplate#  Xceed.Wpf.Toolkit.ColorPicker   SelectedColor �� UpdateSourceTrigger  NumberDataTemplate(  "Xceed.Wpf.Toolkit.CalculatorUpDown�  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]	   Minimum
   Value  WidthDataTemplate  DepthDataTemplate  PackageDataTemplate �� SelectedIndex3   -CargoArrangement.PropertyDataTemplateSelector  templateSelector   DefaultnDataTemplate   ColorDataTemplate��%�  &	        &	 Q     &	 �     &	 �     &	      &	 �    &	 �    &	 [    &	     7  7  �� 5   
   " ��6!   .�5      ��  �@J�Opacity$	 1.0Q�6(   5      S� 5   
   $ SortCriteria��6:   "  6T   5      �� 5   
   .R�5      �� ��6   �� *Value+5      �� 5!   
   .R�5"         6   �� *Color+$ PropertyChanged=�5#      �� 5&   
   .R�5'        $	 1X�6d   
 6$   �� *
Quantity+$ PropertyChanged=�6d   5(      �� 5+   
   .R�5,        $	 1X�6a   
 6$   �� *Width+$ PropertyChanged=�6a   5-      �� 50   
   .R�51        $	 1X�6a   
 6$   �� *Depth+$ PropertyChanged=�6a   52      �� 55   
   .R�56      ��  6   �� *PackageType+$ PropertyChanged=�.@�57      �� $��В два слоя��6   �� 58      $��В один слой��6   59      5:        5=   
   8   8  5?   -   5A      .��5C      �  � RowDefinitions 5D   
   �� 5E      $��10 �6   �� 5F      $��51 �6   �� 5G      $��30 �6   �� 5H      $	��250 �6   �� 5I      $	��16* �6   �� 5J      $	��47* �6   �� 5K      $��31 �6   �� 5L      $	��16* �6   �� 5M      $��10 �6   �� 5N      $	��16* �6   �� 5O      $��10 �6   �� 5P      $	��16* �6   �� 5Q      $��10 �6    � ColumnDefinitions 5S   
   �� 5T      $��10 �6   �� 5U      $
��111* �6   �� 5V      $
��111* �6   �� 5W      $
��222* �6   �� 5X      $��10 �6   .+�5[   
   ]� $��2��6   $��1��6!   $��2��61   .+�5\      �� -   5         ��Name$ label��5\      $$��Добавить палету:��6#   $��1��6>   $��1��6N   $��Center=�6[   5]      �� 5`   
   -   5         ��Name$ canvasBorder��5`      $��3��6'   $��2��67   $��8��6D   $��5,10,0,0q�6U   
���   �$��1q�6{   }�. ._�5a      �� }�. .u�5b      '  !Xceed.Wpf.Toolkit.Zoombox.Zoombox  -   5          Name$ scrollViewer��5b         ViewStackIndex$ 0��65   |�. !   AutoWrapContentWithViewbox .    	ViewStack 5d      +  %Xceed.Wpf.Toolkit.Zoombox.ZoomboxView 5e      4  .Xceed.Wpf.Toolkit.Zoombox.ZoomboxViewConverterFit 60   .��5g      �� -   5         ��Name$ myStackPanel��5g   !    �� Orientation$ 
Horizontal=�67    5h      ��%Y   '��       �� 5i      " ��6$   .�5j   "   ��  � ��$ 	0 0 100 0q�6;   5k      5l      5r      5s      5t      5u      #	   CargoArrangement.Tools.GridEx	  5y   
   $��3��6   $��1��6$   $��2��64   $��0 0 10 0q�6H    5|       	 MarginStyle��%W   &		       �� 5}      " ��6,   .�5~      ��  � ��$ 0 5 0 0q�6/   5      5�      .+�5�      �� $��Номер заказа:��6   �� 5�      -   5         ��Name$ orderNumber��5�       �� TextWrapping$
 Wrap=�6+   �� 5�      $��Клиент:��6   $��0 5 0 0q�6&   �� 5�      -   5        $ 
clientName��5�      $
 Wrap=�6*   $��0 5 0 0q�6>   �� 5�      $��Наименование:��6   $��0 5 0 0q�6,   �� 5�      -   5        $ partName��5�      $
 Wrap=�6(   $��0 5 0 0q�6<   �� 5�      $��Глубина, мм:��6   $��0 5 0 0q�6+     5�      -	   5          Name$ height��5�   $   $	 0X�64   $
 1X�6@   ,
  &Xceed.Wpf.Toolkit.Primitives.InputBase 
  TextAlignment$
 Left=�6J   $��0 5 0 0q�6_   �� 5�      $��Ширина, мм:��6   $��0 5 0 0q�6*     5�      -
   5        $ width��5�   $   $	 0X�63   $
 1X�6?   $
 Left=�6I   $��0 5 0 0q�6^   �� 5�      $"��Количество, шт.:��6   $��0 5 0 0q�6/     5�      -   5        $ quantity��5�   $   $	 0X�66   $
 1X�6B   $
 Left=�6L   $��0 5 0 0q�6a   �� 5�      $ ��Выберите цвет:��6   $��0 5 0 0q�6-     5�      -   5          Name$ color��5�      $ SilverX�6.      UsingAlphaChannel . $��0 5 0 0q�6^   �� 5�      $��Упаковка:��6   $��0 5 0 0q�6(   �� 5�      -   5         ��Name$ package��5�      $��0 5 0 0q�6(   $ 0��69   .@�5�      �� $��В два слоя��6   �� 5�      $��В один слой��6   5�      5�      �� 5�   
   -   5         ��Name$ btnAdd��5�      #��[  6!   $��Добавить��6C   $��1��6V   $��0,0,10,0q�6f   $��4��6x   $��2��6�   &   System.Windows.Controls.DataGrid  5�   
   -   5           Name$  
dgvPallets��5�      $��1��6'   $��5��67   $��
0,10,10,10q�6D   !   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$! * 6X   #��[ 5�      "   AlternatingRowBackground
" �����# �� AlternationCount$# 2��5�   9   $��2��6N   ��5�   h   �� 5�      �� 5�   
   -   5        $ title��5�      $\��VЛогистика: схема размещения груза в автомобиле��6   $��1��6X   $��1��6h   $��3��6u   #��� ��6�   #��� ��6�   $��Center=�6  $��Center=�6C  $��17.333(�6e  �� 5�   
   -   5        $ btnAddShape��5�      $&�� Добавить на схему��6&   $��1��6B   $��11��6R   $��0,0,10,0q�6`   $��2��6�   �� 5�   
   -   5        $ 	btnRemove��5�      $��Убрать��6$   $��1��65   $��9��6E   $��0,0,5,0q�6R   6c   �� 5�   
   -   5        $ btnClearCanvas��5�      $!��Очистить канву��6)   $��2��6B   $��9��6R   $��5,0,10,0q�6_   �� 5�   
   -   5        $ btnSaveReport��5�      $)��#Сформировать отчет��6C   $��3��6`   $��11��6p   $��5 0 0 0q�6~   �� 5�   
   $��2��6   $��2��6'   $��10��64   $��5��6F   $��1q�6P   $��0,10,0,0q�6d   ��5�      �� 5�      $ �� Color#$ � ��6"   5�      �� 5�   
   -   5        $ btnCalculate��5�      $��Вычислить��6'   $��1��6;   $��0,0,10,0q�6K   $��7��6]   $��2��6�   �� 5�   
   -   5        $ cbSortCriteria��5�      $��1��6+   $��	0,0,10,10q�6;   $��6��6N   $��2��6[   $ 0��6o   .@�5�      �� $!��Без сортировки��6   �� 5�      $2��,По максимальной стороне��6   �� 5�      $$��По площади груза��6   �� 5�      $��Сортировка Max��6   �� 5�      $��Сортировка Min��6   �� 5�      $"��По длинне груза��6   �� 5�      $"��По ширине груза��6   5�      5�      5�      