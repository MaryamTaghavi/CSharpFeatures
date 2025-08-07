// Before C#8
var colorBand ;
switch (colorBand)
{
  case "Red" :
    return "#FF0000" ;
  case "Blue" :
    return "#0000FF" ;
  default :
    return "#FFFFFF" ;
}

// It's new in C# 8
return colorBand switch
{
    "Red" => "#FF0000",
    "Orange" => "#FF7F00",
    _ => "#FFFFFF"
} ;

// We can pass into switch **Tuple** (first,second)
