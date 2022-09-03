i=0
c=0
d=0
while d < 501:
    d=0
    c+=1
    i+=c
    
    for j in range(1,i//2):
        if i % j == 0:
            d+=1
            if d > 500:
                break
    print(d)
print(i)
