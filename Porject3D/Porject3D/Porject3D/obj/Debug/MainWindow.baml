   M S B A M L   `   `   `  ����  	Porject3D    Porject3D.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   d `devDept.Eyeshot.Control.Wpf, Version=8.0.265.0, Culture=neutral, PublicKeyToken=5385d83d2fb4d7d9=ddes2http://schemas.devdept.com/winfx/2008/xaml/control  5   	   ] YdevDept.Graphics.Wpf, Version=8.0.265.0, Culture=neutral, PublicKeyToken=5385d83d2fb4d7d9>ddgr3http://schemas.devdept.com/winfx/2008/xaml/graphics  6I     � Title$  
MainWindow��5   	   $��678.62��6   $��947.388��6,   .��5      � .+�5   
   $  devDept.Eyeshot.ViewportLayout  -   5        $��viewport��5      $
��Left=�6.   $	��638��6I   $	��Top=�6V   $	��939��6n      ButtonStyle 5	      $  devDept.Eyeshot.ButtonSettings  5
         
ColorTheme$
 Dark=�6&      	Viewports 5        devDept.Eyeshot.Viewport     DisplayMode$ Rendered=�6       InitialView$ Other=�67      
Background 5      )  #devDept.Graphics.BackgroundSettings  5         BottomColor �	#FFF5F5F5   Style$ LinearGradient=�6J   	   TopColor	 �	#FF66A3D26a   
   CoordinateSystemIcon
 5      *  $devDept.Eyeshot.CoordinateSystemIcon  5      *  $devDept.Eyeshot.CoordinateSystemBase   ArrowColorX �	#FF505050   ArrowColorY �	#FF505050   
LabelColor
 �   �-  'devDept.Eyeshot.UserInterfaceSymbolBase   Visible . 6w      Camera 5        devDept.Eyeshot.Camera  5         Distance$	 600Q�6&      ProjectionMode$ Perspective=�65      RotationY UdevDept.Geometry, Version=8.0.265.0, Culture=neutral, PublicKeyToken=5385d83d2fb4d7d95	  /devDept.Geometry.Converters.QuaternionConverter$Q K0.0868240888334652, 0.150383733180435, 0.492403876506104, 0.852868531952443	 6R      Target2
  ,devDept.Geometry.Converters.Point3DConverter$ 0, 0, 50
 6�      
ZoomFactor$ 2Q�6�      Grids 5        devDept.Eyeshot.Grid     
ColorAxisY �	#7F808080   
ColorAxisX �	#7F808080   MajorLineColor �	#7F5A5A5A   MajorLinesEvery$ 5��6m      Step$ 5Q�6�      Visible . 6�      OriginSymbol 5      "  devDept.Eyeshot.OriginSymbol  5      
 �   � . 6?      Rotate 5      $  devDept.Eyeshot.RotateSettings  5      *  $devDept.Eyeshot.MovementSettingsBase   Enabled . 6.      ToolBar 5         devDept.Eyeshot.ToolBar  5!          Buttons  5#   "   -  'devDept.Eyeshot.ZoomWindowToolBarButton  '  !devDept.Eyeshot.ZoomToolBarButton  5$   "   &   devDept.Eyeshot.PanToolBarButton  5%   "   )  #devDept.Eyeshot.RotateToolBarButton  5&   "   *  $devDept.Eyeshot.ZoomFitToolBarButton  5'   "   5)      !   ViewCubeIcon! 5+      "  devDept.Eyeshot.ViewCubeIcon  5,      "   BackFaceColor" �	#F04D4D4D#   	EdgeColor
# �   �$   FrontFaceColor$ �	#F04D4D4D%   LeftFaceColor% �	#F04D4D4D&   RightFaceColor& �	#F04D4D4D'   	TextColor
' �����(   TopFaceColor( �	#F04D4D4D . 6�   5.      50      52      53      