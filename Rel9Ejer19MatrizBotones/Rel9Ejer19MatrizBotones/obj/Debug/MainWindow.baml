   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5   	    Rel9Ejer19MatrizBotones(   "Rel9Ejer19MatrizBotones.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ]ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5   	     � Title$!  Crear Matriz(2D) de botones��5   	   $	��350��6-   $	��525��6:    � 	Resources 5         stlComboBox �� 
TargetType �� Property �� Value  stlLabel  	stlButton��%  &	        &	 �     &	 _    �� 5   
   " ��6$   .�5	      ��  � ��$ 50��6&   �� 5
       � ��$ 
0,10,10,10q�6'   �� 5       � ��$ Center=�62   5      �� 5   
   " ��6!   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 12(�6)   �� 5       � ��$ Arial)�6+   �� 5       � ��$ 
10,10,0,10q�6'   5      �� 5   
   " ��6"   .�5      ��  � ��$ 40��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 5q�6'   5      5      .��5      � -   5         �Name$ grdPrincipal��5      ���	#FFF0F0F0 � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5         ��Name$ btnCrear��5      $!��Crear matriz de botones de:��6'   $��10q�6M   $��25��6Y   6e   �� 5!      $��Filas:��6   #��[ 6%   �� 5"      -   5        	 ��Name$	 cmbFilas��5"      #��[  6)   �� 5#      $��	Columnas:��6   #��[ 6(   �� 5$      -   5        $	 cmbColumnas��5$      #��[  6,   5%      �� 5&   
   $��1��6   $
��Auto=�6$   $
��Auto=�6G   $��Center=�6l   .��5'      �� -   5        
 ��Name$
 
stpBotones��5'      $ 
Horizontal=�6-   5(      5)      5*      