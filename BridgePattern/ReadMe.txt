One of Structural Pattern from GOF


- its intent is to decuple an abstruction from its implementation so the two can vary independently 

-- this pattern aim to separate abstruction to its implementation 

provide a meanse of replace an implementation with another implementation without modifying the abstruction 



---- Good Use Cases
-when you want to avoid permanent binding between abstruction and implementation (to enable switching implementation  at runtime )

- when abstruction and implementation  should be extensible using subclassing 

- when you don't want to change the implementation of abstruction have no impact on the client





- Real worled scenarion
*****Notification Serice 

sms, 
email,
push 

***  Universal Remote control Application
- separate functionality for specific Device


** separate UI Component Rendering Code 
-- for mac, window , linux etc






