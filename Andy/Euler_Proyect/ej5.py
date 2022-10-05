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

print(count)