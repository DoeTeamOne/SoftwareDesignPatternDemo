Facade Pattern is one of Structural Pattern of GOF Design Pattern

the intent of this pattern is to provide a unified interface to a set of interfaces in a subsystem. it defines a higher level of interface that makes the subsystem easier to use.

by putting the facade in between client and the subsystem you decuple dependancy between client and subsystem

Use Cases
-------------------------------
- when you inegrate with legacy system
-content Managemnt Systems 
- multimedia play Back 
- payment Processing systems 


* Pattern Coscuenses
- the number of object client have to deal with reduced 
- promotes week cupling between the subsystem and its client and enabling subsystem components to vary wuthout afecting the client (open closed principle )
- even thaugh subsystems are shield from client , clients are not forbidden to use subsystem casses

