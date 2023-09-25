// See https://aka.ms/new-console-template for more information

using WindowsInput;
using WindowsInput.Native;


Console.WriteLine("Press Key to start mimicking the keyboard...\nx for dash, E for enter, s for crouch dash");
string keyToMimick = Console.ReadLine();

// Create an instance of the input simulator
InputSimulator inputSimulator = new InputSimulator();

// Specify the desired key to mimic (e.g., A)
VirtualKeyCode desiredKey;
if (keyToMimick.ToCharArray().Length > 0)
{
    switch (keyToMimick.ToCharArray()[0])
    {
        case 'x':
            desiredKey = VirtualKeyCode.VK_X;
            break;
        case 'E':
            desiredKey = VirtualKeyCode.RETURN;
            break;
        case 's':
        default:
            desiredKey = VirtualKeyCode.VK_S;
            break;
    }
} else
{
	desiredKey = VirtualKeyCode.VK_S;
}


Console.WriteLine("Pressing the key. Press Ctrl+C to stop.");

// Loop to repeatedly press the desired key
while (true)//!Console.KeyAvailable)
{
    inputSimulator.Keyboard.KeyDown(desiredKey);
    System.Threading.Thread.Sleep(1); // Delay between key presses
    inputSimulator.Keyboard.KeyUp(desiredKey);
    System.Threading.Thread.Sleep(1); // Delay between key presses
}
