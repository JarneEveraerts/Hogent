   M S B A M L   `   `   `  ����B  >Fitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FitnessFitness  5   	       Fitness.Klant   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Fitness     5   	   -   5          �Name$  Wd_Klant��5   	    � Title$ Klant��5	   	   $	��450��6   $	��800��6$   .��5
      � $
��Auto��6   $��0,0,0,-6q�6   .+�5   
   � -   5         �Name$ Grd_KlantInfo��5      $��	0,0,0,350q�6&   .+�5      �� -   5         ��Name$ Txt_FirstName��5      $
��Left=�6-   $��20��6H   $��	93,10,0,0q�6T    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{    �� IsReadOnlyCaretVisible$
 True��6�   $	��100��6�    J� IsManipulationEnabled$
 True��6�   �� 5      -   5        $ Txt_Name��5      $
��Left=�6(   $��20��6C   $��	93,34,0,0q�6O   $
 Wrap=�6b   $	��Top=�6v   $	��100��6�   $
 True��6�   $
 True��6�   �� 5      $��Name:��6   $
��Left=�6$   $��	55,32,0,0q�6?   $	��Top=�6R   $��10(�6j   $��23��6x   �� 5      $��First Name:��6   $
��Left=�6*   $��33,9,0,0q�6E   $	��Top=�6W   $��10(�6o   $��23��6}   �� 5      -   5        $ Txt_Date��5      $
��Left=�6(   $��20��6C   $��
261,10,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $
 True��6�   $	��100��6�   $
 True��6�   �� 5      -   5        $ 	Txt_Place��5      $
��Left=�6)   $��20��6D   $��
261,34,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��100��6�   $
 True��6�   $
 True��6�   �� 5      $��	Gemeente:��6   $
��Left=�6(   $��
198,32,0,0q�6C   $	��Top=�6W   $��10(�6o   $��24��6}   �� 5      $��
Birthdate:��6   $
��Left=�6)   $��	204,6,0,0q�6D   $	��Top=�6W   $��10(�6o   $��24��6}   �� 5      -   5        $ Txt_Subsciption��5      $
��Left=�6/   $��20��6J   $��
440,34,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��100��6�   $
 True��6�   $
 True��6�   �� 5      $��Subscription:��6   $
��Left=�6,   $��
368,29,0,0q�6G   $	��Top=�6[   $��10(�6s   $��24��6�   �� 5      -   5        $ Txt_Interest��5      $
��Left=�6,   $��20��6G   $��
440,10,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $
 True��6�   $	��100��6�   $
 True��6�   �� 5      $��	Interest:��6   $
��Left=�6(   $��	390,6,0,0q�6C   $	��Top=�6V   $��10(�6n   $��24��6|   5      � 5   
   -	   5        $ Grd_KlantReservation��5      $
��Left=�6-   $	��123��6H   $��	35,90,0,0q�6U   $	��Top=�6h   $	��425��6�    � ColumnDefinitions 5      �� 5      $	��12* �6#   �� 5      $��5* �6#   .+�5      (  "System.Windows.Controls.DatePicker  -
   5          Name$ Dpr_Date��5      $
��Left=�6+   $��
162,10,0,0q�6F   $	��Top=�6Z   $��25��6�   $	��102��6�   �� 5      -   5        	 ��Name$	 Cmb_Machines��5      $
��Left=�6-   $��25��6H   $	��Top=�6T   $	��100��6l   $��	52,10,0,0q�6�   �� 5       -   5        
 ��Name$
 Btn_Reserveer��5       $��	Reserveer��6,   $��52,93,193,0q�6@   $	��Top=�6U   $��20��6m   6y   �� 5!      -   5         ��Name$ Lsb_TimeSlot��5!      $��Center=�6,   $	��109��6I   $��0,10,0,0q�6V   $	��Top=�6h   $	��106��6�    �� SelectionMode$ Multiple=�6�    �� IsTextSearchEnabled$ False��6�   $��1��6�   6�   5"      5#      5$      