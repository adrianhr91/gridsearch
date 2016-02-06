# Grid Search
Technical test for Sigma Seven

## Things that can be improved
As this is a test application there are some good practices that will be an overkill for the current requirements but should be considered in real applications.
* When checking for nearby addresses all entries are loaded into memory in order to apply a custom projection method. This allows the nice encapsulation of the `Square.IsInside()` method but sacrifices performance. For bigger datasets loading all of it into memory can be avoided but it would also mean sacrificing OOP design.
