   M S B A M L   `   `   `  ����G  CJuegdhuis V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Juegdhuis_V3Juegdhuis_V3  5   	       Juegdhuis_V3.StockWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Juegdhuis_V3     5   	   -   5          � Title$  StockWindow��5   	   $
��1024��6    � WindowState$ 	Maximized=�5	   	   $
��1280��6!   .��5
      � .+�5   
   �� -   5         ��Name$ LBoxDrankOverzicht��5      $��10,76,934,10q�6/   $	��320��6E   $
��Auto=�6Q   $��Disabled=�6�    �� SelectionMode$ Single=�6�    �� View 5      �� 5      .P�5      �� $
��naam��6%    �� Width$	 180��63    �� DisplayMemberBinding 6?   �� *naam+�� 5      $��aantal��6%   $ 40��65    6@   �� *	hoeveel+�� 5      $��prijs��6%   $ 40��64    6?   �� *sPrijs+�� 5      $��	voldoende��6%   $ 60��68    6C   �� *	voldoende+5      5      �� 5   
   -   5         ��Name$ label1��5      $��	Van/Naar:��6    $
��Left=�64   $��
457,76,0,0q�6O   $	��Top=�6c   �� 5   
   -   5         ��Name$ 
TxtVanNaar��5      $
��Left=�6&   $��23��6A   $��457,107,0,0q�6M   	 �� TextWrapping$
	 Wrap=�6b   $	��Top=�6v   $��51��6�   �� 5   
   -   5        
 ��Name$
 BtnEditPrijs��5      $��pas aan��6'   $
��Left=�69   $��532,110,0,0q�6T   $	��Top=�6i   $��47��6�   6�   �� 5   
   -   5        $ LblNaamDrank��5      $
��Left=�6&   $��387,106,0,0q�6A   $	��Top=�6V   �� 5   
   -   5        $ label1_Copy��5      $
��Add:��6%   $
��Left=�64   $��457,156,0,0q�6O   $	��Top=�6d   �� 5   
   -   5        $ 	TxtAddAll��5      $
��Left=�6%   $��23��6@   $��457,185,0,0q�6L   $
	 Wrap=�6a   $	��Top=�6u   $��51��6�   �� 5   
   -	   5         ��Name$ ChBAdd��5      $
��Left=�6#   $��23��6>   $��532,185,0,0q�6J   $	��Top=�6_   $��22��6w   �� 5   
   -
   5        $ 
LblInfoAdd��5      $
��Left=�6$   $��559,185,0,0q�6?   $	��Top=�6T   $��64��6l   $	��626��6x   6�   5      5      