
max = 0


for i in range(2,1000000):
    
    starter = i
    chain = []
    chain.append(starter)
    
    while starter > 1:
        
        if starter % 2 == 0:
            starter = starter/2
            chain.append(starter)
        else:
            starter = starter*3 + 1
            chain.append(starter)
            
    if len(chain) > max:
        max = len(chain)
        ans = i
        
#    print(chain)
        
print(max, ans)
                  