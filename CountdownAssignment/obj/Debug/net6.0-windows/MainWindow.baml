   M S B A M L   `   `   `  ����W  SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35I6clr-namespace:System.Windows;assembly=PresentationCoreSystem.Windows  5   	   N JCountdownAssignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CountdownAssignmentCountdownAssignment 5   	   $   CountdownAssignment.MainWindow   5   	   \ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   @d2http://schemas.microsoft.com/expression/blend/2008      5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5   	   QSystem.Windows6clr-namespace:System.Windows;assembly=PresentationCore      5   	   3local!clr-namespace:CountdownAssignment      5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   ��5
      �� 5   
    �� ImageSource$G AD:\How\CountdownAssignment\CountdownAssignment\img\wallpaper4.jpg��6   .��5      � .+�5   
   �� $��Alarm Time:��6   $��
557,62,0,0q�6&   $	��Top=�6:   $
��Left=�6R   $��Arial)�6m   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ cbAlarmHour��5      $��
664,65,0,0q�6(   $��50��6<   $
��Left=�6G   $	��Top=�6b   �� 5   
   -   5        $ cbAlarmMinute��5      $��
724,65,0,0q�6*   $��50��6>   $
��Left=�6I   $	��Top=�6d   �� 5   
   -   5         ��Name$ btnSetAlarm��5      $��	Set Alarm��6&   $��674,108,0,0q�6:   $	��100��6O   $
��Bold"�6[   $��12(�6m   $
��Left=�6{   $	��Top=�6�   
�������$��30��6�   ��5      �� 5       �� 
TargetType" ��6"   .R�5      ��  �� CornerRadius$ 15��6   ���#DC143C �� Padding$ 5q�6D   ._�5      �� $��Center=�6+   $��Center=�6H   5      5      5      �� 5   
   $��Countdown Time:��6   $��6,62,0,0q�6*   $	��Top=�6<   $
��Left=�6T   $��Arial)�6o   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ cbCountdownHour��5   &    �� SelectedValue$ 00��6   $��
156,65,0,0q�6?   $��50��6S   $
��Left=�6^   $	��Top=�6y   �� 5   
   -   5        $ cbCountdownMinute��5   &   $ 00��6   $��
216,65,0,0q�6A   $��50��6U   $
��Left=�6`   $	��Top=�6{   �� 5    
   -   5        $ cbCountdownSecond��5    &   $ 00��6   $��
276,65,0,0q�6A   $��50��6U   $
��Left=�6`   $	��Top=�6{   �� 5!   
   -   5        $ btnStartCountdown��5!      $��Start Countdown��6,   $��12(�6F   $��185,108,0,0q�6T   $	��141��6i   $
��Bold"�6u   $
��Left=�6�   $	��Top=�6�   $��31��6�   ��5"      �� 5#      " ��6"   .R�5$      �� $ 15��6   
����ح�$ 5q�6F   ._�5%      �� $��Center=�6+   $��Center=�6H   5&      5'      5)      �� 5,   
   -   5         ��Name$ tbCurrentTime��5,      $��	627,0,0,0q�6+   $	��147��6>   $
��Left=�6J   $	��Top=�6e   $��24(�6}   	 �� TextAlignment$	 Right=�6�   �� 5/   
   -	   5        $ tbAlarmStatus��5/      $��557,156,0,0q�6+   $	��217��6@   $
��Left=�6L   $	��Top=�6g   $��16(�6   $	 Right=�6�   �� 52   
   -
   5        $ tbCountdownTime��52      $	��300��6-   $��Center=�69   $	��Top=�6V   $��40(�6n   $	 Center=�6|   
���  ��$��	0,345,0,0q�6�   53      54      