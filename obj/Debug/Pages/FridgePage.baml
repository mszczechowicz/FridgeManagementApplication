   M S B A M L   `   `   `  ����V  RFridgeManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:FridgeManagementApplication.Pages!FridgeManagementApplication.Pages  5      2    ,FridgeManagementApplication.Pages.FridgePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:FridgeManagementApplication.Pages     5        N� 
FontFamily$  Comic Sans MS)�5	       N� Title$ 
FridgePage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      5      �� 5      $	��450 �6   5       � RowDefinitions 5   
   �� 5      $	��270 �6   5      �� 5      5      .+�5   
   �� $��1��6   $��Fridge��6$   ���	#FFA4BEC1$��32(�6I   $	��Top=�6W   $
��Left=�6o   � 5    
   $��0��6   $	��150��6   $	��270��6,   $��0,25,0,0q�5!      $	��Top=�5"      $��Center=�6'   .+�5#      �� $��Name:��6   ���	#FFA4BEC1$��18(�6<   $	��Top=�6J   $
��Left=�6b   �� 5$      -   5         ��Name$ NewNameText��5$      $	��Top=�5%      $��0,25,0,0q�5&       �� TextWrapping$
 Wrap=�5'      $��25��5(      $	��150��5)      
����������	#FF272C31 � Cursor$ IBeam��5,      $��16(�5-       �� 	MaxLength$ 18��5.      $��0q�5/      �� 50      $��	Quantity:��6   ���	#FFA4BEC1$��18(�6@   $	��Top=�6N   $
��Left=�6f   $��0,50,0,0q�6�   �� 51      -   5        $ QuantityText��51      $	��Top=�52      $��0,75,0,0q�53      $
 Wrap=�54      $��25��55      $	��150��56      
����������	#FF272C31$��16(�59      $ IBeam��5:      $ 9��5;      $
��Bold"�5<      $��0q�5>      �� 5@      $��	Category:��6   ���	#FFA4BEC1$��18(�6@   $	��Top=�6N   $
��Left=�6f   $��	0,100,0,0q�6�   �� 5A      -   5         ��Name$ CategoryList��5A      $��Center=�5C      $��Center=�6/   $��	0,100,0,0q�5D      $
 Hand��5F      ���	#FF272C31
�������$	��150��5H      $	��100��6   $��0q�5I      5L      �� 5M   
   -   5        	 ��Name$	 InsertToFridge��5M      $��1��6)   $��Insert to fridge��5N      $��Center=�5O      $	��Top=�6.   $	��150��5P      $��25��6   
����������	#FF497AA75Q   <   �� 5R   
   $��1��6   $��1��6!   $��	Quantity:��61   ���	#FFA4BEC1$��18(�6Y   $	��Top=�6g   $
��Left=�6   $��	120,0,0,0q�6�   �� 5S   
   -   5        $ QuantityToRemove��5S      $��1��6,   $��1��69   $	��Top=�5T      $��Center=�5U      $��0,0,0,0q�5V      $
 Wrap=�5W      $��25��5X      $��50��5Y      
����������	#FF272C31$��16(�5\      $ IBeam��5]      $ 9��5^      $
��Bold"�5_      $��0q�5a      �� 5b   
   -   5        $	 
RemoveItem��5b      $��1��6%   $��1��5c      $��Remove from fridge��5d      $��Right=�5e      $	��Top=�6.   $	��150��5f      $��25��6   $��0,0,25,0q�5g      $��Center=�5h      $��Center=�63   $��12(�5i      ���	#FFA74949
�������6I   �� 5j   
   -   5        $ 
FridgeList��5j      $��1��6&   $
��Left=�5m      $	��Top=�6-   $��16(�5n      $��25q�5o      $��0,50,0,0q�5p      ���#39556F
�������$	��420��5r      $	��200��6   $��5q�5s      ���#497AA76&   5t      5u      