# 3dManager

## pasos para replicar la base de datos:
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
