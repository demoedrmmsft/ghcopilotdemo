# Demo Rapida de GitHub Copilot

Este repositorio tiene el paso a paso para dar una demostración de GH Copilot, construyendo un bot inteligente.

El objetivo es mostrar que se pueden construir aplicaciones con inteligencia artificial generativa con GH Copilot, GH Codespaces y usando servicios PaaS de Azure, asi como enfoques que ayudan al despliegue como lo es infraestructura como codigo .

Cada sección tiene como objetivo principal mostrar una o varias Caracteristicas de GH Copilot, las cuales se especifican en cada sección, no es necesario contar con un ambiente de desarrollo porque usaremos GH Codespaces que ya tiene las extensiones y frameworks necesarios para mostrar la demo. 

La solucion final vienen el la rama finalsolution, la rama main solo contiene la guía y esta bloqueada para agregar algun cambio; sin embargo lo recomendable es crear una rama independiente y crear tu workspace (Instrucciones especificadas en la seccion de [Prerequisitos](#prerequisitos)).

A continuacion se muestra el contenido de la guía recomendada dela Demo


- [Demo Rapida de GitHub Copilot](#demo-rapida-de-github-copilot)
  - [Prerequisitos](#prerequisitos)
  - [Paso a paso](#paso-a-paso)
    - [Construcción del Bot](#construcción-del-bot)
    - [Construccion del servicio de OpenAI](#construccion-del-servicio-de-openai)
    - [Adición de inteligencia artificial generativa usando el SDK del  Azure Open AI](#adición-de-inteligencia-artificial-generativa-usando-el-sdk-del--azure-open-ai)
    - [Integraciónn del bot con Microsoft Teams](#integraciónn-del-bot-con-microsoft-teams)
    - [Creacion de un portal web e integración del bot](#creacion-de-un-portal-web-e-integración-del-bot)
    - [Creacion de recursos adicionales en Azure y publicacion del sitio web y bot](#creacion-de-recursos-adicionales-en-azure-y-publicacion-del-sitio-web-y-bot)


## Prerequisitos

Para poder ejecutar la demo es necesario seguir los siguientes pasos: 

1. Descargar e instalar el emulador de Bot Framework en la siguiente liga: https://github.com/Microsoft/BotFramework-Emulator/releases/, este es el unico componente en el equipo para mostrar que el Bot funciona correctamente.
2. Vamos al repositorio (https://github.com/demoedrmmsft/ghcopilotdemo)
3. Crear una rama en el repositorio, siguiendo los siguientes paso:
   - a. Vamos a la sección de codigo, poseriormente en el menu de ramas damos clic ![alt text](images/image-1.png)
   - b. Especificamos el nombre de la rama (recomendable demo-"tualias") y del damos clic en Create branch demo-"tualias" from main ![alt text](images/image-2.png)
   - c. Una vez que estas en la rama recien creada le damos clic en "Code" -> En la sección de Codespaces le damos clic en el botón de "+" ![alt text](images/image-3.png)
4. Puede que intente abrir con Visual Studio code si lo tienes habilitado, si no puedes usar el navegador web. En caso que no visualizar el codespace, en nuestra rama, damos clic al botón de "Code" -> Damos clien en las elipses del codespace de nuestra rama y posteriormente en la opción de "Open in Browser" ![alt text](images/image-4.png) 
5. Estas listo para seguir la guía y dar una excelente demostración a tu cliente

## Paso a paso

Dentro del escenario tenemos un Bot intelligente que usara Azure OpenAI para agregar inteligencia articial generativa, este Bot se podra integrar con microsoft team y con un portal web. 



### Construcción del Bot
### Construccion del servicio de OpenAI 
### Adición de inteligencia artificial generativa usando el SDK del  Azure Open AI
### Integraciónn del bot con Microsoft Teams
### Creacion de un portal web e integración del bot
### Creacion de recursos adicionales en Azure y publicacion del sitio web y bot

