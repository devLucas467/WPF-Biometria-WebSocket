   M S B A M L   `   `   `  ����N  JBiometriaEWebSocket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BiometriaEWebSocketBiometriaEWebSocket  5   	   $    BiometriaEWebSocket.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BiometriaEWebSocket     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         Estilo_Placeholder �� 
TargetType �� BasedOn �� Property �� Value �� 
TargetType ��Name K� ZIndex	 �� Path
 �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� Triggers �� Binding �� Source%  System.Windows.Markup.Reference �� Value��%p  &	        7���� 5
   
   " ��6+   8   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ Texto��5   "   
������ $ 2��5   "   ��5   &   �� $
	 Text�
 �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=�5   "   �� 5      #��z 6&   #��z��6C   $ 1��6m   .��6~   ��5   "   �� 5   &   " ��6,   .�5   *   ��  � ��
 ���� 6G    5   *   �� 5   .    6:   �� $
	 Text�   *Texto+  6t   .a�5   2   ��  � ��
 �����6O   5   /   5   '   .��5    1   5!      5"      5#      5%      5&      5'      .��5(      � .+�5)   
   �� -   5        $��FirstNameBox��5)      $
��Left=�6&   $��24��6A   $��	52,61,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��120��6�   #��[  5*      $ 
First name��6>    J� RenderTransformOrigin$ 0.192,-0.854&�6O   �� 5+   
   -   5        $��LastNameBox��5+      $
��Left=�6%   $��24��6@   $��
52,113,0,0q�6L   $
 Wrap=�6`   #��[  5,      $ 	Last Name��6>   $	��Top=�6N   $	��120��6f   $ 0.192,-0.854&�6r   �� 5-   
   -   5        $��DescriptionBox��5-      $
��Left=�6(   $��64��6C   $��
52,176,0,0q�6O   $
 Wrap=�6c   #��[  5.      $ Description��6>   $	��Top=�6P   $	��157��6h   $ 0.192,-0.854&�6t    �� 	UndoLimit$	 300��6�   �� 5/   
   -   5        $��PhoneBox��5/      $
��Left=�6"   $��24��6=   $��
313,61,0,0q�6I   $
 Wrap=�6]   #��[  50      $ Phone Number��6>   $	��Top=�6Q   $	��125��6i   $ 0.192,-0.854&�6u   �� 51   
   -   5        $��EmailBox��51      $
��Left=�6"   $��24��6=   $��313,123,0,0q�6I   $
 Wrap=�6^   #��[  52      $ Email��6>   $	��Top=�6J   $	��125��6b   $ 0.192,-0.854&�6n   �� 53   
   -   5        $��	SubmitBtn��53      $��Submit��6#   $
��Left=�64   $��354,345,0,0q�6O   $	��Top=�6d   $��84��6|   $��32��6�   6�   �� 54   
   -   5        $��CheckCredential��54      $��
Credential��6*   $
��Left=�6?   $��364,210,0,0q�6Z   $	��Top=�6o   6�   55      56      