# prompts used in the demo:

### step 1
after line break, copilot ought to suggest generated a post method. Just press tab multiple times.

### step 2
inline prompt, in the newly created Post method:

`//check that a part is valid. A valid part is validated by a regex that ensure the name has 3 letters in uppercase or more.`

### step 3
in the EngineeringControllerTests class, start writing the name of the test:

`public void TestPostMethodIsSuc`_cessful_ and copilot will generate a test. 

When breaking a line after the successful test case, copilot should suggest a _TestPostMethodReturnsBadRequest_ or similar and generates a test in which the validation fails.

### step 4
after selecting the search method, in copilot chat:
`migrate code into english`

### step 5
after selecting the search method, in copilot chat:
`translate code into python`