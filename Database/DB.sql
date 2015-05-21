CREATE DATABASE PredictionApp;

USE predictionApp;


CREATE TABLE Assessment(

assessmentID INT AUTO_INCREMENT PRIMARY KEY,

assessmentName VARCHAR(50) NOT NULL UNIQUE,

dueDate DATETIME NOT NULL,

marks INT NOT NULL
);



CREATE TABLE Module(

moduleID INT AUTO_INCREMENT PRIMARY KEY,

moduleCode VARCHAR(10) NOT null UNIQUE,

moduleName VARCHAR(50) NOT NULL,

moduleCredits INT NOT NULL,

assessmentList TEXT NOT NULL
);



CREATE TABLE CourseLevel(

levelID INT AUTO_INCREMENT PRIMARY KEY,

levelName VARCHAR(50) NOT NULL,

modules TEXT NOT NULL
);




CREATE TABLE Course(

CourseID INT AUTO_INCREMENT PRIMARY KEY,

courseName VARCHAr(50) NOT NULL,

courseLevel TEXT NOT NULL
);



DROP TABLE Course;
DROP TABLE CourseLevel;
DROP TABLE Assessment;
DROP TABLE Module;
SELECT * FROM CourseLevel;
SELECT * FROM course;
SELECT * FROM Assessment;

UPDATE PredictionApp.Assessment SET assessmentName='TehkjkstUPD',
dueDate='2011-06-10 00:00:00',
marks=12 WHERE assessmentID=6;


SELECT last_insert_id() FROM Assessment;