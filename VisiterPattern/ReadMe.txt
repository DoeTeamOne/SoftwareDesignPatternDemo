Visiter Pattern is One of Behevioral pattern of GOD Design Pattern

- the intent of visiter pattern is to represent an opration to be performed on the element of an object structure. 
visiter lest you define a new operation without changing the classes of the elements on which it oprates.


UseCases
- when Object Structure Contains many classes of object with differing interfaces and you want to perform operations on them that depend on their concerete class
-when the classes defining your object structure doesn't have to change often but you do often want to define new operations over the structure
- when you have got potencially many operations that needs to be performed on objects in your object structure , but not neccessarly on all of them.


Real World Scenario

- Document Element Processing 
- Medical Record System 
- Data structure Serialization
- Finanacial Transuctions with in Finanacial Software System


pattern Cuensquenses

- it makes adding new operation easy  you can define a new operation by creating  new visitor (Open /Close Principle )
- A viitor can accumilat  info on the objects its visits
-A visitor gathers related operations to gether (and separates un related ones : single Responsiblty principle)
-Adding a new Concerete Element class can be hard 
-it might require  break Encapsulation 
