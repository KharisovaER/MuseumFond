   M S B A M L   `   `   `  ????D  @MuseumApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MuseumApp.WindowsMuseumApp.Windows  5   	   (    "MuseumApp.Windows.ExhibitionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MuseumApp.Windows     5   	     ? Title$  ExhibitionWindow??5   	   $	??450??6"   $	??800??6/   .??5	      ? .+?5
   
   ?? -   5        $??ex_add??5
   %   $??Добавить??6   $
??Left=?63   $??
194,24,0,0q?6N   $	??Top=?6b   $??19??6z   6?   ?? 5   
   -   5        $??ex_upd??5   $   $??Изменить??6   $
??Left=?62   $??
272,24,0,0q?6M   $	??Top=?6a   6y   ?? 5   
   -   5        $??ex_del??5   #   $??Удалить??6   $
??Left=?61   $??
348,24,0,0q?6L   $	??Top=?6`   $??58??6x   6?   &   System.Windows.Controls.DataGrid  5   
   -   5        $??Exhib_table??5   0      AutoGenerateColumns .  $??0,70,0,0q?6C      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название??6H      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *ExhibitionName+6f     5      $ 
Адрес??6J   $ * 6Y    6%   ?? *ExhibitionAdress+6e     5      $# Начало выставки??6C   $ * 6\    6%   ?? *	StartDate+6h     5      $! Конец выставки??6A   $ * 6Y    6%   ?? *	EndDate+6e     5      $ Организовал??6W   $ * 6l    6%   ?? *Organization.OrganizationName+6x   5      ?? 5   
   -   5        $??	upd_table??5   $   $??Обновить??6   $
??Left=?65   $??
119,24,0,0q?6P   $	??Top=?6d   $??19??6|   6?   ?? 5   
   -   5         ??Name$ id_tb??5   -   $
??Left=?6   $??
452,25,0,0q?6<    ?? TextWrapping$
 Wrap=?6P   $	??Top=?6d   $??66??6|   $??19??6?   ?? 5   
   -   5         ??Name$ cancel_b??5      $??X??6   $
??Left=?6/   $??
596,24,0,0q?6J   $	??Top=?6^   $??20??6v   
???  ??$??19??6?   6?   ?? 5   
   -   5        	 ??Name$
	 id_l??5      $??Id??6   $
??Left=?6+   $??
432,22,0,0q?6F   $	??Top=?6Z   $??25??6r   ?? 5   
   -	   5        $ 	item_dell??5   #   $??Удалить??6   $
??Left=?66   $??
529,24,0,0q?6Q   $	??Top=?6e   $??58??6}   6?   ?? 5   
   -
   5        $??Экспорт в PDF??5      $
??Left=?6)   $??	19,25,0,0q?6D   $	??Top=?6W   6o   5      5      