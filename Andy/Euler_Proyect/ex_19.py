"""
1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400
"""


days = 2
leap_month_changes = [31,60,91,121,152,182,213,244,274,305,335,366]
month_changes = [31,59,90,120,151,181,212,243,273,304,334,365]
years = 1901
sunday_counter = 0
sunday_counter_per_year = 0

while years != 2001:
    
    if years % 4 == 0 and years != 2000:
        
        print(years, "bisiesto")
        
        for i in range(1,367):
            
            if days == 8:
                days = 1
            
            if i in leap_month_changes:
                if days == 1:
                    sunday_counter +=1
                    sunday_counter_per_year += 1

            days +=1
            
        print(sunday_counter_per_year)
        sunday_counter_per_year = 0
        
    else:
        
        print(years, "no bisiesto")
        
        for i in range(1,366):
            
            if days == 8:
                days = 1
                
            if i in month_changes:
                if days == 1:
                    sunday_counter +=1
                    sunday_counter_per_year += 1
            
            days +=1

        print(sunday_counter_per_year)
        sunday_counter_per_year = 0
        
    years +=1

print(sunday_counter)
                