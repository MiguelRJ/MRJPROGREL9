   M S B A M L   `   `   `  ����  Rel9Ejer11Frases    Rel9Ejer11Frases.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Configuracion��5   	   $	��400��6   $	��600��6,   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��53* �6   �� 5      $	��95* �6    � RowDefinitions 5
   
   �� 5      $
��226* �6   �� 5      $	��40* �6   .+�5   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Tamaño de letras:��6V   $	��Top=�6o   $��16��6�   $��94��6�   �� 5   
   -   5        $��	txtTamano��5      $
��Left=�6#   $��23��6>   $��	109,9,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $��93��6�   �� 5   
   $
��Left=�6   $��	10,42,0,0q�6/   $
��Wrap=�6B   $��Tipo de letra��6V   $	��Top=�6k   $��16��6�   $��67��6�   �� 5   
   -   5        $��	listFonts��5   
   $��10,63,10,20q�5         System.Windows.Media.Fonts   SystemFontFamilies#��Z 5   
   $��13(�5   
   ��5      �� 5      .R�5      �� ��6    �� ��61   �� 5      5      � 5   
   $��0��6   $��1��6    5      �� 5      $	��50* �6    �� 5      $
��132* �6    .+�5!      �� -   5         ��Name$ panel��5!      $��5q�6(   
���   �63   � 5#      $��1��6    � ToolTip 6    �� *Value+ �� ElementName$ sldAzul�� 5$      �� 5%      $	��50* �6'   �� 5&      $	��450 �6'    5(      �� 5)      �� 5*      �� 5+      .+�5-      �� $
��Rojo��6   
���  ��$��Right=�68   $��0,30,402,34q�6T   $��0��6i   $��Center=�6v   $��Arial Black)�6�   $
��Bold"�6�   $��24��6�   $��39��6�   $��2��6�   �� 5.      -   5         ��Name$ sldRojo��5.      $��0��6+   $��20q�68   $��Center=�6D   $	��300��6_   $��1��6k   $��20��6{   	 � Minimum$	 0Q�6�   
 � Maximum$	
 255Q�6�    � SmallChange$ 1Q�6�    �� IsSnapToTickEnabled .  6�   �� *Value+$ sldRojo���� 5/      $��Verde��6   
��� � �$��Right=�6;   $��0,34,392,30q�6W   $��1��6l   $��Center=�6y   $��Arial Black)�6�   $
��Bold"�6�   $��24��6�   $��48��6�   $��2��6�   �� 50      -   5        $ sldVerde��50      $��1��6,   $��20q�69   $��Center=�6E   $	��300��6`   $��1��6l   $��20��6|   $	 0Q�6�   $	
 255Q�6�   $ 1Q�6�    .  6�   �� *Value+$ sldVerde���� 51      $
��Azul��6   
����  �$��Right=�69   $��0,30,402,34q�6U   $��2��6j   $��Center=�6w   $��Arial Black)�6�   $
��Bold"�6�   $��24��6�   $��38��6�   $��2��6�   �� 52      -   5        $ sldAzul��52      $��2��6*   $��20q�67   $��Center=�6C   $	��300��6^   $��1��6j   $��20��6z   $	 0Q�6�   $	
 255Q�6�   $ 1Q�6�    .  6�   �� *Value+$ sldAzul��53      54      �� 57   
   -   5        $��
btnAceptar��57      $��Aceptar��6#   $��Right=�65   $��	0,0,10,10q�6Q   $��Bottom=�6d   $��75��6   $��1��6�   $��20��6�   $��1��6�   �� 58   
   -   5        $��btnCancelar��58      $��Cancelar��6$   $
��Left=�67   $��	10,0,0,10q�6R   $��Bottom=�6f   $��75��6�   $��20��6�   $��1��6�   5:      5;      