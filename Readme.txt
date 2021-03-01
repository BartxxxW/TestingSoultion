
Content description:

Sources - contains geckodriver.exe 
TestingPlatform contains C# Testing project with solution

Rquirements:

- installed .Net Framweork 4.8
- installed Firefox


Steps  to run project:

1. 	Please downlad both  directories - Sources and TestingPlatform

2.	Each classs with TestCase  contains  "options.BrowserExecutableLocation" and "System.Environment.SetEnvironmentVariable" in SetUp()
	Please provide  directory to  firefox.exe and geckodriver.exe on you PC.
	
	example:
	options.BrowserExecutableLocation = (@"YOUR LOCATION oF FIREFOX.EXE");
	System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"YOUR LOCATION OF geckodriver.exe");
	
3.  In program CS call SetUp() , Test() and TearDown() methods of selected TestCase (Class)
	e.g 
	
	        static void Main(string[] args)
        {

            NotExistingUser.Setup();
            NotExistingUser.Test();
            NotExistingUser.TearDown();
            Console.ReadKey();
        }
		
4. 	Run Project