<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Lab_3.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <!--The automatic slideshow-->
         
    <head>
    <style>
* {box-sizing: border-box;}
body {font-family: Verdana, sans-serif;}
.mySlides {display: none;}
img {vertical-align: middle;}

/* Slideshow container */
.slideshow-container {
  max-width: 450px;
  position: relative;
  margin: auto;
}

/* Caption text */
.text {
  color: #f2f2f2;
  font-size: 15px;
  padding: 8px 12px;
  position: absolute;
  bottom: 8px;
  width: 100%;
  text-align: center;
}

/* Number text (1/3 etc) */
.numbertext {
  color: #f2f2f2;
  font-size: 12px;
  padding: 8px 12px;
  position: absolute;
  top: 0;
}

/* The dots/bullets/indicators */
.dot {
  height: 15px;
  width: 15px;
  margin: 0 2px;
  background-color: #bbb;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
}

.active {
  background-color: #717171;
}

/* Fading animation */
.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 1.5s;
  animation-name: fade;
  animation-duration: 1.5s;
}

@-webkit-keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

@keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

/* On smaller screens, decrease text size */
@media only screen and (max-width: 300px) {
  .text {font-size: 11px}
}
</style>
</head>
       
    
<div>
    
<div class="slideshow-container">

 <div class="mySlides fade">
  <div class="numbertext"><!--1 / 3--></div>
  <img src="imgfile/original.DvgCW6PxR-SNwMNe1pea2s6bHtCIPGJC8jFkiSAVsIU.jpg" style="width:100%">
  <div class="text"><!--Caption Text--></div>
</div>

<div class="mySlides fade">
  <div class="numbertext"><!--2 / 3--></div>
  <img src="imgfile/HAVANA-GREEN-ST-SUIT2-1600x1600.jpg" style="width:100%">
  <div class="text"><!--Caption Two--></div>
</div>

 <div class="mySlides fade">
  <div class="numbertext"><!--3 / 3--></div>
  <img src="imgfile/q106d_f3f4f6.jpg" style="width:100%">
  <div class="text"><!--Caption Three--></div>
</div>

</div>
<br>

<div style="text-align:center">
  <span class="dot"></span> 
  <span class="dot"></span> 
  <span class="dot"></span> 
</div>

<script>
var slideIndex = 0;
showSlides();

function showSlides() {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";  
  }
  slideIndex++;
  if (slideIndex > slides.length) {slideIndex = 1}    
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " active";
  setTimeout(showSlides, 2000); // Change image every 2 seconds
}
</script>

    <!---the four images on the page-->

    </div>
    
         <center><p><img src="imgfile/hair-2537564_1920.jpg" alt="Italian Trulli" style="width:493px; height:625px">&nbsp
             <img src="imgfile/trapeze29.99 (2).jpg" alt="Italian Trulli" style="width:493px; height:625px">
             </p></center>

         <center><p><img src="imgfile/jaclyn-moy-ugZxwLQuZec-unsplash.jpg" alt="Italian Trulli" style="width:485px; height:656px; margin-left: 0px;">&nbsp
             <img src=" imgfile/mens-shoes-875950_1920.jpg" alt="Italian Trulli" style="width:501px; height:656px; margin-left: 0px;">
                 </p></center>

     <center><p><img src="imgfile/jewelry-618429_1920.jpg" alt="Italian Trulli" style="width:485px; height:656px; margin-left: 0px;">&nbsp
             <img src=" imgfile/nordwood-themes-Nv4QHkTVEaI-unsplash - Copy.jpg" alt="Italian Trulli" style="width:501px; height:656px; margin-left: 0px;">
                 </p></center>
    </div>

</asp:Content>
