Template Pattern is one of  Behavioral Pattern of GOF Design Pattern 

-- Its intent is to define skeleton of an algorithm in an opration  differing some step to subclasses.
it lets subclases re define certain steps of algorithm without changing the algorithm structure

*** Use Cases For This Pattern
- when you want to implement the variant parts of an algorithm only once and want to leave it to subclasses to implement the rest of the behavior
- when you want to implement the variant parts of an algorithm only once and want to leave it to subclasses to implement the rest of the behavior
- when you want to control which parts of an algorithm sub clases can vary 
-when you want to have a set of algorithms thta don't vary much 


UseCases
- Document Generation 
- Sorting Algorithms
-Online Shoping Cart .. the Process of Adding item to the cart and Removing From Cart
-Automated Testing Framework


****Cuensquencses
-template methods are fundamental technique for code reuse 
- Template Methods cannot be changed the order of the methods they call is fixed



