   M S B A M L   `   `   `  ����?  ;Lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab5Lab5  5   	       Lab5.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab5     5   	     � Title$
  Lab5��5   	   $	��450��6   $	��800��6#   .��5	      �� .@�5
   
   �� $��Products��6   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5         AutoGenerateColumns$ False��6*      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Article ��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *	Article+  5      $ 	UnitCode ��6)    6<   �� *
UnitCode+  5      $ 	Quantity ��6)    6<   �� *
Quantity+  5      $ Price ��6)    69   �� *Price+5      5      �� 5   
   $��Units Of Measurement ��6   .��5        -   5        $ 	dataGrid2��5      $ False��6*    5        5      $ 
Unit Code ��6)    6=   �� *
UnitCode+  5      $ 
Unit Name ��6)    6=   �� *
UnitName+5      5      �� 5   
   $��Product Info��6   .��5        -   5        $ dataGridProductsInfo��5      $ False��69    5        5       $ Product Info ��6-    6D   �� *ProductInfo+5"      5$      �� 5&   
   $��
Price More��6   .��5'      �� .+�5(      ��  �� Orientation$ 
Horizontal=�6   .+�5)      �� $��0 0 20 0q�6   .��6.   Введіть ціну6=   �� 5*      -   5        $��priceMoreTextBox��5*   <   $��0 0 20 0q�6   $	��100��60   6V   �� 5+      -   5        $	��100��5+      .��6A   OK6E   5,        5-      -   5        $ dataGridPriceMore��5-      $ False��66    5.        5/      $ Article ��6-    6?   �� *	Article+  50      $ 	UnitCode ��6-    6@   �� *
UnitCode+  51      $ 	Quantity ��6-    6@   �� *
Quantity+  52      $ Price ��6-    6=   �� *Price+54      55      58      �� 5:   
   $��Product Info��6   .��5<        -   5        $ dataGridMinMax��5<      5=      5?      5@      5B      