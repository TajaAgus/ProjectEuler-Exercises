ans=0
count=2
i=1
while count != 10001:
    i+=2
    for j in range (1,i,2):
        if j == 1:
            continue
        if i % j == 0:
            break
        if j >= i/2:
            count +=1
            ans=i
            break
    
    
print(ans)

            

            
            

