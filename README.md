# CMPS378 Assignment #1: Change Calculator
### Submitted By: J-Zach Loke

# Description
This program calculates the most efficient way to dispense change for a transaction. In this case, "most efficient" refers to using the least amount of coins as possible. For example: if the value of change to be dispensed is $0.25, then it's more efficient to dispense 1 quater than 25 pennies.

This program is intended to be integrated into POS (point of sale) machines in businesses.

# Features
This program has the optional ability to calculate dispensal of 50 cent coins.

# How to Run
Compile `main.cs` using a C# compiler (preferrably Visual Studio's compiler). I specificually used `Microsoft (R) Visual C# Compiler version 2.6.0.62329`.

# Test Inputs & Outputs

### Basic transaction with 50c coins
```
This program will determine the least amount of coins to dispense as change from a purchase.
Enter the product price without the "$": 0.01
Enter the amount the customer paid without the "$": 1
Should we use 50c coins (y/n)? y
After handing out dollar bills, the value of the change is $0.99
The change that should be dispensed is:
        50c    : 1
        quarter: 1
        dime   : 2
        nickel : 0
        penny  : 4
```

### Basic transaction case without 50c coins
```
This program will determine the least amount of coins to dispense as change from a purchase.
Enter the product price without the "$": 0.01
Enter the amount the customer paid without the "$": 1
Should we use 50c coins (y/n)? n
After handing out dollar bills, the value of the change is $0.99
The change that should be dispensed is:
        50c    : 0
        quarter: 3
        dime   : 2
        nickel : 0
        penny  : 4
```

### Common use case
```
This program will determine the least amount of coins to dispense as change from a purchase.
Enter the product price without the "$": 2.57
Enter the amount the customer paid without the "$": 5
Should we use 50c coins (y/n)? n
After handing out dollar bills, the value of the change is $0.4300001
The change that should be dispensed is:
        50c    : 0
        quarter: 1
        dime   : 1
        nickel : 1
        penny  : 3
```

### Customer gave exact change
```
This program will determine the least amount of coins to dispense as change from a purchase.
Enter the product price without the "$": 0.3
Enter the amount the customer paid without the "$": 0.3
Should we use 50c coins (y/n)? n
Customer has given exact change and no coins need to be dispensed.
```

### Customer did not pay enougb
```
This program will determine the least amount of coins to dispense as change from a purchase.
Enter the product price without the "$": 0.5
Enter the amount the customer paid without the "$": 0.2
Should we use 50c coins (y/n)? n
Customer did not give enough money to pay for this transaction.
```
