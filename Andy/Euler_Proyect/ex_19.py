"""
1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.

All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.

A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.

How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
"""



def sundays_count():
    
    week = ['monday','tuesday','wednesday','thursday','friday','saturday','sunday']
    
    day = 1
    sundays = 0
    
    month_even  = bool
    month_feb_leap = bool
    
    year_config = {month_even : False, month_feb_leap : False, month_even : False, month_even : True, month_feb_leap : False, month_even : True, month_feb_leap : False, month_even : True, month_even : False, month_even : True, month_feb_leap : False}
    year_leap_config = {month_even : False, month_feb_leap : True, month_even : False, month_even : True, month_feb_leap : False, month_even : True, month_feb_leap : False, month_even : True, month_even : False, month_even : True, month_feb_leap : False}
    
    year = bool
    year_leap = bool
    
    for i in range(1901,2000):
        
        if i % 4 == 0: year_leap = True
        if i == 1900: year_leap = False
        
        if year_leap == True:
            
            for j in range(1,366):
                
                for month in year_leap_config:
                    
                    if month == month_feb_leap:
                        
                        while day < 29:
                            
                            for d in week:
                                
                                if d == 'sunday' and day == 1:
                                    sundays += 1
                                    break
                                day += 1
                                j += 1
                            
                                
                    elif month == True:
                        
                        while day < 31:
                            
                            for d in week:
                        
                                if d == 'sunday' and day == 1:
                                    sundays += 1
                                    break
                                day += 1
                                j += 1
                                if day == 32:
                                    break

                                
                    elif month == False:
                        
                        while day < 32:
                            
                            
                            
                            for d in week:
                            
                                if d == 'sunday' and day == 1: sundays += 1
                                day += 1
                                j += 1
                                if day == 32: break

        else:
            
            for j in range(1,365):
                
                for month in year_config:

                    if month == month_feb_leap:
                        
                        while day < 29:
                            
                            for d in week:
                                
                                if d == 'sunday' and day == 1:
                                    sundays += 1
                                    break
                                day += 1
                                j += 1
                                if day == 29:
                                    break
                                

  
                    elif month == True:
                        
                        while day < 31:
                            
                            for d in week:
                            
                                if d == 'sunday' and day == 1: sundays += 1
                                day += 1
                                j += 1
                                if day == 31:
                                    break

                                
                    elif month == False:
                        
                        while day < 32:
                            

                            
                            for d in week:
                            
                                if d == 'sunday' and day == 1: sundays += 1
                                day += 1
                                j += 1
                                if day == 32:
                                    break

            
            if i == 1900:
                sundays == 0
                
    
    print(sundays)
            
sundays_count()

