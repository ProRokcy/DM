   M S B A M L   `   `   `  ����D  @ITService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ITService.Pages.ClientPagesITService.Pages.ClientPages  5      0    *ITService.Pages.ClientPages.MainClientPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ITService.Pages.ClientPages     5        N� Title$  MainClientPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��11* �6   �� 5      $��2* �6   .+�5   
   �� $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��
MyDataGrid��5         
IsReadOnly . $	��600��5      $	��300��5         AutoGenerateColumns .     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      Header$ Мои заявки��5   -      CellTemplate 5      �� 5      .R�5   "   �  � ColumnDefinitions 5   &   �� 5   *   �� 5   *    5!   &   �� 5"   *   �� 5#   *   �� 5$   *   .+�5&   &   �� $��0��61   $��0��5'   -   	 �� Orientation$	 
Horizontal=�5(   -   .+�5)   *   �� $��Устройство: ��64   �� 5*   *   ��64   �� *Device+5+   '   �� 5,   &   $��0��61   $��1��5-   -   $	 
Horizontal=�5.   -   .+�5/   *   �� $��Модель: ��64   �� 50   *   ��64   �� *ModelDevice+51   '   �� 52   &   $��1��61   $��0��53   -   $	 
Horizontal=�54   -   .+�55   *   �� $��Описание: ��64   �� 56   *   ��64   �� *Description+57   '   �� 58   &   $��1��61   $��1��59   -   $	 
Horizontal=�5:   -   .+�5;   *   �� $��Статус: ��64   �� 5<   *   ��64   �� *StatusApplications.Title+5=   '   �� 5>   &   $��2��61   $��2��5?   -   $	 
Horizontal=�5@   -   .+�5A   *   �� $��EditBtn��61   -   5        $ ��Редактировать��5A   V   5B   '   5C   #   5D      5F      5H      5I      �� 5J   
   -   5        $��AddBtn��5J      $��Добавить��64   $��2��6G   $��Center=�6T   $
��Left=�6o   �� 5K   
   $	 
Horizontal=�6   $��0��5L      $
��Left=�5M      $��10q�5N      .+�5O      �� $	 Vertical=�6   .+�5P      �� $&�� Поиск по описанию��6   $
��Left=�65   $��0q�6P   �� 5Q      -   5        
 ��Name$
 TxbSerch��5Q      $	��250��6O   5R      �� 5S      $	 Vertical=�6   .+�5T      �� $��Фильтрация��6   $
��Left=�6.   $��0q�6I   �� 5U      -   5        $��	CmbStatus��5U      $	��250��6,   .@�5W      �� .��6#   Все6(   �� 5X      .��6#   В ожидании6/   �� 5Y      .��6#   В работе6-   �� 5Z      .��6#   Выполнены6.   5[      5\      5]      5^      5_      