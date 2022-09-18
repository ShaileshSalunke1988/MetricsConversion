CREATE DATABASE Conversion;

Create table Conversion
(
 ConversionID [int] IDENTITY(1,1) NOT NULL,
    ConversionCode varchar(5) NOT NULL,
    Unit1 decimal(6,4) NULL,
	Unit2 decimal(6,4) NULL,
	[Description] varchar(50) NOT NULL
)

Insert into Conversion (ConversionCode,Unit1,Unit2,[Description]) values ('AToH',2.471,Null,'Acre to Hectare');
Insert into Conversion (ConversionCode,Unit1,Unit2,[Description]) values ('HToA',2.471,Null,'Hectare to Acre');

Insert into Conversion (ConversionCode,Unit1,Unit2,[Description]) values ('MToK',1.609,Null,'Mile to Kilometer');
Insert into Conversion (ConversionCode,Unit1,Unit2,[Description]) values ('KToM',1.609,Null,'Kilometer to Mile');

Insert into Conversion (ConversionCode,Unit1,Unit2,[Description]) values ('FToC',32,1.8,'Fahrenheit to Celsius');
Insert into Conversion (ConversionCode,Unit1,Unit2,[Description]) values ('CToF',1.8,32,'Celsius to Fahrenheit');

Select * from Conversion;

