   M S B A M L   `   `   `  ����?  ;gitt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:gittgitt  5   	       gitt.Rusanovskaya   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.63.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aae aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:gitt     5   	     � Title$  Rusanovskaya��5   	   $	��450��6   $
��1400��6+    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��1.4* �6   6.   �� 5      $
��0.8* �6   6.   �� 5      $
��0.8* �6   6.   .+�5   
     ScottPlot.WpfPlot  -   5        $��WpfPlot1��5   "   $��0��6   6"   �� 5   
   $��1��6   .+�5      �� -   5         ��Name$ buttton_One��5   0   $��10q�6   $
��25px��6"   .��6_   (&Расчитать для первой6u   �� 5      -   5        $ buttton_Two��5   0   $��10q�6   $
��25px��6"   .��6_   .,Рассчитатать для второй6x   �� 5      $��10q�6   .��6"   86Информация для первой валюты:6A   �� 5      -   5         ��Name$ textBlock_one��5      $��10q�6/   $
��50px��6<   ���	#FFEEEEEE6c   �� 5      $��10q�6   .��6"   86Информация для второй валюты:6A   �� 5      -   5        $ textBlock_two��5      $��10q�6/   $
��50px��6<   ���	#FFEEEEEE6c   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid_Table��5      $��2��6+   5      5      5       