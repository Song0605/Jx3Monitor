   M S B A M L   `   `   `  ����N  JJx3BaiZhanCDMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jx3BaiZhanCDMonitorJx3BaiZhanCDMonitor  5   	   $    Jx3BaiZhanCDMonitor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Jx3BaiZhanCDMonitor     5   	     � Title$  百战CD监控��5   	   $	��450��6   $	��350��6%   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid     CanUserAddRows .     CanUserDeleteRows .     CanUserSortColumns .     CanUserReorderColumns .  ��5      �� *CharacterList+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly . 	   MinWidth$	 50Q�67   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 6E      Header$ 名称��5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 6!   �� *Name+  5       . $	 50Q�67   $

 auto 6E   $ 心法��5       6!   �� *
Profession+  5       . $	 50Q�67   $

 auto 6E   $ 	精力值��5       6"   �� *Energy+  5       . $	 50Q�67   $

 auto 6E   $ 	耐力值��5       6"   �� *Power+  5       . $	 50Q�67   $

 auto 6E   $ 装分��5       6!   �� *Mark+4  .System.Windows.Controls.DataGridCheckBoxColumn  5       . $	 80Q�6;   $

 auto 6I   $ 本周进度��5       6#   �� *TotalWeekProgress+$ TwoWay=�$ PropertyChanged=�5      5       5!      