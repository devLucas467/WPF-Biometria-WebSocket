   M S B A M L   `   `   `  ����N  JBiometriaEWebSocket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BiometriaEWebSocket.ViewsBiometriaEWebSocket.Views  5   	   +    %BiometriaEWebSocket.Views.ProfileUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:BiometriaEWebSocket.Views     5   	     � Title$  ProfileUser��5   	   $	��450��6   $	��800��6*    � 	Resources 5	         Estilo_Placeholder �� 
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
 �����6O   5   /   5   '   .��5    1   5!      5"      5#      5%      5&      5'      .��5)      � .+�5*   
   �� $��Basic��6   $
��Left=�6    $��	63,74,0,0q�6;   $	��Top=�6N    J� RenderTransformOrigin$ -3.868,0.962&�6f   $��63��6�   $��Italic$�6�   $��SemiBold"�6�   $��20(�6�   �� 5+   
   $��
First name��6   $
��Left=�6%   $��
63,128,0,0q�6@   $	��Top=�6T   �� 5,   
   $��	Last Name��6   $
��Left=�6$   $��
63,168,0,0q�6?   $	��Top=�6S   �� 5-   
   $��Description��6   $
��Left=�6&   $��
63,212,0,0q�6A   $	��Top=�6U   �� 5.   
   $��Phone Number��6   $
��Left=�6'   $��
63,252,0,0q�6B   $	��Top=�6V   �� 5/   
   $��Email��6   $
��Left=�6    $��
63,292,0,0q�6;   $	��Top=�6O   �� 50   
   $
��Role��6   $
��Left=�6   $��
66,335,0,0q�6:   $	��Top=�6N   $ -3.868,0.962&�6f   $��63��6�   $��Italic$�6�   $��SemiBold"�6�   $��15(�6�   �� 51   
   -   5         ��Name$ HasCredentialBox��51      $��Is allowed credentials��6-   $
��Left=�6N   $��
66,380,0,0q�6i   $	��Top=�6}   �� 52   
   -   5        $ FirstNameBox��52      $
��Left=�6(   $��23��6C   $��178,132,0,0q�6O    �� TextWrapping$
 Wrap=�6d   #��[  53      $ 
First Name��6>   $	��Top=�6O   $	��120��6g   �� 54   
   -   5        $ LastNameBox��54      $
��Left=�6'   $��23��6B   $��178,172,0,0q�6N   $
 Wrap=�6c   #��[  55      $ 	Last name��6>   $	��Top=�6N   $	��120��6f   �� 56   
   -   5        $ DescriptionBox��56      $
��Left=�6*   $��23��6E   $��178,216,0,0q�6Q   $
 Wrap=�6f   #��[  57      $ Description��6>   $	��Top=�6P   $	��120��6h   �� 58   
   -   5        $ PhoneBox��58      $
��Left=�6$   $��23��6?   $��178,256,0,0q�6K   $
 Wrap=�6`   #��[  59      $ Phone Number��6>   $	��Top=�6Q   $	��120��6i   �� 5:   
   -   5        $ EmailBox��5:      $
��Left=�6$   $��23��6?   $��178,296,0,0q�6K   $
 Wrap=�6`   #��[  5;      $ Email��6>   $	��Top=�6J   $	��120��6b   5@      5A      