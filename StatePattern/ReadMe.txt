State Pattern is one of Behevioral pattern of GOF design Pattern 

its intent is to allow an object to alter  its behaviour when its internal state changes. the object will appear to change its class.


Use Cases 
- when an object's behaviour  depends on its state  and it must  change  it at runtime (depending on the state)

- when your objects are dealing with large Conditional Statments that depends on the objects state



Real Life scenario
- Document Editing Software . eg text editor  with diffrent editing mode  insert mode, overwrite mode  etc
- Veding Machin System eg  machinestate idle , payment, product selection , dispensing 
- workFlow Managment   pending ,inprogress, completed, canceled 
- Robotics  eg Operational mode , exploration, obstacle avoidance, Charging 


Pattern cuensquenses
- it localize  state specific behaviour and partitions behaviour for diffrent states : single responsiblity principle
- new State and Transition can easly be added by defining new subclasses : Open/Closed Principle
- the numer of classes is increased which adds additional complexity
