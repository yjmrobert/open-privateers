-- Use open-privateers and run this script to seed the database with some data from csv files.
-- This script is not idempotent, so it will fail if you run it more than once.
-- It is recommended to run this script after running the migrations.

-- Import the data from the csv files
-- The csv files are in the same directory as this script
-- You'll have to change the path to the csv files as needed
DECLARE @ScriptPath AS VARCHAR(100)='C:\Users\yjmro\source\repos\OpenPrivateers\OpenPrivateers.API\Data\';

BULK
INSERT [dbo].[ShipClasses] 
    FROM '$(ScriptPath)ShipClasses.csv' 
    WITH (FIELDTERMINATOR = ','
    , ROWTERMINATOR = '\n'
    , FIRSTROW = 2);
    
BULK
INSERT [dbo].[Ships] 
    FROM '$(ScriptPath)Ships.csv' 
    WITH (FIELDTERMINATOR = ','
    , ROWTERMINATOR = '\n'
    , FIRSTROW = 2);

    