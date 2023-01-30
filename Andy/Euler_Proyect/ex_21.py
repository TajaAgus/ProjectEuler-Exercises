from resources.divisors import Divisors

divisor_sum = Divisors.sum_list(10000) 

result = 0

for i in range(1, len(divisor_sum)):
    j = divisor_sum[i]

    if j != i and j < len(divisor_sum) and divisor_sum[j] == i:
        result += i

print(result)

