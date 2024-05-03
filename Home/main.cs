@charset "UTF-8";
.borde__solido {
  border: solid 10px;
  background-color: #ecaacd;
  padding: 20px;
  margin: 20px;
}

.borde__dotted, .btn {
  border: dotted 10px;
  background-color: #ecaacd;
  padding: 20px;
  margin: 20px;
}

.borde__dashed {
  border: dashed 10px;
  background-color: #ecaacd;
  padding: 20px;
  margin: 20px;
}

.borde__double {
  border: double 15px;
  background-color: #ecaacd;
  padding: 20px;
  margin: 20px;
}

.borde__groove {
  border: groove 15px;
  background-color: #ecaacd;
  padding: 20px;
  margin: 20px;
}

.borde__ridge {
  border: ridge 15px;
  background-color: #ecaacd;
  padding: 20px;
  margin: 20px;
}

.borde__inset {
  border: inset 15px;
  background-color: #ecaacd;
  padding: 20px;
  margin: 20px;
}

.borde__outset {
  border: outset 15px;
  background-color: #ecaacd;
  padding: 20px;
  margin: 20px;
}

.borde__Esquinas_dedondeada, .formulario__basico__2 input, .formulario__basico__2 textarea, .formulario__basico__2 fieldset, legend, input[type=checkbox],
input[type=radio], input[type=text], input[type=password], input[type=email], select, option, .boton__animacion__1, .boton__animacion__2, .boton__animacion__3, .boton__animacion__4, .boton__basico__1, .boton__basico__2, .boton__basico__3, .boton__basico__4, .boton__blanco__1, .boton__blanco__2, .boton__blanco__3, .boton__blanco__4 {
  border-radius: 5px 5px 5px 5px;
  padding: 20px;
  margin: 20px;
}

.borde__none {
  border: none;
  border-color: #ecaacd;
}

/*------------------------------------------------*/
/*                 BORDES REDONDEADOR             */
/*------------------------------------------------*/
.borde__redondeado__50px, .formulario label, .formulario input[type=text],
.formulario input[type=email],
.formulario input[type=password],
.formulario textarea,
.formulario select, .boton__Movimento__Rosa, .boton__Movimento__rojo, .boton__Movimento__verde, .boton__Movimento__naranja, .formulario button[type=submit], .formulario__basico__2, button {
  border-radius: 50px;
  border: 0;
}

.borde__redondeado__1 {
  border-radius: 25% 10%;
}

.borde__redondeado__2 {
  border-radius: 25% 10%;
}

.borde__redondeado__3 {
  border-radius: 10% 30% 50% 70%;
}

.borde__redondeado__4 {
  border-radius: 10%/50%;
}

.borde__redondeado__5 {
  border-radius: 10px 100px/120px;
}

.borde__redondeado__6 {
  border-radius: 50% 20%/10% 40%;
}

/*------------------------------------------------*/
/*          BORDES CON ESQUINA REDONDEADAS         */
/*------------------------------------------------*/
.borde__redondeado__7 {
  border-end-start-radius: 80px 80px;
}

.borde__redondeado__8 {
  border-end-start-radius: 250px 100px;
  direction: rtl;
}

.borde__redondeado__9 {
  border-end-start-radius: 50%;
  writing-mode: vertical-lr;
}

.borde__redondeado__10 {
  border-end-start-radius: 50%;
  writing-mode: vertical-rl;
}

/*------------------------------------------------*/
/*      BORDER CIRCULO                       */
/*------------------------------------------------*/
.borde__circle {
  border-radius: 50px;
}

/*------------------------------------------------*/
/*          BORDE REDONDEADOS                     */
/*------------------------------------------------*/
.borde__equna {
  border-radius: 60px/20px;
}

.borde__redondeado__15 {
  border-radius: 13em/3em;
}

