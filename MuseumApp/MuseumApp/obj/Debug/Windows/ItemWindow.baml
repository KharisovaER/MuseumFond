   M S B A M L   `   `   `  ????D  @MuseumApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MuseumApp.WindowsMuseumApp.Windows  5   	   "    MuseumApp.Windows.ItemWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MuseumApp.Windows     5   	     ? Title$  
ItemWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? .+?5
   
   ?? -   5        $??item_add??5
   $   $??Добавить??6   $
??Left=?64   $??
241,23,0,0q?6O   $	??Top=?6c   $??19??6{   6?   ?? 5   
   -   5        $??item_upd??5   $   $??Изменить??6   $
??Left=?64   $??
342,23,0,0q?6O   $	??Top=?6c   6{   ?? 5   
   -   5        $??item_del??5   #   $??Удалить??6   $
??Left=?63   $??
440,22,0,0q?6N   $	??Top=?6b   $??58??6z   6?   &   System.Windows.Controls.DataGrid  5   
   -   5        $??
Item_table??5   /      AutoGenerateColumns .  $??0,70,0,0q?6A      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название??6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *
ItemName+6`     5      $ Дата создания??6D   $ * 6[    6%   ?? *
CreateDate+6g     5      $ Точность даты??6O   $ * 6f    6%   ?? *DateType.DateTypeName+6r     5      $ 
Автор??6N   $ * 6]    6%   ?? *Author.AuthorSurname+6i   5      ?? 5   
   -   5        $??	upd_table??5   $   $??Обновить??6   $
??Left=?65   $??
160,23,0,0q?6P   $	??Top=?6d   $??19??6|   6?   ?? 5   
   -   5        $??id_tb??5   -   $
??Left=?6   $??
575,23,0,0q?6:    ?? TextWrapping$
 Wrap=?6N   $	??Top=?6b   $??66??6z   $??19??6?   ?? 5   
   -   5        $??cancel_b??5      $??X??6   $
??Left=?6-   $??
719,22,0,0q?6H   $	??Top=?6\   $??20??6t   
???  ??$??19??6?   6?   ?? 5   
   -   5        $
??id_l??5      $??Id??6   $
??Left=?6)   $??
555,20,0,0q?6D   $	??Top=?6X   $??25??6p   ?? 5   
   -	   5         ??Name$ 	item_dell??5   #   $??Удалить??6   $
??Left=?66   $??
652,22,0,0q?6Q   $	??Top=?6e   $??58??6}   6?   5      5      