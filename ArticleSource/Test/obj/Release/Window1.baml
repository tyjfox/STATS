   M S B A M L   `   `   `  ���� M  IAviad.WPF.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:Aviad.WPF.Controls;assembly=Aviad.WPF.ControlsAviad.WPF.Controls  ? ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestTest    Test.Window1   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8x,http://schemas.microsoft.com/winfx/2006/xaml    Kactb<clr-namespace:Aviad.WPF.Controls;assembly=Aviad.WPF.Controls    "localclr-namespace:Test      � Title$  Dynamic Keyboard��$	��550��$
��1025��$	��550��$
��1025�� � 	Resources    xml �� Source  vm �� Source �� Path �� IsAsync!  Test.MyDataTemplateSelector  TemplateSelector  TheItemTemplate �� CornerRadius � ColumnDefinitions � RowDefinitions	 �� XPath  WaitTemplate��%�  &	        7  7  &	 T     &	 Y     &	 L    ��  � .&��� 8   $ QueryCollection� . �� 8  $ WaitMessage�  �� .R��� 
���r���$��2q�$ 5��._��  �� $
��Auto ���  �� �� .+��� $��Suggestion:  ���� $��1������ $	 suggestion/@data���� $��1��$��
Results:  ���� $��1��$��1������ $	 num_queries/@int���� .R��� 
����Zj����� .��� -   $��Layout��   
bigButtons
 �� 
TargetType �� Property �� Value  bigToggleButtons �� Triggers P� Property P� Value��%'  &	       &	 i     �� "
 ��.���  � ��$
 Left=���  � ��$ 72����  � ��$	 Top=���  � ��$	 140���� "
 d�.���  � ��$
 Left=���  � ��$ 72����  � ��$	 Top=���  � ��$	 140�� P�  �@d�	IsChecked$
 trueY�. ���  � ��
 � ���.+��� -   $��EnterButton��$��Enter��$��860,254,0,0q�#��[ �� -   $��	Backspace��$��	Backspace��$��860,177,0,0q�#��[ d� -   $��Shift��$��Shift��$��860,331,0,0q�#��[ �� -   $��Space��$��Space��$��
95,410,0,0q�$��72��$	��590��$
��Left=�$	��Top=�d� -   $
��Caps��$��CapsLock��$��860,410,0,0q�#��[ �� -   $��	LeftArrow��$��690,410,0,0q�$��80��$��72��$
��Left=�$	��Top=��� -   $��
RightArrow��$��775,410,0,0q�$��80��$��72��$
��Left=�$	��Top=��� -	   $
��col1��$��
10,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -
   $
��col2��$��
95,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -   $
��col3��$��180,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -   $
��col4��$��265,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -   $
��col5��$��350,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -   $
��col6��$��435,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -   $
��col7��$��520,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -   $
��col8��$��605,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -   $
��col9��$��690,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -   $��col10��$��775,177,0,0q�$	��Top=�$
��1000��$	��216��$
��Left=��� -   $��Clear��$��Clear��$��	8,410,0,0q�$��80��$��72��$
��Left=�$	��Top=�,   &Aviad.WPF.Controls.AutoCompleteTextBox  -     Name$ tb��$��30(�$	��150��$
��Left=�$��	10,10,0,0q�$	��Top=�$
��1000��   ItemTemplateSelector# [    MaxCompletions$ 10������ # [ $ 	QueryText� �� UpdateSourceTrigger$ PropertyChanged=�   ItemsSource �� # [     Binding �� $	 suggestion/@data��