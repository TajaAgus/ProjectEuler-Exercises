
primefactor = False
i=1
ans = 0
result=1


while primefactor == False:
    i+=1
    if 600851475143 % i == 0:
        result *= i
        if result == 600851475143:
            ans = i
            primefactor = True
            
print(ans)