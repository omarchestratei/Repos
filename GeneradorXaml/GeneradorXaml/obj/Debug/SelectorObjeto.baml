   M S B A M L   `   `   `  ����H  DGeneradorXaml, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GeneradorXamlGeneradorXaml  5   	   "    GeneradorXaml.SelectorObjeto   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GeneradorXaml     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Selector de objeto��5	   	   $	��300��6$   $	��500��61   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��60 �6   �� 5      $
��100* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $
��100* �6   .+�5   
   �� $��0��6   $��0��6    $��5q�6-   $��Buscar:��68   $��Right=�6J   $��Center=�6m   �� 5   
   -   5         ��Name$ 	txtBuscar��5      $��1��6b   $��0��6r   $��5q�6   $��Center=�6�   ��6%   �� *Filtro+ �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGrid��5      $��0��6%   $��1��65   $��2��6B   $��5q�6V      CanUserAddRows .     CanUserDeleteRows .  	   AutoGenerateColumns	 .  
   
IsReadOnly
 .    SelectionMode$ Single=�5      ��5      �� *Lineas+$ PropertyChanged=�   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Objeto��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
FullName+6R   5#      5$      5%      