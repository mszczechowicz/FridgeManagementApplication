   M S B A M L   `   `   `  ����V  RFridgeManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:FridgeManagementApplication.Pages!FridgeManagementApplication.Pages  5      1    +FridgeManagementApplication.Pages.UsersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:FridgeManagementApplication.Pages     5        N� 
FontFamily$  Comic Sans MS)�5	       N� Title$ 	UsersPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��450��6   5      �� 5      5      .+�5   
   �� $��Welcome to FridgeAPP��6   ���	#FFA4BEC1$��32(�6G   $��Center=�6U   $��Center=�6p   �� 5   
   $��Select user from list'��6   ���	#FF626262$��16(�6I   $��Center=�6W   $��Center=�6r   $��	0,100,0,0q�6�   �� 5   
   $	��400��5      $��50��5      $
��Left=�5      $	��Top=�5       $��25,0,0,0q�5!      ��5#      �� 5$       �� EndPoint$	 1,1&�6&    �� 
StartPoint$	 0,0&�65   .��5%      �  � Color$ #497AA7��6#    � Offset$ 0Q�63   � 5&      $ 	#FF232323��6#   $	 0.5Q�65   5'      5)      �� 5*   
   $	��200��5+      $��50��5,      $
��Left=�5-      $	��Top=�5.      $��25,0,0,0q�5/      $��Selected user:��50      $��16(�51      $��Center=�52      $��Center=�53      
�������54      �� 56   
   -   5         ��Name$ SelectedUser��56      $	��200��57      $��50��58      $
��Left=�59      $	��Top=�5:      $��	225,0,0,0q�5;      $��20(�5=      $
��Bold"�5>      $��Center=�5?      $��Center=�5@      ���	#FFA4BEC15A      � 5E   
   $��1��6   $	��150��6   $	��250��6,   $��0,0,0,0q�5F      $	��Top=�5G      $��Center=�6'   .+�5H      �� -   5         ��Name$ NewUserNick��5H      $��	0,120,0,0q�5I      	 �� TextWrapping$
	 Wrap=�5J      $��20��5K      $	��150��5L      
����������	#FF272C31
 � Cursor$
 IBeam��5O       �� 	MaxLength$ 18��5P      $��0q�5Q      �� 5U      -   5         ��Name$ 	UsersList��5U      $��Right=�5W      $	��Top=�6.   $

 Hand��5Y      ���	#FF272C31
�������$	��150��5[      $	��150��6   $��0q�5\      6&   �� 5^      -   5         ��Name$ AddUser��5^      $��Add user��5_      $
��Left=�5`      $��Bottom=�6,   $	��100��5a      $��25��6   
����������	#FF497AA75b   ;   �� 5d      -   5        $ 
RemoveUser��5d      $��X��5e      $��Right=�5f      $	��Top=�6.   $��25��5g      $��25��6   $��Center=�5h      $��Center=�63   $��12(�5i      ���	#FFA74949
�������$��	0,225,0,0q�6I   6\   5j      5k      5l      