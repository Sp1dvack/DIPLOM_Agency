   M S B A M L   `   `   `  ����A  =Agency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AgencyAgency  5   	       Agency.AddObject   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Agency     5   	     � Title$<  6Добавить объект недвижимости��5   	   $	��764��6.   $	��430��6;    � WindowStartupLocation$ CenterScreen=�6G    � Icon$ icon.png��6l   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $	��67* �6   �� 5      $
��495* �6   .+�5   
   �� $#��Добавить объект��6   $)��#Bahnschrift SemiLight SemiCondensed)�6*   $��35(�6[   $��Center=�6i   $��0��6�   $��0,12,0,0q�6�   $	��246��6�   6�   �� 5   
   $��Center=�6   $��1��62   $��0,10,0,0q�6?   $	��300��6Q   .+�5      �� $��Кол-во комнат��6   $)��#Bahnschrift SemiLight SemiCondensed)�6,   $��25(�6]   6m   �� 5      -   5         ��Name$ place��5      $��1��6D   $	��300��6Q   $��30��6]   $
��Left=�6i    �� 	MaxLength$ 1��6�   ��6%   �� *NumberOfRooms+6�   �� 5      $��
Адрес��6   $)��#Bahnschrift SemiLight SemiCondensed)�6$   $��25(�6U   6e   �� 5      -   5        $ adress��5      $��1��6>   $	��300��6K   $��30��6W   $
��Left=�6c   ��6&   �� *Adress+6�   �� 5      $��Стоимость��6   $)��#Bahnschrift SemiLight SemiCondensed)�6(   $��25(�6Y   6i   �� 5      -   5        $ price��5      $��1��6<   $	��300��6I   $��30��6U   $
��Left=�6a   $ 9��6�   ��6%   �� *Price+6�   �� 5      $��Тип��6   $)��#Bahnschrift SemiLight SemiCondensed)�6"   $��25(�6S   6c   �� 5      -   5         ��Name$ 	comboType��5   X    �� DisplayMemberPath$ TypeName��6   $��1��6l   $	��300��6y   $��30��6�   $
��Left=�6�    �� SelectedItem 64   �� *
ObjectType+6�   �� 5      $��Сотрудник��6   $)��#Bahnschrift SemiLight SemiCondensed)�6(   $��25(�6Y   6i   �� 5      -   5        $ comboEmp��5      $ FullName��6)   $	��300��6i   $��30��6u   $
��Left=�6�    6F   �� *
Employee+6�   �� 5      -   5        	 ��Name$
	 img1��5   !   $	��200��6   61   �� 5      
 �� Orientation$
 
Horizontal=�6   $��Center=�62   .+�5       �� -   5        $#��Выбрать обложку��5       $)��#Bahnschrift SemiLight SemiCondensed)�63   $��0 20 0 0q�6d   $	��178��6v   $��40��6�   
����������	#FF445571$��22(�6�   ��6�   Z� 6�   �� 5!      -   5        $��Добавить��5!      $)��#Bahnschrift SemiLight SemiCondensed)�6,   $��0 20 0 0q�6]   $��Center=�6o   $	��100��6�   $��40��6�   
����������	#FF445571$��22(�6�   ��6�   Z� 6�   5"      5#      5$      5%      