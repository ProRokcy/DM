   M S B A M L   `   `   `  ����D  @ITService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ITService.Pages.Emp_loyeesPagesITService.Pages.Emp_loyeesPages  5      7    1ITService.Pages.Emp_loyeesPages.MainEmployeesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:ITService.Pages.Emp_loyeesPages     5        N� Title$  MainEmployeesPage��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��11* �6   �� 5      $��2* �6   .+�5   
   �� $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��
MyDataGrid��5         
IsReadOnly . $	��600��5      $	��300��5         AutoGenerateColumns .     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      Header$ заявки��5   -      CellTemplate 5      �� 5      .R�5   "   �  � ColumnDefinitions 5   &   �� 5   *   �� 5   *    5    &   �� 5!   *   �� 5"   *   �� 5#   *   .+�5%   &   �� $��0��61   $��0��5&   -   	 �� Orientation$	 
Horizontal=�5'   -   .+�5(   *   �� $��Устройство: ��64   �� 5)   *   ��64   �� *Application.Device+5*   '   �� 5+   &   $��0��61   $��1��5,   -   $	 
Horizontal=�5-   -   .+�5.   *   �� $��Модель: ��64   �� 5/   *   ��64   �� *Application.ModelDevice+50   '   �� 51   &   $��1��61   $��0��52   -   $	 
Horizontal=�53   -   .+�54   *   �� $��Описание: ��64   �� 55   *   ��64   �� *Application.Description+56   '   �� 57   &   $��1��61   $��1��58   -   $	 
Horizontal=�59   -   .+�5:   *   �� $��Приоритет: ��64   �� 5;   *   ��64   �� *Priority.Title+5<   '   �� 5=   &   $��2��61   $��2��5>   -   $	 
Horizontal=�5?   -   .+�5@   *   �� $��EditBtn��61   -   5        $&�� Зарегистрировать��5@   V   5A   '   5B   #   5C      5E      5G      5H      �� 5I   
   $	 
Horizontal=�6   $��0��5J      $
��Left=�5K      $��10q�5L      .+�5M      �� $	 Vertical=�6   .+�5N      �� $&�� Поиск по описанию��6   $
��Left=�65   $��0q�6P   �� 5O      -   5        
 ��Name$
 TxbSerch��5O      $	��250��6O   5P      �� 5Q      $	 Vertical=�6   .+�5R      �� $��Фильтрация��6   $
��Left=�6.   $��0q�6I   �� 5S      -   5        $��	CmbStatus��5S      $	��250��6,   .@�5U      �� .��6#   Все6(   �� 5V      .��6#   Высокий6,   �� 5W      .��6#   Средний6,   �� 5X      .��6#   Низкий6+   5Y      5Z      5[      5\      5]      