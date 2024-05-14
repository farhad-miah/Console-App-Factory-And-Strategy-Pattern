*Anonymised everything*

I was asked to create a console application as part of a tech test

--------------------------------------------------------------------


##Console App

##How it works---


There are currently 2 types of orders: repair and hire

When the application starts - it goes through the program.cs which calls OrderProcessor class

The OrderProcesser then calls the method GetStrategy from the OrderStatusStrategyFactory which then
returns the relevant startegy based on the order type.

The respective strategies run through their logic to calculate the correct status and then return it to the console.

Shared rules for statuses are kept in a base class.


Unit tests have been added which test all requirements


Implemented factory pattern and a strategy pattern.

----------------------------------------------------------------------
Here are the requirements that were given to me:

We need you to create a simple console solution in C# that works with customers and vehicle repair orders.

Based on a number of requirements which are detailed below, the status of an Order may be determined to be `Confirmed`, `Closed` or `AuthorisationRequired`.

Write a solution that accepts the inputs below, and outputs the appropriate status. You also need to create unit tests to prove that it works correctly.

In the future it is likely that the requirements or possible statuses may change, expand or become more complex.

Your solution should take this into account and be easy to modify when these changes occur with minimal code changes.

In particular this might mean avoiding the use of "if" and "switch" statements which deal with specific cases and instead taking a more generic approach.
