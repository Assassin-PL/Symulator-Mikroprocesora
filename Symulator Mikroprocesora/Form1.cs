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
        private Processor processor;

        public Form1()
        {
            InitializeComponent();
            processor = new Processor();
            processor.OnRegisterUpdate += UpdateRegisterDisplay;
            processor.OnInstructionExecuted += UpdateInstructionDisplay;
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
            var instructions = new List<Instruction>
        {
            new Instruction(InstructionType.MOV, "AX", "10", AddressingMode.Immediate),
            new Instruction(InstructionType.ADD, "AX", "5", AddressingMode.Immediate),
            new Instruction(InstructionType.SUB, "AX", "3", AddressingMode.Immediate),
            new Instruction(InstructionType.MOV, "BX", "AX", AddressingMode.Register)
        };

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
    }
}
