﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <style>
	li a{

		display: block;
		width: 140px;
		height: 50px;
		background-color: #d467c6;
		color: white;
		font-size: 200%;
		text-align:center;
 
	}
.float {
		float: left;
	}
	.gallery{
		display: block;
		width: 140px;
		height: 50px;
		background-color: #d467c6;
		color: white;
		font-size: 200%;
		text-align:center;
	}
	
.ul{
   /* margin: 0;*/
   margin-top: 65px;
    padding: 0;
    list-style-type: none;
    width: 100%;
    background-color: #00bcd4;
    position: fixed;
    height: 50px;
    
    border-right: 1px solid red;

}
#three:hover  .two{
	opacity: 1;
}

.two{
    opacity: 0;
    display: block;
    background-color:#00bcd4; 
    margin-top: 8%;
    border: solid;
    border-color: red;
    padding-left: 0%;
}

.four:hover {
	opacity: .5;
	color: black;


}

.four{
		text-decoration: none;
			text-decoration-style: none;
			list-style: none;
			padding-left: -3px;
			padding-top: 5px;

	border-bottom: solid 1px red;

}
li a:hover{
	
	color: #d467c6;
}	
.brand{
	margin-top:-9px;
    margin-bottom: auto;
	width: 100%;
	height: 75px;
	background-color: black;
	position:fixed;
	color: white;
}
.image{
	padding: 10px 10px;
}
.image:hover {
	opacity: .7;
}
</style>
<head runat="server">
    <link rel="stylesheet" type="text/css" href="css/style.css"/>
	<title>navigation bar</title>
</head>
<body style="background-color:black" >
<div class="brand">
	<h1 style="margin-left: 32%; margin-top: 1%">The Riders Club </h1>
<h2 style="margin-top: -2%">In Search Of Infinity</h2> 
</div>
<ul class="ul" >
	<li><a class="text float" href="https://www.w3schools.com/w3css/tryw3css_templates_band.htm">home</a></li>
	<li><a class="text float" href="https://www.w3schools.com/w3css/tryw3css_templates_band.htm">History</a></li>


	<li class="gallery float" id="three" >Gallery

<ul class="two">
	<li class="four">Images</li>
	<li class="four">Videos</li>
</ul>



	</li>




	<li><a class="text float" href="https://www.w3schools.com/w3css/tryw3css_templates_band.htm">Contact</a></li>
</ul>
<img width="100%" height="680px" src="image/bg6.jpg">
    <div style="height: 510px; width: 100%; background-color:black; padding: 10px 10px 10px 10px";>
        <img class="image"; src="image/bg6.jpg"; height="230" width="220px;";>
        <img class="image"; src="image/bg7.jpg"; height="230px" width="220px;">
        <img class="image"; src="image/bg8.jpg"; height="230px" width="220px;">
        <img class="image"; src="image/bg8.jpg"; height="230px" width="220px;">
        <img class="image"; src="image/bg9.jpg"; height="230px" width="220px;">
        <img class="image"; src="image/bg10.jpg"; height="230px" width="220px;">
        <img class="image"; src="image/bg11.jpg"; height="230px" width="220px;">
        <img class="image"; src="image/bg5.jpg"; height="230px" width="220px;">

    </div>
     <div style="height: 510px; width: 100%; background-color:white";>

</div>
</body>
</html>
