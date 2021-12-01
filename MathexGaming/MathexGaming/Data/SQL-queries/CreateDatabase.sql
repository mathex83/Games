USE master
GO
CREATE DATABASE [MathexGaming]
 ON  PRIMARY 
( NAME = N'MathexGaming', FILENAME = N'C:\Databases\MathexGaming\MathexGaming.mdf' , SIZE = 16384KB , FILEGROWTH = 16384KB )
 LOG ON 
( NAME = N'MathexGaming_log', FILENAME = N'C:\Databases\MathexGaming\MathexGaming_log.ldf' , SIZE = 8192KB , FILEGROWTH = 16384KB )
GO