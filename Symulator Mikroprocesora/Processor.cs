using System;
using System.Collections.Generic;
using System.IO;

public enum InstructionType
{
    MOV,
    ADD,
    SUB
}

public enum AddressingMode
{
    Register,
    Immediate
}

public class Instruction
{
    public InstructionType Type { get; set; }
    public string Destination { get; set; }
    public string Source { get; set; }
    public AddressingMode Mode { get; set; }

    public Instruction(InstructionType type, string destination, string source, AddressingMode mode)
    {
        Type = type;
        Destination = destination;
        Source = source;
        Mode = mode;
    }

    public override string ToString()
    {
        return $"{Type} {Destination} {Source} {Mode}";
    }
}

public class Processor
{
    private Dictionary<string, int> registers;
    private List<Instruction> program;
    private int instructionPointer;

    public event Action<string> OnRegisterUpdate;
    public event Action<string> OnInstructionExecuted;

    public Processor()
    {
        registers = new Dictionary<string, int>
        {
            { "AX", 0 }, { "BX", 0 }, { "CX", 0 }, { "DX", 0 },
            { "AH", 0 }, { "AL", 0 }, { "BH", 0 }, { "BL", 0 },
            { "CH", 0 }, { "CL", 0 }, { "DH", 0 }, { "DL", 0 }
        };
        program = new List<Instruction>();
        instructionPointer = 0;
    }

    public void LoadProgram(List<Instruction> newProgram)
    {
        program = newProgram;
        instructionPointer = 0;
    }

    public void ExecuteProgram()
    {
        while (instructionPointer < program.Count)
        {
            ExecuteInstruction(program[instructionPointer]);
            instructionPointer++;
        }
    }

    public void Step()
    {
        if (instructionPointer < program.Count)
        {
            ExecuteInstruction(program[instructionPointer]);
            instructionPointer++;
        }
    }

    private void ExecuteInstruction(Instruction instruction)
    {
        int value = 0;

        if (instruction.Mode == AddressingMode.Immediate)
        {
            value = int.Parse(instruction.Source);
        }
        else if (registers.ContainsKey(instruction.Source))
        {
            value = registers[instruction.Source];
        }

        switch (instruction.Type)
        {
            case InstructionType.MOV:
                registers[instruction.Destination] = value;
                break;
            case InstructionType.ADD:
                registers[instruction.Destination] += value;
                break;
            case InstructionType.SUB:
                registers[instruction.Destination] -= value;
                break;
        }

        UpdateRegisters();
        OnRegisterUpdate?.Invoke(GetRegisterStates());
        OnInstructionExecuted?.Invoke($"Executed: {instruction}");
    }

    private void UpdateRegisters()
    {
        registers["AH"] = (registers["AX"] >> 8) & 0xFF;
        registers["AL"] = registers["AX"] & 0xFF;
        registers["BH"] = (registers["BX"] >> 8) & 0xFF;
        registers["BL"] = registers["BX"] & 0xFF;
        registers["CH"] = (registers["CX"] >> 8) & 0xFF;
        registers["CL"] = registers["CX"] & 0xFF;
        registers["DH"] = (registers["DX"] >> 8) & 0xFF;
        registers["DL"] = registers["DX"] & 0xFF;
    }

    public void SaveProgram(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var instruction in program)
            {
                writer.WriteLine(instruction);
            }
        }
    }

    public void LoadProgramFromFile(string filePath)
    {
        var newProgram = new List<Instruction>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(' ');
                var type = (InstructionType)Enum.Parse(typeof(InstructionType), parts[0]);
                var destination = parts[1];
                var source = parts[2];
                var mode = (AddressingMode)Enum.Parse(typeof(AddressingMode), parts[3]);
                newProgram.Add(new Instruction(type, destination, source, mode));
            }
        }
        LoadProgram(newProgram);
    }

    public string GetRegisterStates()
    {
        string result = "Registers:\n";
        foreach (var reg in registers)
        {
            result += $"{reg.Key}: {reg.Value}\n";
        }
        return result;
    }
}
