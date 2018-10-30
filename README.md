# cbipoc
This is a simple application written in C# to:
1. Create a Class from an XSD file downloaded from the Central Bank of Ireland (CBI)
2. Create a simple object and write the Object to an XML file

The idea is to prove that a valid XML can be generated for submission to CBI.

The file chosen to demonstrate this functionality is https://www.centralbank.ie/docs/default-source/statistics/statistical-reporting-requirements/anacredit-in-ireland/cprd-schema-v4-3.xsd


# Convert the XSD to a Class
A class must be generated so that a type-safe object can be generated (or parsed from a CSV file, as this will be the intended usage).  To convert the XSD file to a class, follow these steps:

1. Launch the Developer Command Prompt for VS2017
2. Place the XSD file in a folder (We will use C:\temp in the example)
3. Run this command:
  - xsd /c cprd-schema-v4-3.xsd /n:XsdClasses.cbipoc 
4. The Class will be generated in the folder you are in within the command prompt.

Then the project source code, make sure the new .cs file is copied to the XsdClasses folder within the project.

Note: Use any folder/naming convention you want. You can refactor the Class name and change the namespace as necessary.
