import time

counter = {0:'and', 1:'one', 2:'two', 3:'three', 4:'four', 5:'five', 6:'six', 7:'seven', 8:'eight', 9:'nine',
           10 : 'ten', 11 : 'eleven', 12 : 'twelve', 13 : 'thirteen', 14 : 'fourteen', 15 : 'fifteen',
           16 : 'sixteen', 17 : 'seventeen', 18 : 'eighteen', 19 : 'nineteen', 20:'twenty', 30:'thirty', 40 : 'forty',
           50 : 'fifty', 60 : 'sixty', 70 : 'seventy', 80 : 'eighty', 90 : 'ninety', 100 : 'onehundred', 200 : 'twohundred', 300 : 'threehundred',
           400 : 'fourhundred', 500 : 'fivehundred', 600 : 'sixhundred', 700 : 'sevenhundred', 800 : 'eighthundred', 900 : 'ninehundred', 1000 : 'onethousand'}

words = []

decades = []

for i in counter:
    
    if i == 0: continue
    
    value = i
    i = counter.get(i)
    
    if value < 20:
        words.append(i)
        
    elif value >= 20 and value < 100:
        decades.append(i)
    
    else:break
    
    



def letter_counter():############ WORSE ##############
    
    
    time_digits = '{0:.4g}'
    inicio = time.time()
    
    
    for i in range(1,1000):
        

        first_digit = int(str(i)[0])
        
        if i > 9:
            second_digit = int(str(i)[1])
        
        if i > 99:
            third_digit = int(str(i)[2])
            first_and_second_digit= int(str(i)[1:3])

        if i in counter: continue
        elif i < 100:
            if first_digit == 2:
                counter.update({i:counter.get(20)+counter.get(second_digit)})
            elif first_digit == 3:
                counter.update({i:counter.get(30)+counter.get(second_digit)})
            elif first_digit == 4:
                counter.update({i:counter.get(40)+counter.get(second_digit)})
            elif first_digit == 5:
                counter.update({i:counter.get(50)+counter.get(second_digit)})
            elif first_digit == 6:
                counter.update({i:counter.get(60)+counter.get(second_digit)})
            elif first_digit == 7:
                counter.update({i:counter.get(70)+counter.get(second_digit)})
            elif first_digit == 8:
                counter.update({i:counter.get(80)+counter.get(second_digit)})
            elif first_digit == 9:
                counter.update({i:counter.get(90)+counter.get(second_digit)})
        
        elif i > 100:
            if first_digit == 1:
                counter.update({i:counter.get(100)+counter.get(0)+counter.get(first_and_second_digit)})
            elif first_digit == 2:
                counter.update({i:counter.get(200)+counter.get(0)+counter.get(first_and_second_digit)})
            elif first_digit == 3:
                counter.update({i:counter.get(300)+counter.get(0)+counter.get(first_and_second_digit)})
            elif first_digit == 4:
                counter.update({i:counter.get(400)+counter.get(0)+counter.get(first_and_second_digit)})
            elif first_digit == 5:
                counter.update({i:counter.get(500)+counter.get(0)+counter.get(first_and_second_digit)})
            elif first_digit == 6:
                counter.update({i:counter.get(600)+counter.get(0)+counter.get(first_and_second_digit)})
            elif first_digit == 7:
                counter.update({i:counter.get(700)+counter.get(0)+counter.get(first_and_second_digit)})
            elif first_digit == 8:
                counter.update({i:counter.get(800)+counter.get(0)+counter.get(first_and_second_digit)})
            elif first_digit == 9:
                counter.update({i:counter.get(900)+counter.get(0)+counter.get(first_and_second_digit)})
            
    counter.pop(0)

    contador = 0
        
    for value in counter:
        
        for i in counter.get(value):
            
            contador +=1
            
    fin = time.time()

    total = fin - inicio

    print(contador,time_digits.format(total))



def letter_counter_two():############ BETTER ##############
    
    time_digits = '{0:.4g}'
    inicio = time.time()

    for d in decades:
        words.append(d)
        for i in range(0,9):
            words.append(str(d + words[i]))
    
    for h in range(0,9):
        words.append(str(words[h]+'hundred'))
        for u in range(0,99):
            words.append(str(words[h]+'hundredand'+ words[u]))
            
    words.append('onethousand')
    
    ans=0
    for l in words:
        ans += len(l)
    
    fin = time.time()

    total = fin - inicio

    print(ans,time_digits.format(total))




letter_counter()

letter_counter_two()