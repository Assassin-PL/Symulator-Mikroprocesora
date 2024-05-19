using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_Mikroprocesora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            processor = new Processor();
            processor.OnRegisterUpdate += UpdateRegisterDisplay;
            processor.OnInstructionExecuted += UpdateInstructionDisplay;

            instructions = new List<Instruction>
        {
            new Instruction(InstructionType.MOV, "AX", "10", AddressingMode.Immediate),
            new Instruction(InstructionType.ADD, "AX", "5", AddressingMode.Immediate),
            new Instruction(InstructionType.SUB, "AX", "3", AddressingMode.Immediate),
            new Instruction(InstructionType.MOV, "BX", "AX", AddressingMode.Register)
        };
        }

        private void UpdateRegisterDisplay(string registerStates)
        {
            txtRegisters.Text = registerStates;
        }

        private void UpdateInstructionDisplay(string instruction)
        {
            txtInstructions.AppendText(instruction + Environment.NewLine);
        }

        private void btnLoadProgram_Click(object sender, EventArgs e)
        {
            processor.LoadProgram(instructions);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            processor.ExecuteProgram();
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            processor.Step();
        }

        private void btnSaveProgram_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                processor.SaveProgram(saveFileDialog.FileName);
            }
        }

        private void btnLoadProgramFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                processor.LoadProgramFromFile(openFileDialog.FileName);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            processor.ClearProgram();
            instructions.Clear(); // Clear the instructions list, leaving it empty
            txtRegisters.Clear();
            txtInstructions.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var commandsText = txtCommands.Text;
            var newInstructions = ParseCommands(commandsText);

            if (newInstructions != null)
            {
                instructions.AddRange(newInstructions);
                txtCommands.Clear();
                MessageBox.Show("Commands added successfully!");
            }
            else
            {
                MessageBox.Show("Error: Invalid commands entered.");
            }
        }
        private List<Instruction> ParseCommands(string commandsText)
        {
            var instructions = new List<Instruction>();
            var lines = commandsText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var parts = line.Split(' ');
                if (parts.Length != 4)
                {
                    return null; // Invalid command format
                }

                if (!Enum.TryParse(parts[0], out InstructionType type))
                {
                    return null; // Invalid instruction type
                }

                var destination = parts[1];
                var source = parts[2];
                if (!Enum.TryParse(parts[3], out AddressingMode mode))
                {
                    return null; // Invalid addressing mode
                }

                instructions.Add(new Instruction(type, destination, source, mode));
            }

            return instructions;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Zamknij główne okno
            Application.Exit(); // Zakończ aplikację
        }
    }
}
