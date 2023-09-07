CREATE TABLE Employee (
    Id                  SERIAL NOT NULL PRIMARY KEY,
    Payroll_Number      VARCHAR(250),
    Forenames           VARCHAR(250),
    Surname             VARCHAR(250),
    Date_Of_Birth       VARCHAR(250),
    Telephone           VARCHAR(250),
    Mobile              VARCHAR(250),
    Address_Name        VARCHAR(250),
    Address_2           VARCHAR(250),
    Postcode            VARCHAR(250),
    Email_Home          VARCHAR(250),
    Start_Date          VARCHAR(250),
);