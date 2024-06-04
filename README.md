# 3dManager
es un programa escrito en c# que nos permite almacenar modelos 3d en una base de datos

## instalacion
# 1. clona el proyecto

#### pasos para clonar el proyecto.
```sh
git clone https://github.com/Thebyren/3dManager
```
> esto generara una carpeta la cual deberas abrir con el explorador de archivos y luego abrir la carpeta de nombre WindowsFormsApp1, posteriormente su archivo.sln

# 2. crear la base de datos

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

# 3. modifica el usuario y contrasenia de la base de datos

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


 # 4. ejecuta el proyecto en visual studio y actualiza los paquetes nuggets. 

 al momento de restaurar los paquetes instalara varios.
 principalmente helixtoolkit quien renderiza los modelos 3d