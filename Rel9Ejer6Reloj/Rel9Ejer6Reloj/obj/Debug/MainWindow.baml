   M S B A M L   `   `   `  ����I  ERel9Ejer6Reloj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Rel9Ejer6RelojRel9Ejer6Reloj  5   	       Rel9Ejer6Reloj.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .localclr-namespace:Rel9Ejer6Reloj     5   	   -   5          �Name$  window��5   4    � Title$ 
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5         txtBlockTime �� 
TargetType �� Property �� Value  botones  ObjetoCentrado��%�  &	        &	 �     &	 S    �� 5   
   " ��6%   .�5      ��  � ��
 �����6+   �� 5	       � ��$ 40(�6)   �� 5
       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 5,0,5,0q�6'   5      �� 5   
   " ��6    .�5      ��  � ��$ 75��6&   �� 5       � ��$ 10q�6'   5      �� 5   
   .�5      ��  � ��$ Center=�6<   �� 5       � ��$ Center=�6:   5      5       � DataContext 5         Rel9Ejer6Reloj.Reloj  5   
   .��5      � -   5         �Name$
 grid��5      
������� � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      �� 5      $��25 �6   .+�5    
   A� $��0��6   #��[ 6    
���   �$��50��6U   $	��350��6a   �� 5!   
   $��0��6   #��[ 6"   .+�5"      �� #��[ 6   	 �� Orientation$	 
Horizontal=�6A   .+�5#      �� #��[  6K   ��6   �� *FechaActualHoras+
 �� Mode$
 OneWay=�6K   �� 5$      $��:��6   #��[  6%   �� 5%      #��[  6M   ��6   �� *FechaActualMinutos+$
 OneWay=�6M   �� 5&      $��:��6   #��[  6%   �� 5'      #��[  6N   ��6   �� *FechaActualSegundos+$
 OneWay=�6N   5(      5)      �� 5*   
   #��[ 6   $��1��6=   $	 
Horizontal=�6J   .+�5+      �� $��Activar��6   #��[ 6'   {�6H   �� *FalseIfRelojActivado+$
 OneWay=���6�   �� *ActivarReloj+$
 OneWay=��� 5,      $��Detener��6   #��[ 6'   {�6H   �� *FalseIfRelojDetenido+$
 OneWay=���6�   �� *DetenerReloj+$
 OneWay=�5-      � 5.   
   $��2��6    � ColumnDefinitions 5/      �� 50      �� 51      $��75 �6#   .+�53      �� -   5         ��Name$ 	statusBar��53      $��0��6/   .@�54      �� �6   �� *
FechaLarga+$
 OneWay=� � ToolTip 6G   �� *	Cultura+$
 OneWay=�55      �� 56      $��1��6   ��6)   �� *
Background+ �� ElementName$ 	statusBar��.+�57      �� $��Salir��6   $��3q�6)   ��64   �� *Salir+$
 OneWay=�58      59      5>      5?      