
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2017 12:19:31
-- Generated from EDMX file: D:\Apps\Farmacia\DAL\ModeloFarmacia.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FarmaciaDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Patologias'
CREATE TABLE [dbo].[Patologias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Medicamento_Id] int  NOT NULL
);
GO

-- Creating table 'Medicamentos'
CREATE TABLE [dbo].[Medicamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Indicacion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Marcas'
CREATE TABLE [dbo].[Marcas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [LaboratorioId] nvarchar(max)  NOT NULL,
    [Precio] nvarchar(max)  NOT NULL,
    [MedicamentoId] nvarchar(max)  NOT NULL,
    [Laboratorio_Id] int  NOT NULL,
    [Medicamento_Id] int  NOT NULL
);
GO

-- Creating table 'ObraSociales'
CREATE TABLE [dbo].[ObraSociales] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Laboratorios'
CREATE TABLE [dbo].[Laboratorios] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'MarcaObraSociales'
CREATE TABLE [dbo].[MarcaObraSociales] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Detalle] nvarchar(max)  NOT NULL,
    [IdMarca] nvarchar(max)  NOT NULL,
    [IdObraSocial] nvarchar(max)  NOT NULL,
    [ObraSocial_Id] int  NOT NULL,
    [Marca_Id] int  NOT NULL
);
GO

-- Creating table 'PersonaFisicaSet'
CREATE TABLE [dbo].[PersonaFisicaSet] (
    [Id] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonaFisicaSet_Empleado'
CREATE TABLE [dbo].[PersonaFisicaSet_Empleado] (
    [EmpleadoId] int IDENTITY(1,1) NOT NULL,
    [Id] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Personas_Empresa'
CREATE TABLE [dbo].[Personas_Empresa] (
    [EmpresaId] int IDENTITY(1,1) NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PersonaFisicaSet_Cliente'
CREATE TABLE [dbo].[PersonaFisicaSet_Cliente] (
    [ClienteId] int IDENTITY(1,1) NOT NULL,
    [Id] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Patologias'
ALTER TABLE [dbo].[Patologias]
ADD CONSTRAINT [PK_Patologias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Medicamentos'
ALTER TABLE [dbo].[Medicamentos]
ADD CONSTRAINT [PK_Medicamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Marcas'
ALTER TABLE [dbo].[Marcas]
ADD CONSTRAINT [PK_Marcas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ObraSociales'
ALTER TABLE [dbo].[ObraSociales]
ADD CONSTRAINT [PK_ObraSociales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Laboratorios'
ALTER TABLE [dbo].[Laboratorios]
ADD CONSTRAINT [PK_Laboratorios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MarcaObraSociales'
ALTER TABLE [dbo].[MarcaObraSociales]
ADD CONSTRAINT [PK_MarcaObraSociales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonaFisicaSet'
ALTER TABLE [dbo].[PersonaFisicaSet]
ADD CONSTRAINT [PK_PersonaFisicaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonaFisicaSet_Empleado'
ALTER TABLE [dbo].[PersonaFisicaSet_Empleado]
ADD CONSTRAINT [PK_PersonaFisicaSet_Empleado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personas_Empresa'
ALTER TABLE [dbo].[Personas_Empresa]
ADD CONSTRAINT [PK_Personas_Empresa]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonaFisicaSet_Cliente'
ALTER TABLE [dbo].[PersonaFisicaSet_Cliente]
ADD CONSTRAINT [PK_PersonaFisicaSet_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Laboratorio_Id] in table 'Marcas'
ALTER TABLE [dbo].[Marcas]
ADD CONSTRAINT [FK_MarcaLaboratorio]
    FOREIGN KEY ([Laboratorio_Id])
    REFERENCES [dbo].[Laboratorios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaLaboratorio'
CREATE INDEX [IX_FK_MarcaLaboratorio]
ON [dbo].[Marcas]
    ([Laboratorio_Id]);
GO

-- Creating foreign key on [Medicamento_Id] in table 'Marcas'
ALTER TABLE [dbo].[Marcas]
ADD CONSTRAINT [FK_MedicamentoMarca]
    FOREIGN KEY ([Medicamento_Id])
    REFERENCES [dbo].[Medicamentos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicamentoMarca'
CREATE INDEX [IX_FK_MedicamentoMarca]
ON [dbo].[Marcas]
    ([Medicamento_Id]);
GO

-- Creating foreign key on [ObraSocial_Id] in table 'MarcaObraSociales'
ALTER TABLE [dbo].[MarcaObraSociales]
ADD CONSTRAINT [FK_MarcaObraSocialObraSocial]
    FOREIGN KEY ([ObraSocial_Id])
    REFERENCES [dbo].[ObraSociales]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaObraSocialObraSocial'
CREATE INDEX [IX_FK_MarcaObraSocialObraSocial]
ON [dbo].[MarcaObraSociales]
    ([ObraSocial_Id]);
GO

-- Creating foreign key on [Marca_Id] in table 'MarcaObraSociales'
ALTER TABLE [dbo].[MarcaObraSociales]
ADD CONSTRAINT [FK_MarcaObraSocialMarca]
    FOREIGN KEY ([Marca_Id])
    REFERENCES [dbo].[Marcas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaObraSocialMarca'
CREATE INDEX [IX_FK_MarcaObraSocialMarca]
ON [dbo].[MarcaObraSociales]
    ([Marca_Id]);
GO

-- Creating foreign key on [Medicamento_Id] in table 'Patologias'
ALTER TABLE [dbo].[Patologias]
ADD CONSTRAINT [FK_PatologiaMedicamento]
    FOREIGN KEY ([Medicamento_Id])
    REFERENCES [dbo].[Medicamentos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatologiaMedicamento'
CREATE INDEX [IX_FK_PatologiaMedicamento]
ON [dbo].[Patologias]
    ([Medicamento_Id]);
GO

-- Creating foreign key on [Id] in table 'PersonaFisicaSet_Empleado'
ALTER TABLE [dbo].[PersonaFisicaSet_Empleado]
ADD CONSTRAINT [FK_Empleado_inherits_PersonaFisica]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PersonaFisicaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Personas_Empresa'
ALTER TABLE [dbo].[Personas_Empresa]
ADD CONSTRAINT [FK_Empresa_inherits_Persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PersonaFisicaSet_Cliente'
ALTER TABLE [dbo].[PersonaFisicaSet_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_PersonaFisica]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PersonaFisicaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------