import math
number = 0
# Iterate through the range of numbers from 1 to 10,000,000
for i in range(1, 10000000):
    # Add the reciprocal of the square of the current number to the total
    number += 1 / i ** 2

# Multiply the sum by 6 to estimate π²
pi_estimate = number * 6
print(pi_estimate)

# Print the actual value of π² using the math module
pi_spuare = math.pi ** 2
print(pi_spuare)