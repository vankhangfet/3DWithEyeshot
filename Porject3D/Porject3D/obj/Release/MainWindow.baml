   M S B A M L   `   `   `  ����   	Porject3D    Porject3D.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     d `devDept.Eyeshot.Control.Wpf, Version=8.0.265.0, Culture=neutral, PublicKeyToken=5385d83d2fb4d7d9=ddes2http://schemas.devdept.com/winfx/2008/xaml/control  ] YdevDept.Graphics.Wpf, Version=8.0.265.0, Culture=neutral, PublicKeyToken=5385d83d2fb4d7d9>ddgr3http://schemas.devdept.com/winfx/2008/xaml/graphics    � Title$  
MainWindow��$��662.202��$��947.388��.��� .+�$  devDept.Eyeshot.ViewportLayout  -   $��viewport��$
��Left=�$	��631��$��0,0,0,0q�$	��Top=�$	��939��   ButtonStyle $  devDept.Eyeshot.ButtonSettings     
ColorTheme$
 Dark=�   	Viewports   devDept.Eyeshot.Viewport     DisplayMode$ Rendered=�   InitialView$ Other=�   
Background )  #devDept.Graphics.BackgroundSettings     BottomColor �	#FFF5F5F5   Style$ LinearGradient=�	   TopColor	 �	#FF66A3D2
   CoordinateSystemIcon
 *  $devDept.Eyeshot.CoordinateSystemIcon  *  $devDept.Eyeshot.CoordinateSystemBase   ArrowColorX �	#FF505050   ArrowColorY �	#FF505050   
LabelColor
 �   �-  'devDept.Eyeshot.UserInterfaceSymbolBase   Visible .    Camera   devDept.Eyeshot.Camera     Distance$	 600Q�   ProjectionMode$ Perspective=�   RotationY UdevDept.Geometry, Version=8.0.265.0, Culture=neutral, PublicKeyToken=5385d83d2fb4d7d95	  /devDept.Geometry.Converters.QuaternionConverter$Q K0.0868240888334652, 0.150383733180435, 0.492403876506104, 0.852868531952443	    Target2
  ,devDept.Geometry.Converters.Point3DConverter$ 0, 0, 50
    
ZoomFactor$ 2Q�   Grids   devDept.Eyeshot.Grid     
ColorAxisY �	#7F808080   
ColorAxisX �	#7F808080   MajorLineColor �	#7F5A5A5A   MajorLinesEvery$ 5��   Step$ 5Q�   Visible .    OriginSymbol "  devDept.Eyeshot.OriginSymbol  
 �   � .    Rotate $  devDept.Eyeshot.RotateSettings  *  $devDept.Eyeshot.MovementSettingsBase   Enabled .    ToolBar   devDept.Eyeshot.ToolBar      Buttons  -  'devDept.Eyeshot.ZoomWindowToolBarButton  '  !devDept.Eyeshot.ZoomToolBarButton  &   devDept.Eyeshot.PanToolBarButton  )  #devDept.Eyeshot.RotateToolBarButton  *  $devDept.Eyeshot.ZoomFitToolBarButton  !   ViewCubeIcon! "  devDept.Eyeshot.ViewCubeIcon  "   BackFaceColor" �	#F04D4D4D#   	EdgeColor
# �   �$   FrontFaceColor$ �	#F04D4D4D%   LeftFaceColor% �	#F04D4D4D&   RightFaceColor& �	#F04D4D4D'   	TextColor
' �����(   TopFaceColor( �	#F04D4D4D . 