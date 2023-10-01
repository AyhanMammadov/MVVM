CREATE TABLE Groups (
    ID INT PRIMARY KEY identity,
    [Name] NVARCHAR(20) not null,
    StudentCountt INT not null,
    TeacherID INT
);


CREATE TABLE Teachers (
    ID INT PRIMARY KEY identity,
    [Name] NVARCHAR(20) not null,
    [GroupID] INT foreign key references Groups(ID) on delete cascade,
);


CREATE TABLE Students (
    ID INT PRIMARY KEY identity,
    [Name] NVARCHAR(20) not null,
    [TeacherID] INT,
    [GroupID] INT
);
alter table Students
add foreign key ([TeacherID]) references Teachers(ID);
alter table Students
add foreign key ([GroupID]) references Groups(ID) ;


