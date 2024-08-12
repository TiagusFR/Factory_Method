Factory Method example based on the following Scenario: Store information about a Point in Cartesian (x,y), but also initialize the point from Polar Cordinates (rho and theta).
It couldn't be done with two pairs of floats, once x and y were already on constructor. An odd approach is to enum both CoordinateSystems and then add another parameter to the point constructor.

But it always matches the type, meaning it can't communicate extra information in it. I can't have two overloads. 

So, started making the constructor protected or on this case private.

Point: now being private, prevents direct instantiation 

NewCartesianPoint: being a static method uses x and y freely 

New PolarPoint: encapsulate the logic for creating Point instances. 
