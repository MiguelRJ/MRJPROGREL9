   M S B A M L   `   `   `  ����  Rel9Ejer7MatrizNumeros'    !Rel9Ejer7MatrizNumeros.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5         txtBlock �� 
TargetType �� Property �� Value 
 txtBox��%y  &	        &	 �     �� 5   
   " ��6!   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5	       � ��$ 
15,10,0,10q�6'   5
      �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 
0,10,15,10q�6'   �� 5       � ��$	 120��6&   5      5      .��5      � -   5         �Name$
 grid��5      
������� � RowDefinitions 5   
   �� 5      ��6   �� *ActualHeight+ �� ElementName$ 
stackPanel�� �� Mode$ OneWay=��� 5      �� 5      ��6   �� *ActualHeight+$ 	statusBar��$ OneWay=�.+�5   
   �� -   5        	 ��Name$	 
stackPanel��5      $��0��6)   $��50��66   
 �� Orientation$
 
Horizontal=�6B   $��Center=�6[   .+�5      �� #��[  6   $
��Wrap=�6:   $��Matriz Filas: ��6N   �� 5      -   5         ��Name$ txtBoxFilas��5      #��[ 6+    �� TextWrapping$
 Wrap=�6K   �� 5      #��[  6   $
��Wrap=�6:   $��Matriz Columnas: ��6N   �� 5      -   5        $ txtBoxColumnas��5      #��[ 6.   $
 Wrap=�6N   �� 5      -   5        $��btnAyuda��5      $��?��6%   $��Right=�61   $��Center=�6M   $��20��6h   $��10q�6s    � ToolTip$0 *Introduce los numeros separados por comas.��6    J� IsHitTestVisible . 6�   5      �� 5!   
   $��10q�6   $��1��6$   $
��Auto=�61   $
��Auto=�6c   .��5"      �� -   5        $��stpPanel��5"      $
 
Horizontal=�6)   $��Center=�6B   5$      5%      �� 5'   
   -   5         ��Name$ 	statusBar��5'      $��25��6(   $��2��65   .@�5(      �� $�Barra de estado��6   5)      �� 5*   
   -   5        $��2��5*      $��0,0,10,0q�6   $��Right=�60   $��Calcular��6L   6_   5/      50      