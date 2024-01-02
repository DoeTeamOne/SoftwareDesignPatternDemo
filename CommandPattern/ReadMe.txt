Command Pattern is one Of Behevioral pattern of GOF Design Pattern

its inntent is to encapsulate request as an object, there by letting you parameterize clients with diffrent requests, queue or Log requests
and Support and undoable Operation.


usecase for this pattern
-when you want to parametrise objects with an action to perform
-when you want to suport Undo
-when you want to specify queue and excute Requests at diffrent time
- when you want to store a list of changes to potentially latter on 


Realworld Scenarios
- Financial Transaction
- workflow managment
-macro recording and playback
-Game Engines


*** cuensequence 
- it decuple the class that invoces the operation from the one that knows how to perform it (single Responsiblity)
- commands can be manipulated and extended
-commands can be assembeled into a composite command
-existing implementation  doesn't have to be changed to add new commands (Open Close Priciple )
- because an additional layer is added , complexity increases

