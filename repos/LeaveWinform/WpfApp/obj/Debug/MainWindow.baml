   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	     � Title$  
MainWindow��5   	   $��899.163��6   $��1093.2��6-    � 	Resources 5	        WpfApp.Contact   c1   Title   Email � Source � XPath  list��%�   &	        &	 >       5
   
   $ balaji��6#   $ 	balaji.rm��62   5      � 5   
   $ Contact.xml?�6   $ Contacts\Contact��60   6Y   5      .��5      � $��0,0,-141,-196q�6    � DataContext# [ 6"   .+�5   
   �� -   5         ��Name$ listBox��5      $
��Left=�6;   ��6#   �� 6X   �� 5   
   $��Label��6   $
��Left=�6    $��457,127,0,0q�6;   $	��Top=�6P   �� 5   
   $��Button��6   $
��Left=�6"   $��332,174,0,0q�6=   $	��Top=�6R   $	��188��6j   $��71��6v   ��5      �� 5      .��5      �  � Offset$	 .25Q�6#   	 � Color$	 Orange��60   6A   � 5      $	 .50Q�6#   $	 white��60   6@   � 5      $	 .75Q�6#   $	 Green��60   6@   5      5      �� 5    
   -   5        
 ��Name$
 btn365��5       $
��Left=�6"   $��311,293,0,0q�6=   $	��Top=�6R   $	��277��6j   $��73��6v   .��5!      �� .+�5"      �� -   5         ��Name$
 chk1��5"      $&�� are u interested in dynamic 365?��6)   5$      �� 5%      $��best of luck��6   5'      5(      �� 5)   
   -   5        $��slider��5)      $
��Left=�6   $��
391,81,0,0q�6:   $	��Top=�6N   $��41��6f   $	��266��6r    � Minimum$ 1Q�6    � Maximum$	 100Q�6�    � SmallChange$	 0.5Q�6�   �� 5*   
   $
��Left=�6   $��34��6-   $��
420,29,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6�   $	��174��6�   ��6b   ��  �� Path$ Value� �� ElementName$ slider��6�   �� 5+   
   $
��Left=�6   $��35��6-   $��657,201,0,0q�69   $
 Wrap=�6N   $	��Top=�6�   $	��154��6�   ��6b   �� $ Title� �� Source# [  6�   �� 5,   
   $
��Left=�6   $��33��6-   $��657,272,0,0q�69   $
 Wrap=�6N   $	��Top=�6�   $	��154��6�   ��6b   �� $ Email�# [  6�   5-      5.      