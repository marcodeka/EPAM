
Feature: The Berlin Clock
	As a clock enthusiast
    I want to tell the time using the Berlin Clock
    So that I can increase the number of ways that I can read the time


Scenario: Midnight 00:00
When the time is "00:00:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
OOOO
"""


Scenario: Middle of the afternoon
When the time is "13:17:01"
Then the clock should look like
"""
O
RROO
RRRO
YYROOOOOOOO
YYOO
"""

Scenario: Just before midnight
When the time is "23:59:59"
Then the clock should look like
"""
O
RRRR
RRRO
YYRYYRYYRYY
YYYY
"""

Scenario: Midnight 24:00
When the time is "24:00:00"
Then the clock should look like
"""
Y
RRRR
RRRR
OOOOOOOOOOO
OOOO
"""

Scenario: Morning 4:00
When the time is "04:00:00"
Then the clock should look like
"""
Y
OOOO
RRRR
OOOOOOOOOOO
OOOO
"""

Scenario: Afternoon 4:00
When the time is "16:00:00"
Then the clock should look like
"""
Y
RRRO
ROOO
OOOOOOOOOOO
OOOO
"""

Scenario: Morning 2 second before 6
When the time is "05:59:58"
Then the clock should look like
"""
Y
ROOO
OOOO
YYRYYRYYRYY
YYYY
"""

Scenario: Morning 1 second
When the time is "00:00:01"
Then the clock should look like
"""
O
OOOO
OOOO
OOOOOOOOOOO
OOOO
"""

Scenario: Wrong Parsing value
When the time is "aa:xx:vv"
Then the user is presented with an error message about parsing

Scenario: Wrong Parsing format
When the time is "11+12"
Then the user is presented with an error message about parsing

Scenario: Wrong Time value
When the time is "25:61:77"
Then the user is presented with an error message about time value

