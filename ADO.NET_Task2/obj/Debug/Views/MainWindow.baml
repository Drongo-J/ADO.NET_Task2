   M S B A M L   `   `   `  ����H  DADO.NET_Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ADO.NET_Task2.ViewsADO.NET_Task2.Views  5   	   $    ADO.NET_Task2.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ADO.NET_Task2.Views     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	     � Title$  Authors��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   $	��450��5   	    � 
ResizeMode$ NoResize=�5   	   $	��833��5   	    � Icon$ \Images\peopleIcon.png��5   	   .��5      � -   5         �Name$ MyGrid��5       � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��7* �6   6*   .+�5   
   �� 
�������$��0,0,0,2q�5      ._�5      � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ AddUser��5         MyButtonStyle#��[  5      
������ $	��100��5      $��32��5       $��20,0,0,0q�5!      ��5      �� *AddAuthorCommand+.��5"      �� .+�5#      �� $��\Images\addUser.png��6$   $��30��5$   $   $��30��5%   $    �� Left$	 -45��5&   $   
	 �� Top$		 -15��5'   $   $��Center=�5(   $   $	��Top=�5)   $   5*      �� 5,      $��
New Author��6(   $��20(�5-   (   $	 -12��5.   (   $		 -11��5/   (   $
��Left=�50   (   $��Center=�51   (   52      53      54      �� 56      -   5        $ 
DeleteUser��56        MyButtonStyle2#��[ 57      
������ $	��100��5:      $��32��5;      $��70,0,0,0q�5<      ��58      �� *DeleteCommmand+.��5=      �� .+�5>      �� $��\Images\delete.png��6$   $��30��5?   $   $��30��5@   $   $	 -45��5A   $   $		 -15��5B   $   $��Center=�5C   $   $	��Top=�5D   $   
 J� RenderTransformOrigin$
 0.5,0.5&�6<   z�5E   "   V� 5F   &   .~�5G   *   �� �� 5H   *   �� 5I   *    �� Angle$ 45Q�6:   T� 5J   *   5K   '   5M      �� 5O      $��Delete��6(   $��20(�5P   (   {�.  $	 -12��5R   (   $		 -11��5S   (   $
��Left=�5T   (   $��Center=�5U   (   5V      5W      5X      �� 5Z      -   5        $ Refresh��5Z      #��[  5[      
������ $	��100��5]      $��32��5_      $��20,0,0,0q�5`      ��5^      �� *RefreshCommand+.��5a      �� .+�5b      �� $��\Images\refresh.png��6$   $��30��5c   $   $��30��5d   $   $	 -45��5e   $   $		 -15��5f   $   $��Center=�5g   $   $	��Top=�5h   $   $
 0.5,0.5&�6<   5j      �� 5l      $��Refresh��6(   $��20(�5m   (   {�.  $	 -12��5o   (   $		 -11��5p   (   $
��Left=�5q   (   $��Center=�5r   (   5s      5t      5u      �� 5w      -   5        $ SaveChanges��5w      #��[  5x      
������ $	��100��5z      $��32��5|      $��20,0,0,0q�5}      ��5{      �� *SaveChangesCommand+.��5~      �� .+�5      �� $��\Images\saveChanges.png��6$   $��30��5�   $   $��30��5�   $   $	 -45��5�   $   $		 -15��5�   $   $��Center=�5�   $   $	��Top=�5�   $   $
 0.5,0.5&�6<   5�      �� 5�      $��Save Changes��6(   $��20(�5�   (   {�.  $	 -12��5�   (   $		 -11��5�   (   $
��Left=�5�   (   $��Center=�5�   (   5�      5�      5�      5�      5�      5�      � 5�   
   $��2��6   .+�5�      �� -   5         ��Name$ Scroll��5�      $
��Auto=�5�      $��Disabled=�5�      .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ AuthorsDataGrid��5�      5�      5�      5�      5�      5�      