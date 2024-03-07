create table Animals
(
    Id               int not null identity(1,1)
        constraint PK_Animals
            primary key,
    Name             nvarchar(max)    not null,
    Description      nvarchar(max)    not null,
    DateOfBirth      datetime2        not null,
    Status           nvarchar(max)    not null,
    Breed            nvarchar(max)    not null,
    PhotoUrl         nvarchar(max)    not null
)
go

create table Markers
(
    Id               int not null identity(1,1)
        constraint PK_Markers
            primary key,
    Latitude         float            not null,
    Longitude        float            not null,
    LocationName     nvarchar(max)    not null
)
go

create table AnimalMarkerEntity
(
    AnimalId int not null
        constraint FK_AnimalMarkerEntity_Animals_AnimalId
            references Animals
            on delete cascade,
    MarkerId int not null
        constraint FK_AnimalMarkerEntity_Markers_MarkerId
            references Markers
            on delete cascade,
    constraint PK_AnimalMarkerEntity
        primary key (AnimalId, MarkerId)
)
go

create index IX_AnimalMarkerEntity_MarkerId
    on AnimalMarkerEntity (MarkerId)
go

create table Roles
(
    Id               int not null identity(1,1)
        constraint PK_Roles
            primary key,
    Name             nvarchar(max)    not null
)
go

create table Users
(
    Id               int not null identity(1,1)
        constraint PK_Users
            primary key,
    Username         nvarchar(max)    not null,
    Password         nvarchar(max)    not null,
    Name             nvarchar(max)    not null,
    Age              int              not null,
    Email            nvarchar(max)    not null
)
go

create table AnimalUserEntity
(
    AnimalId int not null
        constraint FK_AnimalUserEntity_Animals_AnimalId
            references Animals
            on delete cascade,
    UserId   int not null
        constraint FK_AnimalUserEntity_Users_UserId
            references Users
            on delete cascade,
    constraint PK_AnimalUserEntity
        primary key (AnimalId, UserId)
)
go

create index IX_AnimalUserEntity_UserId
    on AnimalUserEntity (UserId)
go

create table UserRoleEntity
(
    UserId int not null
        constraint FK_UserRoleEntity_Users_UserId
            references Users
            on delete cascade,
    RoleId int not null
        constraint FK_UserRoleEntity_Roles_RoleId
            references Roles
            on delete cascade,
    constraint PK_UserRoleEntity
        primary key (RoleId, UserId)
)
go

create index IX_UserRoleEntity_UserId
    on UserRoleEntity (UserId)
go

//////////// Database ////////////

CREATE TABLE AnimalTypes 
(
    AnimalTypeId INT PRIMARY KEY IDENTITY(1,1),
    TypeName NVARCHAR(50) NOT NULL,
    TypeDescription NVARCHAR(255)
);

CREATE TABLE Animals 
(
    AnimalId INT PRIMARY KEY IDENTITY(1,1),
    AnimalTypeId INT NOT NULL,
    AnimalName NVARCHAR(50) NOT NULL,
    AnimalDescription NVARCHAR(255),
    FOREIGN KEY (AnimalTypeId) REFERENCES AnimalTypes(AnimalTypeId)
);
GO

CREATE TABLE Locations 
(
    LocationId INT PRIMARY KEY IDENTITY(1,1),
    LocationName NVARCHAR(50) NOT NULL,
    LocationDescription NVARCHAR(255),
    Latitude DECIMAL(9,6),
    Longitude DECIMAL(9,6)
);
GO

CREATE TABLE MovementPoints 
(
    MovementPointId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    AnimalId INT NOT NULL,
    LocationId INT NOT NULL,
    DateTime DATETIME2 NOT NULL,
    FOREIGN KEY (AnimalId) REFERENCES Animals(AnimalId),
    FOREIGN KEY (LocationId) REFERENCES Locations(LocationId)
);
GO

CREATE TABLE Users
(
    Id INT PRIMARY KEY IDENTITY(1,1) constraint PK_Users NOT NULL,
    Username NVARCHAR(MAX) NOT NULL,
    Password NVARCHAR(MAX) NOT NULL,
    Name NVARCHAR(MAX) NOT NULL,
    Age INT,
    Email NVARCHAR(MAX)
)
GO

INSERT INTO AnimalTypes (TypeName, TypeDescription)
VALUES
('Млекопитающие', 'Животные, которые кормятся молоком'),
('Птицы', 'Животные, которые имеют перья'),
('Рыбы', 'Животные, которые живут в воде'),
('Пресмыкающиеся', 'Холоднокровные животные, которые имеют чешуйчатую кожу'),
('Насекомые', 'Животные, которые имеют шесть ног и два крыла');
GO

INSERT INTO Animals (AnimalTypeID, AnimalName, AnimalDescription)
VALUES
(1, 'Собака', 'Домашнее животное, наиболее верный друг человека'),
(2, 'Воробей', 'Мелкий певчий птичка'),
(3, 'Карп', 'Пресноводная рыба'),
(4, 'Черепаха', 'Пресмыкающееся, имеющее череп на спине'),
(5, 'Пчела', 'Насекомое, производящее мед и опыляющее цветы');
GO

INSERT INTO Locations (LocationName, LocationDescription, Latitude, Longitude)
VALUES
('Центральный парк', 'Парк в центре города', 40.7829, -73.9654),
('Зоопарк', 'Место, где содержатся животные', 40.7685, -73.9714),
('Океанариум', 'Место, где показывают морских животных', 40.5749, -73.9743),
('Озеро', 'Небольшое пресноводное озеро', 40.7745, -73.9637),
('Сад', 'Ухоженное место с растениями', 40.7729, -73.9694);
GO

INSERT INTO MovementPoints (AnimalID, LocationID, DateTime)
VALUES
(1, 1, '2023-05-08'),
(1, 2, '2023-05-09'),
(1, 3, '2023-05-10'),
(2, 2, '2023-05-08'),
(3, 4, '2023-05-08'),
(3, 5, '2023-05-09');
GO

//////////// Views ////////////

CREATE VIEW V1 AS
SELECT TypeName AS НаименованиеТипа, TypeDescription AS ОписаниеТипа
FROM AnimalTypes;

CREATE VIEW V2 AS
SELECT AnimalTypeId AS IdТипаЖивотного, AnimalName AS НаименованиеЖивотного, AnimalDescription AS ОписаниеЖивотного
FROM Animals;

CREATE VIEW V3 AS
SELECT LocationName AS НаименованиеЛокации, LocationDescription AS ОписаниеЛокации, Latitude AS Широта, Longitude AS Долгота
FROM Locations;

CREATE VIEW V4 AS
SELECT AnimalId AS IdЖивотного, LocationId AS IdЛокации
FROM MovementPoints;