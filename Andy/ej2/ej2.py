def fibonacci():
    num1=1
    num2=2
    sum=0
    resp = 0
    while num1 < 4000000:
        sum=num1+num2
        if(sum % 2 == 0):
            print(sum)
            resp+=sum
        num1=num2
        num2=sum
        sum=0
    print(resp+2)

fibonacci()