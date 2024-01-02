Observer Pattern is one of Behevioural pattern Of GOF design pattern 

- the intent of this pattern is to define a one - to many dependancy between  bjects so that when one object changes state ,
all its dependents are notified and updated automatically.


Use Cases
- when a change to one object require changing other and you don't know in advance how many objects needed to be changed.
- when object that observe others are not necessaryily doing that for the total amount of time the application runs.
- use it when object should be able to notify other objects without making assumptions about who those objects are 

Real Life Scenario
- Stock Market Updates  
- Event Hundling in Web Development 
	eg many event handeles like button click , mouse movent and other event hundlers subscribe to service and get notified
-Weather Monitoring System  
	eg many device like mobile apps , website, and displayscreen can subscribe to service and get notified
- Trafic Managment system 


Cuensquences

-  it allows subjuct and observer to vary independently sybclasses can be added and change without having to change others.
- Subjuct and Observer are loosly cupled : open/ close principle 
- it can lead to a cascade of Unexpacted Updates