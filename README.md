# 3dManager
es un programa escrito en c# que nos permite almacenar modelos 3d en una base de datos
1. [instalacion](#instalacion)
2. [modo de uso](#uso)
3. [caracteristicas](#caracteristicas)

# instalacion
#### 1. clona el proyecto

#### pasos para clonar el proyecto.
```sh
git clone https://github.com/Thebyren/3dManager
```
> esto generara una carpeta la cual deberas abrir con el explorador de archivos y luego abrir la carpeta de nombre WindowsFormsApp1, posteriormente su archivo.sln

### 2. crear la base de datos

en mysql deberas crear una base de datos del siguiente modo.

#### pasos para replicar la base de datos:
```SQL
create schema db_3d_models;
use db_3d_models;
CREATE TABLE ModelMetadata (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    description TEXT,
    extension VARCHAR(10) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE ModelData (
    id INT PRIMARY KEY AUTO_INCREMENT,
    model_id INT,
    data LONGBLOB,
    FOREIGN KEY (model_id) REFERENCES ModelMetadata(id)
);
```

### 3. modifica el usuario y contrasenia de la base de datos

al momento de que instalaste mysql generaste tu usuario y contrasenia, debes de utilizar esas credenciales en el siguiente archivo

[Data.cs](WindowsFormsApp1/manager/Data.cs)

en la variable

```cs
public static readonly string[] ConnectionStringUser = {
            "localhost",
            "db_3d_models",
            "root", // usuario
            "password" // contrasenia
        };
```
deberas de modificar el usuario y contrasenia respecto a tus credenciales de tu base de datos.


 ### 4. ejecuta el proyecto en visual studio y actualiza los paquetes nuggets. 

 al momento de restaurar los paquetes instalara varios.
 principalmente helixtoolkit quien renderiza los modelos 3d

 # uso
 abre el proyecto y podras hacer lo siguiente:

1. agregar modelos 3d compatibles con obj, stl y 3ds
2. editar la informacion de registro de esos modelos
3. eliminar toda la informacion de un registro por su id
4. guardar en tu computador un archivo desde la base de datos 

# caracteristicas

### funciones principales
* almacenar modelos 3d en la base de datos
* previsualizar el modelo 3d que has guardado
* gestionar los metadatos de cada modelo
* compatibilidad con hasta 3 tipos de archivos
1. .obj
2. .stl
3. .3ds 
* guardar los modelos 3d en tu computador desde la base de datos
