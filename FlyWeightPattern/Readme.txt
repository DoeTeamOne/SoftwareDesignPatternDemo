Flyweight Pattern is One of Structural pattern of GOF Design Pattern 

- its intent is to use sharing to support large number of fine-grained objects efficiently. 
it does that by sharing parts of the state between those objects insteade of keeping all that state in all of objects.

- lets demo this sharing Caractor in the document 

*** Things to consider before using this pattern
1.  does the application use large number of objects?
2. are storage cost high because of large amount of objects?
3. can most of the object state be made extrinsic?
4. if you remove the extrinsic state can a large group of object replaced by relatively few shared objects?
5. does the application require object identity?


******************Use Cases 
- Music Play Back 
-Inventory Managment
-Document Parsing and analysis
- Game Development 


*** Pattern consuquences 
-- you may save a lot of memory when using this pattren for an applicable use case

- processing costs might be go up , but thats typically by the reducedstorage cost
- the paattern is complex  which makes the code base more complicated as well