   M S B A M L   `   `   `  ����G  CJuegdhuis V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Juegdhuis_V3Juegdhuis_V3  5   	       Juegdhuis_V3.KassaWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Juegdhuis_V3     5   	     � Title$  KassaWindow��5   	   $	��425��6   $	��470��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ BtnStart��5
      $��Start��6#   $
��Left=�63   $��378,360,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5        $ BtnAdd��5      $��>>��6!   $
��Left=�6.   $��
200,97,0,0q�6I   $	��Top=�6]   $��75��6u   6�   �� 5   
   -   5        $ BtnDel��5      $��<<��6!   $
��Left=�64   $��200,184,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5         ��Name$ 	ListKluis��5      $
��Left=�6&   $	��338��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $	��150��6y   $��Disabled=�6�   $��Disabled=�6�   ��.   �� SelectedIndex 6  �� *TestSelected+ �� View 5      �� 5      .P�5      �� $��eenheid��6%    �� Width$	 100��66    �� DisplayMemberBinding 6B   �� *
eenheidC+�� 5      $��aantal��6%   $ 45��65    6@   �� *	hoeveel+5      5      �� 5   
   -   5        $ 	ListKassa��5      $
��Left=�6&   $	��338��6A   $��
303,10,0,0q�6N   $	��Top=�6b   $	��150��6z   $��Disabled=�6�   $��Disabled=�6�   ��.   5      �� 5      .P�5      �� $��eenheid��6%   $	 100��66    6B   �� *
eenheidC+�� 5      $��aantal��6%   $ 45��65    6@   �� *	hoeveel+5      5      �� 5   
   -   5         ��Name$ label��5      $
��Left=�6    $��215,330,0,0q�6;   $	��Top=�6P   �� 5   
   -   5         ��Name$ 	Txtaantal��5      $
��Left=�6%   $��23��6@   $��200,144,0,0q�6L   	 �� TextWrapping$
	 Wrap=�6a   $	��Top=�6u   $��75��6�   6�   �� 5   
   -   5        $ label1��5      $��aantal:��6    $
��Left=�62   $��200,122,0,0q�6M   $	��Top=�6b   $��75��6z   5!      5"      