   M S B A M L   `   `   `  ����B  >Fitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FitnessFitness  5   	       Fitness.LoginBeheerder   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Fitness     5   	     � Title$  Login Beheerder��5   	   $	��450��6!   $	��800��6.   .��5	      � -   5         �Name$ Wnd_LoginBeheerder��5	      $��	0,10,0,12q�6'    � ColumnDefinitions 5
   
   �� 5      $	��13* �6   �� 5      $��7* �6   .+�5   
   �� -   5         ��Name$ Txt_Username��5       � ToolTip$ Username��6(   $
��Left=�6;   $��30��6V   $��320,144,0,0q�6b    �� TextWrapping$
 Wrap=�6w   $	��Top=�6�   $	��264��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Username��6�   $��2��6�   �� 5   
   -   5        $ Txt_Password��5      $ Password��6(   $
��Left=�6;   $��30��6V   $��320,196,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��264��6�   $��2��6�   �� 5   
   -   5         ��Name$ 	Btn_Login��5      $��Login��6$   $
��Left=�64   $��37��6O   $��264,250,0,0q�6[   $	��Top=�6p   $	��111��6�   6�   �� 5   
   -   5        $ 
Btn_Cancel��5      $��Cancel��6%   $
��Left=�66   $��37��6Q   $��408,250,0,0q�6]   $	��Top=�6r   $	��120��6�    J� RenderTransformOrigin$ 
0.527,0.53&�6�   $��2��6�   6�   �� 5   
   $��	Username:��6   $
��Left=�6$   $��229,141,0,0q�6?   $	��Top=�6T   �� 5   
   $��	Password:��6   $��Center=�6$   $��Center=�6A   5      5      