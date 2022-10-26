import time


time_digits = '{0:0.3g}'

def abomination():
    
    inicio = time.time()
    
    count = 20

    while count >= 0:
        if count % 19 == 0:
            if count % 18 == 0:
                if count % 17 == 0:
                    if count % 16 == 0:
                        if count % 15 == 0:
                            if count % 14 == 0:
                                if count % 13 == 0:
                                    if count % 12 == 0:
                                        if count % 11 == 0:
                                            if count % 9 == 0:
                                                if count % 7 == 0:
                                                    break
                                                else:
                                                    count +=20
                                            else:
                                                count +=20
                                        else:
                                            count +=20
                                    else:
                                        count +=20
                                else:
                                    count +=20
                            else:
                                count +=20
                        else:
                            count +=20
                    else:
                        count +=20
                else:
                    count +=20
            else:
                count +=20
        else:
            count +=20

    fin = time.time()

    total = fin - inicio

    print(count,time_digits.format(total))
    


def abomination_two():
    
    inicio = time.time()
    
    count = 20
    divider = 19
    
    while divider != 7:
        
        divider = 19
        
        for i in range(divider,7,-1):
            if count % divider == 0:
                divider -=1
            else:
                count += 20

    fin = time.time()

    total = fin - inicio

    print(count,time_digits.format(total))


abomination()

abomination_two()