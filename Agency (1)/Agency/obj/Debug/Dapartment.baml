   M S B A M L   `   `   `  ����A  =Agency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AgencyAgency  5          Agency.Dapartment   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Agency     5        � 	Resources  5
       �� 
TargetType �� Property �� Value��%+  '��       �� 5   
   " ��6   .�5      ��  � ��$) #Bahnschrift SemiLight SemiCondensed)�6+   �� 5       � ��$ 25(�6)   �� 5       � ��
 �   �6+   �� 5       � ��$
 Left=�64   �� 5       � �� 6+   Z� �� 5       � �� 6,   Z� 5      5      .��5      � .+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Отделы��6   $��5q�6)   66   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgDep��5      $	��302��6&   $��5q�63      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6)   	   Header$	 Наименование��65   
   
Foreground

 �   �1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *DepartmentName+6p   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6-      CanUserResize .     CellTemplate 5      �� 5       .R�5!   "   �� -   5        $ ��Редактировать��5!   )   
�������$
��Left=�6T   $	��Top=�6o   ���	#FF445571���	#FF445571$��Franklin Gothic Book)�6�   $��14(�6�   6�   5"      5$      5&      �� 5'      $ 
Horizontal=�6   .+�5(      �� -   5        $��Добавить��5(      $)��#Bahnschrift SemiLight SemiCondensed)�6,   $	��100��6]   $��30��6i   
����������	#FF445571$��19(�6�   $��15q�6�   ��6u   Z� 6�   �� 5)      -   5        $��Удалить��5)      $)��#Bahnschrift SemiLight SemiCondensed)�6+   $	��100��6\   $��30��6h   
����������	#FF445571$��19(�6�   $��0 0 15 0q�6�   ��6t   Z� 6�   �� 5*      -   5        $��Обновить��5*      $)��#Bahnschrift SemiLight SemiCondensed)�6,   $	��100��6]   $��30��6i   
����������	#FF445571$��19(�6�   ��6u   Z� 6�   5+      5,      5.      5/      