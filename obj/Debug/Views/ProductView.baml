   M S B A M L   `   `   `  ����C  ?ShirtBiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ShirtBizShirtBiz  5   	       ShirtBiz.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ShirtBiz     5   	   -   5          � Title$  Order Information��5   
   $��433.5��6$   $��634.5��63    � 	Resources 5	         categoryViewSource��%   &	        �� 5
   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ categoryDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��13,13,43,191q�5   -      RowDetailsVisibilityMode$ VisibleWhenSelected=�5      ��5      ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        categoryIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Customer Id��5   %   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 6:   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5   ?   �� *
CategoryId+5   :     5      -   5        
nameColumn��$ Order��5   %   $	 SizeToHeader 64   
 5   9   �� *Name+5   4   5        5   
   -   5        $ productDataGrid��5       .   . $��13,200,43,0q�5   -   $ VisibleWhenSelected=�5      ��5      ��  5        5      -   5        categoryIdColumnP��$ Order Id��5   %   $	 SizeToHeader 67   
 5   @   �� *
CategoryId+5   7     5      -   5        nameColumnP��$
 Name��5   %   $	 SizeToHeader 63   
 5   :   �� *Name+5   3     5       -   5        productIdColumnP��$ Product Serial No.��5!   %   $	 SizeToHeader 6A   
 5    ?   �� *
CategoryId+5!   A   5#      �� 5$   
   -	   5        $
��Save��5$      $��13,350,43,0q�6    $	��100��65   $��20��6A   6M   5%      5&      