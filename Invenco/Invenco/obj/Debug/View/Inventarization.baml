   M S B A M L   `   `   `  ����B  >Invenco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Invenco.ViewInvenco.View  5   	   9!clr-namespace:Invenco.ClassEntityInvenco.ClassEntity  5	   	   "    Invenco.View.Inventarization   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   g cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj	 fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae
 aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah  dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj! fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag" cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac# _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag$ cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah% dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae& aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!    	 
                        ! " # $ % & 5   	   _' [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962ac( _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes ' ( 5   	   (localclr-namespace:Invenco.View ' ( 5   	   5WrittenBool!clr-namespace:Invenco.ClassEntity ' ( 5	   	     � Title$  Inventarization��5   	   $	��450��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:    � WindowStyle$
 None=�6_    � 	Resources 5      *   $Invenco.ClassEntity.StatusStringBool   StatusConverter��%   &	          5   
   6'   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   � -   5         �Name$ AddInform_Grid��5      $��1��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    5      �� 5    
   $
��Auto��6   $
��Auto��6"   $	��Top=�60   }�. 
������  �� Orientation$ 
Horizontal=�5!   .   $��Right=�6G   $��1��6c   $��0��6s   .+�5#      �� -   5         ��Name$ 
Roll_up_Bt��5#      $��25��6)   $��20��64     Roll_Up_Menu#��[ 6@   6g   �� 5%      -   5        $ Deployment_Icon��5%      $��25��6.     Unwrap_Menu#��[ 6;   $��20��6a   6m   �� 5'      -   5        $ ClosesBt��5'      
������   TopMenu#��[ 6@   $��20��6a   
������ $��25��6�   $��Right=�5(      61   5*      �� 5,   
   ���	#FF657DD0$
��Auto��6(   $
��Left=�65   ._�5-      ]� .+�5.      �� $	��Top=�6   $��Center=�6/   	 �� Padding$	 3q�6L   
�������
 �� CornerRadius$	
 100��6k   $	��120��5/      $	��120��6%   $	��Top=�62   ._�53      A� -   5         A�Name$ EllipcePhoto��53      ��54      �� 55      -   5        PhotoEllipse�� �� ImageSource 55   ?   :  4MahApps.Metro.IconPacks.MaterialDesignImageExtension     Kind$ PhotoCamera=�8 # 2MahApps.Metro.IconPacks.BasePackIconImageExtension   Brush
 �����58      5=      �� 5A      -   5        $ Back_Left_chefron_BT��5A      $	��Top=�67   $��
5,-180,0,0q�6L     	topButton#��[ 6a   .��5B      . " (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ ArrowCollapseLeft=�6,   5C      �� 5F      -   5         ��Name$ FullName_tb��5F      $�� ��62   
�������$��22(�6M   $��SemiBold"�6[   $	��Top=�5G   !    �� TextAlignment$ Center=�66   $��
 5 25 0 10q�6M   �� 5H      -	   5        $ FullPatronymic��5H      $�� ��64   
�������$��22(�6O   $��SemiBold"�6]   $	��Top=�5I   !   $ Center=�66   $��
 5 25 0 10q�6M   �� 5K      $	��Top=�6   $	��0.8��62   �� 5M      $	��Top=�6   .+�5Q      �� -
   5        $ MapBt��5Q        
menuButton#��[ 6,   .��5R      �� -   5         ��Name$ MapStack��5R   %   $ 
Horizontal=�67   .+�5S        $ 	MapMarker=�64     menuButtonIcon#��[ 6F   �� 5T      $��
Карта��6(   
�������$
��Bold"�6H   $��15(�6Z   5V      5W      �� 5Z      -   5        $ MovLogBt��5Z      #��[ 6/   .��5[      �� -   5        $ MovLogStack��5[   %   $ 
Horizontal=�6:   .+�5\        $ Table=�64   #��[ 6B   �� 5]      $)��#Журнал перемещений��6(   
�������$
��Bold"�6U   $��15(�6g   5^      5_      �� 5a      -   5        $ InventoryLog��5a      #��[ 63   .��5b      �� -   5        $ InventoryLogStack��5b   %   $ 
Horizontal=�6@   .+�5c        $ Table=�64   #��[ 6B   �� 5d      $/��)Журнал инвентаризации��6(   
�������$
��Bold"�6X   $��15(�6j   5e      5f      �� 5h      -   5        $ CategoryStatus��5h      #��[ 65   .��5i      �� -   5        $ KategoryStatusStack��5i   %   $ 
Horizontal=�6B   .+�5j        $ Table=�64   #��[ 6B   �� 5k      $(��"Категория и Статус��6(   
�������$
��Bold"�6U   $��15(�6g   5l      5m      5n      �� 5p      $��Bottom=�6   .+�5q      �� -   5        $ Close_BT��5q      #��[ 6/   .��5r      �� -   5        $ Menu_Profile2��5r   %   $ 
Horizontal=�6<   .+�5s        $ Close=�64   #��[ 6B   �� 5t      $��
Выход��6(   
�������$
��Bold"�6H   $��15(�6Z   5v      5w      5y      5      5�      �� 5�      -   5        $ Status_CategoryStack��5�      $��1��67   $��1��6G   $��0,45,0,0q�6T   $y�Visible=�6f   .+�5�      �� $��25(�6   $'��!Заполнение данных��6&   $��Center=�6?   9� 5�      -   5         9�Name$ MainExpander��5�      ��5�      � 5�      .+�5�      �� $��Категория��6$   $��25(�65   $��Center=�6C   6b   5�      .��5�      �� .+�5�      �� -   5         ��Name$ 
CategoryTB��5�        Textbox1#��[ 62   $
��Auto��6T   $	��800��5�      9� 5�      ��5�      � 5�      .+�5�   "   �� $��Статус��6,   $��25(�6:   $��Center=�6H   6g   5�      .��5�      �� -   5        $ StatusTB��5�   "   #��[ 64   $
��Auto��6V   $	��800��5�      5�      �� 5�      -   5        $ AddInvertarization��5�   .   $��42��6K   $	��375��6W   $��20(�6e   
������ J� Opacity$	 0.9Q�5�   5   
���������5�      Z�  5�       �� 
TargetType �� Property �� Value��%_   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 10��6=   5�      5�      .��5�      �� $ 
Horizontal=�6!   .+�5�      , & &MahApps.Metro.IconPacks.PackIconEntypo     Kind$ 	AddToList=�6.    & "menuButtonIcon_Person_data_profile#��[ 6@   $��25��6|   $��25��6�   �� 5�      $��Добавить��6$   
�������$
��Bold"�6G   $��20(�6Y   5�      5�      5�      5�      5�      �� 5�   
   -   5        $ InventoryStack��5�      $��1��6-   $��1��6=   $��0,45,0,0q�6J   $y�Hidden=�6\   .+�5�      �� -   5         ��Name$ Inventory_listView��5�      ��5�      �� 5�      .R�5�      �� $ 
Horizontal=�6%   .+�5�      �� $ Vertical=�6)   .+�5�   "   �� $
��Auto��6c   $��0,0,10,0q�6p   ��6,   ��  �� StringFormat$ Название {0}�� �� Path$
 name�6p   �� 5�   "   $	��100��6V   $	��100��6b    � ToolTip$ Картинка��6o   ��6(   �� $ Image_Invertarization�6o   5�      �� 5�      $ Vertical=�6)   .+�5�   "   �� $
��Auto��6h   ��6-   �� $ Категория {0}��$ Category�6h   �� 5�   "   $
��Auto��6�   ��6-   �� $= 7Начало инвентаризации {0:dd.MM.yy }��$ 	StartDate�6�   �� 5�   "   $
��Auto��6e   ��6-   �� $ Кабинет {0}��$ cabinet�6e   �� 5�   "   $
��Auto��6   ��6-   �� $; 5Конец инвентаризации {0:dd.MM.yy }��$ EndDate�6   �� 5�   "   $
��Auto��6�   ��6-   �� $ Списание {0}�� �� 	Converter# [  $ 
WrittenOff�6�   �� 5�   "   $
��Auto��6g   ��6-   �� $ Статус {0}��$ 
StatusName�6g   5�      5�      5�      5�      5�      �� 5�   
   -   5        $ MovomentLogStack��5�      $��1��6/   $��1��6?   $��0,45,0,0q�6L   $y�Hidden=�6^   .+�5�      �� -   5        $ MovomentLog_ListView��5�      ��5�      �� 5�      .R�5�      �� $ 
Horizontal=�6%   .+�5�      �� $ Vertical=�6)   .+�5�   "   �� $
��Auto��6r   ��6,   �� $ Название {0}��$ Invertarization.name�6r   �� 5�   "   ��6(   �� $ Image_Invertarization�5�      �� 5�      $ Vertical=�6)   .+�5�   "   �� $
��Auto��6g   ��6-   �� $ Откуда {0}��$ 
Where_from�6g   �� 5�   "   $
��Auto��6c   ��6-   �� $ Куда {0}��$ Where_to�6c   �� 5�   "   $
��Auto��6{   ��6-   �� $3 -Дата перемещения {0:dd.MM.yy }��$ DateMov�6{   5�      5�      5�      5�      5�      5�      5�      