   M S B A M L   `   `   `  ����B  >Invenco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Invenco.ViewInvenco.View  5   	   "    Invenco.View.Inventory_tools   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   g cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj	 fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae
 aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah  dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj! fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag" cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac# _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag$ cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah% dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae& aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!    	 
                        ! " # $ % & 5   	   _' [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962ac( _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes ' ( 5   	   (localclr-namespace:Invenco.View ' ( 5   	     � Title$  Inventory_tools��5
   	    � WindowStartupLocation$ CenterScreen=�6!    � WindowStyle$
 None=�6F   $	��450��6Y   $	��800��6f   .��5      � -   5         �Name$ Grid_BackGround��5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    5      �� 5   
   $
��Auto��6   $
��Auto��6"   $	��Top=�60   }�. 
������  �� Orientation$ 
Horizontal=�5   .   $��Right=�6G   $��1��6c   $��0��6s   .+�5      �� -   5         ��Name$ 
Roll_up_Bt��5      $��25��6)   $��20��64      Roll_Up_Menu#��[  6@   6g   �� 5       -   5        $ Deployment_Icon��5       $��25��6.     Unwrap_Menu#��[ 6;   $��20��6a   6m   �� 5"      -   5        $ ClosesBt��5"      
������   TopMenu#��[ 6@   $��20��6a   
������ $��25��6�   $��Right=�5#      61   5%      �� 5'   
   ���	#FF657DD0$
��Auto��6(   $
��Left=�65   ._�5(      ]� .+�5)      �� $	��Top=�6   $��Center=�6/    �� Padding$ 3q�6L   
�������	 �� CornerRadius$		 100��6k   $	��120��5*      $	��120��6%   $	��Top=�62   ._�5.      A� -   5        
 A�Name$
 EllipcePhoto��5.      ��5/      �� 50      -   5        PhotoEllipse�� �� ImageSource 50   ?   :  4MahApps.Metro.IconPacks.MaterialDesignImageExtension     Kind$ PhotoCamera=�8 # 2MahApps.Metro.IconPacks.BasePackIconImageExtension   Brush
 ����� � ContextMenu 52      �� 53      .@�54   "   m� -   5        $ ��Редактировать��54   +   6B   m� 55   "   -   5        $��Удалить��55   +   6<   56      59      5;      �� 5?      -	   5        $ Back_Left_chefron_BT��5?      $	��Top=�67   $��
5,-180,0,0q�6L     	topButton#��[ 6a   .��5@      . " (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ ArrowCollapseLeft=�6,   5A      �� 5D      -
   5         ��Name$ FullName_tb��5D      $�� ��62   
�������$��22(�6M   $��SemiBold"�6[   $	��Top=�5E   !    �� TextAlignment$ Center=�66   $��
 5 25 0 10q�6M   �� 5F      -   5        $ FullPatronymic��5F      $�� ��64   
�������$��22(�6O   $��SemiBold"�6]   $	��Top=�5G   !   $ Center=�66   $��
 5 25 0 10q�6M   �� 5I      -   5        $ AddFullPersonDataBt��5I      $y�	Collapsed=�66   
�������$	��235��6a   $��15(�6m   
����iA�$	��Top=�5J      $��40��6/   $)��#Полная авторизация��6;   $��
 5 25 0 10q�6X   ��5I   �   Z�  � 	Resources 5K       �� 
TargetType �� Property �� Value��%_   '��       �� 5L      " ��6    .�5M      ��  �@��CornerRadius$ 10��6=   5O      5P      5Q      �� 5W      $	��Top=�6   $	��0.8��62   �� 5Y      $	��Top=�6   .+�5Z      �� -   5        $ Invertarization_Btn��5Z        
menuButton#��[ 6:   .��5[      �� -   5         ��Name$ InvertarizationStack��5[   %   $ 
Horizontal=�6C   .+�5\        $ Table=�64     menuButtonIcon#��[ 6B   �� 5]      $"��Инвентаризация��6(   
�������$
��Bold"�6Q   $��15(�6c   5_      5`      �� 5b      -   5        $ 
HistoryLog��5b      #��[ 61   .��5c      �� -   5        $ HistoryLogStack��5c   %   $ 
Horizontal=�6>   .+�5d        $ Table=�64   #��[ 6B   �� 5e      $��Списанное��6(   
�������$
��Bold"�6L   $��15(�6^   5f      5g      �� 5h      -   5        $ MapBt��5h      #��[ 6,   .��5i      �� -   5        $ MapStack��5i   %   $ 
Horizontal=�67   .+�5j        $ 	MapMarker=�64   #��[ 6F   �� 5k      $��
Карта��6(   
�������$
��Bold"�6H   $��15(�6Z   5m      5n      5o      �� 5s      $��Bottom=�6   .+�5t      �� -   5        $ Invertarization_Btns1��5t      #��[ 6<   .��5u      �� -   5        $ Menu_Profile2��5u   %   $ 
Horizontal=�6<   .+�5v        $ Close=�64   #��[ 6B   �� 5w      $��
Выход��6(   
�������$
��Bold"�6H   $��15(�6Z   5y      5z      5|      5�      5�      5�      5�      