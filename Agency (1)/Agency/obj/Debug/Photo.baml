   M S B A M L   `   `   `  ����A  =Agency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AgencyAgency  5          Agency.Photo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Agency     5        � 	Resources  5      !   Agency.ByteToImageConverter   
binarToImg �� 
TargetType �� Property �� Value��%H  &	        '��        5   
   6%   �� 5      " ��6   .�5      ��  � ��$) #Bahnschrift SemiLight SemiCondensed)�6/   �� 5       � ��$ 25(�6-   �� 5       � ��
 �   �6/   �� 5       � ��$
 Left=�68   �� 5       � �� 6/   Z� �� 5       � �� 60   Z� 5      5      .��5      � -   5         �Name$
 grid��5      .+�5   
   �� .+�5      �� $��Все фото��6   $��5q�6'   $��0��62   6A   �� 5        �� Orientation$ 
Horizontal=�6   $��1��62   .+�5!      �� $��
Адрес��6   $��15(�6(   $��25��66   $��5q�6B   6O   �� 5"      -   5         ��Name$ pAdress��5"       �� DisplayMemberPath$ Adress��6-   $��20��6i   $	��100��6u   $��10 0 0 0q�6�    �� SelectedItem 6H   �� *Object+6�   5#      �� 5%      -   5        	 ��Name$
	 list��5%      $��Disabled=�6&   $��Visible=�5&      $��Center=�6>   $	��353��6�   ��6b   Z� ��6x   Z� ��5'      �� 5(      .R�5)      � 
 � Orientation$
 
Horizontal=�6$   $��Center=�6=   5*      ��5,      �� 5-      .R�5.      ��  �� CornerRadius$ 7��6!   ���	#FF445571$��1q�6J   $��Center=�5/   	    � UseLayoutRounding . $	��350��6>   $
��auto��6J   ���	#FF445571._�50      � $��10q�6#   .+�51   "   �� .+�52   &   �� 
�������$��15(�6}   $)��#Bahnschrift SemiLight SemiCondensed)�6�   ��60   �� *Object.Adress+ �� StringFormat$ Адрес: {0}��6�   �� 53   &   
�������$��15(�6�   $)��#Bahnschrift SemiLight SemiCondensed)�6�   ��60   �� *Object.ObjectType.TypeName+$ Тип: {0}��6�   �� 54   &   
�������$)��#Bahnschrift SemiLight SemiCondensed)�6�   $��15(�6�   ��60   �� *Object.NumberOfRooms+$# Кол-во комнат: {0}��6�   �� 55   &   
�������$��15(�6�   $)��#Bahnschrift SemiLight SemiCondensed)�6�   ��60   �� *Object.Price+$' !Стоимость: ##0.0 руб.��6�   �� 56   &   
�������$��15(�6�   $)��#Bahnschrift SemiLight SemiCondensed)�6�   ��60   �� *Object.Employee.FullName+$ Сотрудник: {0}��6�   �� 57   &    ��Name$	 img��6,   $	��280��6�   $��0q�6�   ��69   �� *Img+ �� 	Converter# [   �� Mode$ OneWay=�6�   �� 58   &   -   5        $��0 10 0 0q�58   -   $��40��6?   $��Center=�6K   $ ��Редактировать��6h   $��13(�6�   ���	#FF527B9E
���������6�   Z� 6�   59   #   5:      5;      5<      5?      �� 5A      $ 
Horizontal=�6   $��3��62   .+�5B      �� -   5        $��Добавить��5B      $)��#Bahnschrift SemiLight SemiCondensed)�6,   $	��100��6]   $��30��6i   
����������	#FF445571$��19(�6�   $��15q�6�   ��6u   Z� 6�   �� 5C      -   5        $��Удалить��5C      $)��#Bahnschrift SemiLight SemiCondensed)�6+   $	��100��6\   $��30��6h   
����������	#FF445571$��19(�6�   $��0 0 15 0q�6�   ��6t   Z� 6�   �� 5D      -   5        $��Обновить��5D      $)��#Bahnschrift SemiLight SemiCondensed)�6,   $	��100��6]   $��30��6i   
����������	#FF445571$��19(�6�   ��6u   Z� 6�   5E      5F      5G      5H      