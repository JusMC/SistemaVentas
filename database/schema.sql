-- =====================================================
-- Sistema de Ventas - Programación 5
-- Prototipo de base de datos en MySQL
-- =====================================================

CREATE DATABASE IF NOT EXISTS sistema_ventas
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE sistema_ventas;

-- -----------------------------------------------------
-- Categorías
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS categorias (
    id          INT AUTO_INCREMENT PRIMARY KEY,
    nombre      VARCHAR(100) NOT NULL UNIQUE,
    descripcion VARCHAR(255)
);

-- -----------------------------------------------------
-- Productos
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS productos (
    codigo       VARCHAR(20)   PRIMARY KEY,
    nombre       VARCHAR(100)  NOT NULL,
    descripcion  VARCHAR(255),
    precio       DECIMAL(10,2) NOT NULL CHECK (precio >= 0),
    stock        INT           NOT NULL DEFAULT 0 CHECK (stock >= 0),
    categoria_id INT,
    CONSTRAINT fk_productos_categoria
        FOREIGN KEY (categoria_id) REFERENCES categorias(id)
        ON DELETE SET NULL
);

-- -----------------------------------------------------
-- Clientes
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS clientes (
    id       INT AUTO_INCREMENT PRIMARY KEY,
    nombre   VARCHAR(100) NOT NULL,
    telefono VARCHAR(20),
    correo   VARCHAR(100) UNIQUE
);

-- -----------------------------------------------------
-- Ventas (cabecera)
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS ventas (
    id         INT AUTO_INCREMENT PRIMARY KEY,
    fecha      DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    cliente_id INT           NOT NULL,
    total      DECIMAL(12,2) NOT NULL DEFAULT 0,
    CONSTRAINT fk_ventas_cliente
        FOREIGN KEY (cliente_id) REFERENCES clientes(id)
);

-- -----------------------------------------------------
-- Detalle de venta
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS detalle_venta (
    id              INT AUTO_INCREMENT PRIMARY KEY,
    venta_id        INT           NOT NULL,
    producto_codigo VARCHAR(20)   NOT NULL,
    cantidad        INT           NOT NULL CHECK (cantidad > 0),
    precio_unitario DECIMAL(10,2) NOT NULL,
    subtotal        DECIMAL(12,2) GENERATED ALWAYS AS (cantidad * precio_unitario) STORED,
    CONSTRAINT fk_detalle_venta
        FOREIGN KEY (venta_id) REFERENCES ventas(id)
        ON DELETE CASCADE,
    CONSTRAINT fk_detalle_producto
        FOREIGN KEY (producto_codigo) REFERENCES productos(codigo)
);