   M S B A M L   `   `   `  ����G  CJuegdhuis V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Juegdhuis_V3Juegdhuis_V3  5   	       Juegdhuis_V3.AdminWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Juegdhuis_V3     5   	   -   5          � Title$  AdminWindow��5   	    � WindowState$ 	Maximized=�5	   	   .��5
      � $��6,0,-6,0q�6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      .+�5   
   �� -   5         ��Name$ ListBoxMaandOverzicht��5      $
��Left=�62   $��
10,94,0,35q�6M   $	��280��6a   $��Disabled=�6m    �� View 5      �� 5      .P�5      �� $��datum��6%    �� Width$ 75��64    �� DisplayMemberBinding 6?   �� *dag+�� 5      $��begin bedrag��6%   $ 75��6;    6F   �� *	begingeld+�� 5      $��eind bedrag��6%   $ 75��6:    6E   �� *
eindgeld+�� 5      $��winst��6%   $ 50��64    6?   �� *winst+5      5      �� 5   
   -   5         ��Name$ 	CboxMonth��5      $
��Left=�6&   $��	10,52,0,0q�6A   $	��Top=�6T   $	��136��6l   6x   �� 5   
   -   5        $ CboxYear��5      $
��Left=�6%   $��
162,52,0,0q�6@   $	��Top=�6T   $	��128��6l   6x   �� 5   
   -   5         ��Name$ BtnStort��5      $��Stort��6#   $
��Left=�63   $��
215,0,0,10q�6N   $��75��6b   $��20��6�   $��Bottom=�6�   �� 5   
   -   5        	 ��Name$	 label��5      $��Nieuwe Leden Toevoegen:��6   $��1��6A   $
��Left=�6Q   $��	20,48,0,0q�6l   $	��Top=�6   $	��200��6�   �� 5   
   -   5        $	 label1��5      $B��<Naam:               Passwoord:          Stock:        Admin:��6    $��1��6g   $
��Left=�6w   $��	20,74,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        
 ��Name$
 TxtNaam��5      $��1��6#   $
��Left=�63   $��23��6N   $��
20,100,0,0q�6Z    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $��81��6�   �� 5   
   -	   5        $
 TxtPass��5      $��1��6#   $
��Left=�63   $��23��6N   $��106,100,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $��70��6�   �� 5    
   -
   5         ��Name$ CbStock��5       $��CheckBox��6$   $��1��67   $
��Left=�6G   $��209,105,0,0q�6b   $	��Top=�6w   $��15��6�   �� 5!   
   -   5        $ CbAdmin��5!      $��CheckBox��6$   $��1��67   $
��Left=�6G   $��265,105,0,0q�6b   $	��Top=�6w   $��15��6�   �� 5"   
   -   5        $ BtnAdd��5"      $��	Toevoegen��6!   $��1��65   $
��Left=�6E   $��319,100,0,0q�6`   $	��Top=�6u   $��75��6�   $��23��6�   6�   �� 5#   
   -   5        $ 	LBoxLeden��5#      $��1��6&   $��10,140,0,10q�66   $
��Left=�6K   $	��440��6f    � BindingGroup 6r   �� *leden+ 5$      �� 5%      .P�5&      �� $
��Naam��6%   $	 150��63    6?   �� *naam+�� 5'      $��Stock��6%   $ 75��64    6?   �� *stockS+�� 5(      $��admin��6%   $ 75��64    6?   �� *adminS+5)      5+      5-      5.      