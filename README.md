# ROT & RUT

Code for parsing and creating files for requesting RUT & ROT tax deductions from Skatteverket (Swedish Tax Agency)

Written in C#/.NET.

## What is this?

The project defines models representing the file structures of the XML and JSON files.

These are the scenarios:

* Parsing and creating RUT & ROT Request files in XML that will be sent to Skatteverket.
* Parsing the JSON files containing the Decisions you have got from Skatteverket.

## Why?

I could not find any library or sample code for handling the files, so I decided to write this as a reference project.

The files are usually being produced by accounting software, like Fortnox. But there are scenarios when you want to parse and generate them yourself.

## To do

* Polish the model
* Add validation to models

## Disclaimer

This code is being published with no warranty whatsoever. 

The project should be considered a reference for your own implementation.

All personal numbers (SSN) have been generated for demo purposes.

## Resources
* [Regler för att importera fil till Rot och rut – företag | Skatteverket](https://www.skatteverket.se/foretagochorganisationer/sjalvservice/allaetjanster/tjanster/rotochrutforetag/reglerforattimporterafiltillrotochrut.4.76a43be412206334b89800033198.html)
* [Schema för rot och rut | Skatteverket](https://www.skatteverket.se/foretagochorganisationer/sjalvservice/allaetjanster/schemalagerxml/rotochrutforetag.4.71004e4c133e23bf6db800063583.html)
* [ROT and RUT work | Skatteverket](https://www.skatteverket.se/servicelankar/otherlanguages/inenglish/businessesandemployers/startingandrunningaswedishbusiness/declaringtaxesbusinesses/rotandrutwork.4.8dcbbe4142d38302d793f.html)