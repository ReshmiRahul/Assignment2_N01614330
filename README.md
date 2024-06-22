# Problem Solutions

This repository contains solutions to CCC (Canadian Computing Competition) problems implemented as WebAPI methods.

--Endpoints--

# J1 - Canadian Calorie Counting

Calculates the total calorie count of a meal based on selected menu items.

- **GET** `/api/J1/Menu/{burger}/{drink}/{side}/{dessert}`

# J2 - Roll the Dice

Determines how many ways two dice can roll the value of 10.

- **GET** `/api/J2/DiceGame/{m}/{n}`

# J3 - Temperature Conversion

Converts a temperature between Celsius and Fahrenheit.

- **GET** `/api/J3/ConvertTemp/{temp}/{scale}`

--Example Requests--

- `GET /api/J1/Menu/4/4/4/4` returns `"Your total calorie count is 0"`
- `GET /api/J1/Menu/1/2/3/4` returns `"Your total calorie count is 691"`
- `GET /api/J2/DiceGame/6/8` returns `"There are 5 total ways to get the sum 10."`
- `GET /api/J2/DiceGame/12/4` returns `"There are 4 total ways to get the sum 10."`
- `GET /api/J3/ConvertTemp/100/C` returns `"100 C is 212 F"`
- `GET /api/J3/ConvertTemp/32/F` returns `"32 F is 0 C"`