/*------------------------------------------------*/
/*      ESTILO DE HTML                            */
/*------------------------------------------------*/
.sombra_superior, .btn {
  box-shadow: 0px -25px 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra_derecha {
  box-shadow: 25px 0 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra_inferior, .formulario__basico__2 form {
  box-shadow: 0px 25px 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra_izquierda {
  box-shadow: -25px 0 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra__superior__derecha {
  box-shadow: 0px -25px 20px -20px #00eeff, 25px 0 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra__superior__inferior {
  box-shadow: 0px -25px 20px -20px #00eeff, 0px 25px 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

body {
  font-family: "Times New Roman", Times, serif;
  font-size: 16px;
  line-height: 1.5;
  color: #1D3557;
}

.title {
  font-family: "Blackbeard", cursive;
  font-size: 2.5em;
  color: #9e0631;
}

.subtitle {
  font-family: "Marine", sans-serif;
  font-size: 1.8em;
  color: #A8DADC;
}

.paragraph {
  font-family: "Times New Roman", Times, serif;
  font-size: 1em;
}

.quote, .boton__blanco__1, .boton__blanco__2, .boton__blanco__3, .boton__blanco__4 {
  font-family: "Devil Fruit", fantasy;
  font-size: 1.2em;
  color: #457B9D;
}

.small-caps {
  font-variant: small-caps;
}

.skull-heading {
  font-family: "Skull and Cross", sans-serif;
  font-size: 3em;
  color: #A8DADC;
}

.ancient-text {
  font-family: "Ancient Text", serif;
  font-size: 1.2em;
  color: #F1FAEE;
}

.treasure-map {
  font-family: "Treasure Map", cursive;
  font-size: 1.5em;
  color: #FFFF00;
}

/* Variables de colores para alertas */
.alert {
  padding: 10px 30px;
  margin: 25px auto; /* Márgenes automáticos para centrar */
  max-width: 600px; /* Ancho máximo de la alerta */
  display: flex;
  align-items: center;
}

.alert-success {
  background: #0e791a;
  font-family: "Devil Fruit", fantasy;
}

.alert-info {
  background: #1628c9;
  color: white;
}

.alert-warning {
  background-color: #FFFF00;
  color: #212529;
}

.alert-danger {
  background-color: #d9160f;
  color: white;
}

.alert-icon {
  margin-left: 10px;
  width: 100px; /* Tamaño del icono */
  height: 100px; /* Tamaño del icono */
  max-width: 20px; /* Ancho máximo del icono */
  max-height: 20px; /* Altura máxima del icono */
}

.alert-success .alert-icon {
  background-image: url("../IMGs/exito.ico");
}

.alert-info .alert-icon {
  background-image: url("info.png");
}

.alert-warning .alert-icon {
  background-image: url("warning.png");
}

.alert-danger .alert-icon {
  background-image: url("error.png");
}

@media (max-width: 768px) {
  .alert {
    flex-direction: column; /* Cambiar la dirección de los elementos en pantallas pequeñas */
    text-align: center; /* Centrar el texto en pantallas pequeñas */
  }
  .alert-icon {
    margin-right: 0; /* Eliminar el margen derecho en pantallas pequeñas */
    margin-bottom: 10px; /* Añadir espacio entre el icono y el texto en pantallas pequeñas */
    width: 50px; /* Ajustar el tamaño del icono en pantallas pequeñas */
    height: 50px; /* Ajustar el tamaño del icono en pantallas pequeñas */
    max-width: 50px; /* Ancho máximo del icono en pantallas pequeñas */
    max-height: 50px; /* Altura máxima del icono en pantallas pequeñas */
  }
}
.sombra_superior, .btn {
  box-shadow: 0px -25px 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra_derecha {
  box-shadow: 25px 0 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra_inferior, .formulario__basico__2 form {
  box-shadow: 0px 25px 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra_izquierda {
  box-shadow: -25px 0 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra__superior__derecha {
  box-shadow: 0px -25px 20px -20px #00eeff, 25px 0 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.sombra__superior__inferior {
  box-shadow: 0px -25px 20px -20px #00eeff, 0px 25px 20px -20px #00eeff;
  margin: 20px;
  background-color: #b3b2b4;
}

.btn {
  background-color: rosybrown;
  padding: 10px;
  width: 20px;
  grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
}

.boton__animacion__1 {
  box-shadow: 0 0 5px rgb(163, 255, 183), 0 0 25px rgb(163, 255, 183);
  background-color: rgb(163, 255, 183);
  margin: 16px;
  padding: 20px;
  justify-content: center;
}

.boton__animacion__1:hover {
  box-shadow: 0 0 5px rgb(163, 255, 183), 0 0 25px rgb(163, 255, 183), 0 0 25px rgb(163, 255, 183), 0 0 50px rgb(163, 255, 183), 0 0 100px rgb(163, 255, 183), 0 0 150px rgb(163, 255, 183), 0 0 200px rgb(163, 255, 183);
}

.boton__animacion__2 {
  box-shadow: 0 0 5px #E83E8C, 0 0 25px #E83E8C;
  background-color: #E83E8C;
  margin: 16px;
  padding: 20px;
  justify-content: center;
}

.boton__animacion__2:hover {
  box-shadow: 0 0 5px #E83E8C, 0 0 25px #E83E8C, 0 0 25px #E83E8C, 0 0 50px #E83E8C, 0 0 100px #E83E8C, 0 0 150px #E83E8C, 0 0 200px #E83E8C;
}

.boton__animacion__3 {
  box-shadow: 0 0 5px #2a5fcf, 0 0 25px #2a5fcf;
  background-color: #2a5fcf;
  margin: 16px;
  padding: 20px;
  justify-content: center;
}

.boton__animacion__3:hover {
  box-shadow: 0 0 5px #2a5fcf, 0 0 25px #2a5fcf, 0 0 25px #2a5fcf, 0 0 50px #2a5fcf, 0 0 100px #2a5fcf, 0 0 150px #2a5fcf, 0 0 200px #2a5fcf;
}

.boton__animacion__4 {
  box-shadow: 0 0 5px #f88809, 0 0 25px #f88809;
  background-color: #f88809;
  margin: 16px;
  padding: 20px;
  justify-content: center;
}

.boton__animacion__4:hover {
  box-shadow: 0 0 5px #f88809, 0 0 25px #f88809, 0 0 25px #f88809, 0 0 50px #f88809, 0 0 100px #f88809, 0 0 150px #f88809, 0 0 200px #f88809;
}

.boton__basico__1 {
  margin: 16px;
  padding: 20px;
  background-color: #6C757D;
}

.boton__basico__2 {
  margin: 16px;
  padding: 20px;
  background-color: #FFC107;
}

.boton__basico__3 {
  margin: 16px;
  padding: 20px;
  background-color: #28A745;
}

.boton__basico__4 {
  margin: 16px;
  padding: 20px;
  background-color: #d9160f;
}

.boton__blanco__1 {
  margin: 16px;
  padding: 10px;
  background-color: #F1FAEE;
  color: #28A745;
  text-transform: uppercase;
  border-color: #28A745;
  cursor: pointer;
}

.boton__blanco__2 {
  margin: 16px;
  padding: 10px;
  background-color: #F1FAEE;
  color: #d9160f;
  text-transform: uppercase;
  border-color: #d9160f;
  cursor: pointer;
}

.boton__blanco__3 {
  margin: 16px;
  padding: 10px;
  background-color: #F1FAEE;
  color: #f88809;
  text-transform: uppercase;
  border-color: #f88809;
  cursor: pointer;
}

.boton__blanco__4 {
  margin: 16px;
  padding: 10px;
  background-color: #F1FAEE;
  color: #FFFF00;
  text-transform: uppercase;
  border-color: #FFFF00;
  cursor: pointer;
}

.boton__Movimento__Rosa, .formulario button[type=submit], .formulario__basico__2, button {
  padding: 17px 40px;
  background-color: #E83E8C;
  box-shadow: #000 0 0 8px;
  text-transform: uppercase;
  font-size: 14px;
  transition: all 0.05s ease;
  cursor: pointer;
  line-height: 1.5;
  font-family: "Ancient Text", serif;
  padding: 20px;
}
.boton__Movimento__Rosa:hover, .formulario button[type=submit]:hover, .formulario__basico__2:hover, button:hover {
  line-height: 3px;
  background-color: #E83E8C;
  color: #F1FAEE;
  box-shadow: #46dffa 0 7px 29px 0;
}
.boton__Movimento__Rosa:active, .formulario button[type=submit]:active, .formulario__basico__2:active, button:active {
  line-height: 3px;
  background-color: #E83E8C;
  color: #F1FAEE;
  box-shadow: #46dffa 0 0 0 0;
  transform: translate(18px);
  transition: 100ms;
}

/*BONTON ROJO */
.boton__Movimento__rojo {
  padding: 17px 40px;
  background-color: #d9160f;
  box-shadow: #000 0 0 8px;
  text-transform: uppercase;
  font-size: 14px;
  transition: all 0.05s ease;
  cursor: pointer;
  line-height: 1.5;
  font-family: "Ancient Text", serif;
  padding: 20px;
}
.boton__Movimento__rojo:hover {
  line-height: 3px;
  background-color: #d9160f;
  color: #F1FAEE;
  box-shadow: #000 0 7px 29px 0;
}
.boton__Movimento__rojo:active {
  line-height: 3px;
  background-color: #d9160f;
  color: #F1FAEE;
  box-shadow: #000 0 0 0 0;
  transform: translate(18px);
  transition: 100ms;
}

/*BONTON verdeee*/
.boton__Movimento__verde {
  padding: 17px 40px;
  background-color: #0e791a;
  box-shadow: #000 0 0 8px;
  text-transform: uppercase;
  font-size: 14px;
  transition: all 0.05s ease;
  cursor: pointer;
  line-height: 1.5;
  font-family: "Ancient Text", serif;
  padding: 20px;
}
.boton__Movimento__verde:hover {
  line-height: 3px;
  background-color: #0e791a;
  color: #F1FAEE;
  box-shadow: #000 0 7px 29px 0;
}
.boton__Movimento__verde:active {
  line-height: 3px;
  background-color: #0e791a;
  color: #F1FAEE;
  box-shadow: #000 0 0 0 0;
  transform: translate(18px);
  transition: 100ms;
}

/*BONTON NARAJA*/
.boton__Movimento__naranja {
  padding: 17px 40px;
  background-color: #f88809;
  box-shadow: #000 0 0 8px;
  text-transform: uppercase;
  font-size: 14px;
  transition: all 0.05s ease;
  cursor: pointer;
  line-height: 1.5;
  font-family: "Ancient Text", serif;
  padding: 20px;
}
.boton__Movimento__naranja:hover {
  line-height: 3px;
  background-color: #f88809;
  color: #F1FAEE;
  box-shadow: #000 0 7px 29px 0;
}
.boton__Movimento__naranja:active {
  line-height: 3px;
  background-color: #f88809;
  color: #F1FAEE;
  box-shadow: #000 0 0 0 0;
  transform: translate(18px);
  transition: 100ms;
}

@media (max-width: 768px) {
  .boton__animacion__1 .boton__animacion__2,
  .boton__animacion__3,
  .boton__animacion__4,
  .boton__basico__1,
  .boton__basico__2,
  .boton__basico__3,
  .boton__basico__4,
  .boton__blanco__1,
  .boton__blanco__2,
  .boton__blanco__3,
  .boton__blanco__4,
  .boton__Movimento__Rosa,
  .formulario button[type=submit],
  .formulario__basico__2,
  button,
  .boton__Movimento__rojo,
  .boton__Movimento__verde,
  .boton__Movimento__naranja {
    flex-direction: column;
    text-align: center;
  }
}
.carousel {
  position: relative;
}

.carousel.pointer-event {
  touch-action: pan-y;
}

.carousel-inner {
  position: relative;
  width: 100%;
  overflow: hidden;
}
.carousel-inner::after {
  display: block;
  clear: both;
  content: "";
}

.carousel-item {
  position: relative;
  display: none;
  float: left;
  width: 100%;
  margin-right: -100%;
  backface-visibility: hidden;
  transition: transform 0.6s ease-in-out;
}
@media (prefers-reduced-motion: reduce) {
  .carousel-item {
    transition: none;
  }
}

.carousel-item.active,
.carousel-item-next,
.carousel-item-prev {
  display: block;
}

.carousel-item-next:not(.carousel-item-left),
.active.carousel-item-right {
  transform: translateX(100%);
}

.carousel-item-prev:not(.carousel-item-right),
.active.carousel-item-left {
  transform: translateX(-100%);
}

.carousel-fade .carousel-item {
  opacity: 0;
  transition-property: opacity;
  transform: none;
}
.carousel-fade .carousel-item.active,
.carousel-fade .carousel-item-next.carousel-item-left,
.carousel-fade .carousel-item-prev.carousel-item-right {
  z-index: 1;
  opacity: 1;
}
.carousel-fade .active.carousel-item-left,
.carousel-fade .active.carousel-item-right {
  z-index: 0;
  opacity: 0;
  transition: opacity 0s 0.6s;
}
@media (prefers-reduced-motion: reduce) {
  .carousel-fade .active.carousel-item-left,
  .carousel-fade .active.carousel-item-right {
    transition: none;
  }
}

.carousel-control-prev,
.carousel-control-next {
  position: absolute;
  top: 0;
  bottom: 0;
  z-index: 1;
  display: flex;
  align-items: center;
  justify-content: center;
  width: 15%;
  color: #ffffff;
  text-align: center;
  opacity: 0.5;
  transition: opacity 0.15s ease;
}
@media (prefers-reduced-motion: reduce) {
  .carousel-control-prev,
  .carousel-control-next {
    transition: none;
  }
}
.carousel-control-prev:hover, .carousel-control-prev:focus,
.carousel-control-next:hover,
.carousel-control-next:focus {
  color: #ffffff;
  text-decoration: none;
  outline: 0;
  opacity: 0.9;
}

.carousel-control-prev {
  left: 0;
}

.carousel-control-next {
  right: 0;
}

.carousel-control-prev-icon,
.carousel-control-next-icon {
  display: inline-block;
  width: 20px;
  height: 20px;
  background: no-repeat 50%/100% 100%;
}

.carousel-control-prev-icon {
  background-image: escape-svg(url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' fill='#ffffff' width='8' height='8' viewBox='0 0 8 8'><path d='M5.25 0l-4 4 4 4 1.5-1.5L4.25 4l2.5-2.5L5.25 0z'/></svg>"));
}

.carousel-control-next-icon {
  background-image: escape-svg(url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' fill='#ffffff' width='8' height='8' viewBox='0 0 8 8'><path d='M2.75 0l-1.5 1.5L3.75 4l-2.5 2.5L2.75 8l4-4-4-4z'/></svg>"));
}

.carousel-indicators {
  position: absolute;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 15;
  display: flex;
  justify-content: center;
  padding-left: 0;
  margin-right: 15%;
  margin-left: 15%;
  list-style: none;
}
.carousel-indicators li {
  box-sizing: content-box;
  flex: 0 1 auto;
  width: 30px;
  height: 3px;
  margin-right: 3px;
  margin-left: 3px;
  text-indent: -999px;
  cursor: pointer;
  background-color: #ffffff;
  background-clip: padding-box;
  border-top: 10px solid transparent;
  border-bottom: 10px solid transparent;
  opacity: 0.5;
  transition: opacity 0.6s ease;
}
@media (prefers-reduced-motion: reduce) {
  .carousel-indicators li {
    transition: none;
  }
}
.carousel-indicators .active {
  opacity: 1;
}

.carousel-caption {
  position: absolute;
  right: 15%;
  bottom: 20px;
  left: 15%;
  z-index: 10;
  padding-top: 20px;
  padding-bottom: 20px;
  color: #ffffff;
  text-align: center;
}

@media (min-width: 992px) {
  #header-carousel,
  .page-header {
    margin-top: -42px;
  }
}
.carousel-caption {
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: rgba(0, 0, 0, 0.5);
  z-index: 1;
}

@media (max-width: 576px) {
  .carousel-caption h4 {
    font-size: 18px;
  }
  .carousel-caption h1 {
    font-size: 30px;
  }
}
.formulario form {
  display: grid;
  flex-direction: column;
  gap: 16px;
  align-items: first baseline;
  width: 100%;
  max-width: 500px;
  margin: 5PX;
  padding: 20px;
  background-color: #003366;
}
.formulario label {
  display: block;
}
.formulario input[type=text],
.formulario input[type=email],
.formulario input[type=password],
.formulario textarea,
.formulario select {
  background-color: #6F42C1;
  width: 100%;
  padding: 8px;
  border-radius: 5px;
  margin-bottom: 10px;
}
.formulario textarea {
  resize: vertical;
}
.formulario button[type=submit] {
  padding: 10px 20px;
  background-color: #0e791a;
  color: #f88809;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  transition: background-color 0.3s;
}
.formulario button[type=submit]:hover {
  background-color: #094b10;
}

.formulario__basico__2 {
  max-width: 100%;
  font-family: "Marine", sans-serif;
  background-image: linear-gradient(to right, rgb(146, 141, 153), rgb(99, 102, 99)); /* Degradado de azul a verde menta */
  padding: 20px;
  margin: 16px;
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(0, 1fr));
  justify-items: center;
  align-items: center;
  gap: 16px;
}
.formulario__basico__2 form {
  display: grid;
  justify-items: center;
  align-items: center;
  gap: 16px;
  width: 100%;
  max-width: 800px;
  margin: 20px auto;
  padding: 20px;
  background-color: #8136e2;
  font-size: large;
}
.formulario__basico__2 label {
  color: #000;
  font-family: "Blackbeard", cursive;
  margin: 16px;
  display: block;
  text-align: left;
  max-width: 90%;
  width: 100%;
}
.formulario__basico__2 input {
  background-color: #ecaacd;
  max-width: 90%;
  width: 100%;
}
.formulario__basico__2 textarea {
  background-color: #ecaacd;
  max-width: 90%;
  width: 100%;
}
.formulario__basico__2 fieldset {
  max-width: 90%;
  width: 100%;
  padding: 0.5rem;
  display: grid;
  grid-template-rows: auto 1fr;
  align-items: start;
  justify-content: start;
}

legend {
  border-radius: 10px;
  border-color: rgb(163, 255, 183);
  font-family: "Marine", sans-serif;
  margin: 10px;
}

input[type=checkbox],
input[type=radio] {
  max-width: 90%;
  width: 100%;
  font-family: "Marine", sans-serif;
  margin-right: 0.2rem;
  display: grid;
  grid-template-rows: auto 1fr;
  align-items: start;
}

input[type=text] {
  background-color: #ecaacd;
  max-width: 90%;
  width: 100%;
  font-family: "Marine", sans-serif;
}

input[type=password] {
  background-color: #ecaacd;
  max-width: 90%;
  width: 100%;
  font: password; /* Ocult text*/
  font-family: "Marine", sans-serif;
}

input[type=email] {
  background-color: #ecaacd;
  max-width: 90%;
  width: 100%;
  font-family: "Marine", sans-serif;
}

select {
  background-color: #ecaacd;
  max-width: 90%;
  width: 100%;
  appearance: none;
  font-size: 16px;
}

option {
  font-family: "Marine", sans-serif;
  background-color: #ecaacd;
  max-width: 90%;
  width: 100%;
  color: #f88809;
  padding: 18px;
  height: 10px;
}

option:hover {
  background-color: #094b10;
}

@media (max-width: 768px) {
  form,
  label,
  input,
  textarea,
  button {
    width: 100%;
    margin-right: 0;
  }
  button[type=""] {
    margin-top: 10px;
  }
}

/*# sourceMappingURL=main.cs.map */
