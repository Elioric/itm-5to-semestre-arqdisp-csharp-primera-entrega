# Arquitectura de Dispositivos Moviles

## Primer Acercamiento a .Net

Para esta configuración hago uso de una imagen de Docker con .Net SDK 8.0 y Podman para ejecutar los comandos de .Net.

## Descargar imagen de Docker Hub

Para ejecutar los comandos de .Net, requiero un entorno que tenga el SDK instalado. Para esto hago uso de la imagen de .Net con SDK 8.0. De tal manera que no sea necesario configurar el Framework en el Host. Utilizo esta aproximación debido a las limitaciones de la máquina que estoy utilizando.

```bash
podman pull mcr.microsoft.com/dotnet/sdk:8.0
```

## Ejecutar contenedor .Net SDK 8.0 en modo interactivo

Ejecuto el contenedor en modo interactivo y con un volumen montado en la carpeta local donde se desarrollará el proyecto.

```bash
podman run --rm -it -v .:/home/dotnet-project mcr.microsoft.com/dotnet/sdk:8.0
```

## Crear .gitignore

Para evitar subir archivos innecesarios al repositorio, hacemos uso de un archivo `.gitignore`. Este archivo se puede crear directamente con un comando .Net y ser editado según nuestras necesidades.

```bash
dotnet new gitignore
```

## Inicializar proyecto .Net de consola

Se ejecuta el comando para la inicialización de una aplicación .Net de consola dentro del contenedor. Como la carpeta local está asociada a la carpeta `/home/dotnet-project`, se debe correr el comando dentro de esta carpeta.

```bash
cd /home/dotnet-project
dotnet new console -n dotnet-basic-exercises
```

Tras ejecutar este comando, podremos ver que se ha creado un nuevo proyecto de .Net dentro de nuestro repositorio local.

## Ejecutar el proyecto inicializado

Para ejecutar el proyecto inicializado, debemos ingresar a la carpeta del proyecto y correr el comando .Net.

```bash
cd dotnet-basic-exercises/
dotnet run
```

Deberíamos visualizar `Hello, World!` en la consola si se configuró de manera correcta.

Estas configuraciones son suficientes para validar que el proyecto se puede ejecutar y empezar a desarrollar los ejercicios.
